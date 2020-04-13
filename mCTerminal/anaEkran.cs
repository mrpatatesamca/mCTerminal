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

namespace mCTerminal
{
    
    public partial class anaEkran : Form
    {
        //--------tablo grafiği için gerekli---------
        int maksm = 20, minm = 0;
        int gkuvvetmin = 0, gkuvvetmaks = 20;
        //-------------------------------------------


        public anaEkran()
        {
            InitializeComponent();
            

            string[] portlar = SerialPort.GetPortNames(); //portlar listesine COM portları alındı.
            serialPort1.BaudRate = 9600; //baudrate ayarlama
            Control.CheckForIllegalCrossThreadCalls = false;
            
            //her bir bağlı olan COM bağlantıları için tek tek listeye ekleme yap
            foreach (string port in portlar)
            {
                COMPortList.Items.Add(port);
                COMPortList.SelectedIndex = 0;
                baudRatePortList.Items.Add("9600");
                baudRatePortList.SelectedIndex = 0;
            }

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);


            //-------------------------Formda altta bulunan yere yazdırılacak yazılar-------------------------
            hamVeriTextBox1.AppendText("@@$ --> COM Portları Taranıyor..." + Environment.NewLine);
            hamVeriTextBox1.AppendText("@@$ --> COM Portları Tarandı!" + Environment.NewLine);
            hamVeriTextBox1.AppendText("@@$ --> #--------------------------#" + Environment.NewLine);
            hamVeriTextBox1.AppendText("@@$ --> #   www.cosmostakimi.com   #" + Environment.NewLine);
            hamVeriTextBox1.AppendText("@@$ --> #--------------------------#" + Environment.NewLine);
            hamVeriTextBox1.AppendText("@@$ --> Program Yüklendi ve Kullanıma Hazır!" + Environment.NewLine);
            
            int line = hamVeriTextBox1.GetLineFromCharIndex(hamVeriTextBox1.SelectionStart); //textbox'ı otomatik olarak en aşağı kaydırıyor
            int column = hamVeriTextBox1.SelectionStart - hamVeriTextBox1.GetFirstCharIndexFromLine(line); //böylece en son gelen veriyi görebiliyoruz.
            //------------------------------------------------------------------------------------------------
        }

        private void anaEkran_Load(object sender, EventArgs e)
        {

            //temalar için ayrılmış bölüm
            
            if (mCTerminal.Properties.Settings.Default.program_tema == "tema_varsayilan")
            {
                this.BackColor = Color.FromArgb(30 ,30 ,30);
                this.ForeColor = Color.WhiteSmoke;
                hamVeriTextBox1.BackColor = Color.FromArgb(20 ,20 ,20);
                hamVeriTextBox1.ForeColor = Color.WhiteSmoke;
                toolStrip1.BackColor = Color.FromArgb(50, 50, 50);
                toolStripDropDownButton1.ForeColor = Color.WhiteSmoke;
                toolStripDropDownButton2.ForeColor = Color.WhiteSmoke;
                toolStripDropDownButton3.ForeColor = Color.WhiteSmoke;
                toolStripDropDownButton4.ForeColor = Color.WhiteSmoke;
                voltajGrafik.Titles[0].ForeColor = Color.WhiteSmoke;
                gkuvvetGrafik.Titles[0].ForeColor = Color.WhiteSmoke;
            }

            if (mCTerminal.Properties.Settings.Default.program_tema == "tema_matrix")
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.DarkOliveGreen;
                hamVeriTextBox1.BackColor = Color.FromArgb(10 ,12 ,10);
                hamVeriTextBox1.ForeColor = Color.LimeGreen;
                toolStrip1.BackColor = Color.Black;
                toolStripDropDownButton1.ForeColor = Color.LimeGreen;
                toolStripDropDownButton2.ForeColor = Color.LimeGreen;
                toolStripDropDownButton3.ForeColor = Color.LimeGreen;
                toolStripDropDownButton4.ForeColor = Color.LimeGreen;
                voltajGrafik.Titles[0].ForeColor = Color.DarkOliveGreen;
                gkuvvetGrafik.Titles[0].ForeColor = Color.DarkOliveGreen;
            }

