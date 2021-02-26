namespace ProData.Infrastructure.LogViewer
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDbConns = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSeverity = new System.Windows.Forms.ComboBox();
            this.lvLogs = new System.Windows.Forms.ListView();
            this.colTimestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAppId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSourceContext = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.numPageLength = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.btnRefreshFilterLists = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.cmbApplicationNames = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDelDatasource = new System.Windows.Forms.Button();
            this.btnAddDatasource = new System.Windows.Forms.Button();
            this.btnEditDatasource = new System.Windows.Forms.Button();
            this.btnPageUp = new System.Windows.Forms.Button();
            this.btnPageDown = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAutoRefresh = new System.Windows.Forms.Button();
            this.btnSortDir = new System.Windows.Forms.Button();
            this.numPageNumber = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPageLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database:";
            // 
            // cmbDbConns
            // 
            this.cmbDbConns.BackColor = System.Drawing.SystemColors.Window;
            this.cmbDbConns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDbConns.FormattingEnabled = true;
            this.cmbDbConns.Location = new System.Drawing.Point(126, 18);
            this.cmbDbConns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDbConns.Name = "cmbDbConns";
            this.cmbDbConns.Size = new System.Drawing.Size(379, 28);
            this.cmbDbConns.Sorted = true;
            this.cmbDbConns.TabIndex = 1;
            this.cmbDbConns.SelectedIndexChanged += new System.EventHandler(this.cmbDbConn_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Severity:";
            // 
            // cmbSeverity
            // 
            this.cmbSeverity.BackColor = System.Drawing.SystemColors.Window;
            this.cmbSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeverity.FormattingEnabled = true;
            this.cmbSeverity.Location = new System.Drawing.Point(124, 77);
            this.cmbSeverity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSeverity.Name = "cmbSeverity";
            this.cmbSeverity.Size = new System.Drawing.Size(354, 28);
            this.cmbSeverity.TabIndex = 3;
            this.cmbSeverity.DropDownClosed += new System.EventHandler(this.cmbSeverity_SelectedIndexChanged);
            // 
            // lvLogs
            // 
            this.lvLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTimestamp,
            this.colLevel,
            this.colAppId,
            this.colSourceContext,
            this.colUserName,
            this.colMessage});
            this.lvLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLogs.ForeColor = System.Drawing.Color.White;
            this.lvLogs.FullRowSelect = true;
            this.lvLogs.HideSelection = false;
            this.lvLogs.Location = new System.Drawing.Point(20, 172);
            this.lvLogs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvLogs.MultiSelect = false;
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.ShowItemToolTips = true;
            this.lvLogs.Size = new System.Drawing.Size(1140, 507);
            this.lvLogs.TabIndex = 4;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            this.lvLogs.View = System.Windows.Forms.View.Details;
            this.lvLogs.DoubleClick += new System.EventHandler(this.lvLogs_DoubleClick);
            // 
            // colTimestamp
            // 
            this.colTimestamp.Text = "Timestamp";
            this.colTimestamp.Width = 100;
            // 
            // colLevel
            // 
            this.colLevel.Text = "Level";
            this.colLevel.Width = 45;
            // 
            // colAppId
            // 
            this.colAppId.Text = "App Id";
            // 
            // colSourceContext
            // 
            this.colSourceContext.Text = "Source";
            this.colSourceContext.Width = 200;
            // 
            // colUserName
            // 
            this.colUserName.Text = "User";
            this.colUserName.Width = 100;
            // 
            // colMessage
            // 
            this.colMessage.Text = "Message";
            this.colMessage.Width = 355;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "blank_16.png");
            this.imageList1.Images.SetKeyName(1, "Debug_16.png");
            this.imageList1.Images.SetKeyName(2, "Info_16.png");
            this.imageList1.Images.SetKeyName(3, "Warn_16.png");
            this.imageList1.Images.SetKeyName(4, "Error_16.png");
            this.imageList1.Images.SetKeyName(5, "Fatal-16.jpeg");
            this.imageList1.Images.SetKeyName(6, "Spinner.gif");
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.toolLblVersion,
            this.toolLblMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 760);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1180, 32);
            this.statusStrip1.TabIndex = 5;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 25);
            // 
            // toolLblVersion
            // 
            this.toolLblVersion.Name = "toolLblVersion";
            this.toolLblVersion.Size = new System.Drawing.Size(82, 25);
            this.toolLblVersion.Text = "v. 1.0.0.0";
            // 
            // toolLblMessage
            // 
            this.toolLblMessage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolLblMessage.Name = "toolLblMessage";
            this.toolLblMessage.Size = new System.Drawing.Size(145, 25);
            this.toolLblMessage.Text = "Auto refresh: Off";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 712);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Page Length:";
            // 
            // numPageLength
            // 
            this.numPageLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numPageLength.BackColor = System.Drawing.SystemColors.Window;
            this.numPageLength.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numPageLength.Location = new System.Drawing.Point(542, 708);
            this.numPageLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPageLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPageLength.Name = "numPageLength";
            this.numPageLength.Size = new System.Drawing.Size(104, 26);
            this.numPageLength.TabIndex = 11;
            this.numPageLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPageLength.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(759, 712);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Page Number:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Image = global::ProData.Infrastructure.LogViewer.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(1094, 18);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(63, 44);
            this.btnRefresh.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnRefresh, "Refresh Logs");
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearLogs.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearLogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLogs.Location = new System.Drawing.Point(20, 692);
            this.btnClearLogs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(151, 57);
            this.btnClearLogs.TabIndex = 16;
            this.btnClearLogs.Text = "Purge Logs";
            this.btnClearLogs.UseVisualStyleBackColor = false;
            this.btnClearLogs.Click += new System.EventHandler(this.btnPurgeLogs_Click);
            // 
            // btnRefreshFilterLists
            // 
            this.btnRefreshFilterLists.Image = global::ProData.Infrastructure.LogViewer.Properties.Resources.refresh_filter_lists;
            this.btnRefreshFilterLists.Location = new System.Drawing.Point(706, 16);
            this.btnRefreshFilterLists.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshFilterLists.Name = "btnRefreshFilterLists";
            this.btnRefreshFilterLists.Size = new System.Drawing.Size(49, 43);
            this.btnRefreshFilterLists.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnRefreshFilterLists, "Refresh Filter Lists");
            this.btnRefreshFilterLists.UseVisualStyleBackColor = true;
            this.btnRefreshFilterLists.Click += new System.EventHandler(this.btnRefreshFilterLists_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Image = global::ProData.Infrastructure.LogViewer.Properties.Resources.clear_filters;
            this.btnClearFilters.Location = new System.Drawing.Point(763, 17);
            this.btnClearFilters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(49, 42);
            this.btnClearFilters.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnClearFilters, "Clear Filters");
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // cmbApplicationNames
            // 
            this.cmbApplicationNames.BackColor = System.Drawing.SystemColors.Window;
            this.cmbApplicationNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApplicationNames.FormattingEnabled = true;
            this.cmbApplicationNames.Location = new System.Drawing.Point(124, 119);
            this.cmbApplicationNames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbApplicationNames.Name = "cmbApplicationNames";
            this.cmbApplicationNames.Size = new System.Drawing.Size(354, 28);
            this.cmbApplicationNames.TabIndex = 25;
            this.cmbApplicationNames.SelectedIndexChanged += new System.EventHandler(this.cmbMachineNames_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Application:";
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.BackColor = System.Drawing.SystemColors.Window;
            this.txtMessage.Location = new System.Drawing.Point(586, 119);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(570, 26);
            this.txtMessage.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Message:";
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.BackColor = System.Drawing.SystemColors.Window;
            this.txtSource.Location = new System.Drawing.Point(586, 77);
            this.txtSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(570, 26);
            this.txtSource.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Source:";
            // 
            // btnDelDatasource
            // 
            this.btnDelDatasource.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelDatasource.Enabled = false;
            this.btnDelDatasource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelDatasource.Image = global::ProData.Infrastructure.LogViewer.Properties.Resources.del_datasource;
            this.btnDelDatasource.Location = new System.Drawing.Point(572, 17);
            this.btnDelDatasource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelDatasource.Name = "btnDelDatasource";
            this.btnDelDatasource.Size = new System.Drawing.Size(39, 35);
            this.btnDelDatasource.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnDelDatasource, "Delete DbConn...");
            this.btnDelDatasource.UseVisualStyleBackColor = false;
            this.btnDelDatasource.Click += new System.EventHandler(this.btnDelDatasource_Click);
            // 
            // btnAddDatasource
            // 
            this.btnAddDatasource.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddDatasource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDatasource.Image = global::ProData.Infrastructure.LogViewer.Properties.Resources.add_datasource;
            this.btnAddDatasource.Location = new System.Drawing.Point(620, 17);
            this.btnAddDatasource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddDatasource.Name = "btnAddDatasource";
            this.btnAddDatasource.Size = new System.Drawing.Size(39, 35);
            this.btnAddDatasource.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnAddDatasource, "Add New DbConn...");
            this.btnAddDatasource.UseVisualStyleBackColor = false;
            this.btnAddDatasource.Click += new System.EventHandler(this.btnAddDatasource_Click);
            // 
            // btnEditDatasource
            // 
            this.btnEditDatasource.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditDatasource.Enabled = false;
            this.btnEditDatasource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditDatasource.Image = global::ProData.Infrastructure.LogViewer.Properties.Resources.edit_datasource;
            this.btnEditDatasource.Location = new System.Drawing.Point(525, 17);
            this.btnEditDatasource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditDatasource.Name = "btnEditDatasource";
            this.btnEditDatasource.Size = new System.Drawing.Size(39, 35);
            this.btnEditDatasource.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btnEditDatasource, "Edit DbConn...");
            this.btnEditDatasource.UseVisualStyleBackColor = false;
            this.btnEditDatasource.Click += new System.EventHandler(this.btnEditDatasource_Click);
            // 
            // btnPageUp
            // 
            this.btnPageUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPageUp.BackColor = System.Drawing.SystemColors.Control;
            this.btnPageUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPageUp.Image = global::ProData.Infrastructure.LogViewer.Properties.Resources.right_arrow;
            this.btnPageUp.Location = new System.Drawing.Point(976, 702);
            this.btnPageUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPageUp.Name = "btnPageUp";
            this.btnPageUp.Size = new System.Drawing.Size(50, 40);
            this.btnPageUp.TabIndex = 21;
            this.btnPageUp.UseVisualStyleBackColor = false;
            this.btnPageUp.Click += new System.EventHandler(this.btnPageUp_Click);
            // 
            // btnPageDown
            // 
            this.btnPageDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPageDown.BackColor = System.Drawing.SystemColors.Control;
            this.btnPageDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPageDown.Image = global::ProData.Infrastructure.LogViewer.Properties.Resources.left_arrow;
            this.btnPageDown.Location = new System.Drawing.Point(694, 702);
            this.btnPageDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPageDown.Name = "btnPageDown";
            this.btnPageDown.Size = new System.Drawing.Size(50, 40);
            this.btnPageDown.TabIndex = 20;
            this.btnPageDown.UseVisualStyleBackColor = false;
            this.btnPageDown.Click += new System.EventHandler(this.btnPageDown_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAutoRefresh
            // 
            this.btnAutoRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnAutoRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAutoRefresh.Image = global::ProData.Infrastructure.LogViewer.Properties.Resources.Timer;
            this.btnAutoRefresh.Location = new System.Drawing.Point(1014, 17);
            this.btnAutoRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAutoRefresh.Name = "btnAutoRefresh";
            this.btnAutoRefresh.Size = new System.Drawing.Size(63, 44);
            this.btnAutoRefresh.TabIndex = 27;
            this.btnAutoRefresh.UseVisualStyleBackColor = false;
            this.btnAutoRefresh.Click += new System.EventHandler(this.btnAutoRefresh_Click);
            // 
            // btnSortDir
            // 
            this.btnSortDir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSortDir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSortDir.Image = global::ProData.Infrastructure.LogViewer.Properties.Resources.arrow_up;
            this.btnSortDir.Location = new System.Drawing.Point(934, 18);
            this.btnSortDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortDir.Name = "btnSortDir";
            this.btnSortDir.Size = new System.Drawing.Size(63, 44);
            this.btnSortDir.TabIndex = 28;
            this.btnSortDir.UseVisualStyleBackColor = false;
            this.btnSortDir.Click += new System.EventHandler(this.btnSortDir_Click);
            // 
            // numPageNumber
            // 
            this.numPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numPageNumber.BackColor = System.Drawing.SystemColors.Window;
            this.numPageNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numPageNumber.Location = new System.Drawing.Point(873, 711);
            this.numPageNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPageNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPageNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPageNumber.Name = "numPageNumber";
            this.numPageNumber.Size = new System.Drawing.Size(80, 26);
            this.numPageNumber.TabIndex = 29;
            this.numPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPageNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPageNumber.ValueChanged += new System.EventHandler(this.NumPageNumber_ValueChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnRefresh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 792);
            this.Controls.Add(this.numPageNumber);
            this.Controls.Add(this.btnRefreshFilterLists);
            this.Controls.Add(this.btnSortDir);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.btnAutoRefresh);
            this.Controls.Add(this.cmbApplicationNames);
            this.Controls.Add(this.btnDelDatasource);
            this.Controls.Add(this.btnAddDatasource);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEditDatasource);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnPageUp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPageDown);
            this.Controls.Add(this.btnClearLogs);
            this.Controls.Add(this.cmbSeverity);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPageLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lvLogs);
            this.Controls.Add(this.cmbDbConns);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Viewer";
            this.toolTip1.SetToolTip(this, "Auto Refresh");
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPageLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDbConns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSeverity;
        private System.Windows.Forms.ListView lvLogs;
        private System.Windows.Forms.ColumnHeader colTimestamp;
        private System.Windows.Forms.ColumnHeader colUserName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ColumnHeader colMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPageLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClearLogs;
        private System.Windows.Forms.ColumnHeader colAppId;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbApplicationNames;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader colSourceContext;
		private System.Windows.Forms.Button btnClearFilters;
		private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnPageDown;
        private System.Windows.Forms.Button btnPageUp;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button btnEditDatasource;
        private System.Windows.Forms.Button btnAddDatasource;
        private System.Windows.Forms.Button btnDelDatasource;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnRefreshFilterLists;
		private System.Windows.Forms.Button btnAutoRefresh;
		private System.Windows.Forms.ToolStripStatusLabel toolLblVersion;
		private System.Windows.Forms.ToolStripStatusLabel toolLblMessage;
		private System.Windows.Forms.Button btnSortDir;
		private System.Windows.Forms.ColumnHeader colLevel;
		private System.Windows.Forms.NumericUpDown numPageNumber;
	}
}

