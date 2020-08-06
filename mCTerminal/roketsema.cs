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
    public partial class roketsema : Form
    {
        public roketsema()
        {
            InitializeComponent();
        }

        private void bilgiaktarTimer_Tick(object sender, EventArgs e)
        {
            //global değişkenlerden verileri al
            gkuvvetLabel.Text = "G Kuvveti: " + Properties.Settings.Default.gkuvvet + "g";
            AciXLabel.Text = "X Açısı: " + Properties.Settings.Default.aciX + "°";
            aciYLabel.Text = "Y Açısı: " + Properties.Settings.Default.aciY + "°";

            //aktif - aktif değil durumu ayarla
            if (Properties.Settings.Default.kameradurum == "1") //kamera durumu 1 ise
            {
                kameraDurumLabel.Text = "Video Yayını: Aktif!";
            }
            else
            {
                kameraDurumLabel.Text = "Video Yayını: Aktif Değil!";
            }

            if (Properties.Settings.Default.konidurum == "1") //koni ayrılmış ise
            {
                koniDurumLabel.Text = "Koni: Ayrıldı!";
            }
            else
            {
                koniDurumLabel.Text = "Koni: Ayrılmadı!";
            }

            if (Properties.Settings.Default.ortagovdedurum == "1") //orta göve ayrılmış ise
            {
                ortagovdeDurumLabel.Text = "Orta Gövde: Ayrıldı!";
            }
            else
            {
                ortagovdeDurumLabel.Text = "Orta Gövde: Ayrılmadı!";
            }
        }
    }
}
