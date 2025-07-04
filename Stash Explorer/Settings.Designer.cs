namespace Stash_Explorer
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.SysTrayMinimiseBox = new System.Windows.Forms.CheckBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelURLExplain = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxStartup = new System.Windows.Forms.GroupBox();
            this.textBoxTag = new System.Windows.Forms.TextBox();
            this.textBoxGallery = new System.Windows.Forms.TextBox();
            this.textBoxPerformer = new System.Windows.Forms.TextBox();
            this.radioButtonTag = new System.Windows.Forms.RadioButton();
            this.radioButtonGallery = new System.Windows.Forms.RadioButton();
            this.radioButtonPerformer = new System.Windows.Forms.RadioButton();
            this.SystemTrayButton = new System.Windows.Forms.RadioButton();
            this.NothingButton = new System.Windows.Forms.RadioButton();
            this.Label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxStartup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 309);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GroupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 283);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stash Explorer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.SysTrayMinimiseBox);
            this.GroupBox4.Controls.Add(this.Label7);
            this.GroupBox4.Location = new System.Drawing.Point(6, 150);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(414, 79);
            this.GroupBox4.TabIndex = 3;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Minimising";
            // 
            // SysTrayMinimiseBox
            // 
            this.SysTrayMinimiseBox.AutoSize = true;
            this.SysTrayMinimiseBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SysTrayMinimiseBox.Location = new System.Drawing.Point(9, 52);
            this.SysTrayMinimiseBox.Name = "SysTrayMinimiseBox";
            this.SysTrayMinimiseBox.Size = new System.Drawing.Size(139, 18);
            this.SysTrayMinimiseBox.TabIndex = 2;
            this.SysTrayMinimiseBox.Text = "Minimise to system tray";
            this.SysTrayMinimiseBox.UseVisualStyleBackColor = true;
            this.SysTrayMinimiseBox.CheckedChanged += new System.EventHandler(this.SysTrayMinimiseBox_CheckedChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(6, 16);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(384, 26);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "When minimising Stash Explorer, it will hide itself in the system tray and run in" +
    " the\r\nbackground.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelURLExplain);
            this.groupBox1.Controls.Add(this.textBoxURL);
            this.groupBox1.Controls.Add(this.labelURL);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stashapp Location Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "WARNING: Your Stashapp URL must be formatted like the example above.\r\nIf not, you" +
    " could break the navigation in this app.";
            // 
            // labelURLExplain
            // 
            this.labelURLExplain.AutoSize = true;
            this.labelURLExplain.Location = new System.Drawing.Point(6, 16);
            this.labelURLExplain.Name = "labelURLExplain";
            this.labelURLExplain.Size = new System.Drawing.Size(391, 39);
            this.labelURLExplain.TabIndex = 2;
            this.labelURLExplain.Text = resources.GetString("labelURLExplain.Text");
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(111, 73);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(297, 20);
            this.textBoxURL.TabIndex = 0;
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(6, 76);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(99, 13);
            this.labelURL.TabIndex = 1;
            this.labelURL.Text = "Stashapp Location:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxStartup);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Start-up";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxStartup
            // 
            this.groupBoxStartup.Controls.Add(this.textBoxTag);
            this.groupBoxStartup.Controls.Add(this.textBoxGallery);
            this.groupBoxStartup.Controls.Add(this.textBoxPerformer);
            this.groupBoxStartup.Controls.Add(this.radioButtonTag);
            this.groupBoxStartup.Controls.Add(this.radioButtonGallery);
            this.groupBoxStartup.Controls.Add(this.radioButtonPerformer);
            this.groupBoxStartup.Controls.Add(this.SystemTrayButton);
            this.groupBoxStartup.Controls.Add(this.NothingButton);
            this.groupBoxStartup.Controls.Add(this.Label6);
            this.groupBoxStartup.Location = new System.Drawing.Point(6, 6);
            this.groupBoxStartup.Name = "groupBoxStartup";
            this.groupBoxStartup.Size = new System.Drawing.Size(414, 179);
            this.groupBoxStartup.TabIndex = 0;
            this.groupBoxStartup.TabStop = false;
            this.groupBoxStartup.Text = "Start-up Settings";
            // 
            // textBoxTag
            // 
            this.textBoxTag.Enabled = false;
            this.textBoxTag.Location = new System.Drawing.Point(145, 145);
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(263, 20);
            this.textBoxTag.TabIndex = 12;
            this.textBoxTag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTag_KeyPress);
            // 
            // textBoxGallery
            // 
            this.textBoxGallery.Enabled = false;
            this.textBoxGallery.Location = new System.Drawing.Point(145, 122);
            this.textBoxGallery.Name = "textBoxGallery";
            this.textBoxGallery.Size = new System.Drawing.Size(263, 20);
            this.textBoxGallery.TabIndex = 11;
            this.textBoxGallery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGallery_KeyPress);
            // 
            // textBoxPerformer
            // 
            this.textBoxPerformer.Enabled = false;
            this.textBoxPerformer.Location = new System.Drawing.Point(145, 99);
            this.textBoxPerformer.Name = "textBoxPerformer";
            this.textBoxPerformer.Size = new System.Drawing.Size(263, 20);
            this.textBoxPerformer.TabIndex = 10;
            this.textBoxPerformer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPerformer_KeyPress);
            // 
            // radioButtonTag
            // 
            this.radioButtonTag.AutoSize = true;
            this.radioButtonTag.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonTag.Location = new System.Drawing.Point(9, 146);
            this.radioButtonTag.Name = "radioButtonTag";
            this.radioButtonTag.Size = new System.Drawing.Size(107, 18);
            this.radioButtonTag.TabIndex = 9;
            this.radioButtonTag.TabStop = true;
            this.radioButtonTag.Text = "Navigate to tag:";
            this.radioButtonTag.UseVisualStyleBackColor = true;
            this.radioButtonTag.CheckedChanged += new System.EventHandler(this.radioButtonTag_CheckedChanged);
            // 
            // radioButtonGallery
            // 
            this.radioButtonGallery.AutoSize = true;
            this.radioButtonGallery.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonGallery.Location = new System.Drawing.Point(9, 123);
            this.radioButtonGallery.Name = "radioButtonGallery";
            this.radioButtonGallery.Size = new System.Drawing.Size(122, 18);
            this.radioButtonGallery.TabIndex = 8;
            this.radioButtonGallery.TabStop = true;
            this.radioButtonGallery.Text = "Navigate to gallery:";
            this.radioButtonGallery.UseVisualStyleBackColor = true;
            this.radioButtonGallery.CheckedChanged += new System.EventHandler(this.radioButtonGallery_CheckedChanged);
            // 
            // radioButtonPerformer
            // 
            this.radioButtonPerformer.AutoSize = true;
            this.radioButtonPerformer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonPerformer.Location = new System.Drawing.Point(9, 100);
            this.radioButtonPerformer.Name = "radioButtonPerformer";
            this.radioButtonPerformer.Size = new System.Drawing.Size(136, 18);
            this.radioButtonPerformer.TabIndex = 7;
            this.radioButtonPerformer.TabStop = true;
            this.radioButtonPerformer.Text = "Navigate to performer:";
            this.radioButtonPerformer.UseVisualStyleBackColor = true;
            this.radioButtonPerformer.CheckedChanged += new System.EventHandler(this.radioButtonPerformer_CheckedChanged);
            // 
            // SystemTrayButton
            // 
            this.SystemTrayButton.AutoSize = true;
            this.SystemTrayButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SystemTrayButton.Location = new System.Drawing.Point(9, 77);
            this.SystemTrayButton.Name = "SystemTrayButton";
            this.SystemTrayButton.Size = new System.Drawing.Size(138, 18);
            this.SystemTrayButton.TabIndex = 6;
            this.SystemTrayButton.TabStop = true;
            this.SystemTrayButton.Text = "Minimise to system tray";
            this.SystemTrayButton.UseVisualStyleBackColor = true;
            this.SystemTrayButton.CheckedChanged += new System.EventHandler(this.SystemTrayButton_CheckedChanged);
            // 
            // NothingButton
            // 
            this.NothingButton.AutoSize = true;
            this.NothingButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NothingButton.Location = new System.Drawing.Point(9, 54);
            this.NothingButton.Name = "NothingButton";
            this.NothingButton.Size = new System.Drawing.Size(68, 18);
            this.NothingButton.TabIndex = 5;
            this.NothingButton.TabStop = true;
            this.NothingButton.Text = "Nothing";
            this.NothingButton.UseVisualStyleBackColor = true;
            this.NothingButton.CheckedChanged += new System.EventHandler(this.NothingButton_CheckedChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(6, 16);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(407, 26);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "Set how you want Stash Explorer to start. When starting to a performer, gallery o" +
    "r tag,\r\nuse the ID corresponding to the item you want to start at.";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 334);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stash Explorer Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBoxStartup.ResumeLayout(false);
            this.groupBoxStartup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelURLExplain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxStartup;
        internal System.Windows.Forms.RadioButton radioButtonTag;
        internal System.Windows.Forms.RadioButton radioButtonGallery;
        internal System.Windows.Forms.RadioButton radioButtonPerformer;
        internal System.Windows.Forms.RadioButton SystemTrayButton;
        internal System.Windows.Forms.RadioButton NothingButton;
        internal System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox textBoxTag;
        private System.Windows.Forms.TextBox textBoxGallery;
        private System.Windows.Forms.TextBox textBoxPerformer;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.CheckBox SysTrayMinimiseBox;
        internal System.Windows.Forms.Label Label7;
    }
}