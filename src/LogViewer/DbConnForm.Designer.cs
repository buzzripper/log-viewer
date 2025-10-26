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
        label2 = new Label();
        txtName = new TextBox();
        label1 = new Label();
        errorProvider1 = new ErrorProvider(components);
        btnTest = new Button();
        picCopyConnStr = new PictureBox();
        statusStrip1 = new StatusStrip();
        txtConnStr = new TextBox();
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picCopyConnStr).BeginInit();
        this.SuspendLayout();
        // 
        // ckbIsDefault
        // 
        ckbIsDefault.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        ckbIsDefault.AutoSize = true;
        ckbIsDefault.CheckAlign = ContentAlignment.MiddleRight;
        ckbIsDefault.Location = new Point(108, 260);
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
        btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.Font = new Font("Segoe UI", 10F);
        btnCancel.Location = new Point(432, 300);
        btnCancel.Margin = new Padding(3, 4, 3, 4);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(86, 28);
        btnCancel.TabIndex = 29;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += this.btnCancel_Click;
        // 
        // btnOk
        // 
        btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnOk.Font = new Font("Segoe UI", 10F);
        btnOk.Location = new Point(343, 300);
        btnOk.Margin = new Padding(3, 4, 3, 4);
        btnOk.Name = "btnOk";
        btnOk.Size = new Size(83, 28);
        btnOk.TabIndex = 28;
        btnOk.Text = "Ok";
        btnOk.UseVisualStyleBackColor = true;
        btnOk.Click += this.btnOk_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(7, 52);
        label2.Name = "label2";
        label2.Size = new Size(85, 19);
        label2.TabIndex = 18;
        label2.Text = "Conn String:";
        // 
        // txtName
        // 
        txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtName.Location = new Point(98, 22);
        txtName.Margin = new Padding(3, 4, 3, 4);
        txtName.Name = "txtName";
        txtName.Size = new Size(420, 23);
        txtName.TabIndex = 19;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(43, 22);
        label1.Name = "label1";
        label1.Size = new Size(49, 17);
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
        btnTest.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnTest.Font = new Font("Segoe UI", 10F);
        btnTest.Location = new Point(17, 300);
        btnTest.Name = "btnTest";
        btnTest.Size = new Size(75, 30);
        btnTest.TabIndex = 31;
        btnTest.Text = "Test";
        btnTest.UseVisualStyleBackColor = true;
        btnTest.Click += this.btnTest_Click;
        // 
        // picCopyConnStr
        // 
        picCopyConnStr.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        picCopyConnStr.BackgroundImage = (Image)resources.GetObject("picCopyConnStr.BackgroundImage");
        picCopyConnStr.BackgroundImageLayout = ImageLayout.Center;
        picCopyConnStr.Cursor = Cursors.Hand;
        picCopyConnStr.Location = new Point(485, 260);
        picCopyConnStr.Name = "picCopyConnStr";
        picCopyConnStr.Size = new Size(33, 24);
        picCopyConnStr.TabIndex = 63;
        picCopyConnStr.TabStop = false;
        picCopyConnStr.Click += this.picCopyConnStr_Click;
        // 
        // statusStrip1
        // 
        statusStrip1.Location = new Point(0, 334);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(548, 22);
        statusStrip1.TabIndex = 64;
        statusStrip1.Text = "statusStrip1";
        // 
        // txtConnStr
        // 
        txtConnStr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtConnStr.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtConnStr.Location = new Point(98, 52);
        txtConnStr.Multiline = true;
        txtConnStr.Name = "txtConnStr";
        txtConnStr.Size = new Size(420, 202);
        txtConnStr.TabIndex = 65;
        txtConnStr.TextChanged += this.txtConnStr_TextChanged;
        // 
        // DbConnForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.CancelButton = btnCancel;
        this.ClientSize = new Size(548, 356);
        this.Controls.Add(txtConnStr);
        this.Controls.Add(statusStrip1);
        this.Controls.Add(btnTest);
        this.Controls.Add(ckbIsDefault);
        this.Controls.Add(btnCancel);
        this.Controls.Add(btnOk);
        this.Controls.Add(label2);
        this.Controls.Add(txtName);
        this.Controls.Add(label1);
        this.Controls.Add(picCopyConnStr);
        this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.Icon = (Icon)resources.GetObject("$this.Icon");
        this.Margin = new Padding(2);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "DbConnForm";
        this.ShowInTaskbar = false;
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Connection Properties";
        this.Load += this.DatasourceForm_Load;
        this.Shown += this.DatasourceForm_Shown;
        ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        ((System.ComponentModel.ISupportInitialize)picCopyConnStr).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private CheckBox ckbIsDefault;
	private Button btnCancel;
	private Button btnOk;
	private Label label2;
	private TextBox txtName;
	private Label label1;
	private ErrorProvider errorProvider1;
	private Button btnTest;
	private PictureBox picCopyConnStr;
	private StatusStrip statusStrip1;
    private TextBox txtConnStr;
}