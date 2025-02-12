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
		label7 = new Label();
		lblAppId = new Label();
		lblSourceContext = new Label();
		label2 = new Label();
		lblException = new Label();
		picLogLevel = new PictureBox();
		button1 = new Button();
		btnUp = new Button();
		txtException = new TextBox();
		panel1 = new Panel();
		statusStrip1 = new StatusStrip();
		lblUserName = new Label();
		label8 = new Label();
		lblMachineName = new Label();
		label10 = new Label();
		txtMessage = new TextBox();
		label5 = new Label();
		lblSeverity = new Label();
		label4 = new Label();
		lblTimestamp = new Label();
		label3 = new Label();
		lblRowId = new Label();
		label1 = new Label();
		((System.ComponentModel.ISupportInitialize)picLogLevel).BeginInit();
		SuspendLayout();
		// 
		// label7
		// 
		label7.ImageAlign = ContentAlignment.MiddleRight;
		label7.Location = new Point(354, 2);
		label7.Margin = new Padding(2, 0, 2, 0);
		label7.Name = "label7";
		label7.Size = new Size(57, 13);
		label7.TabIndex = 61;
		label7.Text = "App Id:";
		label7.TextAlign = ContentAlignment.MiddleRight;
		// 
		// lblAppId
		// 
		lblAppId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		lblAppId.AutoSize = true;
		lblAppId.ImageAlign = ContentAlignment.BottomLeft;
		lblAppId.Location = new Point(415, 4);
		lblAppId.Margin = new Padding(2, 0, 2, 0);
		lblAppId.Name = "lblAppId";
		lblAppId.Size = new Size(52, 15);
		lblAppId.TabIndex = 60;
		lblAppId.Text = "lblAppId";
		lblAppId.TextAlign = ContentAlignment.MiddleLeft;
		// 
		// lblSourceContext
		// 
		lblSourceContext.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		lblSourceContext.AutoSize = true;
		lblSourceContext.ImageAlign = ContentAlignment.BottomLeft;
		lblSourceContext.Location = new Point(81, 44);
		lblSourceContext.Margin = new Padding(2, 0, 2, 0);
		lblSourceContext.Name = "lblSourceContext";
		lblSourceContext.Size = new Size(98, 15);
		lblSourceContext.TabIndex = 59;
		lblSourceContext.Text = "lblSourceContext";
		// 
		// label2
		// 
		label2.ImageAlign = ContentAlignment.MiddleRight;
		label2.Location = new Point(354, 15);
		label2.Margin = new Padding(2, 0, 2, 0);
		label2.Name = "label2";
		label2.Size = new Size(57, 13);
		label2.TabIndex = 58;
		label2.Text = "Machine:";
		label2.TextAlign = ContentAlignment.MiddleRight;
		// 
		// lblException
		// 
		lblException.AutoSize = true;
		lblException.Location = new Point(15, 181);
		lblException.Margin = new Padding(2, 0, 2, 0);
		lblException.Name = "lblException";
		lblException.Size = new Size(62, 15);
		lblException.TabIndex = 57;
		lblException.Text = "Exception:";
		lblException.TextAlign = ContentAlignment.MiddleRight;
		// 
		// picLogLevel
		// 
		picLogLevel.Location = new Point(4, 3);
		picLogLevel.Margin = new Padding(2, 2, 2, 2);
		picLogLevel.Name = "picLogLevel";
		picLogLevel.Size = new Size(11, 10);
		picLogLevel.TabIndex = 56;
		picLogLevel.TabStop = false;
		// 
		// button1
		// 
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.BackColor = Color.Transparent;
		button1.FlatAppearance.BorderSize = 0;
		button1.Location = new Point(610, 20);
		button1.Margin = new Padding(2, 2, 2, 2);
		button1.Name = "button1";
		button1.Size = new Size(20, 17);
		button1.TabIndex = 48;
		button1.UseVisualStyleBackColor = false;
		button1.Click += btnDown_Click;
		// 
		// btnUp
		// 
		btnUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		btnUp.BackColor = Color.Transparent;
		btnUp.FlatAppearance.BorderSize = 0;
		btnUp.Location = new Point(610, 1);
		btnUp.Margin = new Padding(2, 2, 2, 2);
		btnUp.Name = "btnUp";
		btnUp.Size = new Size(20, 17);
		btnUp.TabIndex = 47;
		btnUp.UseVisualStyleBackColor = false;
		btnUp.Click += btnUp_Click;
		// 
		// txtException
		// 
		txtException.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		txtException.BackColor = SystemColors.Control;
		txtException.BorderStyle = BorderStyle.FixedSingle;
		txtException.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtException.Location = new Point(15, 196);
		txtException.Margin = new Padding(2, 2, 2, 2);
		txtException.Multiline = true;
		txtException.Name = "txtException";
		txtException.ScrollBars = ScrollBars.Vertical;
		txtException.Size = new Size(606, 91);
		txtException.TabIndex = 55;
		txtException.Visible = false;
		// 
		// panel1
		// 
		panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		panel1.BorderStyle = BorderStyle.Fixed3D;
		panel1.Location = new Point(6, 68);
		panel1.Margin = new Padding(2, 2, 2, 2);
		panel1.Name = "panel1";
		panel1.Size = new Size(626, 4);
		panel1.TabIndex = 54;
		// 
		// statusStrip1
		// 
		statusStrip1.ImageScalingSize = new Size(24, 24);
		statusStrip1.Location = new Point(0, 284);
		statusStrip1.Name = "statusStrip1";
		statusStrip1.Padding = new Padding(1, 0, 10, 0);
		statusStrip1.Size = new Size(636, 22);
		statusStrip1.TabIndex = 53;
		statusStrip1.Text = "statusStrip1";
		// 
		// lblUserName
		// 
		lblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		lblUserName.AutoSize = true;
		lblUserName.ImageAlign = ContentAlignment.BottomLeft;
		lblUserName.Location = new Point(415, 30);
		lblUserName.Margin = new Padding(2, 0, 2, 0);
		lblUserName.Name = "lblUserName";
		lblUserName.Size = new Size(75, 15);
		lblUserName.TabIndex = 52;
		lblUserName.Text = "lblUserName";
		lblUserName.TextAlign = ContentAlignment.MiddleLeft;
		// 
		// label8
		// 
		label8.ImageAlign = ContentAlignment.MiddleRight;
		label8.Location = new Point(374, 28);
		label8.Margin = new Padding(2, 0, 2, 0);
		label8.Name = "label8";
		label8.Size = new Size(37, 13);
		label8.TabIndex = 51;
		label8.Text = "User:";
		label8.TextAlign = ContentAlignment.MiddleRight;
		// 
		// lblMachineName
		// 
		lblMachineName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		lblMachineName.AutoSize = true;
		lblMachineName.ImageAlign = ContentAlignment.BottomLeft;
		lblMachineName.Location = new Point(415, 17);
		lblMachineName.Margin = new Padding(2, 0, 2, 0);
		lblMachineName.Name = "lblMachineName";
		lblMachineName.Size = new Size(98, 15);
		lblMachineName.TabIndex = 50;
		lblMachineName.Text = "lblMachineName";
		lblMachineName.TextAlign = ContentAlignment.MiddleLeft;
		// 
		// label10
		// 
		label10.ImageAlign = ContentAlignment.MiddleRight;
		label10.Location = new Point(20, 41);
		label10.Margin = new Padding(2, 0, 2, 0);
		label10.Name = "label10";
		label10.Size = new Size(57, 13);
		label10.TabIndex = 49;
		label10.Text = "Source:";
		label10.TextAlign = ContentAlignment.MiddleRight;
		// 
		// txtMessage
		// 
		txtMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		txtMessage.BackColor = SystemColors.Control;
		txtMessage.BorderStyle = BorderStyle.FixedSingle;
		txtMessage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtMessage.Location = new Point(15, 88);
		txtMessage.Margin = new Padding(2, 2, 2, 2);
		txtMessage.Multiline = true;
		txtMessage.Name = "txtMessage";
		txtMessage.ReadOnly = true;
		txtMessage.ScrollBars = ScrollBars.Vertical;
		txtMessage.Size = new Size(606, 85);
		txtMessage.TabIndex = 46;
		// 
		// label5
		// 
		label5.AutoSize = true;
		label5.Location = new Point(15, 73);
		label5.Margin = new Padding(2, 0, 2, 0);
		label5.Name = "label5";
		label5.Size = new Size(56, 15);
		label5.TabIndex = 45;
		label5.Text = "Message:";
		label5.TextAlign = ContentAlignment.MiddleRight;
		// 
		// lblSeverity
		// 
		lblSeverity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		lblSeverity.AutoSize = true;
		lblSeverity.ImageAlign = ContentAlignment.BottomLeft;
		lblSeverity.Location = new Point(81, 31);
		lblSeverity.Margin = new Padding(2, 0, 2, 0);
		lblSeverity.Name = "lblSeverity";
		lblSeverity.Size = new Size(61, 15);
		lblSeverity.TabIndex = 44;
		lblSeverity.Text = "lblSeverity";
		// 
		// label4
		// 
		label4.ImageAlign = ContentAlignment.MiddleRight;
		label4.Location = new Point(21, 28);
		label4.Margin = new Padding(2, 0, 2, 0);
		label4.Name = "label4";
		label4.Size = new Size(56, 13);
		label4.TabIndex = 43;
		label4.Text = "Severity:";
		label4.TextAlign = ContentAlignment.MiddleRight;
		// 
		// lblTimestamp
		// 
		lblTimestamp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		lblTimestamp.AutoSize = true;
		lblTimestamp.ImageAlign = ContentAlignment.BottomLeft;
		lblTimestamp.Location = new Point(81, 17);
		lblTimestamp.Margin = new Padding(2, 0, 2, 0);
		lblTimestamp.Name = "lblTimestamp";
		lblTimestamp.Size = new Size(79, 15);
		lblTimestamp.TabIndex = 42;
		lblTimestamp.Text = "lblTimestamp";
		// 
		// label3
		// 
		label3.ImageAlign = ContentAlignment.MiddleRight;
		label3.Location = new Point(5, 15);
		label3.Margin = new Padding(2, 0, 2, 0);
		label3.Name = "label3";
		label3.Size = new Size(72, 13);
		label3.TabIndex = 41;
		label3.Text = "Timestamp:";
		label3.TextAlign = ContentAlignment.MiddleRight;
		// 
		// lblRowId
		// 
		lblRowId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		lblRowId.AutoSize = true;
		lblRowId.ImageAlign = ContentAlignment.BottomLeft;
		lblRowId.Location = new Point(81, 4);
		lblRowId.Margin = new Padding(2, 0, 2, 0);
		lblRowId.Name = "lblRowId";
		lblRowId.Size = new Size(53, 15);
		lblRowId.TabIndex = 40;
		lblRowId.Text = "lblRowId";
		// 
		// label1
		// 
		label1.ImageAlign = ContentAlignment.MiddleRight;
		label1.Location = new Point(26, 2);
		label1.Margin = new Padding(2, 0, 2, 0);
		label1.Name = "label1";
		label1.Size = new Size(51, 13);
		label1.TabIndex = 39;
		label1.Text = "Row ID:";
		label1.TextAlign = ContentAlignment.MiddleRight;
		// 
		// DetailForm
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(636, 306);
		Controls.Add(label7);
		Controls.Add(lblAppId);
		Controls.Add(lblSourceContext);
		Controls.Add(label2);
		Controls.Add(lblException);
		Controls.Add(picLogLevel);
		Controls.Add(button1);
		Controls.Add(btnUp);
		Controls.Add(txtException);
		Controls.Add(panel1);
		Controls.Add(statusStrip1);
		Controls.Add(lblUserName);
		Controls.Add(label8);
		Controls.Add(lblMachineName);
		Controls.Add(label10);
		Controls.Add(txtMessage);
		Controls.Add(label5);
		Controls.Add(lblSeverity);
		Controls.Add(label4);
		Controls.Add(lblTimestamp);
		Controls.Add(label3);
		Controls.Add(lblRowId);
		Controls.Add(label1);
		Margin = new Padding(2, 2, 2, 2);
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "DetailForm";
		StartPosition = FormStartPosition.CenterParent;
		Text = "DetailForm";
		Load += DetailForm_Load;
		Shown += DetailForm_Shown;
		((System.ComponentModel.ISupportInitialize)picLogLevel).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Label label7;
	private Label lblAppId;
	private Label lblSourceContext;
	private Label label2;
	private Label lblException;
	private PictureBox picLogLevel;
	private Button button1;
	private Button btnUp;
	private TextBox txtException;
	private Panel panel1;
	private StatusStrip statusStrip1;
	private Label lblUserName;
	private Label label8;
	private Label lblMachineName;
	private Label label10;
	private TextBox txtMessage;
	private Label label5;
	private Label lblSeverity;
	private Label label4;
	private Label lblTimestamp;
	private Label label3;
	private Label lblRowId;
	private Label label1;
}