using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Liazon.Common.LogViewer
{
	public partial class DetailForm : Form
	{
		private readonly Form1 _mainForm;
		private bool _showingException;

		public DetailForm(Form form1)
			: this()
		{
			_mainForm = form1 as Form1;
		}

		public DetailForm()
		{
			InitializeComponent();
		}

		private void DetailForm_Load(object sender, EventArgs e)
		{
			//ShowException(!_showingException);
		}

		public void ShowLog(LogItem logItem)
		{
			_mainForm.Cursor = Cursors.WaitCursor;
			try
			{
				lblRowId.Text = logItem.RowId.ToString();
				lblTimestamp.Text = logItem.TimeStamp.ToString();
				lblSeverity.Text = logItem.LevelValue.ToString();
				lblMachineName.Text = logItem.ApplicationName;
				lblModuleName.Text = logItem.UserName;
				lblLogSource.Text = logItem.SourceContext;
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

		private const int BOTTOM_OFFSET = 85;

		private void ShowException(bool showException)
		{
			_showingException = showException;

			if (showException)
			{
				txtMessage.Height = ((this.Height - txtMessage.Top - BOTTOM_OFFSET) / 2);
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
				txtMessage.Height = this.Height - txtMessage.Top - BOTTOM_OFFSET;
				txtException.Visible = false;
				lblException.Visible = false;
			}
		}

		private static string LoadException(Guid rowId)
		{
			try
			{
				string sql = string.Format("SELECT Exception FROM Logs WHERE RowId = '{0}'", rowId);
				using (SqlConnection conn = new SqlConnection(Form1.ConnStr))
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
				MessageBox.Show(string.Format("{0} reading exception: {1}", ex.GetType().Name, ex));
			}
			return null;
		}
	}
}