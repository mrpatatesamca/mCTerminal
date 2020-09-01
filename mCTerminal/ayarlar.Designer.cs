namespace mCTerminal
{
    partial class ayarlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ayarlar));
            this.kaydetButton = new System.Windows.Forms.Button();
            this.tamamButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uygulamaTemaComboBox = new System.Windows.Forms.ComboBox();
            this.vericiktikayitformatComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.haritaDataSilButton = new System.Windows.Forms.Button();
            this.haritaVeriSilTimer = new System.Windows.Forms.Timer(this.components);
            this.haritaVeriBoyutuLabel = new System.Windows.Forms.Label();
            this.haritaEkranGoruntusuKonumDegistirButton = new System.Windows.Forms.Button();
            this.haritaEkranGoruntusuKonumTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.haritaEkranGoruntusuKonumVarsayilanButton = new System.Windows.Forms.Button();
            this.hamVeriDataSilButton = new System.Windows.Forms.Button();
            this.hamVeriBoyutuLabel = new System.Windows.Forms.Label();
            this.hamVeriSilTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kaydetButton
            // 
            this.kaydetButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.kaydetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kaydetButton.Location = new System.Drawing.Point(256, 275);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(83, 23);
            this.kaydetButton.TabIndex = 1;
            this.kaydetButton.Text = "Kaydet ve Çık";
            this.toolTip1.SetToolTip(this.kaydetButton, "Ayarları kaydeder ve pencereyi kapatır.");
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // tamamButton
            // 
            this.tamamButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tamamButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tamamButton.Location = new System.Drawing.Point(175, 275);
            this.tamamButton.Name = "tamamButton";
            this.tamamButton.Size = new System.Drawing.Size(75, 23);
            this.tamamButton.TabIndex = 2;
            this.tamamButton.Text = "Tamam";
            this.toolTip1.SetToolTip(this.tamamButton, "Pencereyi kapatır.");
            this.tamamButton.UseVisualStyleBackColor = true;
            this.tamamButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Uygulama Teması:";
            // 
            // uygulamaTemaComboBox
            // 
            this.uygulamaTemaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uygulamaTemaComboBox.FormattingEnabled = true;
            this.uygulamaTemaComboBox.Items.AddRange(new object[] {
            "Varsayılan Tema",
            "Matrix Teması",
            "Dondurma Teması",
            "Cosmos Takımı Teması",
            "Material Tema"});
            this.uygulamaTemaComboBox.Location = new System.Drawing.Point(9, 32);
            this.uygulamaTemaComboBox.Name = "uygulamaTemaComboBox";
            this.uygulamaTemaComboBox.Size = new System.Drawing.Size(261, 21);
            this.uygulamaTemaComboBox.TabIndex = 11;
            this.uygulamaTemaComboBox.SelectedIndexChanged += new System.EventHandler(this.uygulamaTemaComboBox_SelectedIndexChanged);
            // 
            // vericiktikayitformatComboBox
            // 
            this.vericiktikayitformatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vericiktikayitformatComboBox.FormattingEnabled = true;
            this.vericiktikayitformatComboBox.Items.AddRange(new object[] {
            "Log Dosyası (*.log)",
            "Text Dosyası (*.txt)",
            "eXtensible Markup Language Dosyası (*.xml)",
            "Verilog Dosyası (*.vs)"});
            this.vericiktikayitformatComboBox.Location = new System.Drawing.Point(9, 87);
            this.vericiktikayitformatComboBox.Name = "vericiktikayitformatComboBox";
            this.vericiktikayitformatComboBox.Size = new System.Drawing.Size(261, 21);
            this.vericiktikayitformatComboBox.TabIndex = 13;
            this.vericiktikayitformatComboBox.SelectedIndexChanged += new System.EventHandler(this.vericiktikayitformatComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Veri Çıktısı Kayıt Formatı:";
            // 
            // haritaDataSilButton
            // 
            this.haritaDataSilButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.haritaDataSilButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.haritaDataSilButton.Location = new System.Drawing.Point(7, 48);
            this.haritaDataSilButton.Name = "haritaDataSilButton";
            this.haritaDataSilButton.Size = new System.Drawing.Size(188, 23);
            this.haritaDataSilButton.TabIndex = 14;
            this.haritaDataSilButton.Text = "Harita Verilerini Sil";
            this.toolTip1.SetToolTip(this.haritaDataSilButton, "Program tarafından önbelleklenmiş harita dosyalarını temizler.");
            this.haritaDataSilButton.UseVisualStyleBackColor = true;
            this.haritaDataSilButton.Click += new System.EventHandler(this.haritaDataSilButton_Click);
            // 
            // haritaVeriSilTimer
            // 
            this.haritaVeriSilTimer.Interval = 500;
            this.haritaVeriSilTimer.Tick += new System.EventHandler(this.haritaverisilTimer_Tick);
            // 
            // haritaVeriBoyutuLabel
            // 
            this.haritaVeriBoyutuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.haritaVeriBoyutuLabel.Location = new System.Drawing.Point(6, 108);
            this.haritaVeriBoyutuLabel.Name = "haritaVeriBoyutuLabel";
            this.haritaVeriBoyutuLabel.Size = new System.Drawing.Size(191, 13);
            this.haritaVeriBoyutuLabel.TabIndex = 15;
            this.haritaVeriBoyutuLabel.Text = "Harita Verisi Boyutu: 0 MB";
            this.haritaVeriBoyutuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // haritaEkranGoruntusuKonumDegistirButton
            // 
            this.haritaEkranGoruntusuKonumDegistirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.haritaEkranGoruntusuKonumDegistirButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.haritaEkranGoruntusuKonumDegistirButton.Location = new System.Drawing.Point(450, 216);
            this.haritaEkranGoruntusuKonumDegistirButton.Name = "haritaEkranGoruntusuKonumDegistirButton";
            this.haritaEkranGoruntusuKonumDegistirButton.Size = new System.Drawing.Size(53, 23);
            this.haritaEkranGoruntusuKonumDegistirButton.TabIndex = 16;
            this.haritaEkranGoruntusuKonumDegistirButton.Text = "Değiştir";
            this.toolTip1.SetToolTip(this.haritaEkranGoruntusuKonumDegistirButton, "Ekran görüntüsünün kaydedileceği konumu değiştirin.");
            this.haritaEkranGoruntusuKonumDegistirButton.UseVisualStyleBackColor = true;
            this.haritaEkranGoruntusuKonumDegistirButton.Click += new System.EventHandler(this.haritaEkranGoruntusuKonumDegistirButton_Click);
            // 
            // haritaEkranGoruntusuKonumTextBox
            // 
            this.haritaEkranGoruntusuKonumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.haritaEkranGoruntusuKonumTextBox.Location = new System.Drawing.Point(12, 218);
            this.haritaEkranGoruntusuKonumTextBox.Name = "haritaEkranGoruntusuKonumTextBox";
            this.haritaEkranGoruntusuKonumTextBox.Size = new System.Drawing.Size(363, 20);
            this.haritaEkranGoruntusuKonumTextBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Harita Ekran Görüntüsü Konumu:";
            // 
            // haritaEkranGoruntusuKonumVarsayilanButton
            // 
            this.haritaEkranGoruntusuKonumVarsayilanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.haritaEkranGoruntusuKonumVarsayilanButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.haritaEkranGoruntusuKonumVarsayilanButton.Location = new System.Drawing.Point(381, 216);
            this.haritaEkranGoruntusuKonumVarsayilanButton.Name = "haritaEkranGoruntusuKonumVarsayilanButton";
            this.haritaEkranGoruntusuKonumVarsayilanButton.Size = new System.Drawing.Size(63, 23);
            this.haritaEkranGoruntusuKonumVarsayilanButton.TabIndex = 19;
            this.haritaEkranGoruntusuKonumVarsayilanButton.Text = "Varsayılan";
            this.toolTip1.SetToolTip(this.haritaEkranGoruntusuKonumVarsayilanButton, "Ekran görüntüsünün kaydedileceği konumu varsayılan olarak ayarlar.");
            this.haritaEkranGoruntusuKonumVarsayilanButton.UseVisualStyleBackColor = true;
            this.haritaEkranGoruntusuKonumVarsayilanButton.Click += new System.EventHandler(this.haritaEkranGoruntusuKonumVarsayilanButton_Click);
            // 
            // hamVeriDataSilButton
            // 
            this.hamVeriDataSilButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hamVeriDataSilButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hamVeriDataSilButton.Location = new System.Drawing.Point(7, 19);
            this.hamVeriDataSilButton.Name = "hamVeriDataSilButton";
            this.hamVeriDataSilButton.Size = new System.Drawing.Size(188, 23);
            this.hamVeriDataSilButton.TabIndex = 20;
            this.hamVeriDataSilButton.Text = "Ham Veri Kayıtlarını Sil";
            this.toolTip1.SetToolTip(this.hamVeriDataSilButton, "Program tarafından kaydedilmiş verileri temizler.");
            this.hamVeriDataSilButton.UseVisualStyleBackColor = true;
            this.hamVeriDataSilButton.Click += new System.EventHandler(this.hamVeriDataSilButton_Click);
            // 
            // hamVeriBoyutuLabel
            // 
            this.hamVeriBoyutuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hamVeriBoyutuLabel.Location = new System.Drawing.Point(6, 95);
            this.hamVeriBoyutuLabel.Name = "hamVeriBoyutuLabel";
            this.hamVeriBoyutuLabel.Size = new System.Drawing.Size(191, 13);
            this.hamVeriBoyutuLabel.TabIndex = 21;
            this.hamVeriBoyutuLabel.Text = "Ham Veri Boyutu: 0 MB";
            this.hamVeriBoyutuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hamVeriSilTimer
            // 
            this.hamVeriSilTimer.Interval = 500;
            this.hamVeriSilTimer.Tick += new System.EventHandler(this.hamVeriSilTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.uygulamaTemaComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.vericiktikayitformatComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 137);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hamVeriBoyutuLabel);
            this.groupBox2.Controls.Add(this.hamVeriDataSilButton);
            this.groupBox2.Controls.Add(this.haritaDataSilButton);
            this.groupBox2.Controls.Add(this.haritaVeriBoyutuLabel);
            this.groupBox2.Location = new System.Drawing.Point(300, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 137);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(515, 310);
            this.Controls.Add(this.haritaEkranGoruntusuKonumVarsayilanButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.haritaEkranGoruntusuKonumTextBox);
            this.Controls.Add(this.haritaEkranGoruntusuKonumDegistirButton);
            this.Controls.Add(this.tamamButton);
            this.Controls.Add(this.kaydetButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mCTerminal Ayarları";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ayarlar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.Button tamamButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uygulamaTemaComboBox;
        private System.Windows.Forms.ComboBox vericiktikayitformatComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button haritaDataSilButton;
        private System.Windows.Forms.Timer haritaVeriSilTimer;
        private System.Windows.Forms.Label haritaVeriBoyutuLabel;
        private System.Windows.Forms.Button haritaEkranGoruntusuKonumDegistirButton;
        private System.Windows.Forms.TextBox haritaEkranGoruntusuKonumTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button haritaEkranGoruntusuKonumVarsayilanButton;
        private System.Windows.Forms.Button hamVeriDataSilButton;
        private System.Windows.Forms.Label hamVeriBoyutuLabel;
        private System.Windows.Forms.Timer hamVeriSilTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}