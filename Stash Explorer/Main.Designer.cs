namespace Stash_Explorer
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.createSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createGalleryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPerformerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createStudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stashappStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stashappSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stashExplorerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyboardShortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleTimer = new System.Windows.Forms.Timer(this.components);
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.ContentTimer = new System.Windows.Forms.Timer(this.components);
            this.sysTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.sysTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.scenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galleriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.sysTrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.stashToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.toolStripSeparator2,
            this.createSceneToolStripMenuItem,
            this.createGalleryToolStripMenuItem,
            this.createPerformerToolStripMenuItem,
            this.createStudioToolStripMenuItem,
            this.createTagToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newWindowToolStripMenuItem.Text = "New window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // createSceneToolStripMenuItem
            // 
            this.createSceneToolStripMenuItem.Name = "createSceneToolStripMenuItem";
            this.createSceneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createSceneToolStripMenuItem.Text = "Create scene";
            this.createSceneToolStripMenuItem.Click += new System.EventHandler(this.createSceneToolStripMenuItem_Click);
            // 
            // createGalleryToolStripMenuItem
            // 
            this.createGalleryToolStripMenuItem.Name = "createGalleryToolStripMenuItem";
            this.createGalleryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createGalleryToolStripMenuItem.Text = "Create gallery";
            this.createGalleryToolStripMenuItem.Click += new System.EventHandler(this.createGalleryToolStripMenuItem_Click);
            // 
            // createPerformerToolStripMenuItem
            // 
            this.createPerformerToolStripMenuItem.Name = "createPerformerToolStripMenuItem";
            this.createPerformerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createPerformerToolStripMenuItem.Text = "Create performer";
            this.createPerformerToolStripMenuItem.Click += new System.EventHandler(this.createPerformerToolStripMenuItem_Click);
            // 
            // createStudioToolStripMenuItem
            // 
            this.createStudioToolStripMenuItem.Name = "createStudioToolStripMenuItem";
            this.createStudioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createStudioToolStripMenuItem.Text = "Create studio";
            this.createStudioToolStripMenuItem.Click += new System.EventHandler(this.createStudioToolStripMenuItem_Click);
            // 
            // createTagToolStripMenuItem
            // 
            this.createTagToolStripMenuItem.Name = "createTagToolStripMenuItem";
            this.createTagToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createTagToolStripMenuItem.Text = "Create tag";
            this.createTagToolStripMenuItem.Click += new System.EventHandler(this.createTagToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // stashToolStripMenuItem
            // 
            this.stashToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stashappStatsToolStripMenuItem,
            this.stashappSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.stashExplorerSettingsToolStripMenuItem});
            this.stashToolStripMenuItem.Name = "stashToolStripMenuItem";
            this.stashToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.stashToolStripMenuItem.Text = "Stash";
            // 
            // stashappStatsToolStripMenuItem
            // 
            this.stashappStatsToolStripMenuItem.Name = "stashappStatsToolStripMenuItem";
            this.stashappStatsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.stashappStatsToolStripMenuItem.Text = "Stashapp stats";
            this.stashappStatsToolStripMenuItem.Click += new System.EventHandler(this.stashappStatsToolStripMenuItem_Click);
            // 
            // stashappSettingsToolStripMenuItem
            // 
            this.stashappSettingsToolStripMenuItem.Name = "stashappSettingsToolStripMenuItem";
            this.stashappSettingsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.stashappSettingsToolStripMenuItem.Text = "Stashapp settings";
            this.stashappSettingsToolStripMenuItem.Click += new System.EventHandler(this.stashappSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // stashExplorerSettingsToolStripMenuItem
            // 
            this.stashExplorerSettingsToolStripMenuItem.Name = "stashExplorerSettingsToolStripMenuItem";
            this.stashExplorerSettingsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.stashExplorerSettingsToolStripMenuItem.Text = "Stash Explorer settings...";
            this.stashExplorerSettingsToolStripMenuItem.Click += new System.EventHandler(this.stashExplorerSettingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyboardShortcutsToolStripMenuItem,
            this.toolStripSeparator4,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // keyboardShortcutsToolStripMenuItem
            // 
            this.keyboardShortcutsToolStripMenuItem.Enabled = false;
            this.keyboardShortcutsToolStripMenuItem.Name = "keyboardShortcutsToolStripMenuItem";
            this.keyboardShortcutsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.keyboardShortcutsToolStripMenuItem.Text = "Keyboard shortcuts...";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(182, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // TitleTimer
            // 
            this.TitleTimer.Enabled = true;
            this.TitleTimer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 24);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(804, 427);
            this.webView21.Source = new System.Uri("about:blank", System.UriKind.Absolute);
            this.webView21.TabIndex = 2;
            this.webView21.ZoomFactor = 1D;
            this.webView21.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.webView21_CoreWebView2InitializationCompleted);
            // 
            // ContentTimer
            // 
            this.ContentTimer.Tick += new System.EventHandler(this.ContentTimer_Tick);
            // 
            // sysTrayIcon
            // 
            this.sysTrayIcon.ContextMenuStrip = this.sysTrayMenu;
            this.sysTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("sysTrayIcon.Icon")));
            this.sysTrayIcon.Text = "Stash Explorer";
            this.sysTrayIcon.Visible = true;
            this.sysTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.sysTrayIcon_MouseDoubleClick);
            // 
            // sysTrayMenu
            // 
            this.sysTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.toolStripSeparator6,
            this.scenesToolStripMenuItem,
            this.imagesToolStripMenuItem,
            this.groupsToolStripMenuItem,
            this.markersToolStripMenuItem,
            this.galleriesToolStripMenuItem,
            this.performersToolStripMenuItem,
            this.studiosToolStripMenuItem,
            this.tagsToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem1});
            this.sysTrayMenu.Name = "sysTrayMenu";
            this.sysTrayMenu.Size = new System.Drawing.Size(133, 236);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(129, 6);
            // 
            // scenesToolStripMenuItem
            // 
            this.scenesToolStripMenuItem.Name = "scenesToolStripMenuItem";
            this.scenesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.scenesToolStripMenuItem.Text = "Scenes";
            this.scenesToolStripMenuItem.Click += new System.EventHandler(this.scenesToolStripMenuItem_Click);
            // 
            // imagesToolStripMenuItem
            // 
            this.imagesToolStripMenuItem.Name = "imagesToolStripMenuItem";
            this.imagesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.imagesToolStripMenuItem.Text = "Images";
            this.imagesToolStripMenuItem.Click += new System.EventHandler(this.imagesToolStripMenuItem_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.groupsToolStripMenuItem.Text = "Groups";
            this.groupsToolStripMenuItem.Click += new System.EventHandler(this.groupsToolStripMenuItem_Click);
            // 
            // markersToolStripMenuItem
            // 
            this.markersToolStripMenuItem.Name = "markersToolStripMenuItem";
            this.markersToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.markersToolStripMenuItem.Text = "Markers";
            this.markersToolStripMenuItem.Click += new System.EventHandler(this.markersToolStripMenuItem_Click);
            // 
            // galleriesToolStripMenuItem
            // 
            this.galleriesToolStripMenuItem.Name = "galleriesToolStripMenuItem";
            this.galleriesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.galleriesToolStripMenuItem.Text = "Galleries";
            this.galleriesToolStripMenuItem.Click += new System.EventHandler(this.galleriesToolStripMenuItem_Click);
            // 
            // performersToolStripMenuItem
            // 
            this.performersToolStripMenuItem.Name = "performersToolStripMenuItem";
            this.performersToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.performersToolStripMenuItem.Text = "Performers";
            this.performersToolStripMenuItem.Click += new System.EventHandler(this.performersToolStripMenuItem_Click);
            // 
            // studiosToolStripMenuItem
            // 
            this.studiosToolStripMenuItem.Name = "studiosToolStripMenuItem";
            this.studiosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.studiosToolStripMenuItem.Text = "Studios";
            this.studiosToolStripMenuItem.Click += new System.EventHandler(this.studiosToolStripMenuItem_Click);
            // 
            // tagsToolStripMenuItem
            // 
            this.tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            this.tagsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.tagsToolStripMenuItem.Text = "Tags";
            this.tagsToolStripMenuItem.Click += new System.EventHandler(this.tagsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(129, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(820, 490);
            this.Name = "Main";
            this.Text = "Stash Explorer";
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.sysTrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createGalleryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPerformerToolStripMenuItem;
        internal System.Windows.Forms.Timer TitleTimer;
        public Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.ToolStripMenuItem stashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stashappSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem stashExplorerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem createStudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        internal System.Windows.Forms.Timer ContentTimer;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stashappStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.NotifyIcon sysTrayIcon;
        private System.Windows.Forms.ContextMenuStrip sysTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem keyboardShortcutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem scenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galleriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

