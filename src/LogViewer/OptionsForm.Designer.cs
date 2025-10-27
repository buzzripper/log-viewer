namespace LogViewer
{
    partial class OptionsForm
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
            btnOk = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            numAutoRefreshTimeoutTimerIntervalMs = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            numAutoRefreshTimerIntervalMs = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numAutoRefreshTimeoutTimerIntervalMs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAutoRefreshTimerIntervalMs).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnOk.BackColor = System.Drawing.SystemColors.Control;
            btnOk.Font = new System.Drawing.Font("Segoe UI", 11F);
            btnOk.ForeColor = System.Drawing.SystemColors.ControlText;
            btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOk.Location = new System.Drawing.Point(74, 111);
            btnOk.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(98, 38);
            btnOk.TabIndex = 41;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += this.btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCancel.BackColor = System.Drawing.SystemColors.Control;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F);
            btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancel.Location = new System.Drawing.Point(180, 111);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(96, 38);
            btnCancel.TabIndex = 42;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(36, 27);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(148, 20);
            label1.TabIndex = 43;
            label1.Text = "Auto-refresh Interval:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(284, 27);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 20);
            label2.TabIndex = 45;
            label2.Text = "secs.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(283, 60);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(40, 20);
            label3.TabIndex = 48;
            label3.Text = "mins";
            // 
            // numAutoRefreshTimeoutTimerIntervalMs
            // 
            numAutoRefreshTimeoutTimerIntervalMs.Location = new System.Drawing.Point(191, 58);
            numAutoRefreshTimeoutTimerIntervalMs.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numAutoRefreshTimeoutTimerIntervalMs.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAutoRefreshTimeoutTimerIntervalMs.Name = "numAutoRefreshTimeoutTimerIntervalMs";
            numAutoRefreshTimeoutTimerIntervalMs.Size = new System.Drawing.Size(85, 27);
            numAutoRefreshTimeoutTimerIntervalMs.TabIndex = 47;
            numAutoRefreshTimeoutTimerIntervalMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            numAutoRefreshTimeoutTimerIntervalMs.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(36, 60);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(154, 20);
            label4.TabIndex = 46;
            label4.Text = "Auto-refresh Timeout:";
            // 
            // numAutoRefreshTimerIntervalMs
            // 
            numAutoRefreshTimerIntervalMs.Location = new System.Drawing.Point(191, 25);
            numAutoRefreshTimerIntervalMs.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numAutoRefreshTimerIntervalMs.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numAutoRefreshTimerIntervalMs.Name = "numAutoRefreshTimerIntervalMs";
            numAutoRefreshTimerIntervalMs.Size = new System.Drawing.Size(85, 27);
            numAutoRefreshTimerIntervalMs.TabIndex = 49;
            numAutoRefreshTimerIntervalMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            numAutoRefreshTimerIntervalMs.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // OptionsForm
            // 
            this.AcceptButton = btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = btnCancel;
            this.ClientSize = new System.Drawing.Size(364, 164);
            this.ControlBox = false;
            this.Controls.Add(numAutoRefreshTimerIntervalMs);
            this.Controls.Add(label3);
            this.Controls.Add(numAutoRefreshTimeoutTimerIntervalMs);
            this.Controls.Add(label4);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(btnCancel);
            this.Controls.Add(btnOk);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)numAutoRefreshTimeoutTimerIntervalMs).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAutoRefreshTimerIntervalMs).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numAutoRefreshTimeoutTimerIntervalMs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAutoRefreshTimerIntervalMs;
    }
}