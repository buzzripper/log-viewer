namespace LogViewer;

partial class Form1
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
		numPageNumber = new System.Windows.Forms.NumericUpDown();
		btnRefreshFilterLists = new System.Windows.Forms.Button();
		imageList1 = new System.Windows.Forms.ImageList(components);
		btnClearFilters = new System.Windows.Forms.Button();
		cmbApplicationNames = new System.Windows.Forms.ComboBox();
		btnDelDatasource = new System.Windows.Forms.Button();
		btnAddDatasource = new System.Windows.Forms.Button();
		label8 = new System.Windows.Forms.Label();
		btnEditDatasource = new System.Windows.Forms.Button();
		txtMessage = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		txtSource = new System.Windows.Forms.TextBox();
		btnPageUp = new System.Windows.Forms.Button();
		label6 = new System.Windows.Forms.Label();
		btnPageDown = new System.Windows.Forms.Button();
		btnPurgeLogs = new System.Windows.Forms.Button();
		cmbSeverity = new System.Windows.Forms.ComboBox();
		label2 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		numPageLength = new System.Windows.Forms.NumericUpDown();
		label3 = new System.Windows.Forms.Label();
		statusStrip1 = new System.Windows.Forms.StatusStrip();
		statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
		toolLblVersion = new System.Windows.Forms.ToolStripStatusLabel();
		toolLblMessage = new System.Windows.Forms.ToolStripStatusLabel();
		lvLogs = new System.Windows.Forms.ListView();
		colTimestamp = new System.Windows.Forms.ColumnHeader();
		colLevel = new System.Windows.Forms.ColumnHeader();
		colApp = new System.Windows.Forms.ColumnHeader();
		colSource = new System.Windows.Forms.ColumnHeader();
		colMessage = new System.Windows.Forms.ColumnHeader();
		logEventImgList = new System.Windows.Forms.ImageList(components);
		cmbDbConns = new System.Windows.Forms.ComboBox();
		label1 = new System.Windows.Forms.Label();
		timer1 = new System.Windows.Forms.Timer(components);
		toolTip1 = new System.Windows.Forms.ToolTip(components);
		picSpinner = new System.Windows.Forms.PictureBox();
		picRefresh = new System.Windows.Forms.PictureBox();
		picAutoRefresh = new System.Windows.Forms.PictureBox();
		picSortOrder = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)numPageNumber).BeginInit();
		((System.ComponentModel.ISupportInitialize)numPageLength).BeginInit();
		statusStrip1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)picSpinner).BeginInit();
		((System.ComponentModel.ISupportInitialize)picRefresh).BeginInit();
		((System.ComponentModel.ISupportInitialize)picAutoRefresh).BeginInit();
		((System.ComponentModel.ISupportInitialize)picSortOrder).BeginInit();
		SuspendLayout();
		// 
		// numPageNumber
		// 
		numPageNumber.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		numPageNumber.BackColor = System.Drawing.SystemColors.Window;
		numPageNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
		numPageNumber.Location = new System.Drawing.Point(679, 544);
		numPageNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		numPageNumber.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
		numPageNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
		numPageNumber.Name = "numPageNumber";
		numPageNumber.Size = new System.Drawing.Size(62, 23);
		numPageNumber.TabIndex = 56;
		numPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		numPageNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
		numPageNumber.ValueChanged += numPageNumber_ValueChanged;
		// 
		// btnRefreshFilterLists
		// 
		btnRefreshFilterLists.ImageKey = "refresh_32.png";
		btnRefreshFilterLists.ImageList = imageList1;
		btnRefreshFilterLists.Location = new System.Drawing.Point(549, 6);
		btnRefreshFilterLists.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		btnRefreshFilterLists.Name = "btnRefreshFilterLists";
		btnRefreshFilterLists.Size = new System.Drawing.Size(30, 27);
		btnRefreshFilterLists.TabIndex = 53;
		btnRefreshFilterLists.UseVisualStyleBackColor = true;
		btnRefreshFilterLists.Click += btnRefreshFilterLists_Click;
		// 
		// imageList1
		// 
		imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
		imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
		imageList1.TransparentColor = System.Drawing.Color.Transparent;
		imageList1.Images.SetKeyName(0, "timer_off_32.png");
		imageList1.Images.SetKeyName(1, "timer_32.png");
		imageList1.Images.SetKeyName(2, "refresh_32.png");
		imageList1.Images.SetKeyName(3, "auto_refresh_32.png");
		imageList1.Images.SetKeyName(4, "sort_32.png");
		imageList1.Images.SetKeyName(5, "clear_filters_32.png");
		imageList1.Images.SetKeyName(6, "add_datasource.png");
		imageList1.Images.SetKeyName(7, "del_datasource_32.png");
		imageList1.Images.SetKeyName(8, "edit_datasource_32.png");
		imageList1.Images.SetKeyName(9, "left_arrow_32.png");
		imageList1.Images.SetKeyName(10, "right_arrow_32.png");
		imageList1.Images.SetKeyName(11, "Spinner.gif");
		// 
		// btnClearFilters
		// 
		btnClearFilters.ImageKey = "clear_filters_32.png";
		btnClearFilters.ImageList = imageList1;
		btnClearFilters.Location = new System.Drawing.Point(585, 6);
		btnClearFilters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		btnClearFilters.Name = "btnClearFilters";
		btnClearFilters.Size = new System.Drawing.Size(33, 27);
		btnClearFilters.TabIndex = 41;
		btnClearFilters.UseVisualStyleBackColor = true;
		btnClearFilters.Click += btnClearFilters_Click;
		// 
		// cmbApplicationNames
		// 
		cmbApplicationNames.BackColor = System.Drawing.SystemColors.Window;
		cmbApplicationNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cmbApplicationNames.FormattingEnabled = true;
		cmbApplicationNames.Location = new System.Drawing.Point(91, 80);
		cmbApplicationNames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		cmbApplicationNames.Name = "cmbApplicationNames";
		cmbApplicationNames.Size = new System.Drawing.Size(276, 23);
		cmbApplicationNames.TabIndex = 52;
		cmbApplicationNames.SelectedIndexChanged += cmbApplicationNames_SelectedIndexChanged;
		// 
		// btnDelDatasource
		// 
		btnDelDatasource.BackColor = System.Drawing.SystemColors.Control;
		btnDelDatasource.Enabled = false;
		btnDelDatasource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		btnDelDatasource.ImageKey = "del_datasource_32.png";
		btnDelDatasource.ImageList = imageList1;
		btnDelDatasource.Location = new System.Drawing.Point(445, 7);
		btnDelDatasource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		btnDelDatasource.Name = "btnDelDatasource";
		btnDelDatasource.Size = new System.Drawing.Size(30, 26);
		btnDelDatasource.TabIndex = 51;
		btnDelDatasource.UseVisualStyleBackColor = false;
		btnDelDatasource.Click += btnDelDatasource_Click;
		// 
		// btnAddDatasource
		// 
		btnAddDatasource.BackColor = System.Drawing.SystemColors.Control;
		btnAddDatasource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		btnAddDatasource.ImageKey = "add_datasource.png";
		btnAddDatasource.ImageList = imageList1;
		btnAddDatasource.Location = new System.Drawing.Point(481, 7);
		btnAddDatasource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		btnAddDatasource.Name = "btnAddDatasource";
		btnAddDatasource.Size = new System.Drawing.Size(30, 26);
		btnAddDatasource.TabIndex = 50;
		btnAddDatasource.UseVisualStyleBackColor = false;
		btnAddDatasource.Click += btnAddDatasource_Click;
		// 
		// label8
		// 
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(17, 82);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(71, 15);
		label8.TabIndex = 49;
		label8.Text = "Application:";
		// 
		// btnEditDatasource
		// 
		btnEditDatasource.BackColor = System.Drawing.SystemColors.Control;
		btnEditDatasource.Enabled = false;
		btnEditDatasource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		btnEditDatasource.ImageKey = "edit_datasource_32.png";
		btnEditDatasource.ImageList = imageList1;
		btnEditDatasource.Location = new System.Drawing.Point(408, 7);
		btnEditDatasource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		btnEditDatasource.Name = "btnEditDatasource";
		btnEditDatasource.Size = new System.Drawing.Size(30, 26);
		btnEditDatasource.TabIndex = 48;
		btnEditDatasource.UseVisualStyleBackColor = false;
		btnEditDatasource.Click += btnEditDatasource_Click;
		// 
		// txtMessage
		// 
		txtMessage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtMessage.BackColor = System.Drawing.SystemColors.Window;
		txtMessage.Location = new System.Drawing.Point(463, 80);
		txtMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		txtMessage.Name = "txtMessage";
		txtMessage.Size = new System.Drawing.Size(467, 23);
		txtMessage.TabIndex = 47;
		// 
		// label7
		// 
		label7.AutoSize = true;
		label7.Location = new System.Drawing.Point(389, 82);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(56, 15);
		label7.TabIndex = 46;
		label7.Text = "Message:";
		// 
		// txtSource
		// 
		txtSource.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtSource.BackColor = System.Drawing.SystemColors.Window;
		txtSource.Location = new System.Drawing.Point(463, 51);
		txtSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		txtSource.Name = "txtSource";
		txtSource.Size = new System.Drawing.Size(467, 23);
		txtSource.TabIndex = 45;
		// 
		// btnPageUp
		// 
		btnPageUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnPageUp.BackColor = System.Drawing.SystemColors.Control;
		btnPageUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		btnPageUp.ImageKey = "right_arrow_32.png";
		btnPageUp.ImageList = imageList1;
		btnPageUp.Location = new System.Drawing.Point(759, 540);
		btnPageUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		btnPageUp.Name = "btnPageUp";
		btnPageUp.Size = new System.Drawing.Size(39, 30);
		btnPageUp.TabIndex = 44;
		btnPageUp.UseVisualStyleBackColor = false;
		btnPageUp.Click += btnPageUp_Click;
		// 
		// label6
		// 
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(400, 54);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(46, 15);
		label6.TabIndex = 43;
		label6.Text = "Source:";
		// 
		// btnPageDown
		// 
		btnPageDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnPageDown.BackColor = System.Drawing.SystemColors.Control;
		btnPageDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		btnPageDown.ImageKey = "left_arrow_32.png";
		btnPageDown.ImageList = imageList1;
		btnPageDown.Location = new System.Drawing.Point(540, 540);
		btnPageDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		btnPageDown.Name = "btnPageDown";
		btnPageDown.Size = new System.Drawing.Size(39, 30);
		btnPageDown.TabIndex = 42;
		btnPageDown.UseVisualStyleBackColor = false;
		btnPageDown.Click += btnPageDown_Click;
		// 
		// btnPurgeLogs
		// 
		btnPurgeLogs.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnPurgeLogs.BackColor = System.Drawing.SystemColors.Control;
		btnPurgeLogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		btnPurgeLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnPurgeLogs.Location = new System.Drawing.Point(15, 539);
		btnPurgeLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		btnPurgeLogs.Name = "btnPurgeLogs";
		btnPurgeLogs.Size = new System.Drawing.Size(118, 28);
		btnPurgeLogs.TabIndex = 40;
		btnPurgeLogs.Text = "Purge Logs";
		btnPurgeLogs.UseVisualStyleBackColor = false;
		btnPurgeLogs.Click += btnPurgeLogs_Click;
		// 
		// cmbSeverity
		// 
		cmbSeverity.BackColor = System.Drawing.SystemColors.Window;
		cmbSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cmbSeverity.FormattingEnabled = true;
		cmbSeverity.Location = new System.Drawing.Point(91, 51);
		cmbSeverity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		cmbSeverity.Name = "cmbSeverity";
		cmbSeverity.Size = new System.Drawing.Size(276, 23);
		cmbSeverity.TabIndex = 33;
		cmbSeverity.SelectedIndexChanged += cmbSeverity_SelectedIndexChanged;
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 54);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(61, 15);
		label2.TabIndex = 32;
		label2.Text = "Min Level:";
		// 
		// label4
		// 
		label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(590, 547);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(83, 15);
		label4.TabIndex = 38;
		label4.Text = "Page Number:";
		// 
		// numPageLength
		// 
		numPageLength.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		numPageLength.BackColor = System.Drawing.SystemColors.Window;
		numPageLength.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
		numPageLength.Location = new System.Drawing.Point(421, 544);
		numPageLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		numPageLength.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
		numPageLength.Name = "numPageLength";
		numPageLength.Size = new System.Drawing.Size(81, 23);
		numPageLength.TabIndex = 37;
		numPageLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		numPageLength.Value = new decimal(new int[] { 100, 0, 0, 0 });
		// 
		// label3
		// 
		label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		label3.AutoSize = true;
		label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
		label3.Location = new System.Drawing.Point(339, 547);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(76, 15);
		label3.TabIndex = 36;
		label3.Text = "Page Length:";
		// 
		// statusStrip1
		// 
		statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
		statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusLabel, toolLblVersion, toolLblMessage });
		statusStrip1.Location = new System.Drawing.Point(0, 575);
		statusStrip1.Name = "statusStrip1";
		statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
		statusStrip1.Size = new System.Drawing.Size(941, 22);
		statusStrip1.TabIndex = 35;
		// 
		// statusLabel
		// 
		statusLabel.Name = "statusLabel";
		statusLabel.Size = new System.Drawing.Size(0, 17);
		// 
		// toolLblVersion
		// 
		toolLblVersion.Name = "toolLblVersion";
		toolLblVersion.Size = new System.Drawing.Size(52, 17);
		toolLblVersion.Text = "v. 1.0.0.0";
		// 
		// toolLblMessage
		// 
		toolLblMessage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
		toolLblMessage.Name = "toolLblMessage";
		toolLblMessage.Size = new System.Drawing.Size(95, 17);
		toolLblMessage.Text = "Auto refresh: Off";
		// 
		// lvLogs
		// 
		lvLogs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		lvLogs.BackColor = System.Drawing.Color.LightGray;
		lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { colTimestamp, colLevel, colApp, colSource, colMessage });
		lvLogs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lvLogs.ForeColor = System.Drawing.Color.White;
		lvLogs.FullRowSelect = true;
		lvLogs.Location = new System.Drawing.Point(20, 132);
		lvLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		lvLogs.MultiSelect = false;
		lvLogs.Name = "lvLogs";
		lvLogs.ShowItemToolTips = true;
		lvLogs.Size = new System.Drawing.Size(910, 393);
		lvLogs.SmallImageList = logEventImgList;
		lvLogs.TabIndex = 34;
		lvLogs.UseCompatibleStateImageBehavior = false;
		lvLogs.View = System.Windows.Forms.View.Details;
		lvLogs.DoubleClick += lvLogs_DoubleClick;
		// 
		// colTimestamp
		// 
		colTimestamp.Text = "Timestamp";
		colTimestamp.Width = 200;
		// 
		// colLevel
		// 
		colLevel.Text = "Level";
		colLevel.Width = 110;
		// 
		// colApp
		// 
		colApp.Text = "App";
		colApp.Width = 100;
		// 
		// colSource
		// 
		colSource.Text = "Source";
		colSource.Width = 200;
		// 
		// colMessage
		// 
		colMessage.Text = "Message";
		colMessage.Width = 355;
		// 
		// logEventImgList
		// 
		logEventImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
		logEventImgList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("logEventImgList.ImageStream");
		logEventImgList.TransparentColor = System.Drawing.Color.Transparent;
		logEventImgList.Images.SetKeyName(0, "Verbose.png");
		logEventImgList.Images.SetKeyName(1, "Debug.png");
		logEventImgList.Images.SetKeyName(2, "Information.png");
		logEventImgList.Images.SetKeyName(3, "Warning.png");
		logEventImgList.Images.SetKeyName(4, "Error.png");
		logEventImgList.Images.SetKeyName(5, "Critical.png");
		// 
		// cmbDbConns
		// 
		cmbDbConns.BackColor = System.Drawing.SystemColors.Window;
		cmbDbConns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cmbDbConns.FormattingEnabled = true;
		cmbDbConns.Location = new System.Drawing.Point(92, 7);
		cmbDbConns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		cmbDbConns.Name = "cmbDbConns";
		cmbDbConns.Size = new System.Drawing.Size(275, 23);
		cmbDbConns.Sorted = true;
		cmbDbConns.TabIndex = 31;
		cmbDbConns.SelectedIndexChanged += cmbDbConns_SelectedIndexChanged;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(30, 11);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(58, 15);
		label1.TabIndex = 30;
		label1.Text = "Database:";
		// 
		// timer1
		// 
		timer1.Tick += timer1_Tick;
		// 
		// picSpinner
		// 
		picSpinner.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		picSpinner.Image = (System.Drawing.Image)resources.GetObject("picSpinner.Image");
		picSpinner.Location = new System.Drawing.Point(905, 113);
		picSpinner.Name = "picSpinner";
		picSpinner.Size = new System.Drawing.Size(24, 24);
		picSpinner.TabIndex = 57;
		picSpinner.TabStop = false;
		picSpinner.Visible = false;
		picSpinner.Click += picAutoRefresh_Click;
		// 
		// picRefresh
		// 
		picRefresh.BackgroundImage = (System.Drawing.Image)resources.GetObject("picRefresh.BackgroundImage");
		picRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
		picRefresh.Enabled = false;
		picRefresh.Location = new System.Drawing.Point(19, 103);
		picRefresh.Name = "picRefresh";
		picRefresh.Size = new System.Drawing.Size(37, 31);
		picRefresh.TabIndex = 58;
		picRefresh.TabStop = false;
		picRefresh.Click += picRefresh_Click;
		// 
		// picAutoRefresh
		// 
		picAutoRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		picAutoRefresh.BackgroundImage = (System.Drawing.Image)resources.GetObject("picAutoRefresh.BackgroundImage");
		picAutoRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		picAutoRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
		picAutoRefresh.Enabled = false;
		picAutoRefresh.ErrorImage = (System.Drawing.Image)resources.GetObject("picAutoRefresh.ErrorImage");
		picAutoRefresh.Location = new System.Drawing.Point(875, 108);
		picAutoRefresh.Name = "picAutoRefresh";
		picAutoRefresh.Size = new System.Drawing.Size(24, 24);
		picAutoRefresh.TabIndex = 60;
		picAutoRefresh.TabStop = false;
		picAutoRefresh.Click += picAutoRefresh_Click;
		// 
		// picSortOrder
		// 
		picSortOrder.BackgroundImage = (System.Drawing.Image)resources.GetObject("picSortOrder.BackgroundImage");
		picSortOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		picSortOrder.Cursor = System.Windows.Forms.Cursors.Hand;
		picSortOrder.Location = new System.Drawing.Point(62, 108);
		picSortOrder.Name = "picSortOrder";
		picSortOrder.Size = new System.Drawing.Size(26, 26);
		picSortOrder.TabIndex = 61;
		picSortOrder.TabStop = false;
		// 
		// Form1
		// 
		AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.SystemColors.ControlLight;
		ClientSize = new System.Drawing.Size(941, 597);
		Controls.Add(numPageNumber);
		Controls.Add(btnRefreshFilterLists);
		Controls.Add(btnClearFilters);
		Controls.Add(cmbApplicationNames);
		Controls.Add(btnDelDatasource);
		Controls.Add(btnAddDatasource);
		Controls.Add(label8);
		Controls.Add(btnEditDatasource);
		Controls.Add(txtMessage);
		Controls.Add(label7);
		Controls.Add(txtSource);
		Controls.Add(btnPageUp);
		Controls.Add(label6);
		Controls.Add(btnPageDown);
		Controls.Add(btnPurgeLogs);
		Controls.Add(cmbSeverity);
		Controls.Add(label2);
		Controls.Add(label4);
		Controls.Add(numPageLength);
		Controls.Add(label3);
		Controls.Add(statusStrip1);
		Controls.Add(lvLogs);
		Controls.Add(cmbDbConns);
		Controls.Add(label1);
		Controls.Add(picSpinner);
		Controls.Add(picAutoRefresh);
		Controls.Add(picRefresh);
		Controls.Add(picSortOrder);
		Margin = new System.Windows.Forms.Padding(2);
		Name = "Form1";
		Text = "Form1";
		Activated += Form1_Activated;
		FormClosing += Form1_FormClosing;
		Load += Form1_Load;
		Shown += Form1_Shown;
		Click += picRefresh_Click;
		KeyDown += Form1_KeyDown;
		Resize += Form1_Resize;
		((System.ComponentModel.ISupportInitialize)numPageNumber).EndInit();
		((System.ComponentModel.ISupportInitialize)numPageLength).EndInit();
		statusStrip1.ResumeLayout(false);
		statusStrip1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)picSpinner).EndInit();
		((System.ComponentModel.ISupportInitialize)picRefresh).EndInit();
		((System.ComponentModel.ISupportInitialize)picAutoRefresh).EndInit();
		((System.ComponentModel.ISupportInitialize)picSortOrder).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private System.Windows.Forms.NumericUpDown numPageNumber;
	private System.Windows.Forms.Button btnRefreshFilterLists;
	private System.Windows.Forms.Button btnClearFilters;
	private System.Windows.Forms.ComboBox cmbApplicationNames;
	private System.Windows.Forms.Button btnDelDatasource;
	private System.Windows.Forms.Button btnAddDatasource;
	private System.Windows.Forms.Label label8;
	private System.Windows.Forms.Button btnEditDatasource;
	private System.Windows.Forms.TextBox txtMessage;
	private System.Windows.Forms.Label label7;
	private System.Windows.Forms.TextBox txtSource;
	private System.Windows.Forms.Button btnPageUp;
	private System.Windows.Forms.Label label6;
	private System.Windows.Forms.Button btnPageDown;
	private System.Windows.Forms.Button btnPurgeLogs;
	private System.Windows.Forms.ComboBox cmbSeverity;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.Label label4;
	private System.Windows.Forms.NumericUpDown numPageLength;
	private System.Windows.Forms.Label label3;
	private System.Windows.Forms.StatusStrip statusStrip1;
	private System.Windows.Forms.ToolStripStatusLabel statusLabel;
	private System.Windows.Forms.ToolStripStatusLabel toolLblVersion;
	private System.Windows.Forms.ToolStripStatusLabel toolLblMessage;
	private System.Windows.Forms.ListView lvLogs;
	private System.Windows.Forms.ColumnHeader colTimestamp;
	private System.Windows.Forms.ColumnHeader colLevel;
	private System.Windows.Forms.ColumnHeader colApp;
	private System.Windows.Forms.ColumnHeader colSource;
	private System.Windows.Forms.ColumnHeader colMessage;
	private System.Windows.Forms.ComboBox cmbDbConns;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Timer timer1;
	private System.Windows.Forms.ToolTip toolTip1;
	private System.Windows.Forms.ImageList imageList1;
	private System.Windows.Forms.ImageList logEventImgList;
	private System.Windows.Forms.PictureBox picSpinner;
	private System.Windows.Forms.PictureBox picRefresh;
	private System.Windows.Forms.PictureBox picAutoRefresh;
	private System.Windows.Forms.PictureBox picSortOrder;
}