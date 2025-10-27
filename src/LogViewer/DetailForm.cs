using System;
using System.ComponentModel;
using Microsoft.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using System.Data;

namespace LogViewer;

public partial class DetailForm : Form
{
    #region Fields

    private readonly Form1 _mainForm;
    private ExceptionMessageCache _exceptionCache;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string ConnString { get; set; }

    #endregion

    #region Ctors / Forms Events

    public DetailForm(Form form1) : this()
    {
        _mainForm = form1 as Form1;
        _exceptionCache = new ExceptionMessageCache();
    }

    public DetailForm()
    {
        InitializeComponent();
    }

    private void DetailForm_Load(object sender, EventArgs e)
    {
    }

    private void DetailForm_Shown(object sender, EventArgs e)
    {
    }

    #endregion

    private void btnUp_Click(object sender, EventArgs e)
    {
        LogEvent logItem = _mainForm.GetPrevLogItem();
        if (logItem != null)
            ShowLog(logItem);
    }

    private void btnDown_Click(object sender, EventArgs e)
    {
        LogEvent logEvent = _mainForm.GetNextLogItem();
        if (logEvent != null)
            ShowLog(logEvent);
    }

    public void ShowLog(LogEvent logEvent)
    {
        _mainForm.Cursor = Cursors.WaitCursor;
        try
        {
            lblRowId.Text = logEvent.Id.ToString();
            lblTimestamp.Text = logEvent.TimeStamp.ToString(CultureInfo.InvariantCulture);
            lblSeverity.Text = logEvent.LogLevel.ToString();
            lblSource.Text = logEvent.Source;
            lblApplication.Text = logEvent.Application;
            txtMessage.Text = logEvent.Message;

            if (logEvent.HasException)
            {
                txtException.Text = GetException(logEvent.Id);
            }
            else
            {
                txtException.Text = null;
            }
            ShowException(logEvent.HasException);

            txtMessage.SelectionStart = 0;
            txtMessage.SelectionLength = 0;
            txtException.SelectionStart = 0;
            txtException.SelectionLength = 0;
        }
        finally
        {
            _mainForm.Cursor = Cursors.Default;
        }

        if (!this.Visible)
            //ShowDialog();
            this.Show(_mainForm);
        else
            Refresh();
    }

    private void ShowException(bool showException)
    {
        splitContainer1.Panel2Collapsed = !showException;
    }

    private string GetException(int id)
    {
        try
        {
            // Check if the exception is already cached
            if (_exceptionCache.TryGetFromCache(id, out string cachedException))
                return cachedException;

            string sql = string.Format("SELECT Exception FROM Logs.LogEvents WHERE Id = '{0}'", id);
            using (var conn = new SqlConnection(this.ConnString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var exceptionStr = reader["Exception"].ToString();
                        _exceptionCache.AddToCache(id, exceptionStr);
                        return exceptionStr;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(string.Format($@"{ex.GetType().Name} reading exception: {ex}"));
        }
        return null;
    }

    private void picCopyMessage_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(txtMessage.Text);
    }

    private void picCopyException_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(txtException.Text);
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Hide();
    }

}