            if (mCTerminal.Properties.Settings.Default.program_tema == "tema_dondurma")
            {
                this.BackColor = Color.FromArgb(220, 229, 225);
                this.ForeColor = Color.IndianRed;
                hamVeriTextBox1.BackColor = Color.LightSlateGray;
                hamVeriTextBox1.ForeColor = Color.NavajoWhite;
                toolStrip1.BackColor = Color.DarkSlateGray;
                toolStripDropDownButton1.ForeColor = Color.FromArgb(255, 230, 230);
                toolStripDropDownButton2.ForeColor = Color.FromArgb(255, 230, 230);
                toolStripDropDownButton3.ForeColor = Color.FromArgb(255, 230, 230);
                toolStripDropDownButton4.ForeColor = Color.FromArgb(255, 230, 230);
                voltajGrafik.Titles[0].ForeColor = Color.IndianRed;
                gkuvvetGrafik.Titles[0].ForeColor = Color.IndianRed;
            }

            if (mCTerminal.Properties.Settings.Default.program_tema == "tema_cosmos")
            {
                this.BackColor = Color.FromArgb(26, 16, 122);
                this.ForeColor = Color.FromArgb(245, 228, 183);
                hamVeriTextBox1.BackColor = Color.FromArgb(6, 0, 102);
                hamVeriTextBox1.ForeColor = Color.BurlyWood;
                toolStrip1.BackColor = Color.FromArgb(11, 75, 183);
                toolStripDropDownButton1.ForeColor = Color.FromArgb(245, 228, 183);
                toolStripDropDownButton2.ForeColor = Color.FromArgb(245, 228, 183);
                toolStripDropDownButton3.ForeColor = Color.FromArgb(245, 228, 183);
                toolStripDropDownButton4.ForeColor = Color.FromArgb(245, 228, 183);
                voltajGrafik.Titles[0].ForeColor = Color.FromArgb(245, 228, 183);
                gkuvvetGrafik.Titles[0].ForeColor = Color.FromArgb(245, 228, 183);
            }

