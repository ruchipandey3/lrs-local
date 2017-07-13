using ButlerIIApp.Model;

namespace ButlerIIApp
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
            //ButlerConfigurationModel ButlerConfigModel = new ButlerConfigurationModel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butlerIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beachButlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beachButler2ButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReadButler = new System.Windows.Forms.Button();
            this.btnUpdateButler = new System.Windows.Forms.Button();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtFirmware = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlButler = new System.Windows.Forms.TabControl();
            this.tabButtonsandInputs = new System.Windows.Forms.TabPage();
            this.tabAdvancedFeatures = new System.Windows.Forms.TabPage();
            this.buttonInputTabView1 = new ButlerIIApp.Views.ButtonInputTabView(ButlerConfigModel.ButtonInputTabModel);
            this.menuStrip1.SuspendLayout();
            this.tabControlButler.SuspendLayout();
            this.tabButtonsandInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadConfigurationToolStripMenuItem,
            this.saveConfigurationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadConfigurationToolStripMenuItem
            // 
            this.loadConfigurationToolStripMenuItem.Name = "loadConfigurationToolStripMenuItem";
            this.loadConfigurationToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.loadConfigurationToolStripMenuItem.Text = "Load Configuration";
            // 
            // saveConfigurationToolStripMenuItem
            // 
            this.saveConfigurationToolStripMenuItem.Name = "saveConfigurationToolStripMenuItem";
            this.saveConfigurationToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveConfigurationToolStripMenuItem.Text = "Save Configuration";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectDeviceToolStripMenuItem,
            this.programDeviceToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // selectDeviceToolStripMenuItem
            // 
            this.selectDeviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butlerIIToolStripMenuItem,
            this.beachButlerToolStripMenuItem,
            this.beachButler2ButtonToolStripMenuItem});
            this.selectDeviceToolStripMenuItem.Name = "selectDeviceToolStripMenuItem";
            this.selectDeviceToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.selectDeviceToolStripMenuItem.Text = "Select Device";
            // 
            // butlerIIToolStripMenuItem
            // 
            this.butlerIIToolStripMenuItem.Name = "butlerIIToolStripMenuItem";
            this.butlerIIToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.butlerIIToolStripMenuItem.Text = "Butler II";
            // 
            // beachButlerToolStripMenuItem
            // 
            this.beachButlerToolStripMenuItem.Name = "beachButlerToolStripMenuItem";
            this.beachButlerToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.beachButlerToolStripMenuItem.Text = "Beach Butler";
            // 
            // beachButler2ButtonToolStripMenuItem
            // 
            this.beachButler2ButtonToolStripMenuItem.Name = "beachButler2ButtonToolStripMenuItem";
            this.beachButler2ButtonToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.beachButler2ButtonToolStripMenuItem.Text = "Beach Butler -2 Button";
            // 
            // programDeviceToolStripMenuItem
            // 
            this.programDeviceToolStripMenuItem.Name = "programDeviceToolStripMenuItem";
            this.programDeviceToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.programDeviceToolStripMenuItem.Text = "Program Device";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnReadButler
            // 
            this.btnReadButler.Location = new System.Drawing.Point(339, 574);
            this.btnReadButler.Name = "btnReadButler";
            this.btnReadButler.Size = new System.Drawing.Size(93, 71);
            this.btnReadButler.TabIndex = 2;
            this.btnReadButler.Text = "Read\r\nButler\r\n";
            this.btnReadButler.UseVisualStyleBackColor = true;
            // 
            // btnUpdateButler
            // 
            this.btnUpdateButler.Location = new System.Drawing.Point(450, 574);
            this.btnUpdateButler.Name = "btnUpdateButler";
            this.btnUpdateButler.Size = new System.Drawing.Size(93, 71);
            this.btnUpdateButler.TabIndex = 3;
            this.btnUpdateButler.Text = "Update\r\nButler";
            this.btnUpdateButler.UseVisualStyleBackColor = true;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(662, 578);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(47, 26);
            this.lblSerialNo.TabIndex = 4;
            this.lblSerialNo.Text = "Serial\r\nNumber:";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(715, 584);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(294, 20);
            this.txtSerialNumber.TabIndex = 5;
            // 
            // txtFirmware
            // 
            this.txtFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirmware.Location = new System.Drawing.Point(715, 611);
            this.txtFirmware.Name = "txtFirmware";
            this.txtFirmware.Size = new System.Drawing.Size(294, 20);
            this.txtFirmware.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Firmware:";
            // 
            // tabControlButler
            // 
            this.tabControlButler.Controls.Add(this.tabButtonsandInputs);
            this.tabControlButler.Controls.Add(this.tabAdvancedFeatures);
            this.tabControlButler.Location = new System.Drawing.Point(13, 28);
            this.tabControlButler.Name = "tabControlButler";
            this.tabControlButler.SelectedIndex = 0;
            this.tabControlButler.Size = new System.Drawing.Size(1001, 533);
            this.tabControlButler.TabIndex = 8;
            // 
            // tabButtonsandInputs
            // 
            this.tabButtonsandInputs.Controls.Add(this.buttonInputTabView1);
            this.tabButtonsandInputs.Location = new System.Drawing.Point(4, 22);
            this.tabButtonsandInputs.Name = "tabButtonsandInputs";
            this.tabButtonsandInputs.Padding = new System.Windows.Forms.Padding(3);
            this.tabButtonsandInputs.Size = new System.Drawing.Size(993, 507);
            this.tabButtonsandInputs.TabIndex = 0;
            this.tabButtonsandInputs.Text = "Buttons and Inputs";
            this.tabButtonsandInputs.UseVisualStyleBackColor = true;
            // 
            // tabAdvancedFeatures
            // 
            this.tabAdvancedFeatures.Location = new System.Drawing.Point(4, 22);
            this.tabAdvancedFeatures.Name = "tabAdvancedFeatures";
            this.tabAdvancedFeatures.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvancedFeatures.Size = new System.Drawing.Size(993, 507);
            this.tabAdvancedFeatures.TabIndex = 1;
            this.tabAdvancedFeatures.Text = "Advanced Features";
            this.tabAdvancedFeatures.UseVisualStyleBackColor = true;
            // 
            // buttonInputTabView1
            // 
            this.buttonInputTabView1.AutoSize = true;
            this.buttonInputTabView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInputTabView1.Location = new System.Drawing.Point(3, 3);
            this.buttonInputTabView1.Name = "buttonInputTabView1";
            this.buttonInputTabView1.Size = new System.Drawing.Size(987, 501);
            this.buttonInputTabView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 657);
            this.Controls.Add(this.tabControlButler);
            this.Controls.Add(this.txtFirmware);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.lblSerialNo);
            this.Controls.Add(this.btnUpdateButler);
            this.Controls.Add(this.btnReadButler);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlButler.ResumeLayout(false);
            this.tabButtonsandInputs.ResumeLayout(false);
            this.tabButtonsandInputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem butlerIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beachButlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beachButler2ButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnReadButler;
        private System.Windows.Forms.Button btnUpdateButler;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtFirmware;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlButler;
        private System.Windows.Forms.TabPage tabButtonsandInputs;
        private Views.ButtonInputTabView buttonInputTabView1;
        private System.Windows.Forms.TabPage tabAdvancedFeatures;
    }
}

