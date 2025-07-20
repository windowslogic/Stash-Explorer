using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        #region Variables
        void LoadContent()
        {
            contentTimer.Stop();
            if (Properties.Settings.Default.DomainConfigured == false)
            {
                webView21.Visible = false;
                if (MessageBox.Show("Do you want to set a URL where your stashapp is located? Pressing 'No' will leave it as the default (http://localhost:9999/).", "First Run - Stash Explorer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Settings settings = new Settings();
                    settings.ShowDialog();
                    WVSNavigate();
                }
                else
                {
                    WVSNavigate();
                }

            }
            else
            {
                WVSNavigate();
            }
            titleTimer.Start();
        }

        void WVSNavigate()
        {
            webView21.Visible = true;
            this.webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain);

            //Thread.Sleep(1000);

            switch (Properties.Settings.Default.Startup)
            {
                case 0:
                    break;
                case 1:
                    this.WindowState = FormWindowState.Minimized;
                    if (WindowState == FormWindowState.Minimized)
                    {
                        this.Visible = false;
                        sysTrayIcon.Visible = true;
                        sysTrayIcon.ShowBalloonTip(1, "Stash Explorer - Notification", "Stash Explorer is now running in the background.", ToolTipIcon.Info);
                        GC.Collect();
                    }
                    break;
                case 2:
                    StartupToDestination();
                    break;
                case 3:
                    StartupToDestination();
                    break;
                case 4:
                    StartupToDestination();
                    break;
            }
        }

        void StartupToDestination()
        {
            this.webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + Properties.Settings.Default.StartupToDest);
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
        #endregion
        #region Load Settings
        private void webView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            contentTimer.Start();
        }

        private void ContentTimer_Tick(object sender, EventArgs e)
        {
            LoadContent();
        }
        #endregion

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Attempts to show the document title on the window title bar.
            try
            {
                this.Text = webView21.CoreWebView2.DocumentTitle + " - Stash Explorer";
            }
            catch
            {
                MessageBox.Show("Unable to update Stash Explorer window title.");
            }

            // Checks to see if the current page is a performer page to enable pinning.
            if (webView21.CoreWebView2.DocumentTitle.Contains("| Performers"))
            {
                btnPin.Enabled = true;
            }
            else
            {
                btnPin.Enabled = false;
            }
        }

        private void stashExplorerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
            if (Properties.Settings.Default.Reload == true)
            {
                this.webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain);
            }
            else
            {

            }
            
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

        private void createGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "groups/new");
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
            if (Properties.Settings.Default.ContShield == 1)
            {
                panelContShield.Visible = true;
                panelContShield.BringToFront();
            }
            else if (Properties.Settings.Default.ContShield == 2)
            {
                panelContShield.Visible = true;
                panelContShield.BringToFront();
            }
            else
            {

            }

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
            About about = new About();
            about.ShowDialog();
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/windowslogic/Stash-Explorer/releases");
        }

        #region Pins
        private void btnPin_Click(object sender, EventArgs e)
        {

            // Pins the performer to the settings.
            string pinSource = webView21.Source.ToString();
            Properties.Settings.Default.Pins.Add(pinSource);
            Properties.Settings.Default.Save();
        }

        private void btnPins_Click(object sender, EventArgs e)
        {
            // Checks if the panel is open, then populates the listbox for pinned items.
            if (panelPinned.Visible == false)
            {
                panelPinned.Visible = true;
                foreach (string item in Properties.Settings.Default.Pins)
                {
                    lbPinned.Items.Add(item);
                }
                panelPinned.BringToFront();
            }
            else
            {
                panelPinned.Visible = false;
                lbPinned.Items.Clear();
            }
        }

        public void openPinned()
        {
            // Attempts to open the performer which is double-clicked on.
            try
            {
                webView21.CoreWebView2.Navigate(lbPinned.SelectedItem.ToString());
            }
            catch
            {
                MessageBox.Show("Unable to navigate to selected performer.");
            }
        }

        private void lbPinned_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            openPinned();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openPinned();
        }

        private void linkManage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings settings = new Settings();
            settings.tabControl1.SelectedTab = settings.tpPins;
            settings.ShowDialog();
        }

        private void btnPins_MouseHover(object sender, EventArgs e)
        {
            btnPins.ForeColor = Color.White;
        }

        private void btnPins_MouseLeave(object sender, EventArgs e)
        {
            btnPins.ForeColor = Color.Black;
        }

        private void btnPin_MouseHover(object sender, EventArgs e)
        {
            btnPin.ForeColor = Color.White;
        }

        private void btnPin_MouseLeave(object sender, EventArgs e)
        {
            btnPin.ForeColor = Color.Black;
        }

        #endregion

        // Content shield timer bullshit.
        private void panelContShield_MouseEnter(object sender, EventArgs e)
        {
            panelContShield.Visible = false;
            timerContShield.Stop();
        }

        private void timerContShield_Tick(object sender, EventArgs e)
        {
            if (RectangleToScreen(Bounds).Contains(PointToScreen(Cursor.Position)) == false)
            {
                panelContShield.Visible = true;
            }
        }

        private void Main_MouseLeave(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.ContShield == 3)
            {
                timerContShield.Start();
            }
        }
    }
}
