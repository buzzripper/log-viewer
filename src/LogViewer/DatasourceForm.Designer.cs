using System.Drawing;
using System.Windows.Forms;

namespace LogViewer;

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
		if (disposing && (components != null))
		{
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
		components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatasourceForm));
		ckbIsDefault = new CheckBox();
		panel1 = new Panel();
		btnSetFromName = new Button();
		txtDBServer = new TextBox();
		label4 = new Label();
		btnCancel = new Button();
		btnOk = new Button();
		ckbIsIntegratedSecurity = new CheckBox();
		txtPassword = new TextBox();
		label5 = new Label();
		txtUsername = new TextBox();
		label6 = new Label();
		txtDatabaseName = new TextBox();
		label3 = new Label();
		txtInstanceName = new TextBox();
		label2 = new Label();
		txtName = new TextBox();
		label1 = new Label();
		errorProvider1 = new ErrorProvider(components);
		((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
		SuspendLayout();
		// 
		// ckbIsDefault
		// 
		ckbIsDefault.AutoSize = true;
		ckbIsDefault.CheckAlign = ContentAlignment.MiddleRight;
		ckbIsDefault.Location = new Point(65, 477);
		ckbIsDefault.Margin = new Padding(4, 6, 4, 6);
		ckbIsDefault.Name = "ckbIsDefault";
		ckbIsDefault.Size = new Size(99, 29);
		ckbIsDefault.TabIndex = 27;
		ckbIsDefault.Text = "Default:";
		ckbIsDefault.TextAlign = ContentAlignment.MiddleCenter;
		ckbIsDefault.UseVisualStyleBackColor = true;
		// 
		// panel1
		// 
		panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel1.BorderStyle = BorderStyle.Fixed3D;
		panel1.Location = new Point(39, 85);
		panel1.Margin = new Padding(4, 6, 4, 6);
		panel1.Name = "panel1";
		panel1.Size = new Size(671, 4);
		panel1.TabIndex = 32;
		// 
		// btnSetFromName
		// 
		btnSetFromName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		btnSetFromName.Location = new Point(635, 24);
		btnSetFromName.Margin = new Padding(4, 6, 4, 6);
		btnSetFromName.Name = "btnSetFromName";
		btnSetFromName.Size = new Size(63, 44);
		btnSetFromName.TabIndex = 17;
		btnSetFromName.Text = "Set";
		btnSetFromName.UseVisualStyleBackColor = true;
		btnSetFromName.Click += btnSetFromName_Click;
		// 
		// txtDBServer
		// 
		txtDBServer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		txtDBServer.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtDBServer.Location = new Point(153, 28);
		txtDBServer.Margin = new Padding(4, 6, 4, 6);
		txtDBServer.Name = "txtDBServer";
		txtDBServer.Size = new Size(472, 26);
		txtDBServer.TabIndex = 16;
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label4.Location = new Point(46, 35);
		label4.Margin = new Padding(4, 0, 4, 0);
		label4.Name = "label4";
		label4.Size = new Size(93, 20);
		label4.TabIndex = 31;
		label4.Text = "DB Server:";
		// 
		// btnCancel
		// 
		btnCancel.DialogResult = DialogResult.Cancel;
		btnCancel.Location = new Point(362, 456);
		btnCancel.Margin = new Padding(4, 6, 4, 6);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(124, 69);
		btnCancel.TabIndex = 29;
		btnCancel.Text = "Cancel";
		btnCancel.UseVisualStyleBackColor = true;
		btnCancel.Click += btnCancel_Click;
		// 
		// btnOk
		// 
		btnOk.Location = new Point(211, 456);
		btnOk.Margin = new Padding(4, 6, 4, 6);
		btnOk.Name = "btnOk";
		btnOk.Size = new Size(124, 69);
		btnOk.TabIndex = 28;
		btnOk.Text = "Ok";
		btnOk.UseVisualStyleBackColor = true;
		btnOk.Click += btnOk_Click;
		// 
		// ckbIsIntegratedSecurity
		// 
		ckbIsIntegratedSecurity.AutoSize = true;
		ckbIsIntegratedSecurity.CheckAlign = ContentAlignment.MiddleRight;
		ckbIsIntegratedSecurity.Location = new Point(266, 268);
		ckbIsIntegratedSecurity.Margin = new Padding(4, 6, 4, 6);
		ckbIsIntegratedSecurity.Name = "ckbIsIntegratedSecurity";
		ckbIsIntegratedSecurity.Size = new Size(191, 29);
		ckbIsIntegratedSecurity.TabIndex = 23;
		ckbIsIntegratedSecurity.Text = "Integrated Security:";
		ckbIsIntegratedSecurity.TextAlign = ContentAlignment.MiddleCenter;
		ckbIsIntegratedSecurity.UseVisualStyleBackColor = true;
		ckbIsIntegratedSecurity.CheckedChanged += ckbIsIntegratedSecurity_CheckedChanged;
		// 
		// txtPassword
		// 
		txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		txtPassword.Location = new Point(153, 378);
		txtPassword.Margin = new Padding(4, 6, 4, 6);
		txtPassword.Name = "txtPassword";
		txtPassword.Size = new Size(542, 31);
		txtPassword.TabIndex = 25;
		// 
		// label5
		// 
		label5.AutoSize = true;
		label5.Location = new Point(59, 385);
		label5.Margin = new Padding(4, 0, 4, 0);
		label5.Name = "label5";
		label5.Size = new Size(91, 25);
		label5.TabIndex = 30;
		label5.Text = "Password:";
		// 
		// txtUsername
		// 
		txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		txtUsername.Location = new Point(153, 328);
		txtUsername.Margin = new Padding(4, 6, 4, 6);
		txtUsername.Name = "txtUsername";
		txtUsername.Size = new Size(542, 31);
		txtUsername.TabIndex = 24;
		// 
		// label6
		// 
		label6.AutoSize = true;
		label6.Location = new Point(47, 335);
		label6.Margin = new Padding(4, 0, 4, 0);
		label6.Name = "label6";
		label6.Size = new Size(103, 25);
		label6.TabIndex = 26;
		label6.Text = "User Name:";
		// 
		// txtDatabaseName
		// 
		txtDatabaseName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		txtDatabaseName.Location = new Point(153, 208);
		txtDatabaseName.Margin = new Padding(4, 6, 4, 6);
		txtDatabaseName.Name = "txtDatabaseName";
		txtDatabaseName.Size = new Size(542, 31);
		txtDatabaseName.TabIndex = 22;
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Location = new Point(59, 214);
		label3.Margin = new Padding(4, 0, 4, 0);
		label3.Name = "label3";
		label3.Size = new Size(90, 25);
		label3.TabIndex = 21;
		label3.Text = "Database:";
		// 
		// txtInstanceName
		// 
		txtInstanceName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		txtInstanceName.Location = new Point(153, 158);
		txtInstanceName.Margin = new Padding(4, 6, 4, 6);
		txtInstanceName.Name = "txtInstanceName";
		txtInstanceName.Size = new Size(542, 31);
		txtInstanceName.TabIndex = 20;
		txtInstanceName.Text = "MSSQLSERVER2016";
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new Point(16, 164);
		label2.Margin = new Padding(4, 0, 4, 0);
		label2.Name = "label2";
		label2.Size = new Size(133, 25);
		label2.TabIndex = 18;
		label2.Text = "Instance Name:";
		// 
		// txtName
		// 
		txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		txtName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtName.Location = new Point(153, 110);
		txtName.Margin = new Padding(4, 6, 4, 6);
		txtName.Name = "txtName";
		txtName.Size = new Size(542, 26);
		txtName.TabIndex = 19;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label1.Location = new Point(89, 114);
		label1.Margin = new Padding(4, 0, 4, 0);
		label1.Name = "label1";
		label1.Size = new Size(58, 20);
		label1.TabIndex = 15;
		label1.Text = "Name:";
		// 
		// errorProvider1
		// 
		errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
		errorProvider1.ContainerControl = this;
		// 
		// DatasourceForm
		// 
		AcceptButton = btnOk;
		AutoScaleDimensions = new SizeF(10F, 25F);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = btnCancel;
		ClientSize = new Size(727, 548);
		Controls.Add(ckbIsDefault);
		Controls.Add(panel1);
		Controls.Add(btnSetFromName);
		Controls.Add(txtDBServer);
		Controls.Add(label4);
		Controls.Add(btnCancel);
		Controls.Add(btnOk);
		Controls.Add(ckbIsIntegratedSecurity);
		Controls.Add(txtPassword);
		Controls.Add(label5);
		Controls.Add(txtUsername);
		Controls.Add(label6);
		Controls.Add(txtDatabaseName);
		Controls.Add(label3);
		Controls.Add(txtInstanceName);
		Controls.Add(label2);
		Controls.Add(txtName);
		Controls.Add(label1);
		Icon = (Icon)resources.GetObject("$this.Icon");
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "DatasourceForm";
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = "Connection Properties";
		Load += DatasourceForm_Load;
		Shown += DatasourceForm_Shown;
		((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private CheckBox ckbIsDefault;
	private Panel panel1;
	private Button btnSetFromName;
	private TextBox txtDBServer;
	private Label label4;
	private Button btnCancel;
	private Button btnOk;
	private CheckBox ckbIsIntegratedSecurity;
	private TextBox txtPassword;
	private Label label5;
	private TextBox txtUsername;
	private Label label6;
	private TextBox txtDatabaseName;
	private Label label3;
	private TextBox txtInstanceName;
	private Label label2;
	private TextBox txtName;
	private Label label1;
	private ErrorProvider errorProvider1;
}