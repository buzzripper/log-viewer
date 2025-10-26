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
        autoRefreshTimer = new System.Windows.Forms.Timer(components);
        toolTip1 = new System.Windows.Forms.ToolTip(components);
        btnSort = new System.Windows.Forms.Button();
        btnRefresh = new System.Windows.Forms.Button();
        pnlGlow = new GlowPanel();
        btnAutoRefresh = new System.Windows.Forms.Button();
        autoRefreshTimeoutTimer = new System.Windows.Forms.Timer(components);
        ((System.ComponentModel.ISupportInitialize)numPageNumber).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numPageLength).BeginInit();
        statusStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // numPageNumber
        // 
        numPageNumber.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        numPageNumber.BackColor = System.Drawing.SystemColors.Window;
        numPageNumber.ForeColor = System.Drawing.SystemColors.WindowText;
        numPageNumber.Location = new System.Drawing.Point(469, 574);
        numPageNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        numPageNumber.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        numPageNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numPageNumber.Name = "numPageNumber";
        numPageNumber.Size = new System.Drawing.Size(59, 23);
        numPageNumber.TabIndex = 56;
        numPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        numPageNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
        numPageNumber.ValueChanged += this.numPageNumber_ValueChanged;
        // 
        // btnRefreshFilterLists
        // 
        btnRefreshFilterLists.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        btnRefreshFilterLists.ImageKey = "refresh_24_lt.png";
        btnRefreshFilterLists.ImageList = imageList1;
        btnRefreshFilterLists.Location = new System.Drawing.Point(662, 6);
        btnRefreshFilterLists.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        btnRefreshFilterLists.Name = "btnRefreshFilterLists";
        btnRefreshFilterLists.Size = new System.Drawing.Size(30, 27);
        btnRefreshFilterLists.TabIndex = 53;
        toolTip1.SetToolTip(btnRefreshFilterLists, "Refresh");
        btnRefreshFilterLists.UseVisualStyleBackColor = true;
        btnRefreshFilterLists.Click += this.btnRefreshFilterLists_Click;
        // 
        // imageList1
        // 
        imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
        imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
        imageList1.TransparentColor = System.Drawing.Color.Transparent;
        imageList1.Images.SetKeyName(0, "timer_off_32.png");
        imageList1.Images.SetKeyName(1, "timer_32.png");
        imageList1.Images.SetKeyName(2, "refresh_24_lt.png");
        imageList1.Images.SetKeyName(3, "auto_refresh_32.png");
        imageList1.Images.SetKeyName(4, "sort_32.png");
        imageList1.Images.SetKeyName(5, "clear_filters_24_lt.png");
        imageList1.Images.SetKeyName(6, "add_datasource.png");
        imageList1.Images.SetKeyName(7, "del_datasource_24_lt.png");
        imageList1.Images.SetKeyName(8, "edit_datasource_24_lt.png");
        imageList1.Images.SetKeyName(9, "left_arrow_32.png");
        imageList1.Images.SetKeyName(10, "right_arrow_32.png");
        imageList1.Images.SetKeyName(11, "Spinner.gif");
        imageList1.Images.SetKeyName(12, "swap_vert_32_up.png");
        imageList1.Images.SetKeyName(13, "swap_vert_32_dn.png");
        // 
        // btnClearFilters
        // 
        btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        btnClearFilters.ImageKey = "clear_filters_24_lt.png";
        btnClearFilters.ImageList = imageList1;
        btnClearFilters.Location = new System.Drawing.Point(698, 6);
        btnClearFilters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        btnClearFilters.Name = "btnClearFilters";
        btnClearFilters.Size = new System.Drawing.Size(33, 27);
        btnClearFilters.TabIndex = 41;
        toolTip1.SetToolTip(btnClearFilters, "Clear Filters");
        btnClearFilters.UseVisualStyleBackColor = true;
        btnClearFilters.Click += this.btnClearFilters_Click;
        // 
        // cmbApplicationNames
        // 
        cmbApplicationNames.BackColor = System.Drawing.SystemColors.Window;
        cmbApplicationNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbApplicationNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        cmbApplicationNames.Font = new System.Drawing.Font("Segoe UI", 12F);
        cmbApplicationNames.FormattingEnabled = true;
        cmbApplicationNames.Location = new System.Drawing.Point(171, 77);
        cmbApplicationNames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        cmbApplicationNames.Name = "cmbApplicationNames";
        cmbApplicationNames.Size = new System.Drawing.Size(276, 29);
        cmbApplicationNames.TabIndex = 52;
        cmbApplicationNames.SelectedIndexChanged += this.cmbApplicationNames_SelectedIndexChanged;
        // 
        // btnDelDatasource
        // 
        btnDelDatasource.BackColor = System.Drawing.SystemColors.Control;
        btnDelDatasource.Enabled = false;
        btnDelDatasource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        btnDelDatasource.ImageKey = "del_datasource_24_lt.png";
        btnDelDatasource.ImageList = imageList1;
        btnDelDatasource.Location = new System.Drawing.Point(558, 7);
        btnDelDatasource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        btnDelDatasource.Name = "btnDelDatasource";
        btnDelDatasource.Size = new System.Drawing.Size(30, 26);
        btnDelDatasource.TabIndex = 51;
        toolTip1.SetToolTip(btnDelDatasource, "Delete Datasource");
        btnDelDatasource.UseVisualStyleBackColor = false;
        btnDelDatasource.Click += this.btnDelDatasource_Click;
        // 
        // btnAddDatasource
        // 
        btnAddDatasource.BackColor = System.Drawing.SystemColors.Control;
        btnAddDatasource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        btnAddDatasource.ImageKey = "add_datasource.png";
        btnAddDatasource.ImageList = imageList1;
        btnAddDatasource.Location = new System.Drawing.Point(594, 7);
        btnAddDatasource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        btnAddDatasource.Name = "btnAddDatasource";
        btnAddDatasource.Size = new System.Drawing.Size(30, 26);
        btnAddDatasource.TabIndex = 50;
        toolTip1.SetToolTip(btnAddDatasource, "Add Datasource");
        btnAddDatasource.UseVisualStyleBackColor = false;
        btnAddDatasource.Click += this.btnAddDatasource_Click;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.BackColor = System.Drawing.SystemColors.Control;
        label8.ForeColor = System.Drawing.SystemColors.ControlText;
        label8.Location = new System.Drawing.Point(95, 80);
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
        btnEditDatasource.ImageKey = "edit_datasource_24_lt.png";
        btnEditDatasource.ImageList = imageList1;
        btnEditDatasource.Location = new System.Drawing.Point(521, 7);
        btnEditDatasource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        btnEditDatasource.Name = "btnEditDatasource";
        btnEditDatasource.Size = new System.Drawing.Size(30, 26);
        btnEditDatasource.TabIndex = 48;
        toolTip1.SetToolTip(btnEditDatasource, "Edit Datasource");
        btnEditDatasource.UseVisualStyleBackColor = false;
        btnEditDatasource.Click += this.btnEditDatasource_Click;
        // 
        // txtMessage
        // 
        txtMessage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtMessage.BackColor = System.Drawing.SystemColors.Window;
        txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
        txtMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        txtMessage.Location = new System.Drawing.Point(521, 80);
        txtMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        txtMessage.Name = "txtMessage";
        txtMessage.Size = new System.Drawing.Size(515, 22);
        txtMessage.TabIndex = 47;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.BackColor = System.Drawing.SystemColors.Control;
        label7.ForeColor = System.Drawing.SystemColors.ControlText;
        label7.Location = new System.Drawing.Point(462, 80);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(56, 15);
        label7.TabIndex = 46;
        label7.Text = "Message:";
        // 
        // txtSource
        // 
        txtSource.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtSource.BackColor = System.Drawing.SystemColors.Window;
        txtSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
        txtSource.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        txtSource.Location = new System.Drawing.Point(521, 45);
        txtSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        txtSource.Name = "txtSource";
        txtSource.Size = new System.Drawing.Size(515, 22);
        txtSource.TabIndex = 45;
        // 
        // btnPageUp
        // 
        btnPageUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        btnPageUp.BackColor = System.Drawing.SystemColors.Control;
        btnPageUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        btnPageUp.Image = (System.Drawing.Image)resources.GetObject("btnPageUp.Image");
        btnPageUp.Location = new System.Drawing.Point(534, 572);
        btnPageUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        btnPageUp.Name = "btnPageUp";
        btnPageUp.Size = new System.Drawing.Size(26, 26);
        btnPageUp.TabIndex = 44;
        btnPageUp.UseVisualStyleBackColor = false;
        btnPageUp.Click += this.btnPageUp_Click;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.BackColor = System.Drawing.SystemColors.Control;
        label6.ForeColor = System.Drawing.SystemColors.ControlText;
        label6.Location = new System.Drawing.Point(472, 45);
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
        btnPageDown.Image = (System.Drawing.Image)resources.GetObject("btnPageDown.Image");
        btnPageDown.Location = new System.Drawing.Point(438, 572);
        btnPageDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        btnPageDown.Name = "btnPageDown";
        btnPageDown.Size = new System.Drawing.Size(26, 26);
        btnPageDown.TabIndex = 42;
        btnPageDown.UseVisualStyleBackColor = false;
        btnPageDown.Click += this.btnPageDown_Click;
        // 
        // btnPurgeLogs
        // 
        btnPurgeLogs.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        btnPurgeLogs.BackColor = System.Drawing.SystemColors.ButtonFace;
        btnPurgeLogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        btnPurgeLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        btnPurgeLogs.ForeColor = System.Drawing.SystemColors.ControlText;
        btnPurgeLogs.Location = new System.Drawing.Point(20, 571);
        btnPurgeLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        btnPurgeLogs.Name = "btnPurgeLogs";
        btnPurgeLogs.Size = new System.Drawing.Size(118, 28);
        btnPurgeLogs.TabIndex = 40;
        btnPurgeLogs.Text = "Purge Logs";
        btnPurgeLogs.UseVisualStyleBackColor = false;
        btnPurgeLogs.Click += this.btnPurgeLogs_Click;
        // 
        // cmbSeverity
        // 
        cmbSeverity.BackColor = System.Drawing.SystemColors.Window;
        cmbSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbSeverity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        cmbSeverity.Font = new System.Drawing.Font("Segoe UI", 12F);
        cmbSeverity.FormattingEnabled = true;
        cmbSeverity.Location = new System.Drawing.Point(171, 42);
        cmbSeverity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        cmbSeverity.Name = "cmbSeverity";
        cmbSeverity.Size = new System.Drawing.Size(276, 29);
        cmbSeverity.TabIndex = 33;
        cmbSeverity.SelectedIndexChanged += this.cmbSeverity_SelectedIndexChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.BackColor = System.Drawing.SystemColors.Control;
        label2.ForeColor = System.Drawing.SystemColors.ControlText;
        label2.Location = new System.Drawing.Point(105, 45);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(61, 15);
        label2.TabIndex = 32;
        label2.Text = "Min Level:";
        // 
        // label4
        // 
        label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        label4.AutoSize = true;
        label4.ForeColor = System.Drawing.SystemColors.ControlText;
        label4.Location = new System.Drawing.Point(353, 577);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(83, 15);
        label4.TabIndex = 38;
        label4.Text = "Page Number:";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // numPageLength
        // 
        numPageLength.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        numPageLength.BackColor = System.Drawing.SystemColors.Window;
        numPageLength.ForeColor = System.Drawing.SystemColors.WindowText;
        numPageLength.Location = new System.Drawing.Point(257, 576);
        numPageLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        numPageLength.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        numPageLength.Name = "numPageLength";
        numPageLength.Size = new System.Drawing.Size(58, 23);
        numPageLength.TabIndex = 37;
        numPageLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        numPageLength.Value = new decimal(new int[] { 100, 0, 0, 0 });
        numPageLength.KeyPress += this.numPageLength_KeyPress;
        // 
        // label3
        // 
        label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        label3.AutoSize = true;
        label3.ForeColor = System.Drawing.SystemColors.ControlText;
        label3.Location = new System.Drawing.Point(179, 578);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(76, 15);
        label3.TabIndex = 36;
        label3.Text = "Page Length:";
        // 
        // statusStrip1
        // 
        statusStrip1.BackColor = System.Drawing.SystemColors.Control;
        statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
        statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusLabel, toolLblVersion, toolLblMessage });
        statusStrip1.Location = new System.Drawing.Point(0, 612);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
        statusStrip1.Size = new System.Drawing.Size(1056, 22);
        statusStrip1.TabIndex = 35;
        // 
        // statusLabel
        // 
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new System.Drawing.Size(0, 17);
        // 
        // toolLblVersion
        // 
        toolLblVersion.ForeColor = System.Drawing.SystemColors.ControlText;
        toolLblVersion.Name = "toolLblVersion";
        toolLblVersion.Size = new System.Drawing.Size(52, 17);
        toolLblVersion.Text = "v. 1.0.0.0";
        // 
        // toolLblMessage
        // 
        toolLblMessage.BackColor = System.Drawing.SystemColors.Control;
        toolLblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
        toolLblMessage.Name = "toolLblMessage";
        toolLblMessage.Size = new System.Drawing.Size(95, 17);
        toolLblMessage.Text = "Auto refresh: Off";
        // 
        // lvLogs
        // 
        lvLogs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        lvLogs.BackColor = System.Drawing.SystemColors.ControlLight;
        lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { colTimestamp, colLevel, colApp, colSource, colMessage });
        lvLogs.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        lvLogs.ForeColor = System.Drawing.Color.White;
        lvLogs.FullRowSelect = true;
        lvLogs.Location = new System.Drawing.Point(25, 139);
        lvLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        lvLogs.MultiSelect = false;
        lvLogs.Name = "lvLogs";
        lvLogs.ShowItemToolTips = true;
        lvLogs.Size = new System.Drawing.Size(1019, 420);
        lvLogs.SmallImageList = logEventImgList;
        lvLogs.TabIndex = 34;
        lvLogs.UseCompatibleStateImageBehavior = false;
        lvLogs.View = System.Windows.Forms.View.Details;
        lvLogs.SelectedIndexChanged += this.lvLogs_SelectedIndexChanged;
        lvLogs.DoubleClick += this.lvLogs_DoubleClick;
        lvLogs.KeyPress += this.lvLogs_KeyPress;
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
        cmbDbConns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        cmbDbConns.Font = new System.Drawing.Font("Segoe UI", 12F);
        cmbDbConns.FormattingEnabled = true;
        cmbDbConns.Location = new System.Drawing.Point(172, 7);
        cmbDbConns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        cmbDbConns.Name = "cmbDbConns";
        cmbDbConns.Size = new System.Drawing.Size(275, 29);
        cmbDbConns.Sorted = true;
        cmbDbConns.TabIndex = 31;
        cmbDbConns.SelectedIndexChanged += this.cmbDbConns_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = System.Drawing.SystemColors.Control;
        label1.ForeColor = System.Drawing.SystemColors.ControlText;
        label1.Location = new System.Drawing.Point(108, 11);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(58, 15);
        label1.TabIndex = 30;
        label1.Text = "Database:";
        // 
        // autoRefreshTimer
        // 
        autoRefreshTimer.Interval = 1000;
        autoRefreshTimer.Tick += this.timer1_Tick;
        // 
        // btnSort
        // 
        btnSort.BackColor = System.Drawing.SystemColors.Control;
        btnSort.Enabled = false;
        btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        btnSort.ImageKey = "swap_vert_32_up.png";
        btnSort.ImageList = imageList1;
        btnSort.Location = new System.Drawing.Point(25, 90);
        btnSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        btnSort.Name = "btnSort";
        btnSort.Size = new System.Drawing.Size(36, 36);
        btnSort.TabIndex = 67;
        toolTip1.SetToolTip(btnSort, "Edit Datasource");
        btnSort.UseVisualStyleBackColor = false;
        btnSort.Click += this.btnSort_Click;
        // 
        // btnRefresh
        // 
        btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        btnRefresh.Image = (System.Drawing.Image)resources.GetObject("btnRefresh.Image");
        btnRefresh.Location = new System.Drawing.Point(603, 567);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new System.Drawing.Size(89, 38);
        btnRefresh.TabIndex = 65;
        btnRefresh.UseVisualStyleBackColor = true;
        btnRefresh.Click += this.btnRefresh_Click;
        // 
        // pnlGlow
        // 
        pnlGlow.BackColor = System.Drawing.Color.DodgerBlue;
        pnlGlow.Location = new System.Drawing.Point(917, 573);
        pnlGlow.Name = "pnlGlow";
        pnlGlow.Size = new System.Drawing.Size(85, 26);
        pnlGlow.TabIndex = 66;
        // 
        // btnAutoRefresh
        // 
        btnAutoRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnAutoRefresh.Image = (System.Drawing.Image)resources.GetObject("btnAutoRefresh.Image");
        btnAutoRefresh.Location = new System.Drawing.Point(1008, 569);
        btnAutoRefresh.Name = "btnAutoRefresh";
        btnAutoRefresh.Size = new System.Drawing.Size(36, 33);
        btnAutoRefresh.TabIndex = 68;
        btnAutoRefresh.UseVisualStyleBackColor = true;
        btnAutoRefresh.Click += this.btnAutoRefresh_Click;
        // 
        // autoRefreshTimeoutTimer
        // 
        autoRefreshTimeoutTimer.Interval = 8000;
        autoRefreshTimeoutTimer.Tick += this.autoRefreshTimeoutTimer_Tick;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoSize = true;
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(1056, 634);
        this.Controls.Add(btnAutoRefresh);
        this.Controls.Add(btnSort);
        this.Controls.Add(btnRefresh);
        this.Controls.Add(numPageNumber);
        this.Controls.Add(btnRefreshFilterLists);
        this.Controls.Add(btnClearFilters);
        this.Controls.Add(cmbApplicationNames);
        this.Controls.Add(btnDelDatasource);
        this.Controls.Add(btnAddDatasource);
        this.Controls.Add(label8);
        this.Controls.Add(btnEditDatasource);
        this.Controls.Add(txtMessage);
        this.Controls.Add(label7);
        this.Controls.Add(txtSource);
        this.Controls.Add(btnPageUp);
        this.Controls.Add(label6);
        this.Controls.Add(btnPageDown);
        this.Controls.Add(btnPurgeLogs);
        this.Controls.Add(cmbSeverity);
        this.Controls.Add(label2);
        this.Controls.Add(label4);
        this.Controls.Add(numPageLength);
        this.Controls.Add(label3);
        this.Controls.Add(statusStrip1);
        this.Controls.Add(lvLogs);
        this.Controls.Add(cmbDbConns);
        this.Controls.Add(label1);
        this.Controls.Add(pnlGlow);
        this.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        this.Margin = new System.Windows.Forms.Padding(2);
        this.Name = "Form1";
        this.Text = "Log Viewer";
        this.Activated += this.Form1_Activated;
        this.FormClosing += this.Form1_FormClosing;
        this.Load += this.Form1_Load;
        this.Shown += this.Form1_Shown;
        this.KeyDown += this.Form1_KeyDown;
        this.Resize += this.Form1_Resize;
        ((System.ComponentModel.ISupportInitialize)numPageNumber).EndInit();
        ((System.ComponentModel.ISupportInitialize)numPageLength).EndInit();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
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
	private System.Windows.Forms.Timer autoRefreshTimer;
	private System.Windows.Forms.ToolTip toolTip1;
	private System.Windows.Forms.ImageList imageList1;
	private System.Windows.Forms.ImageList logEventImgList;
    private System.Windows.Forms.Button btnRefresh;
    private GlowPanel pnlGlow;
    private System.Windows.Forms.Button btnSort;
    private System.Windows.Forms.Button btnAutoRefresh;
    private System.Windows.Forms.Timer autoRefreshTimeoutTimer;
}