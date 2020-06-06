using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace mCTerminal
{
    public partial class harita : Form
    {
        anaEkran anaEkranfrm = new anaEkran();
        XmlTextReader xtr = new XmlTextReader(programyolu + @"\res\settings.xml"); //XML dosyasını okumak için hazırlık yap
        string xmlAyarIsim;
        string xmlAyarDeger;
        public string programTema;
        public string programVeriFormat;
        public string programSurum;
        static string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;

        public harita()
        {
            InitializeComponent();
            
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

        private void üstteGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Üstte göster - gösterme butonu için
            if (this.TopMost == true)
            {
                üstteGösterToolStripMenuItem.CheckState = CheckState.Unchecked;
                this.TopMost = false;
            }
            else
            {
                üstteGösterToolStripMenuItem.CheckState = CheckState.Checked;
                this.TopMost = true;

            }
        }

        private void tamEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tam Ekran - Küçük Ekran butonu
            if (this.FormBorderStyle == FormBorderStyle.Sizable)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                tamEkranToolStripMenuItem.Text = "Küçültülmüş Ekran";
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                tamEkranToolStripMenuItem.Text = "Tam Ekran";
            }
        }

        private void harita_Load(object sender, EventArgs e)
        {
            editorAyarYukle();
            //-----------------------------temalar için ayrılmış bölüm---------------------------------

            if (programTema == "tema_varsayilan")
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.ForeColor = Color.WhiteSmoke;
                haritaAracMenu.BackColor = Color.FromArgb(50, 50, 50);
                toolStripDropDownButton1.ForeColor = Color.WhiteSmoke;
                toolStripDropDownButton2.ForeColor = Color.WhiteSmoke;
                haritaortala_checkbox.ForeColor = Color.WhiteSmoke;
                enlemTextBox.ForeColor = Color.WhiteSmoke;
                boylamTextBox.ForeColor = Color.WhiteSmoke;
                haritaortala_checkbox.BackColor = haritaAracMenu.BackColor;
                enlemTextBox.BackColor = haritaAracMenu.BackColor;
                boylamTextBox.BackColor = haritaAracMenu.BackColor;
                gitButon.BackColor = haritaAracMenu.BackColor;
            }

            if (programTema == "tema_matrix")
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.DarkOliveGreen;
                haritaAracMenu.BackColor = Color.Black;
                toolStripDropDownButton1.ForeColor = Color.LimeGreen;
                toolStripDropDownButton2.ForeColor = Color.LimeGreen;
                haritaortala_checkbox.ForeColor = Color.LimeGreen;
                enlemTextBox.ForeColor = Color.LimeGreen;
                boylamTextBox.ForeColor = Color.LimeGreen;
                haritaortala_checkbox.BackColor = haritaAracMenu.BackColor;
                enlemTextBox.BackColor = haritaAracMenu.BackColor;
                boylamTextBox.BackColor = haritaAracMenu.BackColor;
                gitButon.BackColor = haritaAracMenu.BackColor;
            }

            if (programTema == "tema_dondurma")
            {
                this.BackColor = Color.FromArgb(220, 229, 225);
                this.ForeColor = Color.IndianRed;
                haritaAracMenu.BackColor = Color.DarkSlateGray;
                toolStripDropDownButton1.ForeColor = Color.FromArgb(255, 230, 230);
                toolStripDropDownButton2.ForeColor = Color.FromArgb(255, 230, 230);
                haritaortala_checkbox.ForeColor = Color.FromArgb(255, 230, 230);
                enlemTextBox.ForeColor = Color.FromArgb(255, 230, 230);
                boylamTextBox.ForeColor = Color.FromArgb(255, 230, 230);
                haritaortala_checkbox.BackColor = haritaAracMenu.BackColor;
                enlemTextBox.BackColor = haritaAracMenu.BackColor;
                boylamTextBox.BackColor = haritaAracMenu.BackColor;
                gitButon.BackColor = haritaAracMenu.BackColor;
            }

            if (programTema == "tema_cosmos")
            {
                this.BackColor = Color.FromArgb(26, 16, 122);
                this.ForeColor = Color.FromArgb(245, 228, 183);
                haritaAracMenu.BackColor = Color.FromArgb(11, 75, 183);
                toolStripDropDownButton1.ForeColor = Color.FromArgb(245, 228, 183);
                toolStripDropDownButton2.ForeColor = Color.FromArgb(245, 228, 183);
                haritaortala_checkbox.ForeColor = Color.FromArgb(245, 228, 183);
                enlemTextBox.ForeColor = Color.FromArgb(245, 228, 183);
                boylamTextBox.ForeColor = Color.FromArgb(245, 228, 183);
                haritaortala_checkbox.BackColor = haritaAracMenu.BackColor;
                enlemTextBox.BackColor = haritaAracMenu.BackColor;
                boylamTextBox.BackColor = haritaAracMenu.BackColor;
                gitButon.BackColor = haritaAracMenu.BackColor;
            }

            if (programTema == "tema_material")
            {
                this.BackColor = Color.FromArgb(47, 79, 79);
                this.ForeColor = Color.FromArgb(251, 235, 235);
                haritaAracMenu.BackColor = Color.FromArgb(29, 61, 61);
                toolStripDropDownButton1.ForeColor = Color.WhiteSmoke;
                toolStripDropDownButton2.ForeColor = Color.WhiteSmoke;
                haritaortala_checkbox.ForeColor = Color.WhiteSmoke;
                enlemTextBox.ForeColor = Color.WhiteSmoke;
                boylamTextBox.ForeColor = Color.WhiteSmoke;
                haritaortala_checkbox.BackColor = haritaAracMenu.BackColor;
                enlemTextBox.BackColor = haritaAracMenu.BackColor;
                boylamTextBox.BackColor = haritaAracMenu.BackColor;
                gitButon.BackColor = haritaAracMenu.BackColor;
            }
            //-------------------------------TEMA BÖLÜMÜ SON----------------------------------------



            harita1.MapProvider = GMap.NET.MapProviders.GoogleHybridMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            harita1.Position = new GMap.NET.PointLatLng(39.9179769, 44.0351519);
            harita1.Zoom = 10;

        }
        private void bingHaritaToolStripMenuItem_Click(object sender, EventArgs e) //HARİTA SAĞLAYICISINI BING İLE DEĞİŞTİR
        {
            harita1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            harita1.ReloadMap();
        }

        private void wikiMapiaToolStripMenuItem_Click(object sender, EventArgs e) //HARİTA SAĞLAYICISINI WİKİMAPİA YAP
        {
            harita1.MapProvider = GMap.NET.MapProviders.WikiMapiaMapProvider.Instance;
            harita1.ReloadMap();
        }

        private void uyduHaritasıToolStripMenuItem_Click(object sender, EventArgs e) //HARİTA SAĞLAYICISINI GOOGLE UYDU GÖRÜNTÜSÜ YAP
        {
            harita1.MapProvider = GMap.NET.MapProviders.GoogleHybridMapProvider.Instance;
            harita1.ReloadMap();
        }

        private void şehirHaritasıToolStripMenuItem_Click(object sender, EventArgs e) //HARİTA SAĞLAYICISI GOOGLE ŞEHİR HARİTASI
        {
            harita1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            harita1.ReloadMap();
        }

        private void araziHaritasıToolStripMenuItem_Click(object sender, EventArgs e) //HARİTA SAĞLAYICISI GOOGLE ARAZİ HARİTASI
        {
            harita1.MapProvider = GMap.NET.MapProviders.GoogleTerrainMapProvider.Instance;
            harita1.ReloadMap();
        }
        //------------------HARİTA KONUMUNA GÖRE TEXTBOXLARI DEĞİŞTİR---------------------
        private void harita1_OnPositionChanged(GMap.NET.PointLatLng point)
        {
            enlemTextBox.Text = harita1.Position.Lat.ToString();
            boylamTextBox.Text = harita1.Position.Lng.ToString();
        }

        private void harita1_OnMapZoomChanged()
        {
            enlemTextBox.Text = harita1.Position.Lat.ToString();
            boylamTextBox.Text = harita1.Position.Lng.ToString();
        }
        //--------------------------------------------------------------------------------
        private void gitButon_Click(object sender, EventArgs e)
        {
            double enlem = Convert.ToDouble(enlemTextBox.Text);
            double boylam = Convert.ToDouble(boylamTextBox.Text);
            harita1.Position = new GMap.NET.PointLatLng(enlem, boylam);
        }

        private void haritaRoketEsle_Tick(object sender, EventArgs e) 
        {
            //bağlantı kurulmuş ve veri geliyorsa
            if (Properties.Settings.Default.serialportdurum == true) 
            {
                //eğer haritayı ortala seçeneğine tik atılmışsa
                if (haritaortala_checkbox.CheckState == CheckState.Checked) 
                {
                    //öncelikle enlem ve boylam verisini haritada gösterebilmek için bir takım dönüşümler yapmalıyız.
                    //1-enlem ve boylam verisini string formatından double formatına çevir.
                    //2-verileri çevirebilmek için öncelikle string içindeki '.' ve ',' işaretlerinin ne anlama geldiğini belirtmemiz lazım.
                    //3-eğer bu belirtmeyi yapmazsak string formatından double döndürürken '.' ve ',' işaretleri görmezden gelinir.
                    //4-bu da haritanın hatalı yeri göstermesine neden olur.
                    NumberFormatInfo provider = new NumberFormatInfo();
                    provider.NumberDecimalSeparator = ".";
                    provider.NumberGroupSeparator = ",";
                    double enlemDouble = Convert.ToDouble(Properties.Settings.Default.enlem, provider);
                    double boylamDouble = Convert.ToDouble(Properties.Settings.Default.boylam, provider);
                    try
                    {
                        harita1.Position = new PointLatLng(enlemDouble, boylamDouble);
                    }
                    catch
                    {
                        //bir şey olmamış gibi devam :D
                    }
                }
            } 
        }
    }
}
