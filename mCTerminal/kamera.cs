using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Xml;


namespace mCTerminal
{
    public partial class kamera : Form
    {
        public kamera()
        {
            InitializeComponent();
        }
        XmlTextReader xtr = new XmlTextReader(programyolu + @"res\settings.xml"); //XML dosyasını okumak için hazırlık yap
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        anaEkran anaEkranfrm = new anaEkran();
        string xmlAyarIsim;
        string xmlAyarDeger;
        public string programTema;
        public string programVeriFormat;
        public string programSurum;
        static string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;


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

        private void kamera_Load(object sender, EventArgs e)
        {
            editorAyarYukle();

            //-----------------------------temalar için ayrılmış bölüm---------------------------------

            if (programTema == "tema_varsayilan")
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.ForeColor = Color.WhiteSmoke;
                kameraAracMenu.BackColor = Color.FromArgb(50, 50, 50);
                toolStripDropDownButton1.ForeColor = Color.WhiteSmoke;
                toolStripDropDownButton2.ForeColor = Color.WhiteSmoke;
            }

            if (programTema == "tema_matrix")
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.DarkOliveGreen;
                kameraAracMenu.BackColor = Color.Black;
                toolStripDropDownButton1.ForeColor = Color.LimeGreen;
                toolStripDropDownButton2.ForeColor = Color.LimeGreen;
            }

            if (programTema == "tema_dondurma")
            {
                this.BackColor = Color.FromArgb(220, 229, 225);
                this.ForeColor = Color.IndianRed;
                kameraAracMenu.BackColor = Color.DarkSlateGray;
                toolStripDropDownButton1.ForeColor = Color.FromArgb(255, 230, 230);
                toolStripDropDownButton2.ForeColor = Color.FromArgb(255, 230, 230);
            }

            if (programTema == "tema_cosmos")
            {
                this.BackColor = Color.FromArgb(26, 16, 122);
                this.ForeColor = Color.FromArgb(245, 228, 183);
                kameraAracMenu.BackColor = Color.FromArgb(11, 75, 183);
                toolStripDropDownButton1.ForeColor = Color.FromArgb(245, 228, 183);
                toolStripDropDownButton2.ForeColor = Color.FromArgb(245, 228, 183);
            }

            if (programTema == "tema_material")
            {
                this.BackColor = Color.FromArgb(47, 79, 79);
                this.ForeColor = Color.FromArgb(251, 235, 235);
                kameraAracMenu.BackColor = Color.FromArgb(29, 61, 61);
                toolStripDropDownButton1.ForeColor = Color.WhiteSmoke;
                toolStripDropDownButton2.ForeColor = Color.WhiteSmoke;
            }
            //-------------------------------TEMA BÖLÜMÜ SON----------------------------------------

