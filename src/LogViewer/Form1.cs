using LogViewer.Config;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace LogViewer;

public partial class Form1 : Form
{
    #region Constants

    private const string TABLE_NAME = "Logs.LogEvents";
    //private const string TABLE_NAME = "LogEvents";
    private const string COL_ID = "Id";
    private const string COL_TIMESTAMP = "TimeStamp";
    private const string COL_LOGLEVEL = "LogLevel";
    private const string COL_APPLICATION = "Application";
    private const string COL_SOURCE = "Source";
    private const string COL_CORRID = "CorrelationId";
    private const string COL_MSG = "Message";
    private const string COL_EX = "Exception";
    private const string COL_HASEX = "HasException";

    private const string ERRLVL_VERBOSE = "VERBOSE";
    private const string ERRLVL_DEBUG = "DEBUG";
    private const string ERRLVL_INFO = "INFO";
    private const string ERRLVL_WARN = "WARN";
    private const string ERRLVL_ERROR = "ERROR";
    private const string ERRLVL_FATAL = "FATAL";
    private const string IMGKEY_SORT_ASC = "swap_vert_32_up.png";
    private const string IMGKEY_SORT_DESC = "swap_vert_32_dn.png";

    #endregion

    #region Fields

    private DbConnForm _dbConnForm;
    private DetailForm _detailForm;
    private bool _suspendUpdates;
    private readonly ErrorLevelDisplay[] _errorLevelDisplays;
    private bool _sortAsc;
    private bool _autoRefresh;
    private int _timerIntervalMs;
    private List<DbConn> _dbConns;
    private DbConn _currDbConn;
    private AppConfig _appConfig;
    private SqlConnection _conn;

    #endregion

    #region Ctors / Forms Events

