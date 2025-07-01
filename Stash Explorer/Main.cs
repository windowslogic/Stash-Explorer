using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stash_Explorer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        void LoadContent()
        {
            if (Properties.Settings.Default.DomainConfigured == false)
            {
                webView21.Visible = false;
                if (MessageBox.Show("Do you want to set a URL where your stashapp is located? Pressing 'No' will leave it as the default (http://localhost:9999/).", "First Run - Stash Explorer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Settings settings = new Settings();
                    settings.ShowDialog();
                    this.webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain);
                }
                else
                {
                    webView21.Visible = true;
                    this.webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain);
                }

            }
            else
            {
                webView21.Visible = true;
                this.webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain);
            }

            ContentTimer.Stop();
        }

        void Restore()
        {
            try
            {
                this.Visible = true;
                if (this.WindowState == FormWindowState.Maximized)
                {

                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                }
                sysTrayIcon.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                this.Text = webView21.CoreWebView2.DocumentTitle + " - Stash Explorer";
            }
            catch
            {

            }
        }

        private void stashExplorerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
            this.webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain);
        }

        private void webView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            ContentTimer.Start();
        }

        private void ContentTimer_Tick(object sender, EventArgs e)
        {
            LoadContent();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
        }

        private void createSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "scenes/new");
        }

        private void createGalleryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "gallery/new");
        }

        private void createPerformerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "performers/new");
        }

        private void createStudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "studios/new");
        }

        private void createTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "tags/new");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stashappStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "stats");
        }

        private void stashappSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "settings");
        }

        private void sysTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                sysTrayIcon.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SysTrayMinimise == true)
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    this.Visible = false;
                    sysTrayIcon.Visible = true;
                    sysTrayIcon.ShowBalloonTip(1, "Stash Explorer - Notification", "Stash Explorer is now running in the background.", ToolTipIcon.Info);
                    GC.Collect();
                }
            }
            else if (Properties.Settings.Default.SysTrayMinimise == false)
            {
                GC.Collect();
            }
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore();
        }

        private void scenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore();
            webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "scenes");
        }

        private void imagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore();
            webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "images");
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore();
            webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "groups");
        }

        private void markersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore();
            webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "markers");
        }

        private void galleriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore();
            webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "galleries");
        }

        private void performersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore();
            webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "performers");
        }

        private void studiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore();
            webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "studios");
        }

        private void tagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore();
            webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "tags");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stash Explorer " + Application.ProductVersion + "\n\nContribute on the GitHub.\n\nLicensed under GPLv3.", "About Stash Explorer");
        }
    }
}
