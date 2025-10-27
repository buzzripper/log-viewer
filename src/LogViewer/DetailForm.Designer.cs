using System.Drawing;
using System.Windows.Forms;

namespace LogViewer;

partial class DetailForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailForm));
        label7 = new Label();
        lblApplication = new Label();
        lblSource = new Label();
        lblException = new Label();
        picLogLevel = new PictureBox();
        button1 = new Button();
        btnUp = new Button();
        txtException = new TextBox();
        label10 = new Label();
        txtMessage = new TextBox();
        label5 = new Label();
        lblSeverity = new Label();
        label4 = new Label();
        lblTimestamp = new Label();
        label3 = new Label();
        lblRowId = new Label();
        label1 = new Label();
        picCopyMessage = new PictureBox();
        picCopyException = new PictureBox();
        splitContainer1 = new SplitContainer();
        btnClose = new Button();
        ((System.ComponentModel.ISupportInitialize)picLogLevel).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picCopyMessage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picCopyException).BeginInit();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        this.SuspendLayout();
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.ImageAlign = ContentAlignment.MiddleRight;
        label7.Location = new Point(284, 12);
        label7.Name = "label7";
        label7.Size = new Size(94, 18);
        label7.TabIndex = 61;
        label7.Text = "Application:";
        label7.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblApplication
        // 
        lblApplication.AutoSize = true;
        lblApplication.ImageAlign = ContentAlignment.BottomLeft;
        lblApplication.Location = new Point(384, 12);
        lblApplication.Name = "lblApplication";
        lblApplication.Size = new Size(102, 18);
        lblApplication.TabIndex = 60;
        lblApplication.Text = "lblApplication";
        lblApplication.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblSource
        // 
        lblSource.AutoSize = true;
        lblSource.ImageAlign = ContentAlignment.BottomLeft;
        lblSource.Location = new Point(384, 31);
        lblSource.Name = "lblSource";
        lblSource.Size = new Size(135, 18);
        lblSource.TabIndex = 59;
        lblSource.Text = "lblSourceContext";
        // 
        // lblException
        // 
        lblException.AutoSize = true;
        lblException.Location = new Point(13, 11);
        lblException.Name = "lblException";
        lblException.Size = new Size(80, 18);
        lblException.TabIndex = 57;
        lblException.Text = "Exception";
        lblException.TextAlign = ContentAlignment.MiddleRight;
        // 
        // picLogLevel
        // 
        picLogLevel.Location = new Point(5, 4);
        picLogLevel.Margin = new Padding(3, 2, 3, 2);
        picLogLevel.Name = "picLogLevel";
        picLogLevel.Size = new Size(14, 12);
        picLogLevel.TabIndex = 56;
        picLogLevel.TabStop = false;
        // 
        // button1
        // 
        button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        button1.BackColor = Color.Transparent;
        button1.FlatAppearance.BorderSize = 0;
        button1.Image = (Image)resources.GetObject("button1.Image");
        button1.Location = new Point(734, 37);
        button1.Margin = new Padding(3, 2, 3, 2);
        button1.Name = "button1";
        button1.Size = new Size(31, 29);
        button1.TabIndex = 48;
        button1.UseVisualStyleBackColor = false;
        button1.Click += this.btnDown_Click;
        // 
        // btnUp
        // 
        btnUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnUp.BackColor = Color.Transparent;
        btnUp.FlatAppearance.BorderSize = 0;
        btnUp.Image = (Image)resources.GetObject("btnUp.Image");
        btnUp.Location = new Point(734, 5);
        btnUp.Margin = new Padding(3, 2, 3, 2);
        btnUp.Name = "btnUp";
        btnUp.Size = new Size(31, 29);
        btnUp.TabIndex = 47;
        btnUp.UseVisualStyleBackColor = false;
        btnUp.Click += this.btnUp_Click;
        // 
        // txtException
        // 
        txtException.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtException.BackColor = SystemColors.Control;
        txtException.BorderStyle = BorderStyle.FixedSingle;
        txtException.Font = new Font("Verdana", 11F);
        txtException.Location = new Point(13, 35);
        txtException.Margin = new Padding(3, 2, 3, 2);
        txtException.Multiline = true;
        txtException.Name = "txtException";
        txtException.ScrollBars = ScrollBars.Vertical;
        txtException.Size = new Size(751, 199);
        txtException.TabIndex = 55;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.ImageAlign = ContentAlignment.MiddleRight;
        label10.Location = new Point(311, 31);
        label10.Name = "label10";
        label10.Size = new Size(67, 18);
        label10.TabIndex = 49;
        label10.Text = "Source:";
        label10.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtMessage
        // 
        txtMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtMessage.BackColor = SystemColors.Control;
        txtMessage.BorderStyle = BorderStyle.FixedSingle;
        txtMessage.Font = new Font("Verdana", 11F);
        txtMessage.Location = new Point(13, 33);
        txtMessage.Margin = new Padding(3, 2, 3, 2);
        txtMessage.Multiline = true;
        txtMessage.Name = "txtMessage";
        txtMessage.ReadOnly = true;
        txtMessage.ScrollBars = ScrollBars.Vertical;
        txtMessage.Size = new Size(751, 213);
        txtMessage.TabIndex = 46;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(13, 12);
        label5.Name = "label5";
        label5.Size = new Size(73, 18);
        label5.TabIndex = 45;
        label5.Text = "Message";
        label5.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblSeverity
        // 
        lblSeverity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblSeverity.AutoSize = true;
        lblSeverity.ImageAlign = ContentAlignment.BottomLeft;
        lblSeverity.Location = new Point(104, 50);
        lblSeverity.Name = "lblSeverity";
        lblSeverity.Size = new Size(84, 18);
        lblSeverity.TabIndex = 44;
        lblSeverity.Text = "lblSeverity";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.ImageAlign = ContentAlignment.MiddleRight;
        label4.Location = new Point(14, 50);
        label4.Name = "label4";
        label4.Size = new Size(85, 18);
        label4.TabIndex = 43;
        label4.Text = "Log Level:";
        label4.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblTimestamp
        // 
        lblTimestamp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblTimestamp.AutoSize = true;
        lblTimestamp.ImageAlign = ContentAlignment.BottomLeft;
        lblTimestamp.Location = new Point(104, 31);
        lblTimestamp.Name = "lblTimestamp";
        lblTimestamp.Size = new Size(106, 18);
        lblTimestamp.TabIndex = 42;
        lblTimestamp.Text = "lblTimestamp";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.ImageAlign = ContentAlignment.MiddleRight;
        label3.Location = new Point(1, 30);
        label3.Name = "label3";
        label3.Size = new Size(98, 18);
        label3.TabIndex = 41;
        label3.Text = "Timestamp:";
        label3.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblRowId
        // 
        lblRowId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblRowId.AutoSize = true;
        lblRowId.ImageAlign = ContentAlignment.BottomLeft;
        lblRowId.Location = new Point(104, 12);
        lblRowId.Name = "lblRowId";
        lblRowId.Size = new Size(70, 18);
        lblRowId.TabIndex = 40;
        lblRowId.Text = "lblRowId";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.ImageAlign = ContentAlignment.MiddleRight;
        label1.Location = new Point(70, 12);
        label1.Name = "label1";
        label1.Size = new Size(29, 18);
        label1.TabIndex = 39;
        label1.Text = "Id:";
        label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // picCopyMessage
        // 
        picCopyMessage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        picCopyMessage.BackgroundImage = (Image)resources.GetObject("picCopyMessage.BackgroundImage");
        picCopyMessage.BackgroundImageLayout = ImageLayout.Center;
        picCopyMessage.Cursor = Cursors.Hand;
        picCopyMessage.Location = new Point(735, 4);
        picCopyMessage.Margin = new Padding(4);
        picCopyMessage.Name = "picCopyMessage";
        picCopyMessage.Size = new Size(42, 29);
        picCopyMessage.TabIndex = 62;
        picCopyMessage.TabStop = false;
        picCopyMessage.Click += this.picCopyMessage_Click;
        // 
        // picCopyException
        // 
        picCopyException.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        picCopyException.BackgroundImage = (Image)resources.GetObject("picCopyException.BackgroundImage");
        picCopyException.BackgroundImageLayout = ImageLayout.Center;
        picCopyException.Cursor = Cursors.Hand;
        picCopyException.Location = new Point(735, 4);
        picCopyException.Margin = new Padding(4);
        picCopyException.Name = "picCopyException";
        picCopyException.Size = new Size(42, 29);
        picCopyException.TabIndex = 63;
        picCopyException.TabStop = false;
        picCopyException.Click += this.picCopyException_Click;
        // 
        // splitContainer1
        // 
        splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        splitContainer1.Location = new Point(1, 83);
        splitContainer1.Name = "splitContainer1";
        splitContainer1.Orientation = Orientation.Horizontal;
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.BackColor = SystemColors.Control;
        splitContainer1.Panel1.Controls.Add(label5);
        splitContainer1.Panel1.Controls.Add(picCopyMessage);
        splitContainer1.Panel1.Controls.Add(txtMessage);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.BackColor = SystemColors.Control;
        splitContainer1.Panel2.Controls.Add(txtException);
        splitContainer1.Panel2.Controls.Add(picCopyException);
        splitContainer1.Panel2.Controls.Add(lblException);
        splitContainer1.Size = new Size(777, 499);
        splitContainer1.SplitterDistance = 252;
        splitContainer1.TabIndex = 64;
        // 
        // btnClose
        // 
        btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnClose.Location = new Point(690, 590);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(75, 31);
        btnClose.TabIndex = 65;
        btnClose.Text = "Close";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Click += this.btnClose_Click;
        // 
        // DetailForm
        // 
        this.AutoScaleDimensions = new SizeF(9F, 18F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = SystemColors.Control;
        this.CancelButton = btnClose;
        this.ClientSize = new Size(779, 629);
        this.ControlBox = false;
        this.Controls.Add(btnClose);
        this.Controls.Add(splitContainer1);
        this.Controls.Add(label7);
        this.Controls.Add(lblApplication);
        this.Controls.Add(lblSource);
        this.Controls.Add(picLogLevel);
        this.Controls.Add(button1);
        this.Controls.Add(btnUp);
        this.Controls.Add(label10);
        this.Controls.Add(lblSeverity);
        this.Controls.Add(label4);
        this.Controls.Add(lblTimestamp);
        this.Controls.Add(label3);
        this.Controls.Add(lblRowId);
        this.Controls.Add(label1);
        this.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.Margin = new Padding(3, 2, 3, 2);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "DetailForm";
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Log Detail";
        this.Load += this.DetailForm_Load;
        this.Shown += this.DetailForm_Shown;
        ((System.ComponentModel.ISupportInitialize)picLogLevel).EndInit();
        ((System.ComponentModel.ISupportInitialize)picCopyMessage).EndInit();
        ((System.ComponentModel.ISupportInitialize)picCopyException).EndInit();
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel1.PerformLayout();
        splitContainer1.Panel2.ResumeLayout(false);
        splitContainer1.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label label7;
	private Label lblApplication;
	private Label lblSource;
	private Label lblException;
	private PictureBox picLogLevel;
	private Button button1;
	private Button btnUp;
	private TextBox txtException;
	private Label label10;
	private TextBox txtMessage;
	private Label label5;
	private Label lblSeverity;
	private Label label4;
	private Label lblTimestamp;
	private Label label3;
	private Label lblRowId;
	private Label label1;
	private PictureBox picCopyMessage;
	private PictureBox picCopyException;
    private SplitContainer splitContainer1;
    private Button btnClose;
}