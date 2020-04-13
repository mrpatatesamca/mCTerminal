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
            //temalar için ayrılmış bölüm

            if (mCTerminal.Properties.Settings.Default.program_tema == "tema_varsayilan")
            {
                hamveritextbox.BackColor = Color.FromArgb(25, 25, 25);
                hamveritextbox.ForeColor = Color.Chocolate;
            }

            if (mCTerminal.Properties.Settings.Default.program_tema == "tema_matrix")
            {
                hamveritextbox.BackColor = Color.FromArgb(10, 12, 10);
                hamveritextbox.ForeColor = Color.LimeGreen;
            }

            if (mCTerminal.Properties.Settings.Default.program_tema == "tema_dondurma")
            {
                hamveritextbox.BackColor = Color.LightSlateGray;
                hamveritextbox.ForeColor = Color.NavajoWhite;
            }

            if (mCTerminal.Properties.Settings.Default.program_tema == "tema_cosmos")
            {
                hamveritextbox.BackColor = Color.FromArgb(6, 0, 102);
                hamveritextbox.ForeColor = Color.BurlyWood;
            }

            if (mCTerminal.Properties.Settings.Default.program_tema == "tema_material")
            {
                hamveritextbox.BackColor = Color.FromArgb(72, 96, 74);
                hamveritextbox.ForeColor = Color.FromArgb(255, 185, 105);
            }
            //-----------------------------------------------------------






            string sadece_saat = DateTime.Now.ToString("hh:mm:ss");
            hamveritextbox.Text = sadece_saat + " --> Veri Bekleniyor..." + Environment.NewLine;
            hamveritextbox.SelectionStart = hamveritextbox.Text.Length;

        }

        private void verikontrol_Tick(object sender, EventArgs e)
        {
            if (mCTerminal.Properties.Settings.Default.serialportdurum == true)
            {
                string sadece_saat = DateTime.Now.ToString("hh:mm:ss");
                hamveritextbox.AppendText(sadece_saat + " --> " + mCTerminal.Properties.Settings.Default.hamveri + Environment.NewLine);
                int line = hamveritextbox.GetLineFromCharIndex(hamveritextbox.SelectionStart);
                int column = hamveritextbox.SelectionStart - hamveritextbox.GetFirstCharIndexFromLine(line);
            }
            


        }
    }
}