            if (mCTerminal.Properties.Settings.Default.program_tema == "tema_material")
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
                voltajGrafik.Titles[0].ForeColor = Color.FromArgb(251, 235, 235);
                gkuvvetGrafik.Titles[0].ForeColor = Color.FromArgb(251, 235, 235);
            }
            baglantiNoktasi_label.ForeColor = this.ForeColor;
            baglantiHizi_label.ForeColor = this.ForeColor;
            aliciModeli_label.ForeColor = this.ForeColor;
            sinyalGucuLabel.ForeColor = this.ForeColor;
            snrSeviyesiLabel.ForeColor = this.ForeColor;
            uyduSayiLabel.ForeColor = this.ForeColor;
            voltajLabel.ForeColor = this.ForeColor;
            label6.ForeColor = this.ForeColor;
            label5.ForeColor = this.ForeColor;
            label7.ForeColor = this.ForeColor;
            enlemLabel.ForeColor = this.ForeColor;
            boylamLabel.ForeColor = this.ForeColor;
            gkuvvetLabel.ForeColor = this.ForeColor;
            irtifaLabel.ForeColor = this.ForeColor;
            irtifaBaroLabel.ForeColor = this.ForeColor;
            irtifafarkLabel.ForeColor = this.ForeColor;
            yatayHizLabel.ForeColor = this.ForeColor;
            dikeyhizLabel.ForeColor = this.ForeColor;
            label15.ForeColor = this.ForeColor;
            label16.ForeColor = this.ForeColor;
            label17.ForeColor = this.ForeColor;
            label18.ForeColor = this.ForeColor;

            //-----------------------------------------------------------





            //Form adını ayarlar
            this.Text = "mCTerminal " + mCTerminal.Properties.Settings.Default.prog_surum + " | [@" + Environment.MachineName + "]";

            //Ham veri'nin yazıldığı textbox'ın düzgün gözükmesi için
            hamVeriTextBox1.SelectionStart = hamVeriTextBox1.Text.Length;

            //programın dizaynı sebebiyle bazen bu ayar true iken kaydedilebiliyor (tema değiştirilirken meydana gelen bir durum) bu sebeple her açılışta bu ayarı sıfırlıyorum.
            mCTerminal.Properties.Settings.Default.serialportdurum = false;

            //harita konumunu Iğdır yapar. Yurttaki kardeşlerime selam olsun <3
            mCTerminal.Properties.Settings.Default.enlem = "";
            mCTerminal.Properties.Settings.Default.boylam = "";
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data;
            string[] splitted_data;

            try
            {
                data = serialPort1.ReadLine();
                splitted_data = data.Split('*');

                boylamLabel.Text = "Enlem: " + splitted_data[0] + "°"; //enlem
                Properties.Settings.Default.enlem = splitted_data[0]; //enlem verisini ayar olarak da yazıyor böylece her yerden erişilebilir oluyor.
                enlemLabel.Text = "Boylam: " + splitted_data[1] + "°"; //boylam
                Properties.Settings.Default.boylam = splitted_data[1]; //boylam verisini ayar olarak da yazıyor böylece her yerden erişebiliyorum.
                yatayHizLabel.Text = "Yatay Hız: " + splitted_data[2] + "km/s"; //yatay hız
                irtifaLabel.Text = "İrtifa: " + splitted_data[3] + "m"; //irtifa
                uyduSayiLabel.Text = "Bağlanılan Uydu Sayısı: " + splitted_data[4]; //uydu
                voltajLabel.Text = "Voltaj: " + splitted_data[5] + "v"; //voltaj
                gkuvvetLabel.Text = "G Kuvveti: " + splitted_data[6] + "g"; //g kuvvet
                // textBox8.Text = splitted_data[7]; //anahtar
                // textBox9.Text = splitted_data[8]; //video
                // textBox10.Text = splitted_data[9]; //yedek aviyoik
                irtifaBaroLabel.Text = "İrtifa (Barometrik): " + splitted_data[10] + "m"; //barometrik irtifa
                int irtifafarkSayiNormal = Int32.Parse(splitted_data[3]); //irtifa verisini integer'a yani sayı verisine dönüştürüyorum.
                int irtifafarkSayiBarometrik = Int32.Parse(splitted_data[10]); //barometrik irtifa verisini integer'a yani sayı verisine dönüştürüyorum.
                int irtifafarkSayi = irtifafarkSayiNormal - irtifafarkSayiBarometrik; //sayılar arasındaki farkı buluyorum.
                sinyalGucuLabel.Text = "Sinyal Seviyesi: " + splitted_data[11] + "dB"; //sinyal seviyesi
                snrSeviyesiLabel.Text = "SNR Seviyesi: " + splitted_data[12] + "dB"; //snr seviyesi
                irtifafarkLabel.Text = "Fark: " + irtifafarkSayi.ToString() + "m"; //irtifa farkı

                //Ham Veri ekranında da veriler gözüksün diye gelen verileri ayar olarak yazıyorum böylece her yerden erişilebilir oluyor.
                mCTerminal.Properties.Settings.Default.hamveri = data;
                //Gelen veriyi formun altında gözüken siyah yere (TextBox) yazıyorum.
                hamVeriTextBox1.AppendText(data + Environment.NewLine);
                int line = hamVeriTextBox1.GetLineFromCharIndex(hamVeriTextBox1.SelectionStart); //otomatik en aşağı kaydırması için
                int column = hamVeriTextBox1.SelectionStart - hamVeriTextBox1.GetFirstCharIndexFromLine(line); //otomatik en aşağı kaydırması için

                //---------------------------------GRAFİK KUTULARI-----------------------------------
                //-----------------------------------VOLTAJ GRAFİĞİ----------------------------------
                voltajGrafik.ChartAreas[0].AxisX.Minimum = minm;
                voltajGrafik.ChartAreas[0].AxisX.Maximum = maksm;
                voltajGrafik.ChartAreas[0].AxisY.Minimum = 0;
                voltajGrafik.ChartAreas[0].AxisY.Maximum = 5;
                voltajGrafik.ChartAreas[0].AxisX.ScaleView.Zoom(minm, maksm);
                this.voltajGrafik.Series[0].Points.AddXY((minm + maksm) / 2, splitted_data[5]);
                //---------------------------------G KUVVETİ GRAFİĞİ---------------------------------
                gkuvvetGrafik.ChartAreas[0].AxisX.Minimum = gkuvvetmin;
                gkuvvetGrafik.ChartAreas[0].AxisX.Maximum = gkuvvetmaks;
                gkuvvetGrafik.ChartAreas[0].AxisY.Minimum = 0;
                gkuvvetGrafik.ChartAreas[0].AxisY.Maximum = 20;
                gkuvvetGrafik.ChartAreas[0].AxisX.ScaleView.Zoom(gkuvvetmin, gkuvvetmaks);
                this.gkuvvetGrafik.Series[0].Points.AddXY((gkuvvetmin + gkuvvetmaks) / 2, splitted_data[6]);
                //-----------------------------------------------------------------------------------
                gkuvvetmin++;
                gkuvvetmaks++;
                maksm++;
                minm++;
                //----------------------------------GRAFİK KUTULARI SON------------------------------


                //VERİ ÇIKTISINI KAYDETMEK İÇİN VERİ KAYDET BUTONUNU KONTROL EDER VE ONA GÖRE VERİYİ YAZAR
                if (verikaydetToolStripMenuItem.CheckState == CheckState.Checked)
                {
                    string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
                    string sadece_saat = DateTime.Now.ToString("hh:mm:ss");
                    string sadece_tarih = DateTime.Now.ToString("dd-MM-yyyy");

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(programyolu + @"logs\" + "roketLog-" + sadece_tarih.ToString() + ".txt", true)) //Log yerine kullanılabilecek Türkçe bir karşılık bulamadım, belki Veri çıktısı diyebiliriz ama Log kavramı daha evrensel olduğu için böyle yazdım.
                    {
                        file.WriteLine(sadece_saat + " --> " + data);
                    }
                    kayitdurumPictureBox.Image = mCTerminal.Properties.Resources.download_yesil;
                    
                }
                else
                {
                    kayitdurumPictureBox.Image = mCTerminal.Properties.Resources.download_kirmizi;
                    
                }
                //-------------------------------------------VERİ KAYIT SON------------------------------------------






            }
            catch (Exception ex)
            {

            }
        }

        private void bağlantıyıBaşlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sadece_saat = DateTime.Now.ToString("hh:mm:ss");
            string sadece_tarih = DateTime.Now.ToString("dd-MM-yyyy");

            if (!serialPort1.IsOpen) //Bağlantı kurulmamışsa.
            {
                if (COMPortList.SelectedIndex < 0) //Bağlantı noktası boş olduğu zaman program çöküyor bu yüzden kullanıcıyı bilgilendiriyorum ve çökmesini engelliyorum.
                {
                    MessageBox.Show("Hata! Alıcı sistem ile bağlantı kurulamadı! Lütfen alıcıyı bilgisayarınıza bağladığınızdan emin olunuz, eğer zaten bağlıysa kabloları kontrol ediniz. (Detay: Muhtemel Liste Boşluğu)", "Alıcı Sistem Bulunamadı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hamVeriTextBox1.AppendText("@@$ --> Bağlantı noktası ile iletişim kurulamadı! (Muhtemel Liste Boşluğu)" + Environment.NewLine);
                }
                else
                {
                    serialPort1.PortName = COMPortList.Text;
                    try
                    {
                        serialPort1.Open();
                        mCTerminal.Properties.Settings.Default.serialportdurum = true;

                        bağlantıyıBaşlatToolStripMenuItem.Text = "Bağlantıyı Kes";
                        hamVeriTextBox1.AppendText(Environment.NewLine);
                        hamVeriTextBox1.AppendText("@$$ --> Bağlantı " + COMPortList.Text + " üzerinden " + sadece_tarih + "</>" + sadece_saat + " tarihinde başlatıldı!");
                        hamVeriTextBox1.AppendText(Environment.NewLine);
                        //log kayıtlarında da karışıklık olmasın diye eğer kayıt etme açıksa bir kaç bilgi yazılır txt dosyasına
                        if (verikaydetToolStripMenuItem.CheckState == CheckState.Checked)
                        {
                            string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
                            
                            using (System.IO.StreamWriter file = new System.IO.StreamWriter(programyolu + @"logs\" + "roketLog-" + sadece_tarih.ToString() + ".txt", true)) //Log yerine kullanılabilecek Türkçe bir karşılık bulamadım, belki Veri çıktısı diyebiliriz ama Log kavramı daha evrensel olduğu için böyle yazdım.
                            {
                                file.WriteLine("----------------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
                                file.WriteLine("@$$ --> Bağlantı " + COMPortList.Text + " üzerinden " + sadece_tarih + "</>" + sadece_saat + " tarihinde başlatıldı!" + Environment.NewLine);
                                file.WriteLine("----------------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata! Alıcıdan veri alınırken bir problem oluştu. (Detay: " + ex.Message.ToString() + ")", "Alıcı sistem algılanamadı !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hamVeriTextBox1.AppendText("@@$ --> Alıcıdan veri alırken bir problem oluştu! (" + ex.Message.ToString() + ")" + Environment.NewLine);
                    }
                }
            }
            else //Eğer bağlantı zaten kurulmuşsa bağlantıyı kes.
            {
                serialPort1.Close();
                mCTerminal.Properties.Settings.Default.serialportdurum = false;
                
                bağlantıyıBaşlatToolStripMenuItem.Text = "Bağlantıyı Kur";
                hamVeriTextBox1.AppendText("@$$ --> " + COMPortList.Text + " üzerindeki bağlantı " + sadece_tarih + "</>" + sadece_saat + " tarihinde sonlandırıldı!");
                hamVeriTextBox1.AppendText(Environment.NewLine);
                //log kayıtlarında da karışıklık olmasın diye eğer kayıt etme açıksa bir kaç bilgi yazılır txt dosyasına
                if (verikaydetToolStripMenuItem.CheckState == CheckState.Checked)
                {
                    string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(programyolu + @"logs\" + "roketLog-" + sadece_tarih.ToString() + ".txt", true)) //Log yerine kullanılabilecek Türkçe bir karşılık bulamadım, belki Veri çıktısı diyebiliriz ama Log kavramı daha evrensel olduğu için böyle yazdım.
                    {
                        file.WriteLine("----------------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
                        file.WriteLine("@$$ --> " + COMPortList.Text + " üzerindeki bağlantı " + sadece_tarih + "</>" + sadece_saat + " tarihinde sonlandırıldı!" + Environment.NewLine);
                        file.WriteLine("----------------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
                    }
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            serialPort1.Close();
        }

        private void haritayıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            harita haritafrm = new harita();
            haritafrm.Show();
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

        private void hamVeriyiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hamveriekrani hamveriekranifrm = new hamveriekrani();
            hamveriekranifrm.Show();
        }

        private void destekSayfasınaGitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cosmostakimi.com/");
        }

        private void güncelleştirmeleriKontrolEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
                Process.Start(programyolu + @"\mCTerminal-Updater.exe");
            }
            catch
            {
                MessageBox.Show("mCTerminal-Updater.exe bulunamadı! Lütfen dosyaların konumunu kontrol edin.", "Program başlatılamadı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void uzakGörüntüyüGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kamera kamerafrm = new kamera();
            kamerafrm.Show();
        }

        private void tumselKontrolleriAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bütün gerekli pencereleri özel boyutta ve konumda açar
            hamveriekrani hamveriekranifrm = new hamveriekrani();
            hamveriekranifrm.Show();
            hamveriekranifrm.Location = new Point(Screen.PrimaryScreen.Bounds.Width - hamveriekranifrm.Width, Screen.PrimaryScreen.Bounds.Height - hamveriekranifrm.Height);
            
            kamera kamerafrm = new kamera();
            kamerafrm.Show();
            kamerafrm.Location = new Point(Screen.PrimaryScreen.Bounds.Width - kamerafrm.Width, 0);

            harita haritafrm = new harita();
            haritafrm.Show();
            haritafrm.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - haritafrm.Height);

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
            if (verikaydetToolStripMenuItem.CheckState == CheckState.Unchecked)
            {
                verikaydetToolStripMenuItem.CheckState = CheckState.Checked;
                kayitdurumPictureBox.Image = mCTerminal.Properties.Resources.download_yesil;
                toolTip1.SetToolTip(kayitdurumPictureBox, "Veri kayıtı yapılıyor!");
                toolTip1.ToolTipIcon = ToolTipIcon.Info;
            }
            else
            {
                verikaydetToolStripMenuItem.CheckState = CheckState.Unchecked;
                kayitdurumPictureBox.Image = mCTerminal.Properties.Resources.download_kirmizi;
                toolTip1.SetToolTip(kayitdurumPictureBox, "Veri kayıtı yapılmıyor!");
                toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Restart(); 
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayarlar ayarlarfrm = new ayarlar();
            ayarlarfrm.Show();
        }
    }
}
//Bu proje Cosmos Takımı üyesi "Berke AYDİN" nam-ı diğer "MRpatatesAmca" tarafından yazılmıştır.