namespace mCTerminal
{
    partial class eksikdosyaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eksikdosyaForm));
            this.eksikdosyaindirButon = new System.Windows.Forms.Button();
            this.tamamButon = new System.Windows.Forms.Button();
            this.aciklamaLabel = new System.Windows.Forms.Label();
            this.dosyabilgiTextBox = new System.Windows.Forms.TextBox();
            this.dosyabilgiTextBox2 = new System.Windows.Forms.TextBox();
            this.fakebaslikTextBox = new System.Windows.Forms.TextBox();
            this.durumLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // eksikdosyaindirButon
            // 
            this.eksikdosyaindirButon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.eksikdosyaindirButon.Location = new System.Drawing.Point(131, 322);
            this.eksikdosyaindirButon.Name = "eksikdosyaindirButon";
            this.eksikdosyaindirButon.Size = new System.Drawing.Size(110, 23);
            this.eksikdosyaindirButon.TabIndex = 0;
            this.eksikdosyaindirButon.Text = "Kurtarma Modu";
            this.eksikdosyaindirButon.UseVisualStyleBackColor = true;
            this.eksikdosyaindirButon.Click += new System.EventHandler(this.eksikdosyaindirButon_Click);
            // 
            // tamamButon
            // 
            this.tamamButon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tamamButon.Location = new System.Drawing.Point(43, 322);
            this.tamamButon.Name = "tamamButon";
            this.tamamButon.Size = new System.Drawing.Size(82, 23);
            this.tamamButon.TabIndex = 1;
            this.tamamButon.Text = "Tamam";
            this.tamamButon.UseVisualStyleBackColor = true;
            this.tamamButon.Click += new System.EventHandler(this.tamamButon_Click);
            // 
            // aciklamaLabel
            // 
            this.aciklamaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aciklamaLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.aciklamaLabel.Location = new System.Drawing.Point(12, 9);
            this.aciklamaLabel.Name = "aciklamaLabel";
            this.aciklamaLabel.Size = new System.Drawing.Size(261, 58);
            this.aciklamaLabel.TabIndex = 2;
            this.aciklamaLabel.Text = resources.GetString("aciklamaLabel.Text");
            // 
            // dosyabilgiTextBox
            // 
            this.dosyabilgiTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dosyabilgiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dosyabilgiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dosyabilgiTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.dosyabilgiTextBox.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyabilgiTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dosyabilgiTextBox.Location = new System.Drawing.Point(12, 133);
            this.dosyabilgiTextBox.Multiline = true;
            this.dosyabilgiTextBox.Name = "dosyabilgiTextBox";
            this.dosyabilgiTextBox.ReadOnly = true;
            this.dosyabilgiTextBox.Size = new System.Drawing.Size(200, 147);
            this.dosyabilgiTextBox.TabIndex = 3;
            this.dosyabilgiTextBox.Text = resources.GetString("dosyabilgiTextBox.Text");
            // 
            // dosyabilgiTextBox2
            // 
            this.dosyabilgiTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dosyabilgiTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dosyabilgiTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dosyabilgiTextBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dosyabilgiTextBox2.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyabilgiTextBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dosyabilgiTextBox2.Location = new System.Drawing.Point(208, 133);
            this.dosyabilgiTextBox2.Multiline = true;
            this.dosyabilgiTextBox2.Name = "dosyabilgiTextBox2";
            this.dosyabilgiTextBox2.ReadOnly = true;
            this.dosyabilgiTextBox2.Size = new System.Drawing.Size(65, 147);
            this.dosyabilgiTextBox2.TabIndex = 4;
            this.dosyabilgiTextBox2.Text = "TAMAM\r\nTAMAM\r\nTAMAM\r\nTAMAM\r\nTAMAM\r\nTAMAM\r\nTAMAM\r\nTAMAM\r\nTAMAM\r\nTAMAM";
            this.dosyabilgiTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fakebaslikTextBox
            // 
            this.fakebaslikTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fakebaslikTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.fakebaslikTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fakebaslikTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.fakebaslikTextBox.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fakebaslikTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fakebaslikTextBox.Location = new System.Drawing.Point(12, 83);
            this.fakebaslikTextBox.Multiline = true;
            this.fakebaslikTextBox.Name = "fakebaslikTextBox";
            this.fakebaslikTextBox.ReadOnly = true;
            this.fakebaslikTextBox.Size = new System.Drawing.Size(261, 80);
            this.fakebaslikTextBox.TabIndex = 5;
            this.fakebaslikTextBox.Text = "============================\r\n#      mCTerminal Bütünlük Testi    #\r\n============" +
    "================";
            this.fakebaslikTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // durumLabel
            // 
            this.durumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.durumLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.durumLabel.Location = new System.Drawing.Point(9, 283);
            this.durumLabel.Name = "durumLabel";
            this.durumLabel.Size = new System.Drawing.Size(264, 13);
            this.durumLabel.TabIndex = 6;
            this.durumLabel.Text = "Dosyalar taranıyor...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // eksikdosyaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(285, 357);
            this.Controls.Add(this.durumLabel);
            this.Controls.Add(this.dosyabilgiTextBox2);
            this.Controls.Add(this.dosyabilgiTextBox);
            this.Controls.Add(this.aciklamaLabel);
            this.Controls.Add(this.tamamButon);
            this.Controls.Add(this.eksikdosyaindirButon);
            this.Controls.Add(this.fakebaslikTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "eksikdosyaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mCTerminal Hata Giderme";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.eksikdosyaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eksikdosyaindirButon;
        private System.Windows.Forms.Button tamamButon;
        private System.Windows.Forms.Label aciklamaLabel;
        private System.Windows.Forms.TextBox dosyabilgiTextBox;
        private System.Windows.Forms.TextBox dosyabilgiTextBox2;
        private System.Windows.Forms.TextBox fakebaslikTextBox;
        private System.Windows.Forms.Label durumLabel;
        private System.Windows.Forms.Timer timer1;
    }
}