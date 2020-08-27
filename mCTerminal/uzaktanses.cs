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

namespace mCTerminal
{
    public partial class uzaktanses : Form
    {

        private NAudio.Wave.WaveIn sourceStream = null;
        private NAudio.Wave.DirectSoundOut waveOut = null;


        public uzaktanses()
        {
            InitializeComponent();


            var enumerator = new MMDeviceEnumerator();
            //cycle through all audio devices
            for (int i = 0; i < WaveIn.DeviceCount; i++)
                sesCihazComboBox.Items.Add(enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active)[i]);
            //clean up
            enumerator.Dispose();

            sesCihazComboBox.SelectedIndex = 0;


        }

        private void uzaktanses_Load(object sender, EventArgs e)
        {

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
