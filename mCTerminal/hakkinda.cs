using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mCTerminal
{
    public partial class hakkinda : Form
    {
        public hakkinda()
        {
            InitializeComponent();
        }

        private void githubadresLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mrpatatesamca/mCTerminal");
        }

        private void websiteadresLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cosmostakimi.com");
        }

        private void instagramadresLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/mrpatatesamca");
        }

        private void hakkinda_Load(object sender, EventArgs e)
        {
            this.Text = "mCTerminal " + mCTerminal.Properties.Settings.Default.prog_surum + " Hakkında";
            sistembilgiLabel.Text = "@" + Environment.MachineName + "/" + Environment.UserName + " | " + Environment.OSVersion;
            programSurumSayiLabel.Text = "mCTerminal " + mCTerminal.Properties.Settings.Default.prog_surum;       
        }
    }
}
