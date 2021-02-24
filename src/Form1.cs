using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using ProData.Infrastructure.LogViewer.Data;
using ProData.Infrastructure.LogViewer.Properties;

namespace ProData.Infrastructure.LogViewer
{
	public partial class Form1 : Form
	{
		#region Constants

		private const string TABLE_NAME = "Logs";
		private const string COL_TIMESTAMP = "TimeStamp";
		private const string COL_LEVELVALUE = "LevelValue";
		private const string COL_APPID = "AppId";
        private const string COL_SRCCONTEXT = "SourceContext";
		private const string COL_MACHINENAME = "MachineName";
        private const string COL_USERNAME = "UserName";
		private const string COL_CORRID = "CorrelationId";
		private const string COL_MSG = "Message";
		private const string COL_EX = "Exception";
		private const string COL_ROWID = "RowId";
		private const string COL_HASEX = "HasException";

		private const string ERRLVL_VERBOSE = "VERBOSE";
		private const string ERRLVL_DEBUG = "DEBUG";
		private const string ERRLVL_INFO = "INFO";
		private const string ERRLVL_WARN = "WARN";
		private const string ERRLVL_ERROR = "ERROR";
		private const string ERRLVL_FATAL = "FATAL";

		#endregion

		#region Static

		public static string ConnStr;

		#endregion

		#region Fields

		//private string _dataFolder;
		private LogViewerData _logViewerData;
		private bool _suspendUpdates;
		private DatasourceForm _datasourceForm;
		private readonly Bitmap _sortAscBmp = Resources.SortAsc;
		private readonly Bitmap _sortDescBmp = Resources.SortDesc;
		private readonly ErrorLevelDisplay[] _errorLevelDisplays;
		private bool _sortAsc;
		private DetailForm _detailForm;
		private readonly Color _bgdColor = Color.FromArgb(50, 50, 50);
		private readonly Color _labelColor = Color.FromArgb(200, 200, 200);
		private readonly Color _textBoxForeColor = Color.FromArgb(50, 50, 50);
		private readonly Color _btnBgdColor = Color.DimGray;

		#endregion

		public Form1()
		{
			InitializeComponent();

			_errorLevelDisplays = this.BuildErrorLevelDisplays();
			this.SetUpDarkTheme();
		}

		private ErrorLevelDisplay[] BuildErrorLevelDisplays()
		{
			var errorLevelDisplays = new ErrorLevelDisplay[6];

			errorLevelDisplays[0] = new ErrorLevelDisplay(0, ERRLVL_VERBOSE, Color.Silver);
			errorLevelDisplays[1] = new ErrorLevelDisplay(1, ERRLVL_DEBUG, Color.White);
			errorLevelDisplays[2] = new ErrorLevelDisplay(2, ERRLVL_INFO, Color.White);
			errorLevelDisplays[3] = new ErrorLevelDisplay(3, ERRLVL_WARN, Color.Gold);
			errorLevelDisplays[4] = new ErrorLevelDisplay(4, ERRLVL_ERROR, Color.FromArgb(255, 50, 50));
			errorLevelDisplays[5] = new ErrorLevelDisplay(5, ERRLVL_FATAL, Color.FromArgb(255, 50, 50));

			return errorLevelDisplays;
		}

