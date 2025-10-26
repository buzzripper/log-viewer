namespace LogViewer
{
    partial class WaitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitForm));
            label1 = new System.Windows.Forms.Label();
            lblDbConnName = new System.Windows.Forms.Label();
            picSpinner = new System.Windows.Forms.PictureBox();
            lkbCancel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)picSpinner).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.Location = new System.Drawing.Point(0, 9);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(260, 26);
            label1.TabIndex = 0;
            label1.Text = "Opening database connection";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDbConnName
            // 
            lblDbConnName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDbConnName.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblDbConnName.Location = new System.Drawing.Point(0, 35);
            lblDbConnName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDbConnName.Name = "lblDbConnName";
            lblDbConnName.Size = new System.Drawing.Size(260, 36);
            lblDbConnName.TabIndex = 1;
            lblDbConnName.Text = "...";
            lblDbConnName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSpinner
            // 
            picSpinner.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            picSpinner.BackColor = System.Drawing.Color.Transparent;
            picSpinner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            picSpinner.Image = (System.Drawing.Image)resources.GetObject("picSpinner.Image");
            picSpinner.Location = new System.Drawing.Point(118, 74);
            picSpinner.Name = "picSpinner";
            picSpinner.Size = new System.Drawing.Size(42, 77);
            picSpinner.TabIndex = 3;
            picSpinner.TabStop = false;
            // 
            // lkbCancel
            // 
            lkbCancel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lkbCancel.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            lkbCancel.Location = new System.Drawing.Point(0, 154);
            lkbCancel.Name = "lkbCancel";
            lkbCancel.Size = new System.Drawing.Size(260, 22);
            lkbCancel.TabIndex = 4;
            lkbCancel.TabStop = true;
            lkbCancel.Text = "Cancel";
            lkbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lkbCancel.UseMnemonic = false;
            lkbCancel.LinkClicked += this.lkbCancel_LinkClicked;
            // 
            // WaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 185);
            this.Controls.Add(lkbCancel);
            this.Controls.Add(picSpinner);
            this.Controls.Add(lblDbConnName);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WaitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OpenDbConnForm";
            ((System.ComponentModel.ISupportInitialize)picSpinner).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDbConnName;
        private System.Windows.Forms.PictureBox picSpinner;
        private System.Windows.Forms.LinkLabel lkbCancel;
    }
}