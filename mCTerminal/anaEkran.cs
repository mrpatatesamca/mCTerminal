using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.Windows.Media.Animation;
using System.Xml;

namespace mCTerminal
{
    
    public partial class anaEkran : Form
    {
        
        
        
        
        XmlTextReader xtr = new XmlTextReader(programyolu + @"res\settings.xml"); //XML dosyasını okumak için hazırlık yap
        




        //--------tablo grafiği için gerekli---------
        int maksm = 20, minm = 0;
        int gkuvvetmin = 0, gkuvvetmaks = 20;
        //-------------------------------------------

        //global değişkenler
        string xmlAyarIsim;
        string xmlAyarDeger;
        public string programTema;
        public string programVeriFormat;
        public string programSurum;
        static string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
        

        public anaEkran()
        {
            InitializeComponent();
            

            string[] portlar = SerialPort.GetPortNames(); //portlar listesine COM portları alındı.
            serialPort1.BaudRate = 9600; //baudrate ayarlama (daha sonra arayüz üzerinden değiştirilebilir)
            Control.CheckForIllegalCrossThreadCalls = false;

            //her bir bağlı olan COM bağlantıları ve Baud Rate için tek tek listeye ekleme yap
            foreach (string port in portlar)
            {
                COMPortList.Items.Add(port);
                COMPortList.SelectedIndex = 0;
            }
            //baudrate seçeneklerini ekle
            baudRatePortList.Items.Add("110");
            baudRatePortList.Items.Add("300");
            baudRatePortList.Items.Add("600");
            baudRatePortList.Items.Add("1200");
            baudRatePortList.Items.Add("2400");
            baudRatePortList.Items.Add("4800");
            baudRatePortList.Items.Add("9600");
            baudRatePortList.Items.Add("14400");
            baudRatePortList.Items.Add("19200");
            baudRatePortList.Items.Add("38400");
            baudRatePortList.Items.Add("57600");
            baudRatePortList.Items.Add("115200");
            baudRatePortList.Items.Add("128000");
            baudRatePortList.Items.Add("256000");
            baudRatePortList.SelectedIndex = 6; //seçili baudrate'i 9600 yapar (orionid projesi için)


            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

            string sadece_saat = DateTime.Now.ToString("hh:mm:ss");
            //-------------------------Formda altta bulunan yere yazdırılacak yazılar-------------------------
            hamVeriTextBox1.AppendText(sadece_saat + " --> Program başlatılıyor..." + Environment.NewLine);
            hamVeriTextBox1.AppendText(sadece_saat + " --> Gerekli ayarlamalar yapılıyor..." + Environment.NewLine);
            hamVeriTextBox1.AppendText(sadece_saat + " --> #--------------------------#" + Environment.NewLine);
            hamVeriTextBox1.AppendText(sadece_saat + " --> #   www.cosmostakimi.com   #" + Environment.NewLine);
            hamVeriTextBox1.AppendText(sadece_saat + " --> #--------------------------#" + Environment.NewLine);
            hamVeriTextBox1.AppendText(sadece_saat + " --> Program Yüklendi ve Kullanıma Hazır!" + Environment.NewLine);
            
            int line = hamVeriTextBox1.GetLineFromCharIndex(hamVeriTextBox1.SelectionStart); //textbox'ı otomatik olarak en aşağı kaydırıyor
            int column = hamVeriTextBox1.SelectionStart - hamVeriTextBox1.GetFirstCharIndexFromLine(line); //böylece en son gelen veriyi görebiliyoruz.
            //------------------------------------------------------------------------------------------------
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

        private void editorDosyaKontrolEt()
        {
            //----------Gerekli dosyaları kontrol et----------------------
            int eksikdosyasayi = 0;


            if (!File.Exists("AForge.dll"))
            {
                eksikdosyasayi += 1;
            }
            //----------
            if (!File.Exists("AForge.Video.DirectShow.dll"))
            {
                eksikdosyasayi += 1;
            }
            //----------
            if (!File.Exists("AForge.Video.dll"))
            {
                eksikdosyasayi += 1;
            }
            //----------
            if (!File.Exists("AGauge.dll"))
            {
                eksikdosyasayi += 1;
            }
            //----------
            if (!File.Exists("AxInterop.WMPLib.dll"))
            {
                eksikdosyasayi += 1;
            }
            //----------
            if (!File.Exists("DotNetZip.dll"))
            {
                eksikdosyasayi += 1;
            }
            //----------
            if (!File.Exists("GMap.NET.Core.dll"))
            {
                eksikdosyasayi += 1;
            }
            //----------
            if (!File.Exists("GMap.NET.WindowsForms.dll"))
            {
                eksikdosyasayi += 1;
            }
            //----------
            if (!File.Exists("Interop.WMPLib.dll"))
            {
                eksikdosyasayi += 1;
            }
            //----------
            if (!File.Exists("mct-upd.exe"))
            {
                eksikdosyasayi += 1;
            }
            //----------
            if (!File.Exists("mct-rd.exe"))
            {
                eksikdosyasayi += 1;
            }
            //----------
            if (!Directory.Exists("logs"))
            {
                eksikdosyasayi += 1;
            }
            //----------
            if (!Directory.Exists("map_datab"))
            {
                eksikdosyasayi += 1;
            }
            //----------
            if (!File.Exists(programyolu + @"res\settings.xml"))
            {
                eksikdosyasayi += 1;
            }
            //--------------
            if (!File.Exists(programyolu + @"res\chiptune2.mp3"))
            {
                eksikdosyasayi += 1;
            }



            if (eksikdosyasayi >= 1) //eğer bu sayı 0 veya 1'e eşit ise eksik dosyalar var demektir.
            {
                eksikdosyaForm eksikdosyafrm = new eksikdosyaForm();
                eksikdosyafrm.ShowDialog();
            }
        }

        private void editorTemaYukle()
        {
            //temalar için ayrılmış bölüm
            if (programTema == "tema_varsayilan")
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.ForeColor = Color.WhiteSmoke;
                hamVeriTextBox1.BackColor = Color.FromArgb(20, 20, 20);
                hamVeriTextBox1.ForeColor = Color.WhiteSmoke;
                toolStrip1.BackColor = Color.FromArgb(50, 50, 50);
                toolStripDropDownButton1.ForeColor = Color.WhiteSmoke;
                toolStripDropDownButton2.ForeColor = Color.WhiteSmoke;
                toolStripDropDownButton3.ForeColor = Color.WhiteSmoke;
                toolStripDropDownButton4.ForeColor = Color.WhiteSmoke;
                toolStripDropDownButton5.ForeColor = Color.WhiteSmoke;
                toolStripDropDownButton6.ForeColor = Color.WhiteSmoke;
                ortagovdeDurumLabel.ForeColor = Color.WhiteSmoke;
                irtifaMaxLabel.ForeColor = Color.WhiteSmoke;
                irtifaAnlıkLabel.ForeColor = Color.WhiteSmoke;
                hdopLabel.ForeColor = Color.WhiteSmoke;
                anlikİrtifaGrafik.Titles[0].ForeColor = Color.WhiteSmoke;
                gkuvvetGrafik.Titles[0].ForeColor = Color.WhiteSmoke;
            }
            //---------------------
            if (programTema == "tema_matrix")
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.DarkOliveGreen;
                hamVeriTextBox1.BackColor = Color.FromArgb(10, 12, 10);
                hamVeriTextBox1.ForeColor = Color.LimeGreen;
                toolStrip1.BackColor = Color.Black;
                toolStripDropDownButton1.ForeColor = Color.LimeGreen;
                toolStripDropDownButton2.ForeColor = Color.LimeGreen;
                toolStripDropDownButton3.ForeColor = Color.LimeGreen;
                toolStripDropDownButton4.ForeColor = Color.LimeGreen;
                toolStripDropDownButton5.ForeColor = Color.LimeGreen;
                toolStripDropDownButton6.ForeColor = Color.LimeGreen;
                ortagovdeDurumLabel.ForeColor = Color.DarkOliveGreen;
                irtifaMaxLabel.ForeColor = Color.DarkOliveGreen;
                irtifaAnlıkLabel.ForeColor = Color.DarkOliveGreen;
                hdopLabel.ForeColor = Color.DarkOliveGreen;
                anlikİrtifaGrafik.Titles[0].ForeColor = Color.DarkOliveGreen;
                gkuvvetGrafik.Titles[0].ForeColor = Color.DarkOliveGreen;
            }
            //---------------------
            if (programTema == "tema_dondurma")
            {
                this.BackColor = Color.FromArgb(220, 229, 225);
                this.ForeColor = Color.IndianRed;
                hamVeriTextBox1.BackColor = Color.LightSlateGray;
                hamVeriTextBox1.ForeColor = Color.NavajoWhite;
                irtifaAnlıkLabel.ForeColor = Color.IndianRed;
                irtifaMaxLabel.ForeColor = Color.IndianRed;
                hdopLabel.ForeColor = Color.IndianRed;
                ortagovdeDurumLabel.ForeColor = Color.IndianRed;
                toolStrip1.BackColor = Color.DarkSlateGray;
                toolStripDropDownButton1.ForeColor = Color.FromArgb(255, 230, 230);
                toolStripDropDownButton2.ForeColor = Color.FromArgb(255, 230, 230);
                toolStripDropDownButton3.ForeColor = Color.FromArgb(255, 230, 230);
                toolStripDropDownButton4.ForeColor = Color.FromArgb(255, 230, 230);
                toolStripDropDownButton5.ForeColor = Color.FromArgb(255, 230, 230);
                toolStripDropDownButton6.ForeColor = Color.FromArgb(255, 230, 230);
                anlikİrtifaGrafik.Titles[0].ForeColor = Color.IndianRed;
                gkuvvetGrafik.Titles[0].ForeColor = Color.IndianRed;
            }
            //---------------------
            if (programTema == "tema_cosmos")
            {
                this.BackColor = Color.FromArgb(26, 16, 122);
                this.ForeColor = Color.FromArgb(245, 228, 183);
                hamVeriTextBox1.BackColor = Color.FromArgb(6, 0, 102);
                hamVeriTextBox1.ForeColor = Color.BurlyWood;
                ortagovdeDurumLabel.ForeColor = Color.FromArgb(245, 228, 183);
                irtifaMaxLabel.ForeColor = Color.FromArgb(245, 228, 183);
                irtifaAnlıkLabel.ForeColor = Color.FromArgb(245, 228, 183);
                hdopLabel.ForeColor = Color.FromArgb(245, 228, 183);
                toolStrip1.BackColor = Color.FromArgb(11, 75, 183);
                toolStripDropDownButton1.ForeColor = Color.FromArgb(245, 228, 183);
                toolStripDropDownButton2.ForeColor = Color.FromArgb(245, 228, 183);
                toolStripDropDownButton3.ForeColor = Color.FromArgb(245, 228, 183);
                toolStripDropDownButton4.ForeColor = Color.FromArgb(245, 228, 183);
                toolStripDropDownButton5.ForeColor = Color.FromArgb(245, 228, 183);
                toolStripDropDownButton6.ForeColor = Color.FromArgb(245, 228, 183);
                anlikİrtifaGrafik.Titles[0].ForeColor = Color.FromArgb(245, 228, 183);
                gkuvvetGrafik.Titles[0].ForeColor = Color.FromArgb(245, 228, 183);
            }
            //---------------------
            if (programTema == "tema_material")
            {
                this.BackColor = Color.FromArgb(47, 79, 79);
                this.ForeColor = Color.FromArgb(251, 235, 235);
                hamVeriTextBox1.BackColor = Color.FromArgb(72, 96, 74);
                hamVeriTextBox1.ForeColor = Color.FromArgb(255, 185, 105);
                toolStrip1.BackColor = Color.FromArgb(29, 61, 61);
                toolStripDropDownButton1.ForeColor = Color.WhiteSmoke;
                toolStripDropDownButton2.ForeColor = Color.WhiteSmoke;
                toolStripDropDownButton3.ForeColor = Color.WhiteSmoke;
                toolStripDropDownButton4.ForeColor = Color.WhiteSmoke;
                toolStripDropDownButton5.ForeColor = Color.WhiteSmoke;
                toolStripDropDownButton6.ForeColor = Color.WhiteSmoke;
                ortagovdeDurumLabel.ForeColor = Color.FromArgb(251, 235, 235);
                hdopLabel.ForeColor = Color.FromArgb(251, 235, 235);
                irtifaMaxLabel.ForeColor = Color.FromArgb(251, 235, 235);
                irtifaAnlıkLabel.ForeColor = Color.FromArgb(251, 235, 235);
                anlikİrtifaGrafik.Titles[0].ForeColor = Color.FromArgb(251, 235, 235);
                gkuvvetGrafik.Titles[0].ForeColor = Color.FromArgb(251, 235, 235);
            }

