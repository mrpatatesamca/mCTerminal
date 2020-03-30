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

namespace mCTerminal
{
    
    public partial class anaEkran : Form
    {
        int maksm = 20, minm = 0;
        int gkuvvetmin = 0, gkuvvetmaks = 20;
        public class HerYerden
        {
           public static int zamanvoltaj = 0;
        }
        public anaEkran()
        {
            InitializeComponent();
            mCTerminal.Properties.Settings.Default.Reset();
            string[] portlar = SerialPort.GetPortNames(); //portlar listesine COM portları alındı.
            serialPort1.BaudRate = 9600; //baudrate ayarlama
            Control.CheckForIllegalCrossThreadCalls = false; //Serial portlarda oluşabilecek hataları kontrol etmemesi için ayarladık.
            foreach (string port in portlar)
            {
                COMPortList.Items.Add(port);
                COMPortList.SelectedIndex = 0;
                baudRatePortList.Items.Add("9600");
                baudRatePortList.SelectedIndex = 0;
            }
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

        }

        private void anaEkran_Load(object sender, EventArgs e)
        {
            //Ham veri'nin yazıldığı textbox'ın düzgün gözükmesi için
            hamVeriTextBox1.SelectionStart = hamVeriTextBox1.Text.Length;

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
                Properties.Settings.Default.enlem = splitted_data[0];
                enlemLabel.Text = "Boylam: " + splitted_data[1] + "°"; //boylam
                Properties.Settings.Default.boylam = splitted_data[1];
                yatayHizLabel.Text = "Yatay Hız: " + splitted_data[2] + "km/s"; //yatay hız
                irtifaLabel.Text = "İrtifa: " + splitted_data[3] + "m"; //irtifa
                uyduSayiLabel.Text = "Bağlanılan Uydu Sayısı: " + splitted_data[4]; //uydu
                voltajLabel.Text = "Voltaj: " + splitted_data[5] + "v"; //voltaj
                gkuvvetLabel.Text = "G Kuvveti: " + splitted_data[6] + "g"; //g kuvvet
                // textBox8.Text = splitted_data[7]; //anahtar
                // textBox9.Text = splitted_data[8]; //video
                // textBox10.Text = splitted_data[9]; //yedek aviyoik
                irtifaBaroLabel.Text = "İrtifa (Barometrik): " + splitted_data[10] + "m"; //barometrik irtifa
                sinyalGucuLabel.Text = "Sinyal Seviyesi: " + splitted_data[11] + "dB"; //sinyal seviyesi
                snrSeviyesiLabel.Text = "SNR Seviyesi: " + splitted_data[12] + "dB"; //snr seviyesi

                mCTerminal.Properties.Settings.Default.hamveri = data;
                hamVeriTextBox1.AppendText(data + Environment.NewLine);
                int line = hamVeriTextBox1.GetLineFromCharIndex(hamVeriTextBox1.SelectionStart);
                int column = hamVeriTextBox1.SelectionStart - hamVeriTextBox1.GetFirstCharIndexFromLine(line);
                mCTerminal.Properties.Settings.Default.hamveri = data;

                //-----------------------------------VOLTAJ GRAFİĞİ----------------------------------
                voltajGrafik.ChartAreas[0].AxisX.Minimum = minm;
                voltajGrafik.ChartAreas[0].AxisX.Maximum = maksm;
                voltajGrafik.ChartAreas[0].AxisY.Minimum = 0;
                voltajGrafik.ChartAreas[0].AxisY.Maximum = 5;
                voltajGrafik.ChartAreas[0].AxisX.ScaleView.Zoom(minm, maksm);
                this.voltajGrafik.Series[0].Points.AddXY((minm + maksm) / 2, splitted_data[5]);
                //---------------------------------G KUVVETİ GRAFİĞİ---------------------------------
                chart1.ChartAreas[0].AxisX.Minimum = gkuvvetmin;
                chart1.ChartAreas[0].AxisX.Maximum = gkuvvetmaks;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 20;
                chart1.ChartAreas[0].AxisX.ScaleView.Zoom(gkuvvetmin, gkuvvetmaks);
                this.chart1.Series[0].Points.AddXY((gkuvvetmin + gkuvvetmaks) / 2, splitted_data[6]);
                //-----------------------------------------------------------------------------------
                gkuvvetmin++;
                gkuvvetmaks++;
                maksm++;
                minm++;
                


            }
            catch (Exception ex)
            {

            }
        }

        private void bağlantıyıBaşlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) //Bağlantı kurulmamışsa.
            {
                if (COMPortList.SelectedIndex < 0) //Bağlantı noktası boş olduğu zaman program çöküyor bu yüzden kullanıcıyı bilgilendiriyorum ve çökmesini engelliyorum.
                {
                    MessageBox.Show("Hata! Alıcı sistem ile bağlantı kurulamadı! Lütfen alıcıyı bilgisayarınıza bağladığınızdan emin olunuz, eğer zaten bağlıysa kabloları kontrol ediniz.", "Alıcı Sistem Bulunamadı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        hamVeriTextBox1.AppendText("@$$ --> Bağlantı " + COMPortList.Text + " üzerinden başlatıldı!");
                        hamVeriTextBox1.AppendText(Environment.NewLine);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata! Alıcıdan veri alınırken bir problem oluştu. Detay: " + ex.Message.ToString(), "Alıcı sistem algılanamadı !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else //Eğer bağlantı zaten kurulmuşsa bağlantıyı kes.
            {
                serialPort1.Close();
                mCTerminal.Properties.Settings.Default.serialportdurum = false;
                bağlantıyıBaşlatToolStripMenuItem.Text = "Bağlantıyı Kur";
                hamVeriTextBox1.AppendText("@$$ --> " + COMPortList.Text + " üzerindeki bağlantı sonlandırıldı!");
                hamVeriTextBox1.AppendText(Environment.NewLine);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Form kapatılmadan önce ilk başta gözüken yükleme ekranını kapatır daha sonra ise yürütülen işlemi tamamen durdurur.
            baslangic_splash baslangic_splashfrm = new baslangic_splash();
            baslangic_splashfrm.Close();
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
            //Form kapatılmadan önce ilk başta gözüken yükleme ekranını kapatır daha sonra ise yürütülen işlemi tamamen durdurur.
            baslangic_splash baslangic_splashfrm = new baslangic_splash();
            baslangic_splashfrm.Close();
            Application.Exit();
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
        }

        private void destekSayfasınaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cosmostakimi.com");
        }

        private void hamVeriyiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hamveriekrani hamveriekranifrm = new hamveriekrani();
            hamveriekranifrm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Restart(); 
            //Bu proje Cosmos Takımı üyesi "Berke AYDİN" nam-ı diğer "MRpatatesAmca" tarafından yazılmıştır.
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayarlar ayarlarfrm = new ayarlar();
            ayarlarfrm.Show();
        }
    }
}
