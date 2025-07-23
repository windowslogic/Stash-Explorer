using System;
using System.Collections.Generic;
using System.IO;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
using System.Linq;
//using System.Text;
using System.Text.RegularExpressions;
//using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

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
                chkReload.Checked = true;
            }
            else
            {
                chkReload.Checked = false;
            }
            
            // Load user area settings.
            if(Properties.Settings.Default.EnableScenes == true)
            {
                chkScenes.Checked = true;
            }
            else
            {
                chkScenes.Checked = false;
            }

            if (Properties.Settings.Default.EnableImages == true)
            {
                chkImages.Checked = true;
            }
            else
            {
                chkImages.Checked = false;
            }

            if (Properties.Settings.Default.EnableGroups == true)
            {
                chkGroups.Checked = true;
            }
            else
            {
                chkGroups.Checked = false;
            }

            if (Properties.Settings.Default.EnableMarkers == true)
            {
                chkMarkers.Checked = true;
            }
            else
            {
                chkMarkers.Checked = false;
            }

            if (Properties.Settings.Default.EnableGalleries == true)
            {
                chkGalleries.Checked = true;
            }
            else
            {
                chkGalleries.Checked = false;
            }

            if (Properties.Settings.Default.EnablePerformers == true)
            {
                chkPerformers.Checked = true;
            }
            else
            {
                chkPerformers.Checked = false;
            }

            if (Properties.Settings.Default.EnableStudios == true)
            {
                chkStudios.Checked = true;
            }
            else
            {
                chkStudios.Checked = false;
            }

            if (Properties.Settings.Default.EnableTags == true)
            {
                chkTags.Checked = true;
            }
            else
            {
                chkTags.Checked = false;
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
            if (chkReload.Checked == true)
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

            Properties.Settings.Default.Domain = textBoxURL.Text;
            Properties.Settings.Default.Save();
        }
        #endregion

        private void btnImport_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to import a pin stack? This will replace all current pins.", "Pins - Stash Explorer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                openFileDialog1.Title = "Open Stash Explorer Pin Stack";
                openFileDialog1.Filter = "Pin Stack|*.seps";
                openFileDialog1.FileName = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    lbPinned.Items.Clear();

                    List<string> lines = new List<string>();
                    using (StreamReader r = new StreamReader(openFileDialog1.OpenFile()))
                    {
                        string line;
                        while ((line = r.ReadLine()) != null)
                        {
                            lbPinned.Items.Add(line);
                        }
                    }
                }
                Properties.Settings.Default.Save();
            }
            else
            {

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save Stash Explorer Pin Stack";
            saveFileDialog1.Filter = "Pin Stack|*.seps";
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.Create(saveFileDialog1.FileName).Dispose();

                File.WriteAllText(saveFileDialog1.FileName, "");

                StreamWriter objWriter = new StreamWriter(saveFileDialog1.FileName);

                foreach (var item in lbPinned.Items)
                {
                    objWriter.WriteLine(item.ToString());
                }

                objWriter.Close();
            }
        }

        private void chkScenes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkImages_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkGroups_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkMarkers_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkGalleries_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkPerformers_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkStudios_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTags_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