            baglantiNoktasi_label.ForeColor = this.ForeColor;
            baglantiHizi_label.ForeColor = this.ForeColor;
            aliciModeli_label.ForeColor = this.ForeColor;
            uyduSayiLabel.ForeColor = this.ForeColor;
            AciXLabel.ForeColor = this.ForeColor;
            aciYLabel.ForeColor = this.ForeColor;
            enlemLabel.ForeColor = this.ForeColor;
            boylamLabel.ForeColor = this.ForeColor;
            gkuvvetLabel.ForeColor = this.ForeColor;
            irtifaLabel.ForeColor = this.ForeColor;
            barometrikİrtifaMaksLabel.ForeColor = this.ForeColor;
            yatayHizLabel.ForeColor = this.ForeColor;
            koniDurumLabel.ForeColor = this.ForeColor;
            kameraDurumLabel.ForeColor = this.ForeColor;

            //-----------------------------------------------------------
        }

        private void anaEkran_Load(object sender, EventArgs e)
        {
            editorDosyaKontrolEt();
            editorAyarYukle();
            editorTemaYukle();
            beklemeEkranıAcTimer.Start();

            //Form adını ayarlar
            this.Text = "mCTerminal " + programSurum + " | [@" + Environment.MachineName + "]";

            //Ham veri'nin yazıldığı textbox'ın düzgün gözükmesi için
            hamVeriTextBox1.SelectionStart = hamVeriTextBox1.Text.Length;

            //Eski güncelleme aracını kaldırır. (mCTerminal-updater2.exe yeni sürüm, kaldırılacak sürüm: mCTerminal-updater.exe)
            try
            {
                File.Delete("mCTerminal-updater.exe");
            }
            catch
            {
                //bir şey olmamış gibi devam :D
            }

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string sadece_saat = DateTime.Now.ToString("hh:mm:ss");
            string[] splitted_data;
            string data;
            try
            {
                data = serialPort1.ReadLine();
                splitted_data = data.Split('*');
                Properties.Settings.Default.data = data;

                uyduSayiLabel.Text = "Bağlanılan Uydu Sayısı " + splitted_data[0]; //gps uydu sayısı
                hdopLabel.Text = "HDOP: " + splitted_data[1]; //hdop sapması
                enlemLabel.Text = "Enlem: " + splitted_data[2] + "°"; //enlem
                Properties.Settings.Default.enlem = splitted_data[2]; //global değişkene de yaz enlemi
                boylamLabel.Text = "Boylam: " + splitted_data[3] + "°"; //boylam
                Properties.Settings.Default.boylam = splitted_data[3]; //global değikene de yaz boylamı
                irtifaLabel.Text = "İrtifa: " + splitted_data[4] + "m"; //gps irtifa
                irtifaMaxLabel.Text = "Maks İrtifa: " + splitted_data[5] + "m"; //gps maks irtifa
                yatayHizLabel.Text = "Yatay Hız: " + splitted_data[6] + "km/s"; //yatay hız
                AciXLabel.Text = "X Açısı: " + splitted_data[8] + "°"; //x açısı
                Properties.Settings.Default.aciX = splitted_data[8]; // global değişkene de yaz x açısını
                aciYLabel.Text = "Y Açısı: " + splitted_data[9] + "°"; //y açısı
                Properties.Settings.Default.aciY = splitted_data[9]; // global değişkene de yaz y açısını
                gkuvvetLabel.Text = "G Kuvveti: " + splitted_data[10] + "g"; //g kuvveti
                Properties.Settings.Default.gkuvvet = splitted_data[10]; //global değişkene de yaz g kuvvetini
                barometrikİrtifaMaksLabel.Text = "Barometrik Maksimum İrtifa: " + splitted_data[11] + "m"; //baro irtifa maks
                irtifaAnlıkLabel.Text = "Anlık İrtifa: " + splitted_data[12] + "m"; //anlık irtifa


                Properties.Settings.Default.konidurum = splitted_data[13]; //global değişken koni durumu
                Properties.Settings.Default.ortagovdedurum = splitted_data[14]; //global değişken orta gövde durumu
                Properties.Settings.Default.ortagovdedurum = splitted_data[7]; //global değişken kamera durumu


                //----------bağlantı durumunu gösteren simgenin ayarlanması--------
                baglantiDurumPictureBox.Image = Properties.Resources.dot_yesil;
                //-----------------------------------------------------------------


                //Gelen veriyi formun altında gözüken siyah yere (TextBox) yazıyorum.
                hamVeriTextBox1.AppendText(sadece_saat + " --> " + data + Environment.NewLine);
                int line = hamVeriTextBox1.GetLineFromCharIndex(hamVeriTextBox1.SelectionStart); //otomatik en aşağı kaydırması için
                int column = hamVeriTextBox1.SelectionStart - hamVeriTextBox1.GetFirstCharIndexFromLine(line); //otomatik en aşağı kaydırması için

                if (splitted_data[7] == "1") //kamera durumu 1 ise
                {
                    kameraDurumLabel.Text = "Video Yayını: Aktif!";
                }
                else
                {
                    kameraDurumLabel.Text = "Video Yayını: Aktif Değil!";
                }

                if (splitted_data[13] == "1") //koni ayrılmış ise
                {
                    koniDurumLabel.Text = "Koni: Ayrıldı!";
                }
                else
                {
                    koniDurumLabel.Text = "Koni: Ayrılmadı!";
                }

                if (splitted_data[14] == "1") //orta göve ayrılmış ise
                {
                    ortagovdeDurumLabel.Text = "Orta Gövde: Ayrıldı!";
                }
                else
                {
                    ortagovdeDurumLabel.Text = "Orta Gövde: Ayrılmadı!";
                }

                //---------------------------------GRAFİK KUTULARI-----------------------------------
                //-----------------------------------ANLIK İRTİFA GRAFİĞİ----------------------------------
                anlikİrtifaGrafik.ChartAreas[0].AxisX.Minimum = minm;
                anlikİrtifaGrafik.ChartAreas[0].AxisX.Maximum = maksm;
                anlikİrtifaGrafik.ChartAreas[0].AxisY.Minimum = 0;
                anlikİrtifaGrafik.ChartAreas[0].AxisY.Maximum = 3500;
                anlikİrtifaGrafik.ChartAreas[0].AxisX.ScaleView.Zoom(minm, maksm);
                this.anlikİrtifaGrafik.Series[0].Points.AddXY((minm + maksm) / 2, splitted_data[12]);
                //---------------------------------G KUVVETİ GRAFİĞİ---------------------------------
                gkuvvetGrafik.ChartAreas[0].AxisX.Minimum = gkuvvetmin;
                gkuvvetGrafik.ChartAreas[0].AxisX.Maximum = gkuvvetmaks;
                gkuvvetGrafik.ChartAreas[0].AxisY.Minimum = 0;
                gkuvvetGrafik.ChartAreas[0].AxisY.Maximum = 5;
                gkuvvetGrafik.ChartAreas[0].AxisX.ScaleView.Zoom(gkuvvetmin, gkuvvetmaks);
                this.gkuvvetGrafik.Series[0].Points.AddXY((gkuvvetmin + gkuvvetmaks) / 2, splitted_data[10]);
                //-----------------------------------------------------------------------------------
                gkuvvetmin++;
                gkuvvetmaks++;
                maksm++;
                minm++;
                //----------------------------------GRAFİK KUTULARI SON------------------------------

                //--------------------------İBRE KUTULARI--------------------------------
                gKuvvetGauge.Value = Convert.ToInt32(splitted_data[10]); //gkuvvet
                yatayHizGauge.Value = Convert.ToInt32(splitted_data[6]); //yatay hız
                maksİrtifaGauge.Value = Convert.ToInt32(splitted_data[5]); //gps maks irtifa
                irtifaGauge.Value = Convert.ToInt32(splitted_data[4]); //gps irtifa
                AciXGauge.Value = Convert.ToInt32(splitted_data[8]); //x açısı
                AciYGauge.Value = Convert.ToInt32(splitted_data[9]); //y açısı
                //-------------------------İBRE KUTULARI SON-------------------------------

                //-------------------------------SİMGELERİN DURUMU---------------------------------------
                int hdop_durum_sayi = Convert.ToInt32(splitted_data[1]);
                int baglanilan_uydu_sayisi_durum_sayi = Convert.ToInt32(splitted_data[0]);
                //-----hdop durumu-----
                if (hdop_durum_sayi <= 2)
                {
                    hdopPictureBox.Image = Properties.Resources.snr_seviye_yesil;
                }
                if (hdop_durum_sayi > 2 && hdop_durum_sayi <= 4)
                {
                    hdopPictureBox.Image = Properties.Resources.snr_seviye_sari;
                }
                if (hdop_durum_sayi > 4)
                {
                    hdopPictureBox.Image = Properties.Resources.snr_seviye_kirmizi;
                }
                //---hdop durumu son---

                //-----gps uydu durumu-----
                if (baglanilan_uydu_sayisi_durum_sayi <= 4)
                {
                    uyduPictureBox.Image = Properties.Resources.uydu_kirmizi;
                }
                if (baglanilan_uydu_sayisi_durum_sayi > 4 && hdop_durum_sayi <= 7)
                {
                    uyduPictureBox.Image = Properties.Resources.uydu_sari;
                }
                if (baglanilan_uydu_sayisi_durum_sayi > 7)
                {
                    uyduPictureBox.Image = Properties.Resources.uydu_yesil;
                }
                //---gps uydu durumu son---

                //-------------------------------SİMGELERİN DURUMU SON-----------------------------------

                //VERİ ÇIKTISINI KAYDETMEK İÇİN VERİ KAYDET BUTONUNU KONTROL EDER VE ONA GÖRE VERİYİ YAZAR
                if (verikaydetToolStripMenuItem.CheckState == CheckState.Checked)
                {
                    string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
                    string sadece_tarih = DateTime.Now.ToString("dd-MM-yyyy");
                    string kayitformati = programVeriFormat;
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(programyolu + @"logs\" + "roketLog-" + sadece_tarih.ToString() + kayitformati, true)) //Log yerine kullanılabilecek Türkçe bir karşılık bulamadım, belki Veri çıktısı diyebiliriz ama Log kavramı daha evrensel olduğu için böyle yazdım.
                    {
                        file.WriteLine(sadece_saat + " --> " + data);
                    }
                    kayitdurumPictureBox.Image = mCTerminal.Properties.Resources.pen_drive_yesil;
                    
                }
                else
                {
                    kayitdurumPictureBox.Image = mCTerminal.Properties.Resources.pen_drive_kirmizi;
                    
                }
                //-------------------------------------------VERİ KAYIT SON------------------------------------------  
            }
            catch
            {

            }
        }

        private void bağlantıyıBaşlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorBaglantiBaslat();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hakkında ekranını gösterir.
            hakkinda hakkindafrm = new hakkinda();
            hakkindafrm.Show();
        }

