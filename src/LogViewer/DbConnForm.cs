using LogViewer.Config;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogViewer;

public partial class DbConnForm : Form
{
	private readonly Dictionary<Control, string> _errors = new Dictionary<Control, string>();

	public DbConnForm()
	{
		InitializeComponent();

		_errors.Add(txtName, null);
		_errors.Add(txtConnStr, null);
	}

	private void DatasourceForm_Load(object sender, EventArgs e)
	{
	}

	private void DatasourceForm_Shown(object sender, EventArgs e)
	{
	}

	public DialogResult Run(DbConn dbConn)
	{
		if (string.IsNullOrEmpty(dbConn.Name)) {
			this.Text = "Add Datasource";
			txtName.Focus();
		} else {
			this.Text = "Edit Datasource";
			txtConnStr.Focus();
		}

		txtName.Text = dbConn.Name;
		txtConnStr.Text = Split(dbConn.ConnString);

		ShowDialog();

		if (this.DialogResult == DialogResult.OK) {
			dbConn.Name = txtName.Text;
			dbConn.ConnString = Combine(txtConnStr.Text);
			dbConn.IsDefault = ckbIsDefault.Checked;
		}

		return this.DialogResult;
	}

	private string Split(string connString)
	{
		if (string.IsNullOrWhiteSpace(connString))
			return string.Empty;

		var parts = connString.Split(';');

		var sb = new StringBuilder();
		foreach (var part in parts)
			sb.AppendLine(part.Trim());

		return sb.ToString();
	}

	private string Combine(string text)
	{
		var str = text?.Replace(Environment.NewLine, ";");
		return str;
	}

	private void btnOk_Click(object sender, EventArgs e)
	{
		txtName_TextChanged(null, null);
		txtConnStr_TextChanged(null, null);

		if (HasErrors())
			return;

		this.DialogResult = DialogResult.OK;
	}

	private void txtName_TextChanged(object sender, EventArgs e)
	{
		Validate(txtName, string.IsNullOrEmpty(txtName.Text) ? "Cannot be empty." : null);
	}

	private void txtConnStr_TextChanged(object sender, EventArgs e)
	{
		Validate(txtConnStr, string.IsNullOrEmpty(txtConnStr.Text) ? "Cannot be empty." : null);
	}

	private void Validate(Control control, string errMsg)
	{
		_errors[control] = errMsg;
		errorProvider1.SetError(control, errMsg);
	}

	private bool HasErrors()
	{
		return _errors.Values.Any(error => !string.IsNullOrEmpty(error));
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		this.Close();
	}

	private void btnTest_Click(object sender, EventArgs e)
	{
		try {
			this.Cursor = Cursors.WaitCursor;
			var connStr = $"{Combine(txtConnStr.Text)};Connection Timeout=1";
			using var conn = new SqlConnection(connStr);
			conn.Open();
			MessageBox.Show("Connection successful.", "Test Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);

		} catch (Exception ex) {
			MessageBox.Show(ex.Message, "Test Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);

		} finally {
			this.Cursor = Cursors.Default;
		}
	}
}