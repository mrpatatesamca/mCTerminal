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
    public partial class programListeYenileForm : Form
    {
        public programListeYenileForm()
        {
            InitializeComponent();
        }

        private void formKapat_Tick(object sender, EventArgs e)
        {
            formKapatTimer.Stop();
            this.Close();
        }

        private void programListeYenileForm_Load(object sender, EventArgs e)
        {

        }
    }
}
