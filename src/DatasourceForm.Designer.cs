namespace Liazon.Common.LogViewer
{
    partial class DatasourceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatasourceForm));
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtInstanceName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDatabaseName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.ckbIsIntegratedSecurity = new System.Windows.Forms.CheckBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.txtDBServer = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSetFromName = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ckbIsDefault = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(72, 86);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(130, 83);
			this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(488, 26);
			this.txtName.TabIndex = 2;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// txtInstanceName
			// 
			this.txtInstanceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtInstanceName.Location = new System.Drawing.Point(130, 122);
			this.txtInstanceName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtInstanceName.Name = "txtInstanceName";
			this.txtInstanceName.Size = new System.Drawing.Size(488, 26);
			this.txtInstanceName.TabIndex = 3;
			this.txtInstanceName.Text = "MSSQLSERVER2016";
			this.txtInstanceName.TextChanged += new System.EventHandler(this.txtServerName_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 126);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Instance Name:";
			// 
			// txtDatabaseName
			// 
			this.txtDatabaseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDatabaseName.Location = new System.Drawing.Point(130, 162);
			this.txtDatabaseName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDatabaseName.Name = "txtDatabaseName";
			this.txtDatabaseName.Size = new System.Drawing.Size(488, 26);
			this.txtDatabaseName.TabIndex = 4;
			this.txtDatabaseName.TextChanged += new System.EventHandler(this.txtDatabaseName_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(45, 166);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Database:";
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPassword.Location = new System.Drawing.Point(130, 298);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(488, 26);
			this.txtPassword.TabIndex = 7;
			this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(45, 303);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "Password:";
			// 
			// txtUsername
			// 
			this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUsername.Location = new System.Drawing.Point(130, 258);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(488, 26);
			this.txtUsername.TabIndex = 6;
			this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(34, 263);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 20);
			this.label6.TabIndex = 8;
			this.label6.Text = "User Name:";
			// 
			// ckbIsIntegratedSecurity
			// 
			this.ckbIsIntegratedSecurity.AutoSize = true;
			this.ckbIsIntegratedSecurity.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ckbIsIntegratedSecurity.Location = new System.Drawing.Point(231, 210);
			this.ckbIsIntegratedSecurity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ckbIsIntegratedSecurity.Name = "ckbIsIntegratedSecurity";
			this.ckbIsIntegratedSecurity.Size = new System.Drawing.Size(174, 24);
			this.ckbIsIntegratedSecurity.TabIndex = 5;
			this.ckbIsIntegratedSecurity.Text = "Integrated Security:";
			this.ckbIsIntegratedSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ckbIsIntegratedSecurity.UseVisualStyleBackColor = true;
			this.ckbIsIntegratedSecurity.CheckedChanged += new System.EventHandler(this.ckbIsIntegratedSecurity_CheckedChanged);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(182, 360);
			this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(112, 55);
			this.btnOk.TabIndex = 9;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(318, 360);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(112, 55);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// errorProvider1
			// 
			this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider1.ContainerControl = this;
			// 
			// txtDBServer
			// 
			this.txtDBServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDBServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDBServer.Location = new System.Drawing.Point(130, 18);
			this.txtDBServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDBServer.Name = "txtDBServer";
			this.txtDBServer.Size = new System.Drawing.Size(425, 26);
			this.txtDBServer.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(33, 23);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "DB Server:";
			// 
			// btnSetFromName
			// 
			this.btnSetFromName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSetFromName.Location = new System.Drawing.Point(563, 14);
			this.btnSetFromName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSetFromName.Name = "btnSetFromName";
			this.btnSetFromName.Size = new System.Drawing.Size(57, 35);
			this.btnSetFromName.TabIndex = 1;
			this.btnSetFromName.Text = "Set";
			this.btnSetFromName.UseVisualStyleBackColor = true;
			this.btnSetFromName.Click += new System.EventHandler(this.btnSetFromName_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Location = new System.Drawing.Point(27, 63);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(604, 4);
			this.panel1.TabIndex = 14;
			// 
			// ckbIsDefault
			// 
			this.ckbIsDefault.AutoSize = true;
			this.ckbIsDefault.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ckbIsDefault.Location = new System.Drawing.Point(50, 377);
			this.ckbIsDefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ckbIsDefault.Name = "ckbIsDefault";
			this.ckbIsDefault.Size = new System.Drawing.Size(91, 24);
			this.ckbIsDefault.TabIndex = 8;
			this.ckbIsDefault.Text = "Default:";
			this.ckbIsDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ckbIsDefault.UseVisualStyleBackColor = true;
			// 
			// DatasourceForm
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(654, 438);
			this.Controls.Add(this.ckbIsDefault);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnSetFromName);
			this.Controls.Add(this.txtDBServer);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.ckbIsIntegratedSecurity);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtDatabaseName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtInstanceName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DatasourceForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Connection Properties";
			this.Load += new System.EventHandler(this.DatasourceForm_Load);
			this.Shown += new System.EventHandler(this.DatasourceForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInstanceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckbIsIntegratedSecurity;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSetFromName;
		private System.Windows.Forms.TextBox txtDBServer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox ckbIsDefault;
	}
}