		private void SetUpDarkTheme()
		{
			this.BackColor = _bgdColor;
			lvLogs.BackColor = _bgdColor;
			statusStrip1.BackColor = _bgdColor;

			btnEditDatasource.BackColor = _btnBgdColor;
			btnDelDatasource.BackColor = _btnBgdColor;
			btnAddDatasource.BackColor = _btnBgdColor;
			btnSortDir.BackColor = _btnBgdColor;
			btnAutoRefresh.BackColor = _btnBgdColor;
			btnRefresh.BackColor = _btnBgdColor;
			btnClearLogs.BackColor = _btnBgdColor;
			btnPageDown.BackColor = _btnBgdColor;
			btnPageUp.BackColor = _btnBgdColor;
			btnRefreshFilterLists.BackColor = _btnBgdColor;
			btnClearFilters.BackColor = _btnBgdColor;

			label1.ForeColor = _labelColor;
			label2.ForeColor = _labelColor;
			label3.ForeColor = _labelColor;
			label4.ForeColor = _labelColor;
			label6.ForeColor = _labelColor;
			label7.ForeColor = _labelColor;
			label8.ForeColor = _labelColor;
			toolLblVersion.ForeColor = _labelColor;
			toolLblMessage.ForeColor = _labelColor;
			numPageLength.ForeColor = _textBoxForeColor;
			numPageNumber.ForeColor = _textBoxForeColor;
			btnClearLogs.ForeColor = _labelColor;

			lvLogs.OwnerDraw = true;
			lvLogs.DrawColumnHeader +=
				new DrawListViewColumnHeaderEventHandler
				(
					(sender, e) => ListViewHeaderDraw(sender, e, _bgdColor, _labelColor)
				);
			lvLogs.DrawItem += new DrawListViewItemEventHandler(ListViewBodyDraw);
		}

		private static void ListViewHeaderDraw(object sender, DrawListViewColumnHeaderEventArgs e, Color backColor, Color foreColor)
		{
			using (SolidBrush backBrush = new SolidBrush(backColor)) {
				e.Graphics.FillRectangle(backBrush, e.Bounds);
			}

			using (SolidBrush foreBrush = new SolidBrush(foreColor)) {
				e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, e.Bounds);
			}
		}

		private static void ListViewBodyDraw(object sender, DrawListViewItemEventArgs e)
		{
			e.DrawDefault = true;
		}

		#region Form Events

		private void Form1_Load(object sender, EventArgs e)
		{
			_logViewerData = LoadConfigData();

			PopulateForm();

			Form1_Resize(null, null);

			lvLogs.Focus();

			if (ApplicationDeployment.IsNetworkDeployed)
				// Running as click-once
				toolLblVersion.Text = string.Format("v. {0}", ApplicationDeployment.CurrentDeployment.CurrentVersion);
			else
				toolLblVersion.Text = string.Format("v. {0}", FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion);

			// Prevents ListView flicker
			PropertyInfo prop = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
			prop?.SetValue(lvLogs, true, null);

			SelectInitialDbConn();
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			SetAutoRefresh(_logViewerData.AutoRefresh);
		}

