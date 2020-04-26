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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ayarlar));
            this.kaydetButton = new System.Windows.Forms.Button();
            this.iptalButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uygulamaTemaComboBox = new System.Windows.Forms.ComboBox();
            this.vericiktikayitformatComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kaydetButton
            // 
            this.kaydetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kaydetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kaydetButton.Location = new System.Drawing.Point(134, 168);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(83, 23);
            this.kaydetButton.TabIndex = 1;
            this.kaydetButton.Text = "Kaydet ve Çık";
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // iptalButton
            // 
            this.iptalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iptalButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iptalButton.Location = new System.Drawing.Point(53, 168);
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
            this.uygulamaTemaComboBox.Size = new System.Drawing.Size(247, 21);
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
            this.vericiktikayitformatComboBox.Location = new System.Drawing.Point(12, 75);
            this.vericiktikayitformatComboBox.Name = "vericiktikayitformatComboBox";
            this.vericiktikayitformatComboBox.Size = new System.Drawing.Size(247, 21);
            this.vericiktikayitformatComboBox.TabIndex = 13;
            this.vericiktikayitformatComboBox.SelectedIndexChanged += new System.EventHandler(this.vericiktikayitformatComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Veri Çıktısı Kayıt Formatı:";
            // 
            // ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(271, 203);
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
    }
}