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
    public partial class baslangic_splash : Form
    {
        public baslangic_splash()
        {
            InitializeComponent();
            
        }

        private void baslangic_splash_Load(object sender, EventArgs e)
        {
            commandLineTextBox.SelectionStart = commandLineTextBox.Text.Length; //textbox mavi mavi yazılar seçilmesin diye


        }

        private void yuklemebaslatTimer_Tick(object sender, EventArgs e)
        {
            commandLineTextBox.Text = "";
            commandLineTextBox.AppendText("COSMOS TAKIMI SİSTEM TEST PROGRAMI V0.1" + Environment.NewLine);
            commandLineTextBox.AppendText("Program yükleniyor..." + Environment.NewLine);

            int line = commandLineTextBox.GetLineFromCharIndex(commandLineTextBox.SelectionStart);
            int column = commandLineTextBox.SelectionStart - commandLineTextBox.GetFirstCharIndexFromLine(line);
            yuklemebaslatTimer2.Stop();
            yuklemebaslatTimer.Stop();
            yuklemebaslatTimer2.Start();

        }

        private void yuklemebaslatTimer2_Tick(object sender, EventArgs e)
        {
            commandLineTextBox.AppendText("" + Environment.NewLine);
            commandLineTextBox.AppendText("[#####_________________________________]" + Environment.NewLine);
            

            int line = commandLineTextBox.GetLineFromCharIndex(commandLineTextBox.SelectionStart);
            int column = commandLineTextBox.SelectionStart - commandLineTextBox.GetFirstCharIndexFromLine(line);
            yuklemebaslatTimer2.Stop();
            yuklemebaslatTimer3.Start();

        }

        private void yuklemebaslatTimer3_Tick(object sender, EventArgs e)
        {
            commandLineTextBox.Text = "";
            commandLineTextBox.AppendText("COSMOS TAKIMI SİSTEM TEST PROGRAMI V0.1" + Environment.NewLine);
            commandLineTextBox.AppendText("Program yükleniyor..." + Environment.NewLine);
            commandLineTextBox.AppendText("" + Environment.NewLine);
            commandLineTextBox.AppendText("[###########################___________]" + Environment.NewLine);
            yuklemebaslatTimer4.Start();
            yuklemebaslatTimer3.Stop();
            yuklemebaslatTimer2.Stop();
            yuklemebaslatTimer.Stop();
           

        }

        private void yuklemebaslatTimer4_Tick(object sender, EventArgs e)
        {
            commandLineTextBox.Text = "";
            commandLineTextBox.AppendText("COSMOS TAKIMI SİSTEM TEST PROGRAMI V0.1" + Environment.NewLine);
            commandLineTextBox.AppendText("Program yükleniyor..." + Environment.NewLine);
            commandLineTextBox.AppendText("" + Environment.NewLine);
            commandLineTextBox.AppendText("[######################################]" + Environment.NewLine);
            commandLineTextBox.AppendText("Arayüz başlatılıyor..." + Environment.NewLine);
            yuklemebaslatTimer3.Stop();
            yuklemebaslatTimer2.Stop();
            yuklemebaslatTimer.Stop();
            yuklemebaslatTimer4.Stop();
            anaEkran anaekrnfrm = new anaEkran();
            anaekrnfrm.Show();
            this.Hide();
        }
    }
}
