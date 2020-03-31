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


namespace mCTerminal
{
    public partial class kamera : Form
    {
        public kamera()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void kamera_Load(object sender, EventArgs e)
        {
            videoCaptureBox.SizeMode = PictureBoxSizeMode.Zoom;
            //------------------------------DirectShow Cihazlarını belirleme ve yükleme----------------------
            try
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filterInfo in filterInfoCollection)
                    videoCaptureComboBox.Items.Add(filterInfo.Name);
                videoCaptureComboBox.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Görüntü aygıtlarını yüklerken bir hata meydana geldi! (" + ex.ToString() + ")", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //----------------------------------------------------------------------------------------
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            videoCaptureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void kamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoCaptureDevice.Stop();
        }

        private void videoCaptureButton_Click(object sender, EventArgs e)
        {
            yuklemePictureBox.Visible = true; //yukleme animasyonu göster
            //-------------------------DirectShow Cihazları okuma ve görüntü alma-----------------------
            try
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[videoCaptureComboBox.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
                yuklemePictureBox.Visible = false; //yukleme animasyonunu gizle
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
    }
}
