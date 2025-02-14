using System.Drawing;
using System.Windows.Forms;

namespace LogViewer;

partial class DbConnForm
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbConnForm));
		ckbIsDefault = new CheckBox();
		btnCancel = new Button();
		btnOk = new Button();
		txtConnStr = new TextBox();
		label2 = new Label();
		txtName = new TextBox();
		label1 = new Label();
		errorProvider1 = new ErrorProvider(components);
		btnTest = new Button();
		picCopyConnStr = new PictureBox();
		((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
		((System.ComponentModel.ISupportInitialize)picCopyConnStr).BeginInit();
		SuspendLayout();
		// 
		// ckbIsDefault
		// 
		ckbIsDefault.AutoSize = true;
		ckbIsDefault.CheckAlign = ContentAlignment.MiddleRight;
		ckbIsDefault.Location = new Point(108, 259);
		ckbIsDefault.Margin = new Padding(3, 4, 3, 4);
		ckbIsDefault.Name = "ckbIsDefault";
		ckbIsDefault.Size = new Size(67, 19);
		ckbIsDefault.TabIndex = 27;
		ckbIsDefault.Text = "Default:";
		ckbIsDefault.TextAlign = ContentAlignment.MiddleCenter;
		ckbIsDefault.UseVisualStyleBackColor = true;
		// 
		// btnCancel
		// 
		btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		btnCancel.DialogResult = DialogResult.Cancel;
		btnCancel.Location = new Point(250, 289);
		btnCancel.Margin = new Padding(3, 4, 3, 4);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(86, 28);
		btnCancel.TabIndex = 29;
		btnCancel.Text = "Cancel";
		btnCancel.UseVisualStyleBackColor = true;
		btnCancel.Click += btnCancel_Click;
		// 
		// btnOk
		// 
		btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		btnOk.Location = new Point(151, 289);
		btnOk.Margin = new Padding(3, 4, 3, 4);
		btnOk.Name = "btnOk";
		btnOk.Size = new Size(83, 28);
		btnOk.TabIndex = 28;
		btnOk.Text = "Ok";
		btnOk.UseVisualStyleBackColor = true;
		btnOk.Click += btnOk_Click;
		// 
		// txtConnStr
		// 
		txtConnStr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		txtConnStr.Location = new Point(98, 51);
		txtConnStr.Margin = new Padding(3, 4, 3, 4);
		txtConnStr.Multiline = true;
		txtConnStr.Name = "txtConnStr";
		txtConnStr.Size = new Size(282, 203);
		txtConnStr.TabIndex = 20;
		txtConnStr.TextChanged += txtConnStr_TextChanged;
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new Point(18, 54);
		label2.Name = "label2";
		label2.Size = new Size(73, 15);
		label2.TabIndex = 18;
		label2.Text = "Conn String:";
		// 
		// txtName
		// 
		txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		txtName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtName.Location = new Point(98, 22);
		txtName.Margin = new Padding(3, 4, 3, 4);
		txtName.Name = "txtName";
		txtName.Size = new Size(282, 20);
		txtName.TabIndex = 19;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label1.Location = new Point(53, 24);
		label1.Name = "label1";
		label1.Size = new Size(38, 13);
		label1.TabIndex = 15;
		label1.Text = "Name:";
		// 
		// errorProvider1
		// 
		errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
		errorProvider1.ContainerControl = this;
		// 
		// btnTest
		// 
		btnTest.Location = new Point(31, 292);
		btnTest.Name = "btnTest";
		btnTest.Size = new Size(75, 23);
		btnTest.TabIndex = 31;
		btnTest.Text = "Test";
		btnTest.UseVisualStyleBackColor = true;
		btnTest.Click += btnTest_Click;
		// 
		// picCopyConnStr
		// 
		picCopyConnStr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		picCopyConnStr.BackgroundImage = (Image)resources.GetObject("picCopyConnStr.BackgroundImage");
		picCopyConnStr.BackgroundImageLayout = ImageLayout.Center;
		picCopyConnStr.Cursor = Cursors.Hand;
		picCopyConnStr.Location = new Point(347, 253);
		picCopyConnStr.Name = "picCopyConnStr";
		picCopyConnStr.Size = new Size(33, 24);
		picCopyConnStr.TabIndex = 63;
		picCopyConnStr.TabStop = false;
		picCopyConnStr.Click += picCopyConnStr_Click;
		// 
		// DbConnForm
		// 
		AcceptButton = btnOk;
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = btnCancel;
		ClientSize = new Size(410, 335);
		Controls.Add(btnTest);
		Controls.Add(ckbIsDefault);
		Controls.Add(btnCancel);
		Controls.Add(btnOk);
		Controls.Add(txtConnStr);
		Controls.Add(label2);
		Controls.Add(txtName);
		Controls.Add(label1);
		Controls.Add(picCopyConnStr);
		Icon = (Icon)resources.GetObject("$this.Icon");
		Margin = new Padding(2);
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "DbConnForm";
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = "Connection Properties";
		Load += DatasourceForm_Load;
		Shown += DatasourceForm_Shown;
		((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
		((System.ComponentModel.ISupportInitialize)picCopyConnStr).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private CheckBox ckbIsDefault;
	private Button btnCancel;
	private Button btnOk;
	private TextBox txtConnStr;
	private Label label2;
	private TextBox txtName;
	private Label label1;
	private ErrorProvider errorProvider1;
	private Button btnTestConn;
	private Button button1;
	private Button btnTest;
	private PictureBox picCopyConnStr;
}