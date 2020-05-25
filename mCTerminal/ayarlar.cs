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
    public partial class ayarlar : Form
    {
        XmlTextReader xtr = new XmlTextReader(programyolu + @"\res\settings.xml"); //XML dosyasını okumak için hazırlık yap
        static string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
        anaEkran anaEkranfrm = new anaEkran();
        string xmlAyarIsim;
        string xmlAyarDeger;
        public string programTema;
        public string programVeriFormat;
        public string programSurum;

        public ayarlar()
        {
            InitializeComponent();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void uygulamaTemaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Temalar için böyle bir yöntem kullanıyorum, aslında bir xml dosyasına renk bilgilerini ve tema isimlerini yazabilirim ama böyle ekstra bir dosya olmadan halledebiliyorum.
            
            if (uygulamaTemaComboBox.SelectedItem.ToString() == "Varsayılan Tema")
            {
                programTema = "tema_varsayilan";
            }

            if (uygulamaTemaComboBox.SelectedItem.ToString() == "Matrix Teması")
            {
                programTema = "tema_matrix";
            }

            if (uygulamaTemaComboBox.SelectedItem.ToString() == "Dondurma Teması")
            {
                programTema = "tema_dondurma";
            }

            if (uygulamaTemaComboBox.SelectedItem.ToString() == "Cosmos Takımı Teması")
            {
               programTema = "tema_cosmos";
            }

            if (uygulamaTemaComboBox.SelectedItem.ToString() == "Material Tema")
            {
                programTema = "tema_material";
            }
        }

        public void editorAyarKaydet()
        {
            try
            {
                XmlTextWriter xtw = new XmlTextWriter(programyolu + @"\res\settings.xml", System.Text.Encoding.UTF8); //XML dosyasını yazmak için hazırlık yap
                xtw.Formatting = Formatting.Indented;

                xtw.WriteStartDocument();

                xtw.WriteComment("mCTerminal ayarlarının saklandığı yer.");
                xtw.WriteComment("Ne yaptığınızı bilmiyorsanız lütfen hiç bir şeye dokunmayınız!");

                xtw.WriteStartElement("ayarlar");
                //-------------------------------------------
                xtw.WriteStartElement("ayar");
                xtw.WriteElementString("name", "programTema");
                xtw.WriteElementString("value", programTema);
                xtw.WriteEndElement();
                //-------------------------------------------
                xtw.WriteStartElement("ayar");
                xtw.WriteElementString("name", "programSurum");
                xtw.WriteElementString("value", programSurum);
                xtw.WriteEndElement();
                //-------------------------------------------
                xtw.WriteStartElement("ayar");
                xtw.WriteElementString("name", "programVeriFormat");
                xtw.WriteElementString("value", programVeriFormat);
                xtw.WriteEndElement();
                //-------------------------------------------
                xtw.WriteEndElement();
                xtw.WriteComment("Bu ayar dosyası program tarafından oluşturuldu. [" + System.DateTime.Now + "]");
                xtw.WriteEndDocument();
                xtw.Flush();
                xtw.Close();
            }
            catch
            {
                MessageBox.Show(@"Ayarlar diske yazılamadı! Lütfen programı yeniden indirin! (res\settings.xml dosyası bozuk veya değiştirilmiş!)", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void vericiktikayitformatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //veri çıktısı dosyasının uzantısını böyle ayarlıyorum

            if (vericiktikayitformatComboBox.SelectedItem.ToString() == "Log Dosyası (*.log)")
            {
                programVeriFormat = ".log";
            }

            if (vericiktikayitformatComboBox.SelectedItem.ToString() == "Text Dosyası (*.txt)")
            {
                programVeriFormat = ".txt";
            }

            if (vericiktikayitformatComboBox.SelectedItem.ToString() == "eXtensible Markup Language Dosyası (*.xml)")
            {
                programVeriFormat = ".xml";
            }

            if (vericiktikayitformatComboBox.SelectedItem.ToString() == "Verilog Dosyası (*.vs)")
            {
                programVeriFormat = ".vs";
            }
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

                //----------------------program teması ayarları------------------------------
                if (programTema == "tema_varsayilan")
                {
                    uygulamaTemaComboBox.SelectedItem = "Varsayılan Tema";
                }

                if (programTema == "tema_matrix")
                {
                    uygulamaTemaComboBox.SelectedItem = "Matrix Teması";
                }

                if (programTema == "tema_dondurma")
                {
                    uygulamaTemaComboBox.SelectedItem = "Dondurma Teması";
                }

                if (programTema == "tema_cosmos")
                {
                    uygulamaTemaComboBox.SelectedItem = "Cosmos Takımı Teması";
                }

                if (programTema == "tema_material")
                {
                    uygulamaTemaComboBox.SelectedItem = "Material Tema";
                }
                //----------------------------------------------------------------------------

                //------------------veri çıktısı kayıt formatı ayarları-----------------------
                if (programVeriFormat == ".log")
                {
                    vericiktikayitformatComboBox.SelectedItem = "Log Dosyası (*.log)";
                }

                if (programVeriFormat == ".txt")
                {
                    vericiktikayitformatComboBox.SelectedItem = "Text Dosyası (*.txt)";
                }

                if (programVeriFormat == ".xml")
                {
                    vericiktikayitformatComboBox.SelectedItem = "eXtensible Markup Language Dosyası (*.xml)";
                }

                if (programVeriFormat == ".vs")
                {
                    vericiktikayitformatComboBox.SelectedItem = "Verilog Dosyası (*.vs)";
                }

            }
            catch
            {
                MessageBox.Show(@"Ayarlar diskten okunamadı! Lütfen programı yeniden indirin! (res\settings.xml dosyası bozuk veya değiştirilmiş!)", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void ayarlar_Load(object sender, EventArgs e)
        {
            editorAyarYukle();
            
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            DialogResult uyarimesaj = new DialogResult();
            uyarimesaj = MessageBox.Show("Yapılan değişikliklerin uygulanabilmesi için programın yeniden başlatılması lazım! Program yeniden başlatılsın mı?", "Program Yeniden Başlatılsın mı?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (uyarimesaj == DialogResult.Yes)
            {
                editorAyarKaydet();
                Application.Restart();
            }
            else
            {
                editorAyarKaydet();
                this.Close();
            }
            

        }
    }
}
