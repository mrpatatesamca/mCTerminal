using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mCTerminal
{
    public partial class ayarlar : Form
    {
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
            //Temalar için böyle bir yöntem kullanıyorum, aslında bir xml dosyasına renk bilgilerini ve tema isimlerini
            //yazabilirim ama böyle ekstra bir dosya olmadan halledebiliyorum.
            
            if (uygulamaTemaComboBox.SelectedItem.ToString() == "Varsayılan Tema")
            {
                mCTerminal.Properties.Settings.Default.program_tema = "tema_varsayilan";
            }

            if (uygulamaTemaComboBox.SelectedItem.ToString() == "Matrix Teması")
            {
                mCTerminal.Properties.Settings.Default.program_tema = "tema_matrix";
            }

            if (uygulamaTemaComboBox.SelectedItem.ToString() == "Dondurma Teması")
            {
                mCTerminal.Properties.Settings.Default.program_tema = "tema_dondurma";
            }

            if (uygulamaTemaComboBox.SelectedItem.ToString() == "Cosmos Takımı Teması")
            {
                mCTerminal.Properties.Settings.Default.program_tema = "tema_cosmos";
            }

            if (uygulamaTemaComboBox.SelectedItem.ToString() == "Material Tema")
            {
                mCTerminal.Properties.Settings.Default.program_tema = "tema_material";
            }
        }

        private void ayarlar_Load(object sender, EventArgs e)
        {
            if (mCTerminal.Properties.Settings.Default.program_tema == "tema_varsayilan")
            {
                uygulamaTemaComboBox.SelectedItem = "Varsayılan Tema";
            }

            if (mCTerminal.Properties.Settings.Default.program_tema == "tema_matrix")
            {
                uygulamaTemaComboBox.SelectedItem = "Matrix Teması";
            }

            if (mCTerminal.Properties.Settings.Default.program_tema == "tema_dondurma")
            {
                uygulamaTemaComboBox.SelectedItem = "Dondurma Teması";
            }

            if (mCTerminal.Properties.Settings.Default.program_tema == "tema_cosmos")
            {
                uygulamaTemaComboBox.SelectedItem = "Cosmos Takımı Teması"; 
            }

            if (mCTerminal.Properties.Settings.Default.program_tema == "tema_material")
            {
                uygulamaTemaComboBox.SelectedItem = "Material Tema";
            }
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            DialogResult uyarimesaj = new DialogResult();
            uyarimesaj = MessageBox.Show("Yapılan değişikliklerin uygulanabilmesi için programın yeniden başlatılması lazım! Program yeniden başlatılsın mı?", "Program Yeniden Başlatılsın mı?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (uyarimesaj == DialogResult.Yes)
            {
                mCTerminal.Properties.Settings.Default.Save();
                Application.Restart();
            }
            else
            {
                mCTerminal.Properties.Settings.Default.Save();
                this.Close();
            }
            

        }
    }
}
