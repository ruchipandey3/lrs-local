namespace ButlerIIApp.Views
{
    partial class ButtonRowView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbPagerMessage = new System.Windows.Forms.ComboBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.cmbPagerVibeMode = new System.Windows.Forms.ComboBox();
            this.cmbPagerFlashMode = new System.Windows.Forms.ComboBox();
            this.cmbPagerType = new System.Windows.Forms.ComboBox();
            this.spinPagerNumber = new System.Windows.Forms.NumericUpDown();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.spinPagerNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPagerMessage
            // 
            this.cmbPagerMessage.FormattingEnabled = true;
            this.cmbPagerMessage.Location = new System.Drawing.Point(272, 12);
            this.cmbPagerMessage.Name = "cmbPagerMessage";
            this.cmbPagerMessage.Size = new System.Drawing.Size(73, 21);
            this.cmbPagerMessage.TabIndex = 25;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(272, 11);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(225, 20);
            this.txtMessage.TabIndex = 27;
            // 
            // cmbPagerVibeMode
            // 
            this.cmbPagerVibeMode.FormattingEnabled = true;
            this.cmbPagerVibeMode.Location = new System.Drawing.Point(193, 12);
            this.cmbPagerVibeMode.Name = "cmbPagerVibeMode";
            this.cmbPagerVibeMode.Size = new System.Drawing.Size(73, 21);
            this.cmbPagerVibeMode.TabIndex = 24;
            // 
            // cmbPagerFlashMode
            // 
            this.cmbPagerFlashMode.FormattingEnabled = true;
            this.cmbPagerFlashMode.Location = new System.Drawing.Point(193, 11);
            this.cmbPagerFlashMode.Name = "cmbPagerFlashMode";
            this.cmbPagerFlashMode.Size = new System.Drawing.Size(73, 21);
            this.cmbPagerFlashMode.TabIndex = 23;
            // 
            // cmbPagerType
            // 
            this.cmbPagerType.FormattingEnabled = true;
            this.cmbPagerType.Location = new System.Drawing.Point(113, 12);
            this.cmbPagerType.Name = "cmbPagerType";
            this.cmbPagerType.Size = new System.Drawing.Size(73, 21);
            this.cmbPagerType.TabIndex = 22;
            this.cmbPagerType.SelectedIndexChanged += new System.EventHandler(this.cmbPagerType_SelectedIndexChanged);
            // 
            // spinPagerNumber
            // 
            this.spinPagerNumber.Location = new System.Drawing.Point(29, 12);
            this.spinPagerNumber.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spinPagerNumber.Name = "spinPagerNumber";
            this.spinPagerNumber.Size = new System.Drawing.Size(73, 20);
            this.spinPagerNumber.TabIndex = 26;
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Location = new System.Drawing.Point(8, 14);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(15, 14);
            this.chkEnabled.TabIndex = 21;
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // ButtonRowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbPagerMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.cmbPagerFlashMode);
            this.Controls.Add(this.cmbPagerType);
            this.Controls.Add(this.spinPagerNumber);
            this.Controls.Add(this.chkEnabled);
            this.Controls.Add(this.cmbPagerVibeMode);
            this.Name = "ButtonRowView";
            this.Size = new System.Drawing.Size(505, 41);
            this.Load += new System.EventHandler(this.ButtonRowView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinPagerNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPagerMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ComboBox cmbPagerVibeMode;
        private System.Windows.Forms.ComboBox cmbPagerFlashMode;
        private System.Windows.Forms.ComboBox cmbPagerType;
        private System.Windows.Forms.NumericUpDown spinPagerNumber;
        private System.Windows.Forms.CheckBox chkEnabled;
    }
}
