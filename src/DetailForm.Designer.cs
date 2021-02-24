namespace ProData.Infrastructure.LogViewer
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblRowId = new System.Windows.Forms.Label();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblLogSource = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtException = new System.Windows.Forms.TextBox();
            this.picLogLevel = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblException = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Row ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRowId
            // 
            this.lblRowId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRowId.AutoSize = true;
            this.lblRowId.Location = new System.Drawing.Point(127, 10);
            this.lblRowId.Name = "lblRowId";
            this.lblRowId.Size = new System.Drawing.Size(78, 22);
            this.lblRowId.TabIndex = 2;
            this.lblRowId.Text = "lblRowId";
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.Location = new System.Drawing.Point(127, 29);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(116, 22);
            this.lblTimestamp.TabIndex = 4;
            this.lblTimestamp.Text = "lblTimestamp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Timestamp:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSeverity
            // 
            this.lblSeverity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeverity.AutoSize = true;
            this.lblSeverity.Location = new System.Drawing.Point(127, 48);
            this.lblSeverity.Name = "lblSeverity";
            this.lblSeverity.Size = new System.Drawing.Size(93, 22);
            this.lblSeverity.TabIndex = 6;
            this.lblSeverity.Text = "lblSeverity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Severity:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Message:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.BackColor = System.Drawing.SystemColors.Control;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(89, 154);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(719, 155);
            this.txtMessage.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = global::ProData.Infrastructure.LogViewer.Properties.Resources.down_arrow;
            this.button1.Location = new System.Drawing.Point(793, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.Image = global::ProData.Infrastructure.LogViewer.Properties.Resources.up_arrow;
            this.btnUp.Location = new System.Drawing.Point(793, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(28, 28);
            this.btnUp.TabIndex = 9;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblLogSource
            // 
            this.lblLogSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogSource.AutoSize = true;
            this.lblLogSource.Location = new System.Drawing.Point(127, 106);
            this.lblLogSource.Name = "lblLogSource";
            this.lblLogSource.Size = new System.Drawing.Size(115, 22);
            this.lblLogSource.TabIndex = 16;
            this.lblLogSource.Text = "lblLogSource";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Source:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblModuleName
            // 
            this.lblModuleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.Location = new System.Drawing.Point(127, 86);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(113, 22);
            this.lblModuleName.TabIndex = 14;
            this.lblModuleName.Text = "lblUserName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "User:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMachineName
            // 
            this.lblMachineName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Location = new System.Drawing.Point(127, 67);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(142, 22);
            this.lblMachineName.TabIndex = 12;
            this.lblMachineName.Text = "lblMachineName";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 22);
            this.label10.TabIndex = 11;
            this.label10.Text = "Machine:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(829, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(7, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 4);
            this.panel1.TabIndex = 30;
            // 
            // txtException
            // 
            this.txtException.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtException.BackColor = System.Drawing.SystemColors.Control;
            this.txtException.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtException.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtException.Location = new System.Drawing.Point(89, 335);
            this.txtException.Multiline = true;
            this.txtException.Name = "txtException";
            this.txtException.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtException.Size = new System.Drawing.Size(719, 151);
            this.txtException.TabIndex = 32;
            this.txtException.Visible = false;
            // 
            // picLogLevel
            // 
            this.picLogLevel.Location = new System.Drawing.Point(6, 7);
            this.picLogLevel.Name = "picLogLevel";
            this.picLogLevel.Size = new System.Drawing.Size(16, 16);
            this.picLogLevel.TabIndex = 33;
            this.picLogLevel.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Debug_16.png");
            this.imageList1.Images.SetKeyName(1, "Info_16.png");
            this.imageList1.Images.SetKeyName(2, "Warn_16.png");
            this.imageList1.Images.SetKeyName(3, "Error_16.png");
            this.imageList1.Images.SetKeyName(4, "Fatal-16.jpeg");
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(19, 337);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(94, 22);
            this.lblException.TabIndex = 34;
            this.lblException.Text = "Exception:";
            this.lblException.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 540);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.picLogLevel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtException);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblLogSource);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblModuleName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMachineName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSeverity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTimestamp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRowId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DetailForm";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRowId;
        private System.Windows.Forms.Label lblTimestamp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSeverity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblLogSource;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblModuleName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblMachineName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtException;
		private System.Windows.Forms.PictureBox picLogLevel;
		private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblException;
    }
}