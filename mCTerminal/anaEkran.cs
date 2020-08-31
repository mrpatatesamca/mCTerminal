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

        //global değişkenler
        public string xmlAyarIsim;
        public string xmlAyarDeger;
        public string[] splitted_data;
        public string data;
        public int gecenSalise;
        public int gecenSaniye;
        public int gecenDakika;
        public int gecenSaat;
        public string programTema;
        public string programVeriFormat;
        public string programSurum;
        static string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;

        public string veri_uydu_sayi;
        public string veri_hdop;
        public string veri_enlem;
        public string veri_boylam;
        public string veri_base_gps_irtifa;
        public string veri_gps_irtifa;
        public string veri_maksimum_gps_irtifa;
        public string veri_suruklenme_hiz;
        public string veri_kamera_durum;
        public string veri_aciX;
        public string veri_aciY;
        public string veri_gKuvvet;
        public string veri_maksimum_gKuvvet;
        public string veri_base_barometrik_irtifa;
        public string veri_barometrik_irtifa;
        public string veri_maksimum_barometrik_irtifa;
        public string veri_orta_govde_base_gps_irtifa;
        public string veri_orta_govde_gps_irtifa;
        public string veri_orta_govde_maksimum_gps_irtifa;
        public string veri_orta_govde_hdop;
        public string veri_orta_govde_enlem;
        public string veri_orta_govde_boylam;
        public string veri_faz1_durum;
        public string veri_faz2_durum;


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

            string sadece_saat = DateTime.Now.ToString("HH:mm:ss");
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
                baseGpsİrtifaLabel.ForeColor = Color.WhiteSmoke;
                hdopLabel.ForeColor = Color.WhiteSmoke;
                gecenSureLabel.BackColor = toolStrip1.BackColor;
                saatLabel.BackColor = toolStrip1.BackColor;
                gecenSureLabel.ForeColor = Color.WhiteSmoke;
                saatLabel.ForeColor = Color.WhiteSmoke;
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
                baseGpsİrtifaLabel.ForeColor = Color.DarkOliveGreen;
                hdopLabel.ForeColor = Color.DarkOliveGreen;
                gecenSureLabel.BackColor = toolStrip1.BackColor;
                saatLabel.BackColor = toolStrip1.BackColor;
                gecenSureLabel.ForeColor = Color.LimeGreen;
                saatLabel.ForeColor = Color.LimeGreen;
            }
            //---------------------
            if (programTema == "tema_dondurma")
            {
                this.BackColor = Color.FromArgb(220, 229, 225);
                this.ForeColor = Color.IndianRed;
                hamVeriTextBox1.BackColor = Color.LightSlateGray;
                hamVeriTextBox1.ForeColor = Color.NavajoWhite;
                baseGpsİrtifaLabel.ForeColor = Color.IndianRed;
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
                gecenSureLabel.BackColor = toolStrip1.BackColor;
                saatLabel.BackColor = toolStrip1.BackColor;
                gecenSureLabel.ForeColor = Color.FromArgb(255, 230, 230);
                saatLabel.ForeColor = Color.FromArgb(255, 230, 230);
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
                baseGpsİrtifaLabel.ForeColor = Color.FromArgb(245, 228, 183);
                hdopLabel.ForeColor = Color.FromArgb(245, 228, 183);
                toolStrip1.BackColor = Color.FromArgb(11, 75, 183);
                toolStripDropDownButton1.ForeColor = Color.FromArgb(245, 228, 183);
                toolStripDropDownButton2.ForeColor = Color.FromArgb(245, 228, 183);
                toolStripDropDownButton3.ForeColor = Color.FromArgb(245, 228, 183);
                toolStripDropDownButton4.ForeColor = Color.FromArgb(245, 228, 183);
                toolStripDropDownButton5.ForeColor = Color.FromArgb(245, 228, 183);
                toolStripDropDownButton6.ForeColor = Color.FromArgb(245, 228, 183);
                gecenSureLabel.BackColor = toolStrip1.BackColor;
                saatLabel.BackColor = toolStrip1.BackColor;
                gecenSureLabel.ForeColor = Color.FromArgb(245, 228, 183);
                saatLabel.ForeColor = Color.FromArgb(245, 228, 183);
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
                baseGpsİrtifaLabel.ForeColor = Color.FromArgb(251, 235, 235);
                gecenSureLabel.BackColor = toolStrip1.BackColor;
                saatLabel.BackColor = toolStrip1.BackColor;
                gecenSureLabel.ForeColor = Color.WhiteSmoke;
                saatLabel.ForeColor = Color.WhiteSmoke;
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
            suruklenmeHizLabel.ForeColor = this.ForeColor;
            koniDurumLabel.ForeColor = this.ForeColor;
            kameraDurumLabel.ForeColor = this.ForeColor;
            groupBox1.ForeColor = toolStripDropDownButton1.ForeColor;
            groupBox2.ForeColor = toolStripDropDownButton1.ForeColor;

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

            baudRatePortList.Visible = false;


        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string sadece_saat = DateTime.Now.ToString("HH:mm:ss");
            try
            {
                data = serialPort1.ReadLine();
                splitted_data = data.Split('*');
                Properties.Settings.Default.data = data;
                Properties.Settings.Default.hamveriyazmayadevam = true;

                veri_uydu_sayi = splitted_data[0];
                veri_hdop = splitted_data[1];
                veri_enlem = splitted_data[2];
                veri_boylam = splitted_data[3];
                veri_base_gps_irtifa = splitted_data[4];
                veri_gps_irtifa = splitted_data[5];
                veri_maksimum_gps_irtifa = splitted_data[6];
                veri_suruklenme_hiz = splitted_data[7];
                veri_kamera_durum = splitted_data[8];
                veri_aciX = splitted_data[9];
                veri_aciY = splitted_data[10];
                veri_gKuvvet = splitted_data[11];
                veri_maksimum_gKuvvet = splitted_data[12];
                veri_base_barometrik_irtifa = splitted_data[13];
                veri_barometrik_irtifa = splitted_data[14];
                veri_maksimum_barometrik_irtifa = splitted_data[15];
                veri_orta_govde_base_gps_irtifa = splitted_data[16];
                veri_orta_govde_gps_irtifa = splitted_data[17];
                veri_orta_govde_maksimum_gps_irtifa = splitted_data[18];
                veri_orta_govde_hdop = splitted_data[19];
                veri_orta_govde_enlem = splitted_data[20];
                veri_orta_govde_boylam = splitted_data[21];
                veri_faz1_durum = splitted_data[22];
                veri_faz2_durum = splitted_data[23];
            }
            catch
            {

            }
            finally
            {
                editorDurumSimgeAyarla();
                editorGrafikKutuAyarla();
                editorİbreKutuAyarla();
                editorDurumYaziAyarla();
                editorVeriKaydetMotor();
            }
            //------------------------------------------------------------------------------------------
            try
            {
                uyduSayiLabel.Text = "Bağlanılan Uydu Sayısı " + veri_uydu_sayi; //gps uydu sayısı
            }
            catch
            {

            }
            //--------------------------------------------------------------------
            try
            {
                hdopLabel.Text = "HDOP: " + veri_hdop; //hdop sapması
            }
            catch
            {

            }
            //--------------------------------------------------------------------
            try
            {
                enlemLabel.Text = "Enlem: " + veri_enlem + "°"; //enlem
                Properties.Settings.Default.enlem = veri_enlem; //global değişkene de yaz enlemi
            }
            catch
            {

            }
            //--------------------------------------------------------------------
            try
            {
                boylamLabel.Text = "Boylam: " + veri_boylam + "°"; //boylam
                Properties.Settings.Default.boylam = veri_boylam; //global değikene de yaz boylamı
            }
            catch
            {

            }
            //--------------------------------------------------------------------
            try
            {
                baseGpsİrtifaLabel.Text = "Baz İrtifa: " + veri_base_gps_irtifa + "m"; //base gps irtifa
            }
            catch
            {

            }
            //--------------------------------------------------------------------
            try
            {
                irtifaLabel.Text = "İrtifa: " + veri_gps_irtifa + "m"; //gps irtifa
                irtifaMaxLabel.Text = "Maksimum İrtifa: " + veri_maksimum_gps_irtifa + "m"; //gps maks irtifa
            }
            catch
            {

            }
            //--------------------------------------------------------------------
            try
            {
                suruklenmeHizLabel.Text = "Sürüklenme Hızı: " + veri_suruklenme_hiz + "km/s"; //sürüklenme hız
            }
            catch
            {

            }
            //--------------------------------------------------------------------
            try
            {
                AciXLabel.Text = "X Açısı: " + veri_aciX + "°"; //x açısı
                Properties.Settings.Default.aciX = veri_aciX; // global değişkene de yaz x açısını
            }
            catch
            {

            }
            //--------------------------------------------------------------------
            try
            {
                aciYLabel.Text = "Y Açısı: " + veri_aciY + "°"; //y açısı
                Properties.Settings.Default.aciY = veri_aciY; // global değişkene de yaz y açısını
            }
            catch
            {

            }
            //--------------------------------------------------------------------
            try
            {
                gkuvvetLabel.Text = "G Kuvveti: " + veri_gKuvvet + "g"; //g kuvveti
                Properties.Settings.Default.gkuvvet = veri_gKuvvet; //global değişkene de yaz g kuvvetini
            }
            catch
            {

            }
            //--------------------------------------------------------------------
            try
            {
                maksGKuvvetLabel.Text = "G Maks: " + veri_maksimum_gKuvvet + "g"; //maks g kuvveti
            }
            catch
            {

            }
            //--------------------------------------------------------------------
            try
            {
                baseBarometrikİrtifaLabel.Text = "Baz İrtifa: " + veri_base_barometrik_irtifa + "m"; //base barometrik irtifa
                barometrikİrtifaLabel.Text = "İrtifa: " + veri_barometrik_irtifa + "m"; //barometrik irtifa
                barometrikİrtifaMaksLabel.Text = "Maksimum İrtifa: " + veri_maksimum_barometrik_irtifa + "m"; //baro irtifa maks
            }
            catch
            {

            }
            //-----------------------------------------------------------------------






            //--------------------------------ORTA GÖVDE ANA EKRAN BİLGİLERİ------------------------------------
            try
            {
                ortaGovdeBaseGpsİrtifaLabel.Text = "Baz İrtifa: " + veri_orta_govde_base_gps_irtifa + "m";
            }
            catch
            {

            }
            //--------------------------------------------------------------------
            try
            {
                ortaGovdeGpsİrtifaLabel.Text = "İrtifa: " + veri_orta_govde_gps_irtifa + "m";
            }
            catch
            {

            }
            //--------------------------------------------------------------------
            try
            {
                ortaGovdeGpsMaksimumİrtifaLabel.Text = "Maksimum İrtifa: " + veri_orta_govde_maksimum_gps_irtifa + "m";
            }
            catch
            {

            }
            //--------------------------------------------------------------------
            try
            {
                ortaGovdeHdopLabel.Text = "HDOP: " + veri_orta_govde_hdop;
            }
            catch
            {

            }
            //--------------------------------------------------------------------
            try
            {
                ortaGovdeEnlemLabel.Text = "Enlem: " + veri_orta_govde_enlem + "°";
            }
            catch
            {

            }
            //--------------------------------------------------------------------
            try
            {
                ortaGovdeBoylamLabel.Text = "Boylam: " + veri_orta_govde_boylam + "°";
            }
            catch
            {

            }
            //--------------------------------------------------------------------

            Properties.Settings.Default.konidurum = veri_faz1_durum; //global değişken koni durumu
            Properties.Settings.Default.ortagovdedurum = veri_faz2_durum; //global değişken orta gövde durumu
            Properties.Settings.Default.kameradurum = veri_kamera_durum; //global değişken kamera durumu


            //----------bağlantı durumunu gösteren simgenin ayarlanması--------
            baglantiDurumPictureBox.Image = Properties.Resources.dot_yesil;
            //-----------------------------------------------------------------


            //Gelen veriyi formun altında gözüken siyah yere (TextBox) yazıyorum.
            hamVeriTextBox1.AppendText(sadece_saat + " --> " + data + Environment.NewLine);

            int line = hamVeriTextBox1.GetLineFromCharIndex(hamVeriTextBox1.SelectionStart); //otomatik en aşağı kaydırması için
            int column = hamVeriTextBox1.SelectionStart - hamVeriTextBox1.GetFirstCharIndexFromLine(line); //otomatik en aşağı kaydırması için

            

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

            Application.Exit();
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
            this.WindowState = FormWindowState.Normal;

            kamera kamerafrm = new kamera();
            hamveriekrani hamveriekranifrm = new hamveriekrani();
            harita haritafrm = new harita();
            roketsema roketsemafrm = new roketsema();

            hamveriekranifrm.Show();
            hamveriekranifrm.Height = 225;
            hamveriekranifrm.Width += 190;
            hamveriekranifrm.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - kamerafrm.Height + 90);

            kamerafrm.Show();
            kamerafrm.Location = new Point(kamerafrm.Width - 115, Screen.PrimaryScreen.Bounds.Height - kamerafrm.Height * 2);

            haritafrm.Show();
            haritafrm.Height = 680;
            haritafrm.Width = 520;
            haritafrm.Location = new Point(Screen.PrimaryScreen.Bounds.Width - haritafrm.Width, Screen.PrimaryScreen.Bounds.Height - haritafrm.Height + 40);

            roketsemafrm.Show();
            roketsemafrm.Width = 800;
            roketsemafrm.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - hamveriekranifrm.Height - 95);


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
                üstteGösterToolStripMenuItem.Text = "Üstte Göster";
                this.TopMost = false;
            }
            else
            {
                üstteGösterToolStripMenuItem.CheckState = CheckState.Checked;
                üstteGösterToolStripMenuItem.Text = "Üstte Gösterme";
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
        }

        private void ciktoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void editorBaglantiBaslat()
        {
            string sadece_saat = DateTime.Now.ToString("HH:mm:ss");
            string sadece_tarih = DateTime.Now.ToString("dd-MM-yyyy");
            baglantiDurumPictureBox.Image = Properties.Resources.dot_sari;

            if (!serialPort1.IsOpen) //Bağlantı kurulmamışsa.
            {
                if (COMPortList.SelectedIndex < 0) //Bağlantı noktası boş olduğu zaman program çöküyor bu yüzden kullanıcıyı bilgilendiriyorum ve çökmesini engelliyorum.
                {
                    MessageBox.Show("Hata! Alıcı sistem ile bağlantı kurulamadı! Lütfen alıcıyı bilgisayarınıza bağladığınızdan emin olunuz, eğer zaten bağlıysa kabloları kontrol ediniz. (Detay: Muhtemel Liste Boşluğu)", "Alıcı Sistem Bulunamadı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hamVeriTextBox1.AppendText(sadece_saat + " --> Bağlantı noktası ile iletişim kurulamadı! (Muhtemel Liste Boşluğu)" + Environment.NewLine);
                    Properties.Settings.Default.hata_data = sadece_saat + " --> Bağlantı noktası ile iletişim kurulamadı! (Muhtemel Liste Boşluğu)" + Environment.NewLine;
                }
                else //liste boş değil ve bağlantı kurulmamış ise.
                {
                    serialPort1.PortName = COMPortList.Text;
                    try
                    {
                        serialPort1.Open();
                        Properties.Settings.Default.serialportdurum = true;
                        gecenSureGuncelleTimer.Start();
                        BellekBosaltTimer.Start(); //bellek boşaltmayı başlat.

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
                        Properties.Settings.Default.hata_data = sadece_saat + " --> Alıcıdan veri alırken bir problem oluştu! (" + ex.Message.ToString() + ")" + Environment.NewLine;
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
            string sadece_saat = DateTime.Now.ToString("HH:mm:ss");
            string sadece_tarih = DateTime.Now.ToString("dd-MM-yyyy");

            serialPort1.Close();
            Properties.Settings.Default.serialportdurum = false;
            gecenSureGuncelleTimer.Stop();
            BellekBosaltTimer.Stop(); //bellek boşaltmayı durdur.
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

        private void hamVeriBellekBosaltTimer_Tick(object sender, EventArgs e)
        {
            //program şişmesin diye hem veri ekranını (ana ekrandaki) hem de global (ayar) data değişkenini temizler.
            hamVeriTextBox1.Text = string.Empty;
            Properties.Settings.Default.data = string.Empty;


            bellekTemizlemeDurumPictureBox.Image = Properties.Resources.ram_sari;
            BellekBosaltTimer2.Start();
        }

        //form belli bir boyuttan sonra belirli kontrolleri göstermesi için yapılan fonksiyon.
        private void anaEkran_SizeChanged(object sender, EventArgs e)
        {
            //baudrate listesi gösterimi.
            if (this.Size.Width >= 703)
            {
                baudRatePortList.Visible = true;
            }
            else
            {
                baudRatePortList.Visible = false;
            }
            //saat gösterimi.
            if (this.Size.Width >= 795)
            {
                saatLabel.Visible = true;
                saatGuncelleTimer.Start();
            }
            else
            {
                saatLabel.Visible = false;
                saatGuncelleTimer.Stop();
            }
            //geçen süre gösterimi.
            if (this.Size.Width >= 915)
            {
                gecenSureLabel.Visible = true;
            }
            else
            {
                gecenSureLabel.Visible = false;
            }


        }

        private void saatGuncelleTimer_Tick(object sender, EventArgs e)
        {
            string sadece_saat = DateTime.Now.ToString("HH:mm:ss");
            saatLabel.Text = "Saat: " + sadece_saat;
        }

        private void gecenSureGuncelleTimer_Tick(object sender, EventArgs e)
        {
            //-------------kullanılmıyor!---------------
            if (gecenSalise == 60) //60 salise olursa.
            {
                gecenSalise = 0; //saliseyi geri sıfır yap.
                gecenSaniye += 1; //saniyeyi + 1 yap.
            }
            //------------------------------------------



            if (gecenSaniye == 60) //60 saniye olursa.
            {
                gecenSaniye = 0; //saniyeyi geri sıfır yap.
                gecenDakika += 1; //dakikayı + 1 yap.
            }
            if (gecenDakika == 60) //60 dakika olursa.
            {
                gecenDakika = 0; //dakikayı geri sıfır yap.
                gecenSaat += 1; //saati + 1 yap.
            }

            gecenSaniye++;
            gecenSureLabel.Text = "Geçen Süre: " + gecenSaat.ToString("00") + ":" + gecenDakika.ToString("00") + ":" + gecenSaniye.ToString("00");

        }

        private void hamVeriBellekBosaltTimer2_Tick(object sender, EventArgs e)
        {
            BellekBosaltTimer2.Stop();
            bellekTemizlemeDurumPictureBox.Image = Properties.Resources.ram;
        }

        private void baglantiYenileİkonDuzeltTimer_Tick(object sender, EventArgs e)
        {
            baglantiDurumPictureBox.Image = Properties.Resources.dot; //bağlantı durumu ikonunu düzelt.
            baglantiYenileİkonDuzeltTimer.Stop();
        }

        public void editorProgramYenidenBaslat()
        {
            System.Diagnostics.Process.Start("mCTerminal.exe");
            Application.Exit();
        }

        public void editorDurumYaziAyarla()
        {
            try
            {
                if (veri_kamera_durum == "1") //kamera durumu 1 ise
                {
                    kameraDurumLabel.Text = "Video Yayını: Aktif!";
                    kameraDurumPictureBox.Image = Properties.Resources.film_yesil;
                }
                else
                {
                    kameraDurumLabel.Text = "Video Yayını: Aktif Değil!";
                    kameraDurumPictureBox.Image = Properties.Resources.film_kirmizi;
                }

                if (veri_faz1_durum == "1") //koni ayrılmış ise
                {
                    koniDurumLabel.Text = "Koni: Ayrıldı!";
                    koniDurumPictureBox.Image = Properties.Resources.cone_yesil;
                }
                else
                {
                    koniDurumLabel.Text = "Koni: Ayrılmadı!";
                    koniDurumPictureBox.Image = Properties.Resources.cone_kirmizi;
                }

                if (veri_faz2_durum == "1") //orta göve ayrılmış ise
                {
                    ortagovdeDurumLabel.Text = "Orta Gövde: Ayrıldı!";
                    ortaGovdeDurumPictureBox.Image = Properties.Resources.split_yesil;
                }
                else
                {
                    ortagovdeDurumLabel.Text = "Orta Gövde: Ayrılmadı!";
                    ortaGovdeDurumPictureBox.Image = Properties.Resources.split_kirmizi;
                }
            }
            catch
            {

            }
        }

        public void editorDurumSimgeAyarla()
        {
            //-------------------------------SİMGELERİN DURUMU---------------------------------------

            string sadece_saat = DateTime.Now.ToString("HH:mm:ss");
            try
            {
                int gurultu_durum = Properties.Settings.Default.gurultudurum;
                //-----gürültü durumu-----
                if (gurultu_durum <= 1)
                {
                    gurultuDurumPictureBox.Image = Properties.Resources.noise_sari;
                }
                if (gurultu_durum > 1 && gurultu_durum <= 98)
                {
                    gurultuDurumPictureBox.Image = Properties.Resources.noise_yesil;
                }
                if (gurultu_durum >= 99)
                {
                    gurultuDurumPictureBox.Image = Properties.Resources.noise_kirmizi;
                }
                //---gürültü durumu son---
            }
            catch
            {
                hamVeriTextBox1.AppendText(sadece_saat + " --> Hata! Durum Simgeleri (Bağlanılan Uydu Sayısı) bir hata ile karşılaştı. Yok sayılıp devam ediliyor..." + Environment.NewLine);
                Properties.Settings.Default.hata_data = sadece_saat + " --> Hata! Durum Simgeleri (Bağlanılan Uydu Sayısı) bir hata ile karşılaştı. Yok sayılıp devam ediliyor..." + Environment.NewLine;
            }

            try
            {
                int hdop_durum_sayi = Convert.ToInt32(veri_hdop.Split('.')[0]);
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
            }
            catch
            {
                hamVeriTextBox1.AppendText(sadece_saat + " --> Hata! Durum Simgeleri (HDOP) bir hata ile karşılaştı. Yok sayılıp devam ediliyor..." + Environment.NewLine);
                Properties.Settings.Default.hata_data = sadece_saat + " --> Hata! Durum Simgeleri (HDOP) bir hata ile karşılaştı. Yok sayılıp devam ediliyor..." + Environment.NewLine;
            }

            try
            {
                int baglanilan_uydu_sayisi_durum_sayi = Convert.ToInt32(veri_uydu_sayi);
                //-----gps uydu durumu-----
                if (baglanilan_uydu_sayisi_durum_sayi <= 4)
                {
                    uyduPictureBox.Image = Properties.Resources.uydu_kirmizi;
                }
                if (baglanilan_uydu_sayisi_durum_sayi > 4 && baglanilan_uydu_sayisi_durum_sayi <= 7)
                {
                    uyduPictureBox.Image = Properties.Resources.uydu_sari;
                }
                if (baglanilan_uydu_sayisi_durum_sayi > 7)
                {
                    uyduPictureBox.Image = Properties.Resources.uydu_yesil;
                }
                //---gps uydu durumu son---
            }
            catch
            {
                hamVeriTextBox1.AppendText(sadece_saat + " --> Hata! Durum Simgeleri (Bağlanılan Uydu Sayısı) bir hata ile karşılaştı. Yok sayılıp devam ediliyor..." + Environment.NewLine);
                Properties.Settings.Default.hata_data = sadece_saat + " --> Hata! Durum Simgeleri (Bağlanılan Uydu Sayısı) bir hata ile karşılaştı. Yok sayılıp devam ediliyor..." + Environment.NewLine;
            }
            //-------------------------------SİMGELERİN DURUMU SON-----------------------------------
        }

        public void editorGrafikKutuAyarla()
        {

        }

        public void editorİbreKutuAyarla()
        {
            string sadece_saat = DateTime.Now.ToString("HH:mm:ss");
            try
            {
                if (veri_gps_irtifa != null && veri_suruklenme_hiz != null && veri_gKuvvet != null)
                {
                    string gps_irtifa_bolunmus = veri_gps_irtifa.Split('.')[0];
                    string yatay_hiz_bolunmus = veri_suruklenme_hiz.Split('.')[0];
                    string g_kuvvet_bolunmus = veri_gKuvvet.Split('.')[0];
                    //--------------------------İBRE KUTULARI--------------------------------
                    yatayHizGauge.Value = Convert.ToInt32(yatay_hiz_bolunmus); //yatay hız
                    irtifaGauge.Value = Convert.ToInt32(gps_irtifa_bolunmus); //gps irtifa
                    AciXGauge.Value = Convert.ToInt32(veri_aciX); //x açısı
                    AciYGauge.Value = Convert.ToInt32(veri_aciY); //y açısı
                    //-------------------------İBRE KUTULARI SON-------------------------------
                }

            }
            catch
            {
                //hamVeriTextBox1.AppendText(sadece_saat + " --> Hata! İbre Kutuları bir hata ile karşılaştı. Yok sayılıp devam ediliyor..." + Environment.NewLine);
                //Properties.Settings.Default.hata_data = sadece_saat + " --> Hata! İbre Kutuları bir hata ile karşılaştı. Yok sayılıp devam ediliyor..." + Environment.NewLine;
            }
        }

        public void editorVeriKaydetMotor()
        {
            string sadece_saat = DateTime.Now.ToString("HH:mm:ss");
            //VERİ ÇIKTISINI KAYDETMEK İÇİN VERİ KAYDET BUTONUNU KONTROL EDER VE ONA GÖRE VERİYİ YAZAR
            try
            {
                if (verikaydetToolStripMenuItem.CheckState == CheckState.Checked)
                {
                    string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
                    string sadece_tarih = DateTime.Now.ToString("dd-MM-yyyy");
                    string kayitformati = programVeriFormat;
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(programyolu + @"logs\" + "roketLog-" + sadece_tarih.ToString() + kayitformati, true)) //Log yerine kullanılabilecek Türkçe bir karşılık bulamadım, belki Veri çıktısı diyebiliriz ama Log kavramı daha evrensel olduğu için böyle yazdım.
                    {
                        file.WriteLine(sadece_saat + " --> " + data);
                    }
                }
                else
                {

                }
                //-------------------------------------------VERİ KAYIT SON------------------------------------------
            }
            catch
            {
                hamVeriTextBox1.AppendText(sadece_saat + " --> Hata! Veri Kaydetme Motoru bir hata ile karşılaştı. Yok sayılıp devam ediliyor..." + Environment.NewLine);
                Properties.Settings.Default.hata_data = sadece_saat + " --> Hata! Veri Kaydetme Motoru bir hata ile karşılaştı. Yok sayılıp devam ediliyor..." + Environment.NewLine;
            }
        }

        private void hamVeriYazmayaDevamKontrolTimer_Tick(object sender, EventArgs e)
        {
            Properties.Settings.Default.hamveriyazmayadevam = false;
        }

        private void serialPortKontrolTimer_Tick(object sender, EventArgs e)
        {

        }

        private void bütünPencereleriKöşesizYapToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (bütünPencereleriKöşesizYapToolStripMenuItem.Text == "Bütün Pencereleri Köşesiz Yap")
            {
                var hamveriekranifrm = Application.OpenForms.OfType<hamveriekrani>().Single();
                var haritafrm = Application.OpenForms.OfType<harita>().Single();
                var roketsemafrm = Application.OpenForms.OfType<roketsema>().Single();
                var kamerafrm = Application.OpenForms.OfType<kamera>().Single();

                hamveriekranifrm.FormBorderStyle = FormBorderStyle.None;
                haritafrm.FormBorderStyle = FormBorderStyle.None;
                roketsemafrm.FormBorderStyle = FormBorderStyle.None;
                kamerafrm.FormBorderStyle = FormBorderStyle.None;

                hamveriekranifrm.Show();
                haritafrm.Show();
                roketsemafrm.Show();
                kamerafrm.Show();

                bütünPencereleriKöşesizYapToolStripMenuItem.Text = "Bütün Pencereleri Normal Yap";
            }
            else
            {
                var hamveriekranifrm = Application.OpenForms.OfType<hamveriekrani>().Single();
                var haritafrm = Application.OpenForms.OfType<harita>().Single();
                var roketsemafrm = Application.OpenForms.OfType<roketsema>().Single();
                var kamerafrm = Application.OpenForms.OfType<kamera>().Single();

                hamveriekranifrm.FormBorderStyle = FormBorderStyle.Sizable;
                haritafrm.FormBorderStyle = FormBorderStyle.Sizable;
                roketsemafrm.FormBorderStyle = FormBorderStyle.Sizable;
                kamerafrm.FormBorderStyle = FormBorderStyle.Sizable;

                hamveriekranifrm.Show();
                haritafrm.Show();
                roketsemafrm.Show();
                kamerafrm.Show();

                bütünPencereleriKöşesizYapToolStripMenuItem.Text = "Bütün Pencereleri Köşesiz Yap";
            }

        }

        private void uzakSesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uzaktanses uzaktansesfrm = new uzaktanses();
            uzaktansesfrm.Show();
        }
    }
}
//Bu proje Cosmos Takımı üyesi "Berke AYDİN" nam-ı diğer "MRpatatesAmca" tarafından yazılmıştır.