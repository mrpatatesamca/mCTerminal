using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml;

namespace mCTerminal
{
    public partial class uzaktanses : Form
    {

        private NAudio.Wave.WaveIn sourceStream = null;
        private NAudio.Wave.DirectSoundOut waveOut = null;
        XmlTextReader xtr = new XmlTextReader(programyolu + @"res\settings.xml"); //XML dosyasını okumak için hazırlık yap
        string xmlAyarIsim;
        string xmlAyarDeger;
        public string programTema;
        public string programVeriFormat;
        public string programSurum;
        static string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;


        public uzaktanses()
        {
            InitializeComponent();

            for (int n = 0; n < WaveIn.DeviceCount; n++)
            {
                
                sesCihazComboBox.Items.Add(WaveIn.GetCapabilities(n).ProductName);
            }

            sesCihazComboBox.SelectedIndex = 0;


        }

        private void uzaktanses_Load(object sender, EventArgs e)
        {
            editorAyarYukle();
            //temalar için ayrılmış bölüm

            if (programTema == "tema_varsayilan")
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.ForeColor = Color.WhiteSmoke;
                sesSiddetGauge.BackColor = this.BackColor;
            }

            if (programTema == "tema_matrix")
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.DarkOliveGreen;
                sesSiddetGauge.BackColor = this.BackColor;
            }

            if (programTema == "tema_dondurma")
            {
                this.BackColor = Color.FromArgb(220, 229, 225);
                this.ForeColor = Color.IndianRed;
                sesSiddetGauge.BackColor = this.BackColor;
            }

            if (programTema == "tema_cosmos")
            {
                this.BackColor = Color.FromArgb(26, 16, 122);
                this.ForeColor = Color.FromArgb(245, 228, 183);
                sesSiddetGauge.BackColor = this.BackColor;
            }

            if (programTema == "tema_material")
            {
                this.BackColor = Color.FromArgb(47, 79, 79);
                this.ForeColor = Color.FromArgb(251, 235, 235);
                sesSiddetGauge.BackColor = this.BackColor;
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

        private void sesCihaziBilgiGuncellemeTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (sesCihazComboBox.SelectedItem != null)
                {
                    var enumerator = new MMDeviceEnumerator();
                    var device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
                    int ses_siddet = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
                    sesSiddetProgressBar.Value = ses_siddet;
                    sesSiddetGauge.Value = ses_siddet;
                    sesSiddetLabel.Text = "%" + ses_siddet.ToString();
                    Properties.Settings.Default.gurultudurum = ses_siddet;
                }
            }
            catch
            {

            }
        }

        private void sesCihazComboBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = "mCTerminal Uzak Ses | (" + sesCihazComboBox.SelectedItem + ")";
        }

        public void editorSesDinlemeBaslat()
        {
            int deviceNumber = sesCihazComboBox.SelectedIndex;

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(48000, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);

            NAudio.Wave.WaveInProvider waveIn = new NAudio.Wave.WaveInProvider(sourceStream);
            waveOut = new NAudio.Wave.DirectSoundOut();
            waveOut.Init(waveIn);

            sourceStream.StartRecording();
            waveOut.Play();
            onbellekSayiLabel.Text = "Kullanılacak Önbellek Sayısı: " + sourceStream.NumberOfBuffers;
            
        }

        public void editorSesDinlemeDurdur()
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }
        }

        private void uzaktanses_FormClosing(object sender, FormClosingEventArgs e)
        {
            editorSesDinlemeDurdur();
        }

        private void sesDinlemeButton_Click(object sender, EventArgs e)
        {
            if (sesDinlemeButton.Text == "Aygıtı Dinlemeye Başla")
            {
                editorSesDinlemeBaslat();
                sesDinlemeButton.Text = "Aygıtı Dinlemeyi Durdur";
            }
            else
            {
                editorSesDinlemeDurdur();
                sesDinlemeButton.Text = "Aygıtı Dinlemeye Başla";
            }
        }
    }
}
