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
    public partial class hamveriekrani : Form
    {
        public hamveriekrani()
        {
            InitializeComponent();
        }

        private void hamveriekrani_Load(object sender, EventArgs e)
        {
            hamveritextbox.SelectionStart = hamveritextbox.Text.Length;

        }

        private void verikontrol_Tick(object sender, EventArgs e)
        {
            if (mCTerminal.Properties.Settings.Default.serialportdurum == true)
            {
                hamveritextbox.AppendText(mCTerminal.Properties.Settings.Default.hamveri + Environment.NewLine);
                int line = hamveritextbox.GetLineFromCharIndex(hamveritextbox.SelectionStart);
                int column = hamveritextbox.SelectionStart - hamveritextbox.GetFirstCharIndexFromLine(line);
            }
            


        }
    }
}
