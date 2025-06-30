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
    }
}