            videoCaptureBox.SizeMode = PictureBoxSizeMode.Zoom;
            //------------------------------DirectShow Cihazlarını belirleme ve yükleme----------------------
            try
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo kayit_cihazi in filterInfoCollection)
                    videoCaptureComboBox.Items.Add(kayit_cihazi.Name);
                videoCaptureComboBox.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();

                if (videoCaptureComboBox.Items != null) 
                {
                    //-------------------------DirectShow Cihazları okuma ve görüntü alma-----------------------
                    try
                    {
                        videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[videoCaptureComboBox.SelectedIndex].MonikerString);
                        videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                        videoCaptureDevice.VideoResolution = videoCaptureDevice.VideoCapabilities[0];
                        videoCaptureDevice.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Görüntü aygıtına bağlanırken bir hata meydana geldi! (" + ex.ToString() + ")", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //------------------------------------------------------------------------------------------
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Görüntü aygıtlarını yüklerken bir hata meydana geldi! (" + ex.ToString() + ")", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //----------------------------------------------------------------------------------------
            this.Text = "mCTerminal Uzak Görüntü | (" + videoCaptureComboBox.SelectedItem.ToString() + ")";
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                eventArgs.Frame.RotateFlip(RotateFlipType.Rotate180FlipNone);
                videoCaptureBox.Image = (Bitmap)eventArgs.Frame.Clone();
                
            }
            catch
            {
                MessageBox.Show("Görüntü İşleyici bir hata ile karşılaştı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoCaptureDevice.Stop();
        }

        private void videoCaptureButton_Click(object sender, EventArgs e)
        {
            //-------------------------DirectShow Cihazları okuma ve görüntü alma-----------------------
            try
            {
                videoCaptureDevice.Stop();
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[videoCaptureComboBox.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.VideoResolution = videoCaptureDevice.VideoCapabilities[0];
                videoCaptureDevice.Start();
                this.Text = "mCTerminal Uzak Görüntü | (" + videoCaptureComboBox.SelectedItem.ToString() + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Görüntü aygıtına bağlanırken bir hata meydana geldi! (" + ex.ToString() + ")", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //------------------------------------------------------------------------------------------
            
        }

        private void üstteGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Üstte göster butonu için
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
            //Tam Ekran - Küçük Ekran için
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

        private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
        //-------------------------------------------------------------------------------------------------------------------------
        //DirectShow cihazının çözünürlüğünü ayarlama kısmı (Çözünürlük değerini direkt giremiyoruz
        //bunun yerine DirectShow cihazının desteklediği çözünürlükleri alıp onların karşılık geldiği numarayı seçmeliyiz
        //videoCaptureDevice.VideoCapabilities[x] = x sayısı yerine desteklenen çözünürlüklere bağlı olarak 0'dan +sonsuz'a
        //kadar sayı gider. Bizim yer istasyonumuzda kullanacağımız sistemdeki video capture karta göre bu değerleri değiştireceğim
        //ama başka bir video kartıyla düzgün çalışmayacaktır çünkü program arayüzünde yazdığım çözünürlükle burada karşılık
        //gelen çözünürlük farklılık gösterecektir. Sadece bizim sistemimizde kullanılacağı için bir sıkıntı yok ama bu programı kullanmak isteyen
        //diğer kişiler kodları değiştirmeleri gerekecektir. Eğer üşenmezsem daha düzgün bir sistem eklerim.
        //--> Bizim kullandığımız USB Capture Card'a göre videoCaptureDevice.VideoCapabilities[0] = 720x480 çözünürlüğe denk geliyor.
        //--> Daha detaylı bilgi için: http://www.aforgenet.com/framework/docs/html/0992e0fc-d7a2-f882-2b40-42fa54236f4e.htm
        //--> Buna da bakmakta fayda var: https://stackoverflow.com/questions/19433853/how-to-set-video-resolution
        //-------------------------------------------------------------------------------------------------------------------------
        private void x576ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //maalesef böyle ilkel bir yol kullanmak zorundayım şuan :(
            videoCaptureDevice.Stop();
            videoCaptureDevice.VideoResolution = videoCaptureDevice.VideoCapabilities[1]; //index 1 720x576 oluyo
            videoCaptureDevice.Start();
            //--------------evet bu kadar ilkel oldum :(-------------------
            x576ToolStripMenuItem.CheckState = CheckState.Checked;
            x480ToolStripMenuItem.CheckState = CheckState.Unchecked;
            x480ToolStripMenuItem1.CheckState = CheckState.Unchecked;
            x240ToolStripMenuItem.CheckState = CheckState.Unchecked;
            x120ToolStripMenuItem.CheckState = CheckState.Unchecked;
            //-------------------------------------------------------------
        }

        private void x480ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            videoCaptureDevice.Stop();
            videoCaptureDevice.VideoResolution = videoCaptureDevice.VideoCapabilities[0]; //ilk başta bu indexler ters xd
            videoCaptureDevice.Start();
            //--------------evet bu kadar ilkel oldum :(-------------------
            x576ToolStripMenuItem.CheckState = CheckState.Unchecked;
            x480ToolStripMenuItem.CheckState = CheckState.Checked;
            x480ToolStripMenuItem1.CheckState = CheckState.Unchecked;
            x240ToolStripMenuItem.CheckState = CheckState.Unchecked;
            x120ToolStripMenuItem.CheckState = CheckState.Unchecked;
            //-------------------------------------------------------------
        }

        private void x480ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            videoCaptureDevice.Stop();
            videoCaptureDevice.VideoResolution = videoCaptureDevice.VideoCapabilities[2];
            videoCaptureDevice.Start();
            //--------------evet bu kadar ilkel oldum :(-------------------
            x576ToolStripMenuItem.CheckState = CheckState.Unchecked;
            x480ToolStripMenuItem.CheckState = CheckState.Unchecked;
            x480ToolStripMenuItem1.CheckState = CheckState.Checked;
            x240ToolStripMenuItem.CheckState = CheckState.Unchecked;
            x120ToolStripMenuItem.CheckState = CheckState.Unchecked;
            //-------------------------------------------------------------
        }

        private void x240ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            videoCaptureDevice.Stop();
            videoCaptureDevice.VideoResolution = videoCaptureDevice.VideoCapabilities[3];
            videoCaptureDevice.Start();
            //--------------evet bu kadar ilkel oldum :(-------------------
            x576ToolStripMenuItem.CheckState = CheckState.Unchecked;
            x480ToolStripMenuItem.CheckState = CheckState.Unchecked;
            x480ToolStripMenuItem1.CheckState = CheckState.Unchecked;
            x240ToolStripMenuItem.CheckState = CheckState.Checked;
            x120ToolStripMenuItem.CheckState = CheckState.Unchecked;
            //-------------------------------------------------------------
        }

        private void x120ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            videoCaptureDevice.Stop();
            videoCaptureDevice.VideoResolution = videoCaptureDevice.VideoCapabilities[4];
            videoCaptureDevice.Start();
            //--------------evet bu kadar ilkel oldum :(-------------------
            x576ToolStripMenuItem.CheckState = CheckState.Unchecked;
            x480ToolStripMenuItem.CheckState = CheckState.Unchecked;
            x480ToolStripMenuItem1.CheckState = CheckState.Unchecked;
            x240ToolStripMenuItem.CheckState = CheckState.Unchecked;
            x120ToolStripMenuItem.CheckState = CheckState.Checked;
            //-------------------------------------------------------------
        }
    }
}
