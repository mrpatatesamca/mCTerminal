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
            this.iptalButton = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // kaydetButton
            // 
            this.kaydetButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.kaydetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kaydetButton.Location = new System.Drawing.Point(222, 401);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(83, 23);
            this.kaydetButton.TabIndex = 1;
            this.kaydetButton.Text = "Kaydet ve Çık";
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // iptalButton
            // 
            this.iptalButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iptalButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iptalButton.Location = new System.Drawing.Point(141, 401);
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(75, 23);
            this.iptalButton.TabIndex = 2;
            this.iptalButton.Text = "İptal";
            this.iptalButton.UseVisualStyleBackColor = true;
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
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
            this.uygulamaTemaComboBox.Location = new System.Drawing.Point(12, 25);
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
            this.vericiktikayitformatComboBox.Location = new System.Drawing.Point(12, 80);
            this.vericiktikayitformatComboBox.Name = "vericiktikayitformatComboBox";
            this.vericiktikayitformatComboBox.Size = new System.Drawing.Size(261, 21);
            this.vericiktikayitformatComboBox.TabIndex = 13;
            this.vericiktikayitformatComboBox.SelectedIndexChanged += new System.EventHandler(this.vericiktikayitformatComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Veri Çıktısı Kayıt Formatı:";
            // 
            // haritaDataSilButton
            // 
            this.haritaDataSilButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.haritaDataSilButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.haritaDataSilButton.Location = new System.Drawing.Point(129, 324);
            this.haritaDataSilButton.Name = "haritaDataSilButton";
            this.haritaDataSilButton.Size = new System.Drawing.Size(188, 23);
            this.haritaDataSilButton.TabIndex = 14;
            this.haritaDataSilButton.Text = "Harita Verilerini Sil";
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
            this.haritaVeriBoyutuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.haritaVeriBoyutuLabel.Location = new System.Drawing.Point(111, 350);
            this.haritaVeriBoyutuLabel.Name = "haritaVeriBoyutuLabel";
            this.haritaVeriBoyutuLabel.Size = new System.Drawing.Size(225, 13);
            this.haritaVeriBoyutuLabel.TabIndex = 15;
            this.haritaVeriBoyutuLabel.Text = "Harita Verisi Boyutu: 0MB";
            this.haritaVeriBoyutuLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // haritaEkranGoruntusuKonumDegistirButton
            // 
            this.haritaEkranGoruntusuKonumDegistirButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.haritaEkranGoruntusuKonumDegistirButton.Location = new System.Drawing.Point(381, 167);
            this.haritaEkranGoruntusuKonumDegistirButton.Name = "haritaEkranGoruntusuKonumDegistirButton";
            this.haritaEkranGoruntusuKonumDegistirButton.Size = new System.Drawing.Size(53, 23);
            this.haritaEkranGoruntusuKonumDegistirButton.TabIndex = 16;
            this.haritaEkranGoruntusuKonumDegistirButton.Text = "Değiştir";
            this.haritaEkranGoruntusuKonumDegistirButton.UseVisualStyleBackColor = true;
            this.haritaEkranGoruntusuKonumDegistirButton.Click += new System.EventHandler(this.haritaEkranGoruntusuKonumDegistirButton_Click);
            // 
            // haritaEkranGoruntusuKonumTextBox
            // 
            this.haritaEkranGoruntusuKonumTextBox.Location = new System.Drawing.Point(12, 141);
            this.haritaEkranGoruntusuKonumTextBox.Name = "haritaEkranGoruntusuKonumTextBox";
            this.haritaEkranGoruntusuKonumTextBox.Size = new System.Drawing.Size(422, 20);
            this.haritaEkranGoruntusuKonumTextBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Harita Ekran Görüntüsü Konumu:";
            // 
            // haritaEkranGoruntusuKonumVarsayilanButton
            // 
            this.haritaEkranGoruntusuKonumVarsayilanButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.haritaEkranGoruntusuKonumVarsayilanButton.Location = new System.Drawing.Point(312, 167);
            this.haritaEkranGoruntusuKonumVarsayilanButton.Name = "haritaEkranGoruntusuKonumVarsayilanButton";
            this.haritaEkranGoruntusuKonumVarsayilanButton.Size = new System.Drawing.Size(63, 23);
            this.haritaEkranGoruntusuKonumVarsayilanButton.TabIndex = 19;
            this.haritaEkranGoruntusuKonumVarsayilanButton.Text = "Varsayılan";
            this.haritaEkranGoruntusuKonumVarsayilanButton.UseVisualStyleBackColor = true;
            this.haritaEkranGoruntusuKonumVarsayilanButton.Click += new System.EventHandler(this.haritaEkranGoruntusuKonumVarsayilanButton_Click);
            // 
            // hamVeriDataSilButton
            // 
            this.hamVeriDataSilButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hamVeriDataSilButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hamVeriDataSilButton.Location = new System.Drawing.Point(129, 249);
            this.hamVeriDataSilButton.Name = "hamVeriDataSilButton";
            this.hamVeriDataSilButton.Size = new System.Drawing.Size(188, 23);
            this.hamVeriDataSilButton.TabIndex = 20;
            this.hamVeriDataSilButton.Text = "Ham Veri Kayıtlarını Sil";
            this.hamVeriDataSilButton.UseVisualStyleBackColor = true;
            this.hamVeriDataSilButton.Click += new System.EventHandler(this.hamVeriDataSilButton_Click);
            // 
            // hamVeriBoyutuLabel
            // 
            this.hamVeriBoyutuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hamVeriBoyutuLabel.Location = new System.Drawing.Point(111, 275);
            this.hamVeriBoyutuLabel.Name = "hamVeriBoyutuLabel";
            this.hamVeriBoyutuLabel.Size = new System.Drawing.Size(225, 13);
            this.hamVeriBoyutuLabel.TabIndex = 21;
            this.hamVeriBoyutuLabel.Text = "Ham Veri Boyutu: 0MB";
            this.hamVeriBoyutuLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // hamVeriSilTimer
            // 
            this.hamVeriSilTimer.Interval = 500;
            this.hamVeriSilTimer.Tick += new System.EventHandler(this.hamVeriSilTimer_Tick);
            // 
            // ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(446, 436);
            this.Controls.Add(this.hamVeriBoyutuLabel);
            this.Controls.Add(this.hamVeriDataSilButton);
            this.Controls.Add(this.haritaEkranGoruntusuKonumVarsayilanButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.haritaEkranGoruntusuKonumTextBox);
            this.Controls.Add(this.haritaEkranGoruntusuKonumDegistirButton);
            this.Controls.Add(this.haritaVeriBoyutuLabel);
            this.Controls.Add(this.haritaDataSilButton);
            this.Controls.Add(this.vericiktikayitformatComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uygulamaTemaComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iptalButton);
            this.Controls.Add(this.kaydetButton);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.Button iptalButton;
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
    }
}