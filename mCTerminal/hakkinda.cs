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
using WMPLib;

namespace mCTerminal
{
    public partial class hakkinda : Form
    {
        static string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
        anaEkran anaEkranfrm = new anaEkran();
        XmlTextReader xtr = new XmlTextReader(programyolu + @"\res\settings.xml"); //XML dosyasını okumak için hazırlık yap
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        string xmlAyarIsim;
        string xmlAyarDeger;
        public string programTema;
        public string programVeriFormat;
        public string programSurum;

        public hakkinda()
        {
            InitializeComponent();
            editorAyarYukle();
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

        private void githubadresLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mrpatatesamca/mCTerminal");
        }

        private void twitterLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitter.com/mrpatatesamca");
        }

        private void hakkinda_Load(object sender, EventArgs e)
        {
            this.Text = "mCTerminal " + programSurum + " Hakkında";
            programSurumSayiLabel.Text = "mCTerminal " + programSurum;
            sistembilgiLabel.Text = "@" + Environment.MachineName + "/" + Environment.UserName + " | " + Environment.OSVersion;
            wmp.URL = programyolu + @"\res\chiptune2.mp3";
            wmp.controls.play();
        }

        private void hakkinda_FormClosing(object sender, FormClosingEventArgs e)
        {
            wmp.controls.stop();
        }
    }
}