        private void anaEkran_FormClosing(object sender, FormClosingEventArgs e)
        {

            Environment.Exit(0);
        }

        private void haritayıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            harita haritafrm = new harita();
            haritafrm.Show();
        }

        private void hamVeriyiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hamveriekrani hamveriekranifrm = new hamveriekrani();
            hamveriekranifrm.Show();
        }

        private void destekSayfasınaGitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mrpatatesamca/mCTerminal");
        }

        private void uzakGörüntüyüGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kamera kamerafrm = new kamera();
            kamerafrm.Show();
        }

        private void tumselKontrolleriAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bütün gerekli pencereleri özel boyutta ve konumda açar
            kamera kamerafrm = new kamera();
            hamveriekrani hamveriekranifrm = new hamveriekrani();
            harita haritafrm = new harita();

            hamveriekranifrm.Show();
            hamveriekranifrm.Height = 230;
            hamveriekranifrm.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - kamerafrm.Height + 90);
            
            kamerafrm.Show();
            kamerafrm.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - kamerafrm.Height - hamveriekranifrm.Height);

            haritafrm.Show();
            haritafrm.Height = 530;
            haritafrm.Location = new Point(Screen.PrimaryScreen.Bounds.Width - haritafrm.Width, Screen.PrimaryScreen.Bounds.Height - haritafrm.Height);

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
            //------------------------------------------------------------------
        }

        private void COMPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglantiNoktasi_label.Text = "Bağlantı Noktası: " + COMPortList.SelectedItem.ToString();
            serialPort1.PortName = COMPortList.Text;
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

        private void verikaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorVeriKaydet();
        }

        private void tamEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form'un o anki durumuna göre değişen pencere ayarı.
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
            //----------------------------------------------------------
        }

        private void programiyenidenbaslatStripMenuItem2_Click(object sender, EventArgs e)
        {
            editorProgramYenidenBaslat();
        }

        private void baglantiListeYenileButton_Click(object sender, EventArgs e)
        {
            editorBaglantiYenile();
            baglantiYenileİkonDuzeltTimer.Start();
        }

        private void baudRatePortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglantiHizi_label.Text = "Bağlantı Hızı: " + baudRatePortList.SelectedItem.ToString();
            serialPort1.BaudRate = Convert.ToInt32(baudRatePortList.Text);
        }

        private void roketŞemasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roketsema roketsemafrm = new roketsema();
            roketsemafrm.Show();
        }

        private void beklemeEkranıAcTimer_Tick(object sender, EventArgs e)
        {
            //bekleme ekranını açar (sırf hoş gözüksün diye yoksa işlevsellik yok xd)
            beklemeEkranıAcTimer.Stop();
            
            programListeYenileForm programListeYenileFormfrm = new programListeYenileForm();
            programListeYenileFormfrm.Show();
            beklemeEkranıAcTimer.Stop();
        }

        private void ciktoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void editorBaglantiBaslat()
        {
            string sadece_saat = DateTime.Now.ToString("hh:mm:ss");
            string sadece_tarih = DateTime.Now.ToString("dd-MM-yyyy");
            baglantiDurumPictureBox.Image = Properties.Resources.dot_sari;

            if (!serialPort1.IsOpen) //Bağlantı kurulmamışsa.
            {
                if (COMPortList.SelectedIndex < 0) //Bağlantı noktası boş olduğu zaman program çöküyor bu yüzden kullanıcıyı bilgilendiriyorum ve çökmesini engelliyorum.
                {
                    MessageBox.Show("Hata! Alıcı sistem ile bağlantı kurulamadı! Lütfen alıcıyı bilgisayarınıza bağladığınızdan emin olunuz, eğer zaten bağlıysa kabloları kontrol ediniz. (Detay: Muhtemel Liste Boşluğu)", "Alıcı Sistem Bulunamadı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hamVeriTextBox1.AppendText(sadece_saat + " --> Bağlantı noktası ile iletişim kurulamadı! (Muhtemel Liste Boşluğu)" + Environment.NewLine);
                }
                else //liste boş değil ve bağlantı kurulmamış ise.
                {
                    serialPort1.PortName = COMPortList.Text;
                    try
                    {
                        serialPort1.Open();
                        Properties.Settings.Default.serialportdurum = true;

                        bağlantıyıBaşlatToolStripMenuItem.Text = "Bağlantıyı Kes";
                        hamVeriTextBox1.AppendText(Environment.NewLine);
                        hamVeriTextBox1.AppendText(sadece_saat + " --> Bağlantı " + COMPortList.Text + " üzerinden " + sadece_tarih + "</>" + sadece_saat + " tarihinde başlatıldı!");
                        hamVeriTextBox1.AppendText(Environment.NewLine);

                        //log kayıtlarında da karışıklık olmasın diye eğer kayıt etme açıksa bir kaç bilgi yazılır kayıt dosyasına
                        if (verikaydetToolStripMenuItem.CheckState == CheckState.Checked)
                        {
                            string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
                            string kayitformati = programVeriFormat;
                            using (System.IO.StreamWriter file = new System.IO.StreamWriter(programyolu + @"logs\" + "roketLog-" + sadece_tarih.ToString() + kayitformati, true)) //Log yerine kullanılabilecek Türkçe bir karşılık bulamadım, belki Veri çıktısı diyebiliriz ama Log kavramı daha evrensel olduğu için böyle yazdım.
                            {
                                file.WriteLine("----------------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
                                file.WriteLine(sadece_saat + " --> Bağlantı " + COMPortList.Text + " üzerinden " + sadece_tarih + "</>" + sadece_saat + " tarihinde başlatıldı!" + Environment.NewLine);
                                file.WriteLine("----------------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata! Alıcıdan veri alınırken bir problem oluştu. (Detay: " + ex.Message.ToString() + ")", "Alıcı sistem algılanamadı !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hamVeriTextBox1.AppendText(sadece_saat + " --> Alıcıdan veri alırken bir problem oluştu! (" + ex.Message.ToString() + ")" + Environment.NewLine);
                    }
                }
            }
            else //Eğer bağlantı zaten kurulmuşsa bağlantıyı kes.
            {
                editorBaglantiKes();
            }
        }

        public void editorBaglantiKes()
        {
            string sadece_saat = DateTime.Now.ToString("hh:mm:ss");
            string sadece_tarih = DateTime.Now.ToString("dd-MM-yyyy");

            serialPort1.Close();
            Properties.Settings.Default.serialportdurum = false;
            baglantiDurumPictureBox.Image = Properties.Resources.dot_kirmizi;
            bağlantıyıBaşlatToolStripMenuItem.Text = "Bağlantıyı Kur";
            hamVeriTextBox1.AppendText(sadece_saat + " --> " + COMPortList.Text + " üzerindeki bağlantı " + sadece_tarih + "</>" + sadece_saat + " tarihinde sonlandırıldı!");
            hamVeriTextBox1.AppendText(Environment.NewLine);

            //log kayıtlarında da karışıklık olmasın diye eğer kayıt etme açıksa bir kaç bilgi yazılır kayıt dosyasına
            if (verikaydetToolStripMenuItem.CheckState == CheckState.Checked)
            {
                string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
                string kayitformati = programVeriFormat;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(programyolu + @"logs\" + "roketLog-" + sadece_tarih.ToString() + kayitformati, true)) //Log yerine kullanılabilecek Türkçe bir karşılık bulamadım, belki Veri çıktısı diyebiliriz ama Log kavramı daha evrensel olduğu için böyle yazdım.
                {
                    file.WriteLine("----------------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
                    file.WriteLine(sadece_saat + " --> " + COMPortList.Text + " üzerindeki bağlantı " + sadece_tarih + "</>" + sadece_saat + " tarihinde sonlandırıldı!" + Environment.NewLine);
                    file.WriteLine("----------------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
                }
            }
        }

        public void editorBaglantiYenile()
        {
            //bekleme ekranını açar (sırf hoş gözüksün diye yoksa işlevsellik yok xd)
            programListeYenileForm programListeYenileFormfrm = new programListeYenileForm();
            programListeYenileFormfrm.Show();

            editorBaglantiKes(); //program bağlantısını keser.
            baudRatePortList.Items.Clear();
            serialPort1.Close(); //serial portunu kapatır.
            COMPortList.Items.Clear(); //listeyi temizle.
            string[] portlar = SerialPort.GetPortNames(); //portlar listesine COM portları alındı.
            serialPort1.BaudRate = 9600; //baudrate ayarlama (daha sonra arayüz üzerinden değiştirilebilir)
            Control.CheckForIllegalCrossThreadCalls = false;

            //her bir bağlı olan COM bağlantıları ve Baud Rate için tek tek listeye ekleme yap
            foreach (string port in portlar)
            {
                COMPortList.Items.Add(port);
                COMPortList.SelectedIndex = 0;
            }
            //baudrate seçeneklerini ekle
            baudRatePortList.Items.Add("110");
            baudRatePortList.Items.Add("300");
            baudRatePortList.Items.Add("600");
            baudRatePortList.Items.Add("1200");
            baudRatePortList.Items.Add("2400");
            baudRatePortList.Items.Add("4800");
            baudRatePortList.Items.Add("9600");
            baudRatePortList.Items.Add("14400");
            baudRatePortList.Items.Add("19200");
            baudRatePortList.Items.Add("38400");
            baudRatePortList.Items.Add("57600");
            baudRatePortList.Items.Add("115200");
            baudRatePortList.Items.Add("128000");
            baudRatePortList.Items.Add("256000");
            baudRatePortList.SelectedIndex = 6; //seçili baudrate'i 9600 yapar (orionid projesi için)
        }

        public void editorVeriKaydet()
        {
            if (verikaydetToolStripMenuItem.CheckState == CheckState.Unchecked)
            {
                verikaydetToolStripMenuItem.CheckState = CheckState.Checked;
                kayitdurumPictureBox.Image = mCTerminal.Properties.Resources.pen_drive_yesil;
                toolTip1.SetToolTip(kayitdurumPictureBox, "Veri kayıtı yapılıyor!");
                verikaydetToolStripMenuItem.Text = "Veri Çıktısını Kaydetme";
                toolTip1.ToolTipIcon = ToolTipIcon.Info;
            }
            else
            {
                verikaydetToolStripMenuItem.CheckState = CheckState.Unchecked;
                kayitdurumPictureBox.Image = mCTerminal.Properties.Resources.pen_drive_kirmizi;
                toolTip1.SetToolTip(kayitdurumPictureBox, "Veri kayıtı yapılmıyor!");
                verikaydetToolStripMenuItem.Text = "Veri Çıktısını Kaydet";
                toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            }
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayarlar ayarlarfrm = new ayarlar();
            ayarlarfrm.Show();
        }

        private void güncelleştirmeleriKontrolEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                Process.Start(programyolu + @"mct-upd.exe");

            }
            catch
            {
                MessageBox.Show("Güncelleme aracı başlatılamadı! Lütfen dosyaların konumunu kontrol edin.", "Program başlatılamadı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hataGidermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eksikdosyaForm eksikdosyafrm = new eksikdosyaForm();
            eksikdosyafrm.Show();
        }

        private void kayıtlıVeriOkuyucuMctrdexeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mct-rd.exe");
        }

        private void baglantiYenileİkonDuzeltTimer_Tick(object sender, EventArgs e)
        {
            baglantiDurumPictureBox.Image = Properties.Resources.dot; //bağlantı durumu ikonunu düzelt.
        }

        public void editorProgramYenidenBaslat()
        {
            System.Diagnostics.Process.Start("mCTerminal.exe");
            Application.Exit();
        }
    }
}
//Bu proje Cosmos Takımı üyesi "Berke AYDİN" nam-ı diğer "MRpatatesAmca" tarafından yazılmıştır.