    public Form1()
    {
        InitializeComponent();
        _errorLevelDisplays = this.BuildErrorLevelDisplays();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _dbConnForm = new DbConnForm();
        _detailForm = new DetailForm(this);

        _appConfig = ConfigManager.GetAppConfig();

        PopulateForm(_appConfig);

        Form1_Resize(null, null);

        lvLogs.Focus();

        //if (ApplicationDeployment.IsNetworkDeployed)
        //	// Running as click-once
        //	toolLblVersion.Text = string.Format("v. {0}", ApplicationDeployment.CurrentDeployment.CurrentVersion);
        //else
        toolLblVersion.Text = string.Format("v. {0}", FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion);

        // Prevents ListView flicker
        PropertyInfo prop = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
        prop?.SetValue(lvLogs, true, null);
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
        this.Cursor = Cursors.WaitCursor;
        try
        {
            ResetDbConnCombo(_appConfig.DbConns, _appConfig);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.GetType().Name} getting log items: {ex.Message}");
        }
        finally
        {
            this.Cursor = Cursors.Default;
        }
    }

    private void Form1_Activated(object sender, EventArgs e)
    {
        if (this.WindowState == FormWindowState.Minimized)
            SetAutoRefresh(false);
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        SaveSettings();
    }

    private void Form1_Resize(object sender, EventArgs e)
    {
        if (this.WindowState == FormWindowState.Minimized)
        {
            if (timer1.Enabled)
                SetAutoRefresh(false);
        }
        else
        {
            var width = lvLogs.Width - 22;
            for (var i = 0; i < 4; i++)
                width -= lvLogs.Columns[i].Width;
            lvLogs.Columns[4].Width = width;
        }
    }

    #endregion

    #region Initialization

    private void PopulateForm(AppConfig appConfig)
    {
        _suspendUpdates = true;
        try
        {
            _autoRefresh = appConfig.AutoRefresh;
            _timerIntervalMs = appConfig.TimerIntervalMs > 0 ? appConfig.TimerIntervalMs : 2000;
            timer1.Interval = _timerIntervalMs;

            foreach (var errLevel in _errorLevelDisplays)
                cmbSeverity.Items.Add(errLevel.Text);

            SetFormSizeAndPosition(appConfig.WindowSize, appConfig.WindowPosition);
            SetSortDirection(appConfig.MRUSortAsc);
            SetColumnWidths(appConfig.ColWidths);
            numPageLength.Value = (appConfig.MRUPageLength > 10) ? appConfig.MRUPageLength : 100;

            cmbSeverity.SelectedIndex = 0;
            cmbApplicationNames.Items.Insert(0, string.Empty);
            InitializeGlowPanel();
        }
        finally
        {
            _suspendUpdates = false;
        }
    }

    private Image LoadEmbeddedImage(string resourceName)
    {
        var resourceFullName = $"LogViewer.Resources.{resourceName}";

        Assembly assembly = Assembly.GetExecutingAssembly();

        using (var stream = assembly.GetManifestResourceStream(resourceFullName))
        {
            if (stream != null)
            {
                return Image.FromStream(stream);
            }
            else
            {
                throw new Exception("Resource not found: " + resourceName);
            }
        }
    }

    private void InitializeGlowPanel()
    {
        pnlGlow.BackColor = Color.Transparent;
        pnlGlow.Top = lvLogs.Top - 10;
        pnlGlow.Left = lvLogs.Left - 10;
        pnlGlow.Width = lvLogs.Width + 20;
        pnlGlow.Height = lvLogs.Height + 20;
    }

    #endregion

    #region Settings

    private void SaveSettings()
    {
        // Save settings
        var appConfig = new AppConfig();

        appConfig.MRUDbConnName = _currDbConn?.Name;
        appConfig.MRUSortAsc = _sortAsc;
        appConfig.MRUPageLength = (int)numPageLength.Value;
        appConfig.AutoRefresh = timer1.Enabled;
        appConfig.TimerIntervalMs = timer1.Interval;

        appConfig.DbConns = _dbConns.ToList();

        // Window
        if (this.WindowState == FormWindowState.Normal)
        {
            appConfig.WindowPosition = this.Location;
            appConfig.WindowSize = this.Size;
        }
        else
        {
            appConfig.WindowPosition = this.RestoreBounds.Location;
            appConfig.WindowSize = this.RestoreBounds.Size;
        }

        foreach (ColumnHeader col in lvLogs.Columns)
            appConfig.ColWidths.Add(col.Width);

        ConfigManager.SaveAppConfig(appConfig);
    }

    private void SetFormSizeAndPosition(Size windowSize, Point position)
    {
        this.Width = (windowSize.Width < 934) ? 934 : windowSize.Width;
        this.Height = (windowSize.Height < 633) ? 633 : windowSize.Height;

        // Get the screen that contains the specified coordinates
        Screen screen = Screen.FromPoint(position);

        // Ensure the form is not positioned outside the screen bounds
        Rectangle workingArea = screen.WorkingArea;

        int x = position.X;
        int y = position.Y;

        if (x < workingArea.Left)
            x = workingArea.Left;
        else if (x + this.Width > workingArea.Right)
            x = workingArea.Right - this.Width;

        if (y < workingArea.Top)
            y = workingArea.Top;
        else if (y + this.Height > workingArea.Bottom)
            y = workingArea.Bottom - this.Height;

        // Set the form's position
        this.StartPosition = FormStartPosition.Manual;
        this.Location = new Point(x, y);
    }

    private void SetColumnWidths(List<int> colWidths)
    {
        for (int i = 0; i < colWidths.Count; i++)
        {
            if (i < lvLogs.Columns.Count)
                lvLogs.Columns[i].Width = colWidths[i];
        }
    }

    #endregion

    #region DbConns

    private void ResetDbConnCombo(List<DbConn> dbConns, DbConn selectDbConn)
    {
        this.ResetDbConnCombo(dbConns, selectDbConn, null);
    }

    private void ResetDbConnCombo(List<DbConn> dbConns, AppConfig appConfig)
    {
        this.ResetDbConnCombo(dbConns, null, appConfig);
    }

    private void ResetDbConnCombo(List<DbConn> dbConns, DbConn selectDbConn, AppConfig appConfig)
    {
        _dbConns = dbConns;

        cmbDbConns.Items.Clear();

        foreach (var dbConn in _dbConns)
            cmbDbConns.Items.Add(dbConn);

        if (_dbConns.Count == 0)
            return;

        if (selectDbConn != null)
        {
            cmbDbConns.SelectedItem = selectDbConn;
        }
        else
        {
            // Select the last used connection, if one is set
            if (!string.IsNullOrEmpty(appConfig?.MRUDbConnName))
            {
                var mruDbConn = _dbConns.FirstOrDefault(c => c.Name == appConfig.MRUDbConnName);
                if (mruDbConn != null)
                    cmbDbConns.SelectedItem = mruDbConn;
                else
                    // No MRU, simply select the first one
                    cmbDbConns.SelectedIndex = 0;

            }
            else
            {
                // No MRU connection, so select the default connection if there is one
                var defaultDbConn = _dbConns.FirstOrDefault(c => c.IsDefault);
                if (defaultDbConn != null)
                    cmbDbConns.SelectedItem = defaultDbConn;
                else
                    // No default, simply select the first one
                    cmbDbConns.SelectedIndex = 0;
            }
        }
    }

    private void cmbDbConns_SelectedIndexChanged(object sender, EventArgs e)
    {
        SetDbConn(cmbDbConns.SelectedItem as DbConn);
        lvLogs.Focus();
    }

    private void SetDbConn(DbConn dbConn)
    {

        if (dbConn == null)
        {
            btnEditDatasource.Enabled = false;
            btnDelDatasource.Enabled = false;
            pnlGlow.Enabled = false;
            pnlGlow.Cursor = Cursors.Default;
            btnRefresh.Enabled = false;
            btnRefresh.Cursor = Cursors.Default;
            btnAutoRefresh.Enabled = false;
            btnAutoRefresh.Cursor = Cursors.Default;
            btnSort.Enabled = false;
            btnSort.Cursor = Cursors.Default;

            return;
        }

        btnEditDatasource.Enabled = true;
        btnDelDatasource.Enabled = true;
        pnlGlow.Enabled = true;
        pnlGlow.Cursor = Cursors.Hand;
        btnRefresh.Enabled = true;
        btnRefresh.Cursor = Cursors.Hand;
        btnAutoRefresh.Enabled = true;
        btnAutoRefresh.Cursor = Cursors.Hand;
        btnSort.Enabled = true;
        btnSort.Cursor = Cursors.Hand;

        _detailForm.ConnString = dbConn.ConnString;

        _currDbConn = dbConn;

        if (_currDbConn != dbConn)
        {
            OpenConn(true);
            ResetApplicationFilterList();
        }

        if (!_suspendUpdates)
        {
            LoadLogItems();
            RefreshFilterLists(true);
        }
    }

    private void btnAddDatasource_Click(object sender, EventArgs e)
    {
        try
        {
            var dbConn = new DbConn();

            if (_dbConnForm.Run(dbConn) == DialogResult.OK)
            {
                _dbConns.Add(dbConn);
                ResetDbConnCombo(_dbConns, dbConn);
                RefreshFilterLists(true);
                //SetDbConn(dbConn);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(this, $@"(btnAddDatasource_Click) {ex.GetType().Name}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEditDatasource_Click(object sender, EventArgs e)
    {
        try
        {
            DbConn dbConn = cmbDbConns.SelectedItem as DbConn;
            if (dbConn == null)
                return;

            if (_dbConnForm.Run(dbConn) == DialogResult.OK)
            {
                ResetDbConnCombo(_dbConns, dbConn);
                if (dbConn.IsDefault)
                {
                    foreach (var otherConn in _dbConns)
                    {
                        if (otherConn != dbConn)
                            otherConn.IsDefault = false;
                    }
                }
                RefreshFilterLists(true);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(string.Format("(btnAddDatasource_Click) {0}: {1}", ex.GetType().Name, ex.Message));
        }
    }

    private void btnDelDatasource_Click(object sender, EventArgs e)
    {
        if (cmbDbConns.SelectedItem == null)
            return;

        if (MessageBox.Show(this, "Delete the selected datasource?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            _dbConns.Remove(cmbDbConns.SelectedItem as DbConn);
            ResetDbConnCombo(_dbConns, null, null);
            RefreshFilterLists(true);
        }
    }

    #endregion

    #region LogEvents

    private void ResetData()
    {
        numPageNumber.Value = 1;
        this.LoadLogItems();
    }

    private void picRefresh_Click(object sender, EventArgs e)
    {
        LoadLogItems();
    }

    private void LoadLogItems()
    {
        this.Cursor = Cursors.WaitCursor;
        try
        {
            Refresh();
            FillGrid((int)numPageNumber.Value, (int)numPageLength.Value);
            toolLblMessage.Text = null;

        }
        catch (Exception ex)
        {
            SetAutoRefresh(false);
            MessageBox.Show(ex.Message);

        }
        finally
        {
            this.Cursor = Cursors.Default;
        }
    }

    private void OpenConn(bool closeExisting = false)
    {
        if (closeExisting)
        {
            _conn?.Dispose();
            _conn = null;
        }
        else
        {
            if (_conn != null)
            {
                if (_conn.State == ConnectionState.Open)
                    return;
            }
            else
            {
                _conn = new SqlConnection(_currDbConn.ConnString);
            }
        }

        try
        {
            _conn.Open();
        }
        catch
        {
            // DB was probably re-created since the last calll, let's try once more
            _conn.Open();
        }
    }

    private void FillGrid(int pageNumber, int pageSize)
    {
        //int startRow = ((startPage - 1) * pageLength) + 1;
        //int endRow = startRow + pageLength;
        string sqlWhere = BuildWhereClause();
        string orderByDir = _sortAsc ? "DESC" : "ASC";

        /*
        string sql = $@"SELECT 
	                                  MasterRowNums.*
	                                FROM
	                                (
	                                  SELECT
	                                    {COL_ID}, 
										{COL_TIMESTAMP}, 
										{COL_LOGLEVEL}, 
										{COL_APPLICATION}, 
										{COL_SOURCE}, 
                                        {COL_CORRID}, 
										{COL_MSG},
										CASE WHEN {COL_EX} = '' THEN 0 ELSE 1 END AS {COL_HASEX},
										ROW_NUMBER() OVER (ORDER BY {COL_TIMESTAMP} {orderByDir}) AS RowNum
	                                  FROM 
	                                    {TABLE_NAME} WITH(NOLOCK)
	                                  {sqlWhere}
	                                ) 
	                                  MasterRowNums
	                                WHERE 
	                                  RowNum BETWEEN {startRow} AND {endRow}
	                                ORDER BY 
	                                  {COL_TIMESTAMP} {orderByDir}";
        */

        var sql = $@"
            SELECT 
                [Id],
                [Timestamp],
                [LogLevel],
                [Application],
                [Source],
                [CorrelationId],
                [Message],
                CASE WHEN Exception = '' THEN 0 ELSE 1 END AS HasException
            FROM 
                Logs.LogEvents
            {sqlWhere}
            ORDER BY 
                Timestamp {orderByDir}
            OFFSET 
                @Offset ROWS
            FETCH NEXT 
                @PageSize ROWS ONLY;";

        OpenConn();
        using (SqlCommand cmd = new SqlCommand(sql, _conn))
        {
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Offset", (pageNumber - 1) * pageSize);
            cmd.Parameters.AddWithValue("@PageSize", pageSize);

            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();

            }
            catch (SqlException sqlEx)
            {
                // Sql Error #10054 means the database rebuild script was recently run but the connection pool
                // didn't know about it so it tries connecting on a stale connection. Let's try once more..
                if (sqlEx.Number == 10054)
                {
                    OpenConn();
                    reader = cmd.ExecuteReader();
                }
                else
                {
                    throw;
                }
            }

            lvLogs.Items.Clear();

            try
            {
                while (reader.Read())
                {
                    var logItem = new LogEvent
                    {
                        Id = (int)reader[COL_ID],
                        TimeStamp = ((DateTime)reader[COL_TIMESTAMP]).ToLocalTime(),
                        LogLevel = (int)reader[COL_LOGLEVEL],
                        Application = reader[COL_APPLICATION].ToString(),
                        Source = reader[COL_SOURCE].ToString(),
                        CorrelationId = reader[COL_CORRID].ToString(),
                        Message = reader[COL_MSG].ToString(),
                        HasException = ((int)reader[COL_HASEX] == 1)
                    };

                    var localTimestamp = logItem.TimeStamp.ToLocalTime();
                    var timestampStr = localTimestamp.Date == DateTime.Now.Date ? localTimestamp.ToString("h:mm:ss.fff") : localTimestamp.ToString("M/d/yy  h:mm:ss.fff");
                    var errLevelDisplay = _errorLevelDisplays[logItem.LogLevel];

                    ListViewItem lvItem = new ListViewItem(new[] { timestampStr, errLevelDisplay.Text, logItem.Application, logItem.Source, logItem.Message });
                    lvItem.ImageIndex = errLevelDisplay.ImageIndex;
                    lvItem.ForeColor = errLevelDisplay.TextColor;
                    lvItem.ToolTipText = logItem.TimeStamp.ToString("M/d/yy");
                    lvItem.Tag = logItem;

                    lvLogs.Items.Add(lvItem);
                }
            }
            finally
            {
                reader.Dispose();
            }
        }

        if (!_sortAsc && (lvLogs.Items.Count > 0))
            lvLogs.Items[lvLogs.Items.Count - 1].EnsureVisible();
    }

    private ErrorLevelDisplay[] BuildErrorLevelDisplays()
    {
        var errorLevelDisplays = new ErrorLevelDisplay[6];

        errorLevelDisplays[0] = new ErrorLevelDisplay(0, ERRLVL_VERBOSE, Color.White);
        errorLevelDisplays[1] = new ErrorLevelDisplay(1, ERRLVL_DEBUG, Color.White);
        errorLevelDisplays[2] = new ErrorLevelDisplay(2, ERRLVL_INFO, Color.White);
        errorLevelDisplays[3] = new ErrorLevelDisplay(3, ERRLVL_WARN, Color.FromArgb(240, 146, 46));
        errorLevelDisplays[4] = new ErrorLevelDisplay(4, ERRLVL_ERROR, Color.FromArgb(250, 105, 105));
        errorLevelDisplays[5] = new ErrorLevelDisplay(5, ERRLVL_FATAL, Color.FromArgb(247, 52, 52));

        return errorLevelDisplays;
    }

    private bool PurgeLogs()
    {
        string msg = string.Format("Are you sure you want to delete all logs in database {0}?", cmbDbConns.SelectedText);
        if (MessageBox.Show(msg, "Confirm Delete Logs", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            return false;

        try
        {
            using (SqlConnection conn = new SqlConnection(_currDbConn.ConnString))
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    conn.Open();
                }
                catch (SqlException)
                {
                    // Try once more
                    conn.Open();
                }

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"DELETE FROM {TABLE_NAME}";
                cmd.CommandTimeout = 300;       // 5 minutes, sometimes these take a long time

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException sqlEx)
                {
                    // Sql Error #10054 means the database rebuild script was recently run but the connection pool
                    // didn't know about it so it tries connecting on a stale connection. Another try will get a new connection, so let's try
                    if (sqlEx.Number == 10054)
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        throw;
                    }
                }

                cmbApplicationNames.Items.Clear();
            }

            return true;

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
    }

    private string BuildWhereClause()
    {
        List<string> whereList = new List<string>();

        // LogLevel
        if (cmbSeverity.SelectedIndex > 0)
            whereList.Add($"{COL_LOGLEVEL} >= {cmbSeverity.SelectedIndex} ");

        // Machine
        if (cmbApplicationNames.SelectedIndex > 0)
        {
            whereList.Add($"{COL_APPLICATION} = '{cmbApplicationNames.Text}' ");
        }

        // SourceClass
        if (!string.IsNullOrEmpty(txtSource.Text))
        {
            whereList.Add($"{COL_SOURCE} LIKE '%{txtSource.Text}%' ");
        }

        // Message
        if (!string.IsNullOrEmpty(txtMessage.Text))
        {
            whereList.Add($"{COL_MSG} LIKE '%{txtMessage.Text}%' ");
        }

        string result = null;

        if (whereList.Count > 0)
        {
            result = "WHERE ";
            for (int i = 0; i < whereList.Count; i++)
            {
                if (i > 0)
                    result += " AND ";
                result += whereList[i];
            }
        }

        return result;
    }

    #endregion

    #region DetailForm

    public LogEvent GetPrevLogItem()
    {
        if (lvLogs.SelectedItems.Count == 0)
            return null;

        int idx = lvLogs.SelectedItems[0].Index;
        if (idx > 0)
        {
            lvLogs.Items[idx - 1].Selected = true;
            return lvLogs.Items[idx - 1].Tag as LogEvent;
        }
        return null;
    }

    public LogEvent GetNextLogItem()
    {
        if (lvLogs.SelectedItems.Count == 0)
            return null;

        int idx = lvLogs.SelectedItems[0].Index;
        if (idx < lvLogs.Items.Count - 1)
        {
            lvLogs.Items[idx + 1].Selected = true;
            return lvLogs.Items[idx + 1].Tag as LogEvent;
        }
        return null;
    }

    #endregion

    #region Auto Refresh

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.R)
            LoadLogItems();
    }

    private void btnAutoRefresh_Click(object sender, EventArgs e)
    {
        SetAutoRefresh(!_autoRefresh);
    }

    private void SetAutoRefresh(bool autoRefresh)
    {
        if (autoRefresh)
        {
            ResetData();
            timer1.Enabled = true;
            timer1.Start();
            pnlGlow.Visible = true;
            toolLblMessage.Text = "Auto refresh: On";
            pnlGlow.Start();

        }
        else
        {
            pnlGlow.Stop();
            timer1.Stop();
            timer1.Enabled = false;
            toolLblMessage.Text = "Auto refresh: Off";
            pnlGlow.Visible = false;
        }

        _autoRefresh = autoRefresh;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        System.Windows.Forms.MethodInvoker refreshDataActionStart = LoadLogItems;
        cmbApplicationNames.BeginInvoke(refreshDataActionStart);
    }

    private void btnSort_Click(object sender, EventArgs e)
    {
        SetSortDirection(!_sortAsc);
        FillGrid((int)numPageNumber.Value, (int)numPageLength.Value);
    }

    private void SetSortDirection(bool sortAsc)
    {
        if (sortAsc)
        {
            btnSort.ImageKey = IMGKEY_SORT_ASC;
            toolTip1.SetToolTip(btnSort, "Change to Ascending Sort");
        }
        else
        {
            btnSort.ImageKey = IMGKEY_SORT_DESC;
            toolTip1.SetToolTip(btnSort, "Change to Descending Sort");
        }

        _sortAsc = sortAsc;
    }

    #endregion

    #region Filters

    private void cmbSeverity_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!_suspendUpdates)
        {
            LoadLogItems();
            lvLogs.Focus();
        }
    }

    private void cmbMachineNames_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!_suspendUpdates)
        {
            lvLogs.Focus();
            LoadLogItems();
        }
    }

    private void cmbApplications_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!_suspendUpdates)
        {
            lvLogs.Focus();
            LoadLogItems();
        }
    }

    private void cmbApplicationNames_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!_suspendUpdates)
        {
            lvLogs.Focus();
            LoadLogItems();
        }
    }

    private void btnRefreshFilterLists_Click(object sender, EventArgs e)
    {
        RefreshFilterLists(true);
    }

    private void RefreshFilterLists(bool clearLists)
    {
        RefreshApplicationNameFilterList(clearLists);
    }

    private void ResetApplicationFilterList()
    {
        cmbApplicationNames.Items.Clear();
        cmbApplicationNames.Items.Add(string.Empty);
    }

    private void RefreshApplicationNameFilterList(bool clearList)
    {
        if (clearList)
            ResetApplicationFilterList();
        try
        {
            using (SqlConnection conn = new SqlConnection(_currDbConn.ConnString))
            {
                conn.Open();

                // AppName
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"SELECT DISTINCT {COL_APPLICATION} FROM {TABLE_NAME}";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string appName = reader[COL_APPLICATION].ToString();
                            if (!cmbApplicationNames.Items.Contains(appName))
                                cmbApplicationNames.Items.Add(appName);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            statusLabel.Text = string.Format("Error refreshing: {0}", ex.Message);
        }
    }

    private void ClearFilters()
    {
        _suspendUpdates = true;
        try
        {
            cmbSeverity.SelectedIndex = 0;
            txtSource.Text = string.Empty;
            cmbApplicationNames.SelectedIndex = 0;
            txtMessage.Text = string.Empty;

        }
        finally
        {
            _suspendUpdates = false;
        }
    }

    private void btnClearFilters_Click(object sender, EventArgs e)
    {
        ClearFilters();
        this.ResetData();
    }

    #endregion

    private void lvLogs_DoubleClick(object sender, EventArgs e)
    {
        this.SelectLogEvent();
    }

    private void lvLogs_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
            this.SelectLogEvent();
    }

    private void SelectLogEvent()
    {
        if (lvLogs.SelectedItems.Count == 1)
            _detailForm.ShowLog(lvLogs.SelectedItems[0].Tag as LogEvent);
    }

    private void btnPageDown_Click(object sender, EventArgs e)
    {
        if (numPageNumber.Value < 2)
            return;
        numPageNumber.Value -= 1;
    }

    private void btnPageUp_Click(object sender, EventArgs e)
    {
        numPageNumber.Value += 1;
    }

    private void numPageNumber_ValueChanged(object sender, EventArgs e)
    {
        this.LoadLogItems();
    }

    private void btnPurgeLogs_Click(object sender, EventArgs e)
    {
        if (PurgeLogs())
            lvLogs.Items.Clear();
    }

    private void numPageLength_KeyDown(object sender, KeyEventArgs e)
    {
    }

    private void numPageLength_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
            this.LoadLogItems();
    }

    private void lvLogs_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        ResetData();
    }
}
