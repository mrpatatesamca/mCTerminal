using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace mCTerminal
{
    public partial class roketsema : Form
    {

        XmlTextReader xtr = new XmlTextReader(programyolu + @"res\settings.xml"); //XML dosyasını okumak için hazırlık yap
        string xmlAyarIsim;
        string xmlAyarDeger;
        public string programTema;
        public string programVeriFormat;
        public string programSurum;
        static string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;



        public roketsema()
        {
            InitializeComponent();
        }

        private void bilgiaktarTimer_Tick(object sender, EventArgs e)
        {
            //global değişkenlerden verileri al
            gkuvvetLabel.Text = "G Kuvveti: " + Properties.Settings.Default.gkuvvet + "g";
            aciXLabel.Text = "X Açısı: " + Properties.Settings.Default.aciX + "°";
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

        private void roketsema_Load(object sender, EventArgs e)
        {
            editorAyarYukle();

            //temalar için ayrılmış bölüm

            if (programTema == "tema_varsayilan")
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.ForeColor = Color.WhiteSmoke;
                aciYLabel.ForeColor = this.ForeColor;
                aciXLabel.ForeColor = this.ForeColor;
                gkuvvetLabel.ForeColor = this.ForeColor;
                kameraDurumLabel.ForeColor = this.ForeColor;
                koniDurumLabel.ForeColor = this.ForeColor;
                ortagovdeDurumLabel.ForeColor = this.ForeColor;
            }

            if (programTema == "tema_matrix")
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.DarkOliveGreen;
                aciYLabel.ForeColor = this.ForeColor;
                aciXLabel.ForeColor = this.ForeColor;
                gkuvvetLabel.ForeColor = this.ForeColor;
                kameraDurumLabel.ForeColor = this.ForeColor;
                koniDurumLabel.ForeColor = this.ForeColor;
                ortagovdeDurumLabel.ForeColor = this.ForeColor;
            }

            if (programTema == "tema_dondurma")
            {
                this.BackColor = Color.FromArgb(220, 229, 225);
                this.ForeColor = Color.IndianRed;
                aciYLabel.ForeColor = this.ForeColor;
                aciXLabel.ForeColor = this.ForeColor;
                gkuvvetLabel.ForeColor = this.ForeColor;
                kameraDurumLabel.ForeColor = this.ForeColor;
                koniDurumLabel.ForeColor = this.ForeColor;
                ortagovdeDurumLabel.ForeColor = this.ForeColor;
            }

            if (programTema == "tema_cosmos")
            {
                this.BackColor = Color.FromArgb(26, 16, 122);
                this.ForeColor = Color.FromArgb(245, 228, 183);
                aciYLabel.ForeColor = this.ForeColor;
                aciXLabel.ForeColor = this.ForeColor;
                gkuvvetLabel.ForeColor = this.ForeColor;
                kameraDurumLabel.ForeColor = this.ForeColor;
                koniDurumLabel.ForeColor = this.ForeColor;
                ortagovdeDurumLabel.ForeColor = this.ForeColor;
            }

            if (programTema == "tema_material")
            {
                this.BackColor = Color.FromArgb(47, 79, 79);
                this.ForeColor = Color.FromArgb(251, 235, 235);
                aciYLabel.ForeColor = this.ForeColor;
                aciXLabel.ForeColor = this.ForeColor;
                gkuvvetLabel.ForeColor = this.ForeColor;
                kameraDurumLabel.ForeColor = this.ForeColor;
                koniDurumLabel.ForeColor = this.ForeColor;
                ortagovdeDurumLabel.ForeColor = this.ForeColor;
            }
            //-----------------------------------------------------------


        }

        public void editorAyarYukle()
        {
            try
            {
                while (xtr.Read())
                {
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "name") //xml içindeki name elementini al
                    {
                        xmlAyarIsim += xtr.ReadElementContentAsString() + "*";
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "value") //xml içindeki value elementini al
                    {
                        xmlAyarDeger += xtr.ReadElementContentAsString() + "*";
                    }
                }
                string data1;
                string data2;
                string[] splitted_data1;
                string[] splitted_data2;
                data1 = xmlAyarIsim;
                data2 = xmlAyarDeger;
                splitted_data1 = data1.Split('*');
                splitted_data2 = data2.Split('*');
                //değerleri gerekli değişkenlere ata.
                programTema = splitted_data2[0];
                programSurum = splitted_data2[1];
                programVeriFormat = splitted_data2[2];
                xtr.Close();
            }
            catch
            {
                MessageBox.Show(@"Ayarlar diskten okunamadı! Lütfen programı yeniden indirin! (res\settings.xml dosyası bozuk veya değiştirilmiş!)", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
