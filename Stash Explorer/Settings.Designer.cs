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
            this.tpStash = new System.Windows.Forms.TabPage();
            this.groupBoxReload = new System.Windows.Forms.GroupBox();
            this.chkReload = new System.Windows.Forms.CheckBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.SysTrayMinimiseBox = new System.Windows.Forms.CheckBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.labelURLExplain = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.tpStart = new System.Windows.Forms.TabPage();
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
            this.tpPins = new System.Windows.Forms.TabPage();
            this.gbPins = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lbPinned = new System.Windows.Forms.ListBox();
            this.FavouritesLabel = new System.Windows.Forms.Label();
            this.tpContShield = new System.Windows.Forms.TabPage();
            this.gbContShield = new System.Windows.Forms.GroupBox();
            this.rbDNSC = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rbSCM = new System.Windows.Forms.RadioButton();
            this.lblContShield = new System.Windows.Forms.Label();
            this.rbSCMB = new System.Windows.Forms.RadioButton();
            this.lblSaveReminder = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbImportPins = new System.Windows.Forms.TextBox();
            this.tpAreas = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkScenes = new System.Windows.Forms.CheckBox();
            this.chkGroups = new System.Windows.Forms.CheckBox();
            this.chkImages = new System.Windows.Forms.CheckBox();
            this.chkMarkers = new System.Windows.Forms.CheckBox();
            this.chkGalleries = new System.Windows.Forms.CheckBox();
            this.chkPerformers = new System.Windows.Forms.CheckBox();
            this.chkStudios = new System.Windows.Forms.CheckBox();
            this.chkTags = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tpStash.SuspendLayout();
            this.groupBoxReload.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpStart.SuspendLayout();
            this.groupBoxStartup.SuspendLayout();
            this.tpPins.SuspendLayout();
            this.gbPins.SuspendLayout();
            this.tpContShield.SuspendLayout();
            this.gbContShield.SuspendLayout();
            this.tpAreas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpStash);
            this.tabControl1.Controls.Add(this.tpAreas);
            this.tabControl1.Controls.Add(this.tpStart);
            this.tabControl1.Controls.Add(this.tpPins);
            this.tabControl1.Controls.Add(this.tpContShield);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 309);
            this.tabControl1.TabIndex = 0;
            // 
            // tpStash
            // 
            this.tpStash.Controls.Add(this.groupBoxReload);
            this.tpStash.Controls.Add(this.GroupBox4);
            this.tpStash.Controls.Add(this.groupBox1);
            this.tpStash.Location = new System.Drawing.Point(4, 22);
            this.tpStash.Name = "tpStash";
            this.tpStash.Padding = new System.Windows.Forms.Padding(3);
            this.tpStash.Size = new System.Drawing.Size(426, 283);
            this.tpStash.TabIndex = 0;
            this.tpStash.Text = "General";
            this.tpStash.UseVisualStyleBackColor = true;
            // 
            // groupBoxReload
            // 
            this.groupBoxReload.Controls.Add(this.chkReload);
            this.groupBoxReload.Location = new System.Drawing.Point(6, 226);
            this.groupBoxReload.Name = "groupBoxReload";
            this.groupBoxReload.Size = new System.Drawing.Size(414, 51);
            this.groupBoxReload.TabIndex = 4;
            this.groupBoxReload.TabStop = false;
            this.groupBoxReload.Text = "Other Settings";
            // 
            // chkReload
            // 
            this.chkReload.AutoSize = true;
            this.chkReload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkReload.Location = new System.Drawing.Point(9, 21);
            this.chkReload.Name = "chkReload";
            this.chkReload.Size = new System.Drawing.Size(235, 18);
            this.chkReload.TabIndex = 2;
            this.chkReload.Text = "Reload Stashapp when closing settings";
            this.chkReload.UseVisualStyleBackColor = true;
            this.chkReload.CheckedChanged += new System.EventHandler(this.checkBoxReload_CheckedChanged);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.SysTrayMinimiseBox);
            this.GroupBox4.Controls.Add(this.Label7);
            this.GroupBox4.Location = new System.Drawing.Point(6, 141);
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
            this.SysTrayMinimiseBox.Size = new System.Drawing.Size(151, 18);
            this.SysTrayMinimiseBox.TabIndex = 1;
            this.SysTrayMinimiseBox.Text = "Minimise to system tray";
            this.SysTrayMinimiseBox.UseVisualStyleBackColor = true;
            this.SysTrayMinimiseBox.CheckedChanged += new System.EventHandler(this.SysTrayMinimiseBox_CheckedChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(6, 16);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(397, 26);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "When minimising Stash Explorer, it will hide itself in the system tray and run\r\ni" +
    "n the background.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblWarning);
            this.groupBox1.Controls.Add(this.labelURLExplain);
            this.groupBox1.Controls.Add(this.textBoxURL);
            this.groupBox1.Controls.Add(this.labelURL);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stashapp Location Settings";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(6, 94);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(382, 26);
            this.lblWarning.TabIndex = 3;
            this.lblWarning.Text = "WARNING: Your Stashapp URL must be formatted like the example above.\r\nIf not, you" +
    " could break the navigation in this app.";
            // 
            // labelURLExplain
            // 
            this.labelURLExplain.AutoSize = true;
            this.labelURLExplain.Location = new System.Drawing.Point(6, 16);
            this.labelURLExplain.Name = "labelURLExplain";
            this.labelURLExplain.Size = new System.Drawing.Size(383, 39);
            this.labelURLExplain.TabIndex = 2;
            this.labelURLExplain.Text = resources.GetString("labelURLExplain.Text");
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(111, 62);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(297, 22);
            this.textBoxURL.TabIndex = 0;
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(6, 65);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(105, 13);
            this.labelURL.TabIndex = 1;
            this.labelURL.Text = "Stashapp Location:";
            // 
            // tpStart
            // 
            this.tpStart.Controls.Add(this.groupBoxStartup);
            this.tpStart.Location = new System.Drawing.Point(4, 22);
            this.tpStart.Name = "tpStart";
            this.tpStart.Padding = new System.Windows.Forms.Padding(3);
            this.tpStart.Size = new System.Drawing.Size(426, 283);
            this.tpStart.TabIndex = 1;
            this.tpStart.Text = "Start-up";
            this.tpStart.UseVisualStyleBackColor = true;
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
            this.textBoxTag.Size = new System.Drawing.Size(263, 22);
            this.textBoxTag.TabIndex = 7;
            this.textBoxTag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTag_KeyPress);
            // 
            // textBoxGallery
            // 
            this.textBoxGallery.Enabled = false;
            this.textBoxGallery.Location = new System.Drawing.Point(145, 122);
            this.textBoxGallery.Name = "textBoxGallery";
            this.textBoxGallery.Size = new System.Drawing.Size(263, 22);
            this.textBoxGallery.TabIndex = 5;
            this.textBoxGallery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGallery_KeyPress);
            // 
            // textBoxPerformer
            // 
            this.textBoxPerformer.Enabled = false;
            this.textBoxPerformer.Location = new System.Drawing.Point(145, 99);
            this.textBoxPerformer.Name = "textBoxPerformer";
            this.textBoxPerformer.Size = new System.Drawing.Size(263, 22);
            this.textBoxPerformer.TabIndex = 3;
            this.textBoxPerformer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPerformer_KeyPress);
            // 
            // radioButtonTag
            // 
            this.radioButtonTag.AutoSize = true;
            this.radioButtonTag.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonTag.Location = new System.Drawing.Point(9, 146);
            this.radioButtonTag.Name = "radioButtonTag";
            this.radioButtonTag.Size = new System.Drawing.Size(113, 18);
            this.radioButtonTag.TabIndex = 6;
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
            this.radioButtonGallery.Size = new System.Drawing.Size(130, 18);
            this.radioButtonGallery.TabIndex = 4;
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
            this.radioButtonPerformer.Size = new System.Drawing.Size(147, 18);
            this.radioButtonPerformer.TabIndex = 2;
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
            this.SystemTrayButton.Size = new System.Drawing.Size(150, 18);
            this.SystemTrayButton.TabIndex = 1;
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
            this.NothingButton.Size = new System.Drawing.Size(74, 18);
            this.NothingButton.TabIndex = 0;
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
            this.Label6.Size = new System.Drawing.Size(378, 26);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "Set how you want Stash Explorer to start. When starting to a performer,\r\ngallery " +
    "or tag, use the ID corresponding to the item you want to start at.";
            // 
            // tpPins
            // 
            this.tpPins.Controls.Add(this.gbPins);
            this.tpPins.Location = new System.Drawing.Point(4, 22);
            this.tpPins.Name = "tpPins";
            this.tpPins.Padding = new System.Windows.Forms.Padding(3);
            this.tpPins.Size = new System.Drawing.Size(426, 283);
            this.tpPins.TabIndex = 2;
            this.tpPins.Text = "Pins";
            this.tpPins.UseVisualStyleBackColor = true;
            // 
            // gbPins
            // 
            this.gbPins.Controls.Add(this.tbImportPins);
            this.gbPins.Controls.Add(this.btnImport);
            this.gbPins.Controls.Add(this.btnExport);
            this.gbPins.Controls.Add(this.btnDel);
            this.gbPins.Controls.Add(this.btnDelAll);
            this.gbPins.Controls.Add(this.btnOpen);
            this.gbPins.Controls.Add(this.lbPinned);
            this.gbPins.Controls.Add(this.FavouritesLabel);
            this.gbPins.Location = new System.Drawing.Point(6, 6);
            this.gbPins.Name = "gbPins";
            this.gbPins.Size = new System.Drawing.Size(414, 271);
            this.gbPins.TabIndex = 4;
            this.gbPins.TabStop = false;
            this.gbPins.Text = "Pin Settings";
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDel.Location = new System.Drawing.Point(252, 239);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelAll.Location = new System.Drawing.Point(333, 239);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(75, 23);
            this.btnDelAll.TabIndex = 6;
            this.btnDelAll.Text = "Delete All";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpen.Location = new System.Drawing.Point(6, 239);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lbPinned
            // 
            this.lbPinned.FormattingEnabled = true;
            this.lbPinned.Location = new System.Drawing.Point(6, 73);
            this.lbPinned.Name = "lbPinned";
            this.lbPinned.Size = new System.Drawing.Size(402, 160);
            this.lbPinned.TabIndex = 4;
            // 
            // FavouritesLabel
            // 
            this.FavouritesLabel.AutoSize = true;
            this.FavouritesLabel.Location = new System.Drawing.Point(6, 18);
            this.FavouritesLabel.Name = "FavouritesLabel";
            this.FavouritesLabel.Size = new System.Drawing.Size(392, 39);
            this.FavouritesLabel.TabIndex = 3;
            this.FavouritesLabel.Text = "Below is a list of performers you have saved. Performers cannot be saved in\r\nthe " +
    "INI file, so it\'s best to export them manually and import them when the\r\napp upd" +
    "ates.";
            // 
            // tpContShield
            // 
            this.tpContShield.Controls.Add(this.gbContShield);
            this.tpContShield.Location = new System.Drawing.Point(4, 22);
            this.tpContShield.Name = "tpContShield";
            this.tpContShield.Padding = new System.Windows.Forms.Padding(3);
            this.tpContShield.Size = new System.Drawing.Size(426, 283);
            this.tpContShield.TabIndex = 3;
            this.tpContShield.Text = "Content Shield";
            this.tpContShield.UseVisualStyleBackColor = true;
            // 
            // gbContShield
            // 
            this.gbContShield.Controls.Add(this.rbDNSC);
            this.gbContShield.Controls.Add(this.checkBox1);
            this.gbContShield.Controls.Add(this.rbSCM);
            this.gbContShield.Controls.Add(this.lblContShield);
            this.gbContShield.Controls.Add(this.rbSCMB);
            this.gbContShield.Location = new System.Drawing.Point(6, 6);
            this.gbContShield.Name = "gbContShield";
            this.gbContShield.Size = new System.Drawing.Size(414, 126);
            this.gbContShield.TabIndex = 4;
            this.gbContShield.TabStop = false;
            this.gbContShield.Text = "Content Shield Settings";
            // 
            // rbDNSC
            // 
            this.rbDNSC.AutoSize = true;
            this.rbDNSC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbDNSC.Location = new System.Drawing.Point(9, 55);
            this.rbDNSC.Name = "rbDNSC";
            this.rbDNSC.Size = new System.Drawing.Size(144, 18);
            this.rbDNSC.TabIndex = 6;
            this.rbDNSC.TabStop = true;
            this.rbDNSC.Text = "Do not shield content";
            this.rbDNSC.UseVisualStyleBackColor = true;
            this.rbDNSC.CheckedChanged += new System.EventHandler(this.rbDNSC_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(162, 115);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(25, 5);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rbSCM
            // 
            this.rbSCM.AutoSize = true;
            this.rbSCM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbSCM.Location = new System.Drawing.Point(9, 78);
            this.rbSCM.Name = "rbSCM";
            this.rbSCM.Size = new System.Drawing.Size(192, 18);
            this.rbSCM.TabIndex = 2;
            this.rbSCM.TabStop = true;
            this.rbSCM.Text = "Shield content while minimised";
            this.rbSCM.UseVisualStyleBackColor = true;
            this.rbSCM.CheckedChanged += new System.EventHandler(this.rbSCM_CheckedChanged);
            // 
            // lblContShield
            // 
            this.lblContShield.AutoSize = true;
            this.lblContShield.Location = new System.Drawing.Point(6, 16);
            this.lblContShield.Name = "lblContShield";
            this.lblContShield.Size = new System.Drawing.Size(397, 26);
            this.lblContShield.TabIndex = 0;
            this.lblContShield.Text = "Content Shield stops onlookers from seeing what you\'re looking at on your\r\nStasha" +
    "pp. This is useful if you\'re in an unsafe place to view pornography.";
            // 
            // rbSCMB
            // 
            this.rbSCMB.AutoSize = true;
            this.rbSCMB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbSCMB.Location = new System.Drawing.Point(9, 101);
            this.rbSCMB.Name = "rbSCMB";
            this.rbSCMB.Size = new System.Drawing.Size(325, 18);
            this.rbSCMB.TabIndex = 3;
            this.rbSCMB.TabStop = true;
            this.rbSCMB.Text = "Shield content while minimised and while in background";
            this.rbSCMB.UseVisualStyleBackColor = true;
            this.rbSCMB.CheckedChanged += new System.EventHandler(this.rbSCMB_CheckedChanged);
            // 
            // lblSaveReminder
            // 
            this.lblSaveReminder.AutoSize = true;
            this.lblSaveReminder.Location = new System.Drawing.Point(309, -2);
            this.lblSaveReminder.Name = "lblSaveReminder";
            this.lblSaveReminder.Size = new System.Drawing.Size(152, 13);
            this.lblSaveReminder.TabIndex = 5;
            this.lblSaveReminder.Text = " Settings are saved on close.";
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExport.Location = new System.Drawing.Point(333, 47);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export...";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImport.Location = new System.Drawing.Point(252, 47);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "Import...";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbImportPins
            // 
            this.tbImportPins.Location = new System.Drawing.Point(137, 47);
            this.tbImportPins.Name = "tbImportPins";
            this.tbImportPins.Size = new System.Drawing.Size(100, 22);
            this.tbImportPins.TabIndex = 10;
            this.tbImportPins.Visible = false;
            // 
            // tpAreas
            // 
            this.tpAreas.Controls.Add(this.groupBox2);
            this.tpAreas.Location = new System.Drawing.Point(4, 22);
            this.tpAreas.Name = "tpAreas";
            this.tpAreas.Padding = new System.Windows.Forms.Padding(3);
            this.tpAreas.Size = new System.Drawing.Size(426, 283);
            this.tpAreas.TabIndex = 4;
            this.tpAreas.Text = "Areas";
            this.tpAreas.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTags);
            this.groupBox2.Controls.Add(this.chkStudios);
            this.groupBox2.Controls.Add(this.chkPerformers);
            this.groupBox2.Controls.Add(this.chkGalleries);
            this.groupBox2.Controls.Add(this.chkMarkers);
            this.groupBox2.Controls.Add(this.chkImages);
            this.groupBox2.Controls.Add(this.chkGroups);
            this.groupBox2.Controls.Add(this.chkScenes);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 226);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Start-up Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select the areas which you want to be visible in Stash Explorer.";
            // 
            // chkScenes
            // 
            this.chkScenes.AutoSize = true;
            this.chkScenes.Location = new System.Drawing.Point(9, 41);
            this.chkScenes.Name = "chkScenes";
            this.chkScenes.Size = new System.Drawing.Size(99, 17);
            this.chkScenes.TabIndex = 5;
            this.chkScenes.Text = "Enable Scenes";
            this.chkScenes.UseVisualStyleBackColor = true;
            this.chkScenes.CheckedChanged += new System.EventHandler(this.chkScenes_CheckedChanged);
            // 
            // chkGroups
            // 
            this.chkGroups.AutoSize = true;
            this.chkGroups.Location = new System.Drawing.Point(9, 87);
            this.chkGroups.Name = "chkGroups";
            this.chkGroups.Size = new System.Drawing.Size(102, 17);
            this.chkGroups.TabIndex = 6;
            this.chkGroups.Text = "Enable Groups";
            this.chkGroups.UseVisualStyleBackColor = true;
            this.chkGroups.CheckedChanged += new System.EventHandler(this.chkGroups_CheckedChanged);
            // 
            // chkImages
            // 
            this.chkImages.AutoSize = true;
            this.chkImages.Location = new System.Drawing.Point(9, 64);
            this.chkImages.Name = "chkImages";
            this.chkImages.Size = new System.Drawing.Size(100, 17);
            this.chkImages.TabIndex = 7;
            this.chkImages.Text = "Enable Images";
            this.chkImages.UseVisualStyleBackColor = true;
            this.chkImages.CheckedChanged += new System.EventHandler(this.chkImages_CheckedChanged);
            // 
            // chkMarkers
            // 
            this.chkMarkers.AutoSize = true;
            this.chkMarkers.Location = new System.Drawing.Point(9, 110);
            this.chkMarkers.Name = "chkMarkers";
            this.chkMarkers.Size = new System.Drawing.Size(105, 17);
            this.chkMarkers.TabIndex = 8;
            this.chkMarkers.Text = "Enable Markers";
            this.chkMarkers.UseVisualStyleBackColor = true;
            this.chkMarkers.CheckedChanged += new System.EventHandler(this.chkMarkers_CheckedChanged);
            // 
            // chkGalleries
            // 
            this.chkGalleries.AutoSize = true;
            this.chkGalleries.Location = new System.Drawing.Point(9, 133);
            this.chkGalleries.Name = "chkGalleries";
            this.chkGalleries.Size = new System.Drawing.Size(108, 17);
            this.chkGalleries.TabIndex = 9;
            this.chkGalleries.Text = "Enable Galleries";
            this.chkGalleries.UseVisualStyleBackColor = true;
            this.chkGalleries.CheckedChanged += new System.EventHandler(this.chkGalleries_CheckedChanged);
            // 
            // chkPerformers
            // 
            this.chkPerformers.AutoSize = true;
            this.chkPerformers.Location = new System.Drawing.Point(9, 156);
            this.chkPerformers.Name = "chkPerformers";
            this.chkPerformers.Size = new System.Drawing.Size(119, 17);
            this.chkPerformers.TabIndex = 10;
            this.chkPerformers.Text = "Enable Performers";
            this.chkPerformers.UseVisualStyleBackColor = true;
            this.chkPerformers.CheckedChanged += new System.EventHandler(this.chkPerformers_CheckedChanged);
            // 
            // chkStudios
            // 
            this.chkStudios.AutoSize = true;
            this.chkStudios.Location = new System.Drawing.Point(9, 179);
            this.chkStudios.Name = "chkStudios";
            this.chkStudios.Size = new System.Drawing.Size(103, 17);
            this.chkStudios.TabIndex = 11;
            this.chkStudios.Text = "Enable Studios";
            this.chkStudios.UseVisualStyleBackColor = true;
            this.chkStudios.CheckedChanged += new System.EventHandler(this.chkStudios_CheckedChanged);
            // 
            // chkTags
            // 
            this.chkTags.AutoSize = true;
            this.chkTags.Location = new System.Drawing.Point(9, 202);
            this.chkTags.Name = "chkTags";
            this.chkTags.Size = new System.Drawing.Size(86, 17);
            this.chkTags.TabIndex = 12;
            this.chkTags.Text = "Enable Tags";
            this.chkTags.UseVisualStyleBackColor = true;
            this.chkTags.CheckedChanged += new System.EventHandler(this.chkTags_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 334);
            this.Controls.Add(this.lblSaveReminder);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stash Explorer Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpStash.ResumeLayout(false);
            this.groupBoxReload.ResumeLayout(false);
            this.groupBoxReload.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpStart.ResumeLayout(false);
            this.groupBoxStartup.ResumeLayout(false);
            this.groupBoxStartup.PerformLayout();
            this.tpPins.ResumeLayout(false);
            this.gbPins.ResumeLayout(false);
            this.gbPins.PerformLayout();
            this.tpContShield.ResumeLayout(false);
            this.gbContShield.ResumeLayout(false);
            this.gbContShield.PerformLayout();
            this.tpAreas.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelURLExplain;
        private System.Windows.Forms.Label lblWarning;
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
        private System.Windows.Forms.GroupBox groupBoxReload;
        private System.Windows.Forms.CheckBox chkReload;
        internal System.Windows.Forms.Label FavouritesLabel;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ListBox lbPinned;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnDelAll;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tpStash;
        public System.Windows.Forms.TabPage tpStart;
        public System.Windows.Forms.GroupBox gbPins;
        public System.Windows.Forms.TabPage tpPins;
        private System.Windows.Forms.Label lblSaveReminder;
        private System.Windows.Forms.TabPage tpContShield;
        internal System.Windows.Forms.GroupBox gbContShield;
        internal System.Windows.Forms.CheckBox checkBox1;
        internal System.Windows.Forms.Label lblContShield;
        private System.Windows.Forms.RadioButton rbSCMB;
        private System.Windows.Forms.RadioButton rbSCM;
        private System.Windows.Forms.RadioButton rbDNSC;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbImportPins;
        private System.Windows.Forms.TabPage tpAreas;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkScenes;
        private System.Windows.Forms.CheckBox chkGroups;
        private System.Windows.Forms.CheckBox chkImages;
        private System.Windows.Forms.CheckBox chkTags;
        private System.Windows.Forms.CheckBox chkStudios;
        private System.Windows.Forms.CheckBox chkPerformers;
        private System.Windows.Forms.CheckBox chkGalleries;
        private System.Windows.Forms.CheckBox chkMarkers;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}