		private void Form1_Activated(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
				SetAutoRefresh(_logViewerData.AutoRefresh);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			_logViewerData.MRUConnStringName = cmbDbConns.Text;
			_logViewerData.AutoRefresh = timer1.Enabled;

			_logViewerData.WindowPlacement = new XmlDocument().CreateCDataSection(WindowPlacement.GetPlacement(this.Handle));
			if (this.DetailForm != null)
				_logViewerData.DetailWindowPlacement = new XmlDocument().CreateCDataSection(WindowPlacement.GetPlacement(this.DetailForm.Handle));

			SaveData();
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized) {
				if (timer1.Enabled)
					SetAutoRefresh(false);
			} else {
				var width = lvLogs.Width - 22;
				for (var i = 0; i < 5; i++)
					width -= lvLogs.Columns[i].Width;
				lvLogs.Columns[5].Width = width;
			}
		}

		#endregion

		#region Properties

		private DatasourceForm DatasourceForm {
			get { return _datasourceForm ?? (_datasourceForm = new DatasourceForm()); }
		}

		private DetailForm DetailForm {
			get {
				if (_detailForm == null)
					_detailForm = new DetailForm(this);
				return _detailForm;
			}
		}

		#endregion

		#region Datasources

		private void SelectInitialDbConn()
		{
			if (_logViewerData.DbConns.Count > 0) {
				var i = 0;
				foreach (DbConn dbConn in cmbDbConns.Items) {
					if (dbConn.Name == _logViewerData.MRUConnStringName) {
						cmbDbConns.SelectedIndex = i;
						return;
					}
					i++;
				}
				cmbDbConns.SelectedIndex = 0;
			}
		}

		private LogViewerData LoadConfigData()
		{
			var regRepos = new RegRepository();
			return regRepos.Load();
		}

		private void SaveData()
		{
			var regRepos = new RegRepository();
			regRepos.Save(_logViewerData);
		}

		private void PopulateForm()
		{
			_suspendUpdates = true;
			try {
				foreach (var errLevel in _errorLevelDisplays)
					cmbSeverity.Items.Add(errLevel.Text);

				cmbSeverity.SelectedIndex = 0;

				foreach (DbConn dbConn in _logViewerData.DbConns)
					cmbDbConns.Items.Add(dbConn);

				cmbApplicationNames.Items.Insert(0, string.Empty);

				if (!string.IsNullOrEmpty(_logViewerData.WindowPlacement?.Value))
					WindowPlacement.SetPlacement(this.Handle, _logViewerData.WindowPlacement.Value);
				if (!string.IsNullOrEmpty(_logViewerData.DetailWindowPlacement?.Value)) {
					WindowPlacement.SetPlacement(this.DetailForm.Handle, _logViewerData.DetailWindowPlacement.Value);
					this.DetailForm.Visible = false;
				}

				SetSortDirection(_logViewerData.MRUSortAsc);

			} finally {
				_suspendUpdates = false;
			}
		}

		private void cmbDbConn_SelectedIndexChanged(object sender, EventArgs e)
		{
			lvLogs.Focus();
			DbConnChanged();
		}

		private void DbConnChanged()
		{
			if (cmbDbConns.SelectedItem == null) {
				btnEditDatasource.Enabled = false;
				btnDelDatasource.Enabled = false;
				ConnStr = string.Empty;
				return;
			}

			btnEditDatasource.Enabled = true;
			btnDelDatasource.Enabled = true;

			ResetApplicationFilterList();

			DbConn dbConn = (cmbDbConns.SelectedItem as DbConn);
			if (dbConn == null) {
				MessageBox.Show(this, "Connection string data is null.", "Connection String Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			ConnStr = dbConn.ConnectionString;

			if (!_suspendUpdates) {
				LoadLogItems();
				RefreshFilterLists(true);
			}
		}

		#endregion

		private void ResetData()
		{
			numPageNumber.Value = 1;
			this.LoadLogItems();
		}

		private void LoadLogItems()
		{
			this.Cursor = Cursors.WaitCursor;
			try {
				Refresh();
				FillGrid((int)numPageNumber.Value, (int)numPageLength.Value);
				toolLblMessage.Text = null;

			} catch (Exception ex) {
				SetAutoRefresh(false);
				MessageBox.Show(ex.Message);

			} finally {
				this.Cursor = Cursors.Default;
			}
		}

		private void FillGrid(int startPage, int pageLength)
		{
			int startRow = ((startPage - 1) * pageLength) + 1;
			int endRow = startRow + pageLength;
			string sqlWhere = BuildWhereClause();
			string orderByDir = _sortAsc ? "DESC" : "ASC";

			string sql = $@"SELECT 
	                                  MasterRowNums.*
	                                FROM
	                                (
	                                  SELECT
	                                    {COL_ROWID}, 
										{COL_TIMESTAMP}, 
										{COL_LEVELVALUE}, 
										{COL_APPID}, 
										{COL_SRCCONTEXT}, 
										{COL_USERNAME}, 
										{COL_MACHINENAME}, 
                                        {COL_CORRID}, 
										{COL_MSG},
										CASE WHEN {COL_EX} = '' THEN 0 ELSE 1 END AS {COL_HASEX},
										ROW_NUMBER() OVER (ORDER BY {COL_TIMESTAMP} DESC) AS RowNum
	                                  FROM 
	                                    {TABLE_NAME} WITH(NOLOCK)
	                                  {sqlWhere}
	                                ) 
	                                  MasterRowNums
	                                WHERE 
	                                  RowNum BETWEEN {startRow} AND {endRow}
	                                ORDER BY 
	                                  {COL_TIMESTAMP} {orderByDir}";

			using (SqlConnection conn = new SqlConnection(ConnStr))
			using (SqlCommand cmd = new SqlCommand(sql, conn)) {
				cmd.CommandType = CommandType.Text;

				try {
					conn.Open();
				} catch {
					// DB was probably re-created since the last calll, let's try once more
					conn.Open();
				}

				SqlDataReader reader;
				try {
					reader = cmd.ExecuteReader();

				} catch (SqlException sqlEx) {
					// Sql Error #10054 means the database rebuild script was recently run but the connection pool
					// didn't know about it so it tries connecting on a stale connection. Let's try once more..
					if (sqlEx.Number == 10054) {
						conn.Open();
						reader = cmd.ExecuteReader();
					} else {
						throw;
					}
				}

				lvLogs.Items.Clear();

				try {
					while (reader.Read()) {
						var logItem = new LogItem {
							RowId = (Guid)reader[COL_ROWID],
							TimeStamp = ((DateTime)reader[COL_TIMESTAMP]).ToLocalTime(),
							LevelValue = (int)reader[COL_LEVELVALUE],
							AppId = reader[COL_APPID].ToString(),
                            SourceContext = reader[COL_SRCCONTEXT].ToString(),
							MachineName = reader[COL_MACHINENAME].ToString(),
                            UserName = reader[COL_USERNAME].ToString(),
                            CorrelationId = reader[COL_CORRID].ToString(),
							Message = reader[COL_MSG].ToString(),
							HasException = ((int)reader[COL_HASEX] == 1)
						};

						var timestampStr = logItem.TimeStamp.Date == DateTime.Now.Date ? logItem.TimeStamp.ToString("h:mm:ss.fff") : logItem.TimeStamp.ToString("h:mm:ss.fff M/d/yy");
						var errLevelDisplay = _errorLevelDisplays[logItem.LevelValue];

						ListViewItem lvItem = new ListViewItem(new[] { timestampStr, errLevelDisplay.Text, logItem.AppId, logItem.SourceContext, logItem.UserName, logItem.Message });
						lvItem.ImageIndex = errLevelDisplay.ImageIndex;
						lvItem.ForeColor = errLevelDisplay.TextColor;
						lvItem.ToolTipText = logItem.TimeStamp.ToString("M/d/yy");
						lvItem.Tag = logItem;

						lvLogs.Items.Add(lvItem);
					}
				} finally {
					reader.Dispose();
				}
			}

			if (!_sortAsc && (lvLogs.Items.Count > 0))
				lvLogs.Items[lvLogs.Items.Count - 1].EnsureVisible();
		}

		private bool PurgeLogs()
		{
			string msg = string.Format("Are you sure you want to delete all logs in database {0}?", cmbDbConns.SelectedText);
			if (MessageBox.Show(msg, "Confirm Delete Logs", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
				return false;

			try {
				using (SqlConnection conn = new SqlConnection(ConnStr))
				using (SqlCommand cmd = new SqlCommand()) {
					try {
						conn.Open();
					} catch (SqlException) {
						// Try once more
						conn.Open();
					}

					cmd.Connection = conn;
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = $"DELETE FROM {TABLE_NAME}";
					cmd.CommandTimeout = 300;       // 5 minutes, sometimes these take a long time

					try {
						cmd.ExecuteNonQuery();
					} catch (SqlException sqlEx) {
						// Sql Error #10054 means the database rebuild script was recently run but the connection pool
						// didn't know about it so it tries connecting on a stale connection. Another try will get a new connection, so let's try
						if (sqlEx.Number == 10054) {
							conn.Open();
							cmd.ExecuteNonQuery();
						} else {
							throw;
						}
					}

					cmbApplicationNames.Items.Clear();
				}

				return true;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
				return false;
			}
		}

		private string BuildWhereClause()
		{
			List<string> whereList = new List<string>();

			// LevelValue
			whereList.Add($"LevelValue >= {cmbSeverity.SelectedIndex} ");

			// Machine
			if (cmbApplicationNames.SelectedIndex > 0) {
				whereList.Add($"{COL_APPID} = '{cmbApplicationNames.Text}' ");
			}

			// SourceClass
			if (!string.IsNullOrEmpty(txtSource.Text)) {
				whereList.Add($"{COL_SRCCONTEXT} LIKE '%{txtSource.Text}%' ");
			}

			// Message
			if (!string.IsNullOrEmpty(txtMessage.Text)) {
				whereList.Add($"{COL_MSG} LIKE '%{txtMessage.Text}%' ");
			}

			string result = null;

			if (whereList.Count > 0) {
				result = "WHERE ";
				for (int i = 0; i < whereList.Count; i++) {
					if (i > 0)
						result += " AND ";
					result += whereList[i];
				}
			}

			return result;
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			LoadLogItems();
		}

		#region DetailForm

		private void lvLogs_DoubleClick(object sender, EventArgs e)
		{
			if (lvLogs.SelectedItems.Count == 1) {
				this.DetailForm.ShowLog(lvLogs.SelectedItems[0].Tag as LogItem);
			}
		}

		public void DetailFormClosing(int width, int height)
		{
			_logViewerData.DetailWindowPlacement = new XmlDocument().CreateCDataSection(WindowPlacement.GetPlacement(this.DetailForm.Handle));
		}

		public LogItem GetPrevLogItem()
		{
			if (lvLogs.SelectedItems.Count == 0)
				return null;

			int idx = lvLogs.SelectedItems[0].Index;
			if (idx > 0) {
				lvLogs.Items[idx - 1].Selected = true;
				return lvLogs.Items[idx - 1].Tag as LogItem;
			}
			return null;
		}

		public LogItem GetNextLogItem()
		{
			if (lvLogs.SelectedItems.Count == 0)
				return null;

			int idx = lvLogs.SelectedItems[0].Index;
			if (idx < lvLogs.Items.Count - 1) {
				lvLogs.Items[idx + 1].Selected = true;
				return lvLogs.Items[idx + 1].Tag as LogItem;
			}
			return null;
		}

		#endregion

		private void btnPurgeLogs_Click(object sender, EventArgs e)
		{
			if (PurgeLogs())
				lvLogs.Items.Clear();
		}

		#region Paging

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

		private void NumPageNumber_ValueChanged(object sender, EventArgs e)
		{
			this.LoadLogItems();
		}

		#endregion

		#region Datasources

		private void btnAddDatasource_Click(object sender, EventArgs e)
		{
			try {
				if (this.DatasourceForm.Run(new DbConn())) {
					_logViewerData.DbConns.Add(this.DatasourceForm.DbConn);
					int idx = cmbDbConns.Items.Add(this.DatasourceForm.DbConn);
					cmbDbConns.SelectedIndex = idx;
					RefreshFilterLists(true);
				}

			} catch (Exception ex) {
				MessageBox.Show($@"(btnAddDatasource_Click) {ex.GetType().Name}: {ex.Message}");
			}
		}

		private void btnEditDatasource_Click(object sender, EventArgs e)
		{
			try {

				DbConn datasource = cmbDbConns.SelectedItem as DbConn;
				if (datasource == null)
					return;
				int idx = _logViewerData.DbConns.IndexOf(datasource);
				if (idx == -1) {
					MessageBox.Show("Error with connection list.");
					return;
				}

				if (this.DatasourceForm.Run(datasource)) {
					_logViewerData.DbConns[idx].Apply(this.DatasourceForm.DbConn);

					// If this is set as the default datasource, clear all others
					if (datasource.IsDefault)
						for (var i = 0; i < _logViewerData.DbConns.Count; i++)
							_logViewerData.DbConns[i].IsDefault = (i == idx);

					cmbDbConns.Items[idx] = this.DatasourceForm.DbConn;
					DbConnChanged();
					RefreshFilterLists(true);
				}
			} catch (Exception ex) {
				MessageBox.Show(string.Format("(btnAddDatasource_Click) {0}: {1}", ex.GetType().Name, ex.Message));
			}
		}

		private void btnDelDatasource_Click(object sender, EventArgs e)
		{
			if (cmbDbConns.SelectedItem == null)
				return;

			if (MessageBox.Show(this, "Delete the selected datasource?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				_logViewerData.DbConns.Remove(cmbDbConns.SelectedItem as DbConn);
				int idx = cmbDbConns.SelectedIndex;
				cmbDbConns.Items.RemoveAt(idx);
				if (idx < cmbDbConns.Items.Count)
					cmbDbConns.SelectedIndex = idx;
				else
					cmbDbConns.SelectedIndex = cmbDbConns.Items.Count - 1;
				RefreshFilterLists(true);
			}
		}

		#endregion

		#region Refresh

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.R)
				LoadLogItems();
		}
		#endregion

		#region Auto-refresh

		private void btnAutoRefresh_Click(object sender, EventArgs e)
		{
			_logViewerData.AutoRefresh = !_logViewerData.AutoRefresh;
			SetAutoRefresh(_logViewerData.AutoRefresh);

		}

		private void SetAutoRefresh(bool autoRefresh)
		{
			if (autoRefresh) {
				ResetData();
				btnAutoRefresh.Image = Resources.Spinner;
				toolLblMessage.Text = "Auto refresh: On";
				timer1.Enabled = true;
				timer1.Interval = _logViewerData.TimerInterval;
				timer1.Start();

			} else {
				timer1.Stop();
				timer1.Enabled = false;
				btnAutoRefresh.Image = Resources.Timer;
				toolLblMessage.Text = "Auto refresh: Off";
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			MethodInvoker refreshDataActionStart = LoadLogItems;
			cmbApplicationNames.BeginInvoke(refreshDataActionStart);
		}

		private void btnSortDir_Click(object sender, EventArgs e)
		{
			_sortAsc = !_sortAsc;
			SetSortDirection(_sortAsc);

			FillGrid((int)numPageNumber.Value, (int)numPageLength.Value);
		}

		private void SetSortDirection(bool sortAsc)
		{
			if (sortAsc) {
				btnSortDir.Image = _sortDescBmp;
				toolTip1.SetToolTip(btnSortDir, "Change to Ascending Sort");
			} else {
				btnSortDir.Image = _sortAscBmp;
				toolTip1.SetToolTip(btnSortDir, "Change to Descending Sort");
			}
			_logViewerData.MRUSortAsc = sortAsc;
		}

		#endregion

		#region Filters

		private void cmbSeverity_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!_suspendUpdates) {
				LoadLogItems();
				lvLogs.Focus();
			}
		}

		private void cmbMachineNames_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!_suspendUpdates) {
				lvLogs.Focus();
				LoadLogItems();
			}
		}

		private void cmbApplications_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!_suspendUpdates) {
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
			try {
				using (SqlConnection conn = new SqlConnection(ConnStr)) {
					conn.Open();

					// AppName
					using (SqlCommand cmd = new SqlCommand()) {
						cmd.Connection = conn;
						cmd.CommandType = CommandType.Text;
						cmd.CommandText = $"SELECT DISTINCT {COL_APPID} FROM {TABLE_NAME}";
						using (SqlDataReader reader = cmd.ExecuteReader()) {
							while (reader.Read()) {
								string appName = reader[COL_APPID].ToString();
								if (!cmbApplicationNames.Items.Contains(appName))
									cmbApplicationNames.Items.Add(appName);
							}
						}
					}
				}
			} catch (Exception ex) {
				statusLabel.Text = string.Format("Error refreshing: {0}", ex.Message);
			}
		}

		private void ClearFilters()
		{
			_suspendUpdates = true;
			try {
				cmbSeverity.SelectedIndex = 0;
				txtSource.Text = string.Empty;
				cmbApplicationNames.SelectedIndex = 0;
				txtMessage.Text = string.Empty;

			} finally {
				_suspendUpdates = false;
			}
		}

		private void btnClearFilters_Click(object sender, EventArgs e)
		{
			ClearFilters();
			this.ResetData();
		}

		#endregion
	}
}