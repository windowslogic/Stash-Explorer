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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // Load Settings.
            textBoxURL.Text = Properties.Settings.Default.Domain;

            if (Properties.Settings.Default.SysTrayMinimise == true)
            {
                SysTrayMinimiseBox.Checked = true;
            }
            else
            {
                SysTrayMinimiseBox.Checked = false;
            }

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
                    break;
                case 3:
                    radioButtonGallery.Checked = true;
                    textBoxPerformer.Enabled = false;
                    textBoxGallery.Enabled = true;
                    textBoxTag.Enabled = false;
                    break;
                case 4:
                    radioButtonTag.Checked = true;
                    textBoxPerformer.Enabled = false;
                    textBoxGallery.Enabled = false;
                    textBoxTag.Enabled = true;
                    break;
            }


        }

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

            Properties.Settings.Default.Domain = textBoxURL.Text;
            Properties.Settings.Default.Save();
        }

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
            Properties.Settings.Default.StartupToDest = "performers/" + textBoxPerformer.Text;
        }

        private void radioButtonGallery_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPerformer.Enabled = false;
            textBoxGallery.Enabled = true;
            textBoxTag.Enabled = false;
            Properties.Settings.Default.Startup = 3;
            Properties.Settings.Default.StartupToDest = "galleries/" + textBoxPerformer.Text;
        }

        private void radioButtonTag_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPerformer.Enabled = false;
            textBoxGallery.Enabled = false;
            textBoxTag.Enabled = true;
            Properties.Settings.Default.Startup = 4;
            Properties.Settings.Default.StartupToDest = "tags/" + textBoxPerformer.Text;
        }

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
    }
}
