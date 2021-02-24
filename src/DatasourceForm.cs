using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ProData.Infrastructure.LogViewer.Data;

namespace ProData.Infrastructure.LogViewer
{
	public partial class DatasourceForm : Form
	{
		private readonly Dictionary<Control, string> _errors = new Dictionary<Control, string>();

		public DatasourceForm()
		{
			InitializeComponent();

			_errors.Add(txtName, null);
			_errors.Add(txtInstanceName, null);
			_errors.Add(txtDatabaseName, null);
			_errors.Add(txtUsername, null);
			_errors.Add(txtPassword, null);
		}

		public DbConn DbConn { get; private set; }

		public bool Run(DbConn datasource)
		{
			PopulateForm(datasource);

			this.DbConn = null;

			ShowDialog();

			if (this.DialogResult == DialogResult.OK)
			{
				this.DbConn = GetDatasourceFromForm();
				return true;
			}
			return false;
		}

		private void DatasourceForm_Load(object sender, EventArgs e)
		{
		}


		private void DatasourceForm_Shown(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtName.Text))
				txtDBServer.Focus();
			else
				txtName.Focus();
		}

		private void PopulateForm(DbConn datasource)
		{
			txtDBServer.Text = null;
			txtName.Text = datasource.Name;
			txtInstanceName.Text = datasource.ServerName;
			txtDatabaseName.Text = datasource.DatabaseName;
			ckbIsIntegratedSecurity.Checked = datasource.IsIntegratedSecurity;
			txtUsername.Text = datasource.Username;
			txtPassword.Text = datasource.Password;
			ckbIsDefault.Checked = datasource.IsDefault;
		}

		private DbConn GetDatasourceFromForm()
		{
			return new DbConn {
				Name = txtName.Text,
				ServerName = txtInstanceName.Text,
				DatabaseName = txtDatabaseName.Text,
				IsIntegratedSecurity = ckbIsIntegratedSecurity.Checked,
				Username = txtUsername.Text,
				Password = txtPassword.Text,
				IsDefault = ckbIsDefault.Checked
			};
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			txtName_TextChanged(null, null);
			txtServerName_TextChanged(null, null);
			txtDatabaseName_TextChanged(null, null);
			txtUsername_TextChanged(null, null);
			txtPassword_TextChanged(null, null);

			if (!HasErrors())
				this.DialogResult = DialogResult.OK;
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{
			Validate(txtName, string.IsNullOrEmpty(txtName.Text) ? "Cannot be empty." : null);
		}

		private void txtServerName_TextChanged(object sender, EventArgs e)
		{
			Validate(txtInstanceName, string.IsNullOrEmpty(txtInstanceName.Text) ? "Cannot be empty." : null);
		}

		private void txtDatabaseName_TextChanged(object sender, EventArgs e)
		{
			Validate(txtDatabaseName, string.IsNullOrEmpty(txtDatabaseName.Text) ? "Cannot be empty." : null);
		}

		private void ckbIsIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
		{
			if (ckbIsIntegratedSecurity.Checked)
			{
				txtUsername.Enabled = false;
				txtUsername.BackColor = SystemColors.ButtonFace;
				txtUsername.Text = string.Empty;
				txtUsername_TextChanged(null, null);
				txtPassword.Enabled = false;
				txtPassword.BackColor = SystemColors.ButtonFace;
				txtPassword.Text = string.Empty;
				txtPassword_TextChanged(null, null);
			}
			else
			{
				txtUsername.Enabled = true;
				txtUsername.BackColor = SystemColors.Window;
				txtPassword.Enabled = true;
				txtPassword.BackColor = SystemColors.Window;
			}
		}

		private void txtUsername_TextChanged(object sender, EventArgs e)
		{
			Validate(txtUsername, !ckbIsIntegratedSecurity.Checked && string.IsNullOrEmpty(txtUsername.Text) ? "Cannot be empty." : null);
		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{
			Validate(txtPassword, !ckbIsIntegratedSecurity.Checked && string.IsNullOrEmpty(txtPassword.Text) ? "Cannot be empty." : null);
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

		private void btnSetFromName_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtDBServer.Text))
			{
				MessageBox.Show("No DB Server entered.");
				txtDBServer.Focus();
				return;
			}

			txtName.Text = txtDBServer.Text;
			txtInstanceName.Text = txtDBServer.Text;
			txtPassword.Text = "P@ssword1";

			txtDatabaseName.Focus();
		}
	}
}