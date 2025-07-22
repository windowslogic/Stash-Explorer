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
using System.IO;

namespace Stash_Explorer
{
    public partial class Main : Form
    {
        #region Variables
        public Main()
        {
            InitializeComponent();

        }

        void LoadContent()
        {
            // Attempt to read INI file and port into Properties.Settings.Default
            try
            {
                tbSetSettings.Text = File.ReadAllLines("StashExplorer.ini").ElementAt(2).ToString();

                if(tbSetSettings.Text == "true")
                {
                    Properties.Settings.Default.DomainConfigured = true;
                }
                else
                {
                    Properties.Settings.Default.DomainConfigured = false;
                }

                tbSetSettings.Text = File.ReadAllLines("StashExplorer.ini").ElementAt(4).ToString();

                Properties.Settings.Default.Domain = tbSetSettings.Text;

                tbSetSettings.Text = File.ReadAllLines("StashExplorer.ini").ElementAt(6).ToString();

                Properties.Settings.Default.Startup = Convert.ToInt32(tbSetSettings.Text);

                tbSetSettings.Text = File.ReadAllLines("StashExplorer.ini").ElementAt(8).ToString();

                Properties.Settings.Default.StartupToDest = tbSetSettings.Text;

                tbSetSettings.Text = File.ReadAllLines("StashExplorer.ini").ElementAt(10).ToString();

                if (tbSetSettings.Text == "true")
                {
                    Properties.Settings.Default.SysTrayMinimise = true;
                }
                else
                {
                    Properties.Settings.Default.SysTrayMinimise = false;
                }

                tbSetSettings.Text = File.ReadAllLines("StashExplorer.ini").ElementAt(12).ToString();

                Properties.Settings.Default.StartupIDP = tbSetSettings.Text;

                tbSetSettings.Text = File.ReadAllLines("StashExplorer.ini").ElementAt(14).ToString();

                Properties.Settings.Default.StartupIDG = tbSetSettings.Text;

                tbSetSettings.Text = File.ReadAllLines("StashExplorer.ini").ElementAt(16).ToString();

                Properties.Settings.Default.StartupIDT = tbSetSettings.Text;

                tbSetSettings.Text = File.ReadAllLines("StashExplorer.ini").ElementAt(18).ToString();

                if (tbSetSettings.Text == "true")
                {
                    Properties.Settings.Default.Reload = true;
                }
                else
                {
                    Properties.Settings.Default.Reload = false;
                }

                tbSetSettings.Text = File.ReadAllLines("StashExplorer.ini").ElementAt(20).ToString();

                Properties.Settings.Default.ContShield = Convert.ToInt32(tbSetSettings.Text);
            }
            catch
            {

            }

            // Stop timer used to trick WebView2 into loading from code.
            // Load user selected domain, or settings if not configured.
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
        #region Menu
        #region File
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
        #endregion
        #region Stash
        private void stashappStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "stats");
        }

        private void stashappSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webView21.CoreWebView2.Navigate(Properties.Settings.Default.Domain + "settings");
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
        #endregion
        #region Help
        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/windowslogic/Stash-Explorer/releases");
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
        #endregion
        #endregion
        #region System Tray Icon & Menu
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
        #endregion
        #region Pins
        void openPinPanel()
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

        private void btnPin_Click(object sender, EventArgs e)
        {
            // Checks if user has 12 Pins, otherwise pins the performer.
            if (lbPinned.Items.Count == 12)
            {
                MessageBox.Show("You can only have up to 12 pins.");
            }
            else
            {
                string pinSource = webView21.Source.ToString();
                Properties.Settings.Default.Pins.Add(pinSource);
                lbPinned.Items.Add(pinSource);
                Properties.Settings.Default.Save();
            }
        }

        private void btnPins_Click(object sender, EventArgs e)
        {
            openPinPanel();
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
        #region Content Shield
        private void timerHideInactive_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ContShield == 2)
            {
                if (Form.ActiveForm != this)
                {
                    panelContShield.Visible = true;
                    panelContShield.BringToFront();
                }
                else
                {
                    panelContShield.Visible = false;
                }
            }
        }
        #endregion
        #region Functions
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
        #endregion

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Create("StashExplorer.ini").Dispose();

            File.WriteAllText("StashExplorer.ini", "");

            StreamWriter objWriter = new StreamWriter("StashExplorer.ini", true);

            objWriter.WriteLine("[Stash Explorer " + Application.ProductVersion + "]");
            objWriter.WriteLine("[DomainConfigured]");
            if(Properties.Settings.Default.DomainConfigured == true)
            {
                objWriter.WriteLine("true");
            }
            else
            {
                objWriter.WriteLine("false");
            }
            objWriter.WriteLine("[Domain]");
            objWriter.WriteLine(Properties.Settings.Default.Domain);
            objWriter.WriteLine("[Start-up]");
            objWriter.WriteLine(Properties.Settings.Default.Startup.ToString());
            objWriter.WriteLine("[Start-upToDest]");
            objWriter.WriteLine(Properties.Settings.Default.StartupToDest);
            objWriter.WriteLine("[SysTrayMinimise]");
            if (Properties.Settings.Default.SysTrayMinimise == true)
            {
                objWriter.WriteLine("true");
            }
            else
            {
                objWriter.WriteLine("false");
            }
            objWriter.WriteLine("[Start-upIDP]");
            objWriter.WriteLine(Properties.Settings.Default.StartupIDP.ToString());
            objWriter.WriteLine("[Start-upIDG]");
            objWriter.WriteLine(Properties.Settings.Default.StartupIDG.ToString());
            objWriter.WriteLine("[Start-upIDT]");
            objWriter.WriteLine(Properties.Settings.Default.StartupIDT.ToString());
            objWriter.WriteLine("[Reload]");
            if (Properties.Settings.Default.Reload == true)
            {
                objWriter.WriteLine("true");
            }
            else
            {
                objWriter.WriteLine("false");
            }
            objWriter.WriteLine("[ContShield]");
            objWriter.WriteLine(Properties.Settings.Default.ContShield.ToString());

            objWriter.Close();
        }
    }
}
