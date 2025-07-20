using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Text.RegularExpressions;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stash_Explorer
{
    public partial class Settings : Form
    {
        #region Variables
        public Settings()
        {
            InitializeComponent();
            
        }

        void CheckChars(KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
        #endregion
        #region Load Settings
        private void Settings_Load(object sender, EventArgs e)
        {
            // Load user domain settings.
            textBoxURL.Text = Properties.Settings.Default.Domain;

            // Load user minimising settings.
            if (Properties.Settings.Default.SysTrayMinimise == true)
            {
                SysTrayMinimiseBox.Checked = true;
            }
            else
            {
                SysTrayMinimiseBox.Checked = false;
            }

            if (Properties.Settings.Default.Reload == true)
            {
                checkBoxReload.Checked = true;
            }
            else
            {
                checkBoxReload.Checked = false;
            }

            // Load user startup settings.
            switch (Properties.Settings.Default.Startup)
            {
                case 0:
                    NothingButton.Checked = true;
                    textBoxPerformer.Enabled = false;
                    textBoxGallery.Enabled = false;
                    textBoxTag.Enabled = false;
                    break;
                case 1:
                    SystemTrayButton.Checked = true;
                    textBoxPerformer.Enabled = false;
                    textBoxGallery.Enabled = false;
                    textBoxTag.Enabled = false;
                    break;
                case 2:
                    radioButtonPerformer.Checked = true;
                    textBoxPerformer.Enabled = true;
                    textBoxGallery.Enabled = false;
                    textBoxTag.Enabled = false;
                    textBoxPerformer.Text = Properties.Settings.Default.StartupIDP;
                    break;
                case 3:
                    radioButtonGallery.Checked = true;
                    textBoxPerformer.Enabled = false;
                    textBoxGallery.Enabled = true;
                    textBoxTag.Enabled = false;
                    textBoxGallery.Text = Properties.Settings.Default.StartupIDG;
                    break;
                case 4:
                    radioButtonTag.Checked = true;
                    textBoxPerformer.Enabled = false;
                    textBoxGallery.Enabled = false;
                    textBoxTag.Enabled = true;
                    textBoxTag.Text = Properties.Settings.Default.StartupIDT;
                    break;
            }

            // Load and populate user pin settings.
            lbPinned.Items.Clear();
            foreach (string item in Properties.Settings.Default.Pins)
            {
                lbPinned.Items.Add(item);
            }

            // Load user content shield settings.
            switch (Properties.Settings.Default.ContShield)
            {
                case 0:
                    rbDNSC.Checked = true;
                    break;
                case 1:
                    rbSCM.Checked = true;
                    break;
                case 2:
                    rbSCMB.Checked = true;
                    break;
                case 3:
                    rbSCAT.Checked = true;
                    break;
            }
        }
        #endregion
        #region Stash Explorer
        // Toggle minimising behaviour.
        private void SysTrayMinimiseBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SysTrayMinimiseBox.Checked == true)
            {
                Properties.Settings.Default.SysTrayMinimise = true;
            }
            else
            {
                Properties.Settings.Default.SysTrayMinimise = false;
            }
        }

        // Toggle WebView2 reload on settings exit.
        private void checkBoxReload_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReload.Checked == true)
            {
                Properties.Settings.Default.Reload = true;
            }
            else
            {
                Properties.Settings.Default.Reload = false;
            }
        }
        #endregion
        #region Start-up
        private void NothingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NothingButton.Checked == true)
            {
                textBoxPerformer.Enabled = false;
                textBoxGallery.Enabled = false;
                textBoxTag.Enabled = false;
                Properties.Settings.Default.Startup = 0;
            }
        }

        private void SystemTrayButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SystemTrayButton.Checked == true)
            {
                textBoxPerformer.Enabled = false;
                textBoxGallery.Enabled = false;
                textBoxTag.Enabled = false;
                Properties.Settings.Default.Startup = 1;
            }
        }

        private void radioButtonPerformer_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPerformer.Enabled = true;
            textBoxGallery.Enabled = false;
            textBoxTag.Enabled = false;
            Properties.Settings.Default.Startup = 2;
        }

        private void radioButtonGallery_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPerformer.Enabled = false;
            textBoxGallery.Enabled = true;
            textBoxTag.Enabled = false;
            Properties.Settings.Default.Startup = 3;
        }

        private void radioButtonTag_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPerformer.Enabled = false;
            textBoxGallery.Enabled = false;
            textBoxTag.Enabled = true;
            Properties.Settings.Default.Startup = 4;
        }

        private void textBoxPerformer_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckChars(e);
        }

        private void textBoxGallery_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckChars(e);
        }

        private void textBoxTag_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckChars(e);
        }
        #endregion
        #region Pins
        private void btnOpen_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.openPinned();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                int item = Properties.Settings.Default.Pins.IndexOf(lbPinned.SelectedItem.ToString());
                Properties.Settings.Default.Pins.RemoveAt(item);
                lbPinned.Items.Remove(lbPinned.SelectedItem);
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to deleted selected pin.");
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all pinned performers?", "Clear Pins", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Properties.Settings.Default.Pins.Clear();
                lbPinned.Items.Clear();
                Properties.Settings.Default.Save();
            }
        }
        #endregion
        #region Content Shield
        private void rbDNSC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDNSC.Checked == true)
            {
                Properties.Settings.Default.ContShield = 0;
            }
        }

        private void rbSCM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSCM.Checked == true)
            {
                Properties.Settings.Default.ContShield = 1;
            }
        }

        private void rbSCMB_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSCMB.Checked == true)
            {
                Properties.Settings.Default.ContShield = 2;
            }
        }

        private void rbSCAT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSCAT.Checked == true)
            {
                Properties.Settings.Default.ContShield = 3;
                gbCSTimer.Enabled = true;
            }
            else
            {
                gbCSTimer.Enabled = false;
            }
        }

        private void rb1min_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1min.Checked == true)
            {
                Properties.Settings.Default.ContShieldTime = 60000;
            }
        }

        private void rb5min_CheckedChanged(object sender, EventArgs e)
        {
            if (rb5min.Checked == true)
            {
                Properties.Settings.Default.ContShieldTime = 300000;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb10min.Checked == true)
            {
                Properties.Settings.Default.ContShieldTime = 600000;
            }
        }
        #endregion
        #region Other
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save settings on form close automatically.
            if (Properties.Settings.Default.DomainConfigured == false)
            {
                Properties.Settings.Default.DomainConfigured = true;
            }
            else
            {

            }

            switch (Properties.Settings.Default.Startup)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    Properties.Settings.Default.StartupIDP = textBoxPerformer.Text;
                    Properties.Settings.Default.StartupToDest = "performers/" + Properties.Settings.Default.StartupIDP;
                    break;
                case 3:
                    Properties.Settings.Default.StartupIDG = textBoxGallery.Text;
                    Properties.Settings.Default.StartupToDest = "galleries/" + Properties.Settings.Default.StartupIDG;
                    break;
                case 4:
                    Properties.Settings.Default.StartupIDT = textBoxTag.Text;
                    Properties.Settings.Default.StartupToDest = "tags/" + Properties.Settings.Default.StartupIDT;
                    break;
            }

            switch (Properties.Settings.Default.ContShieldTime)
            {
                case 60000:
                    Main main1min = new Main();
                    main1min.timerContShield.Interval = 300000;
                    break;
                case 300000:
                    Main main5min = new Main();
                    main5min.timerContShield.Interval = 300000;
                    break;
                case 600000:
                    Main main10min = new Main();
                    main10min.timerContShield.Interval = 600000;
                    break;
            }

            Properties.Settings.Default.Domain = textBoxURL.Text;
            Properties.Settings.Default.Save();
        }
        #endregion

        
    }
}
