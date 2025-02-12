using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using LogViewer.Config;

namespace LogViewer;
public partial class DetailForm : Form
{
	private const int BottomOffset = 85;
	private readonly Form1 _mainForm;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public DbConn DbConn { get; set; }

	#region Ctors / Forms Events

	public DetailForm(Form form1) : this()
	{
		_mainForm = form1 as Form1;
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
		LogItem logItem = _mainForm.GetPrevLogItem();
		if (logItem != null)
			ShowLog(logItem);
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		LogItem logItem = _mainForm.GetNextLogItem();
		if (logItem != null)
			ShowLog(logItem);
	}


	public void ShowLog(LogItem logItem)
	{
		_mainForm.Cursor = Cursors.WaitCursor;
		try
		{
			lblRowId.Text = logItem.RowId.ToString();
			lblTimestamp.Text = logItem.TimeStamp.ToString(CultureInfo.InvariantCulture);
			lblSeverity.Text = logItem.LevelValue.ToString();
			lblSourceContext.Text = logItem.SourceContext;
			lblAppId.Text = logItem.AppId;
			lblMachineName.Text = logItem.MachineName;
			lblUserName.Text = logItem.UserName;
			txtMessage.Text = logItem.Message;
			if (!string.IsNullOrWhiteSpace(logItem.Exception))
			{
				if (logItem.ExceptionWasLoaded)
					txtException.Text = logItem.Exception;
				else
					txtException.Text = LoadException(logItem.RowId);
				ShowException(true);
				lblException.Visible = true;
			}
			else
			{
				txtException.Text = null;
				ShowException(false);
				lblException.Visible = false;
			}

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
			ShowDialog();
		else
			Refresh();
	}

	private void ShowException(bool showException)
	{
		if (showException)
		{
			txtMessage.Height = ((this.Height - txtMessage.Top - BottomOffset) / 2);
			txtMessage.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
			txtException.Top = txtMessage.Top + txtMessage.Height + 15;
			txtException.Height = txtMessage.Height;
			txtException.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
			lblException.Top = txtMessage.Top + txtMessage.Height + 5;
			txtException.Visible = true;
			lblException.Visible = true;
		}
		else
		{
			txtMessage.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
			txtMessage.Height = this.Height - txtMessage.Top - BottomOffset;
			txtException.Visible = false;
			lblException.Visible = false;
		}
	}

	private string LoadException(Guid rowId)
	{
		try
		{
			string sql = string.Format("SELECT Exception FROM Logs WHERE RowId = '{0}'", rowId);
			using (var conn = new SqlConnection(this.DbConn.ConnString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.CommandType = CommandType.Text;
				conn.Open();
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						return reader["Exception"].ToString();
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
}
