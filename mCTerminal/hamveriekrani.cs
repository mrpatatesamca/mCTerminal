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

namespace mCTerminal
{
    public partial class hamveriekrani : Form
    {
        anaEkran anaEkranfrm = new anaEkran();
        XmlTextReader xtr = new XmlTextReader(programyolu + @"\res\settings.xml"); //XML dosyasını okumak için hazırlık yap
        string xmlAyarIsim;
        string xmlAyarDeger;
        public string programTema;
        public string programVeriFormat;
        public string programSurum;
        static string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;

        public hamveriekrani()
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

        private void hamveriekrani_Load(object sender, EventArgs e)
        {
            editorAyarYukle();

            //temalar için ayrılmış bölüm

            if (programTema == "tema_varsayilan")
            {
                hamveritextbox.BackColor = Color.FromArgb(25, 25, 25);
                hamveritextbox.ForeColor = Color.Chocolate;
            }

            if (programTema == "tema_matrix")
            {
                hamveritextbox.BackColor = Color.FromArgb(10, 12, 10);
                hamveritextbox.ForeColor = Color.LimeGreen;
            }

            if (programTema == "tema_dondurma")
            {
                hamveritextbox.BackColor = Color.LightSlateGray;
                hamveritextbox.ForeColor = Color.NavajoWhite;
            }

            if (programTema == "tema_cosmos")
            {
                hamveritextbox.BackColor = Color.FromArgb(6, 0, 102);
                hamveritextbox.ForeColor = Color.BurlyWood;
            }

            if (programTema == "tema_material")
            {
                hamveritextbox.BackColor = Color.FromArgb(72, 96, 74);
                hamveritextbox.ForeColor = Color.FromArgb(255, 185, 105);
            }
            //-----------------------------------------------------------






            string sadece_saat = DateTime.Now.ToString("hh:mm:ss");
            hamveritextbox.Text = sadece_saat + " --> Veri Bekleniyor..." + Environment.NewLine;
            hamveritextbox.SelectionStart = hamveritextbox.Text.Length;

        }

        private void verikontrol_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.serialportdurum == true)
            {
                string sadece_saat = DateTime.Now.ToString("hh:mm:ss");
                hamveritextbox.AppendText(sadece_saat + " --> " + Properties.Settings.Default.data + Environment.NewLine);
                int line = hamveritextbox.GetLineFromCharIndex(hamveritextbox.SelectionStart);
                int column = hamveritextbox.SelectionStart - hamveritextbox.GetFirstCharIndexFromLine(line);
            }
            


        }
    }
}
