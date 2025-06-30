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
    }
}
