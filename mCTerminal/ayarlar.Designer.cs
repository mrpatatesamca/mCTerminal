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
            this.cokGizliCheckBox = new System.Windows.Forms.CheckBox();
            this.kaydetButton = new System.Windows.Forms.Button();
            this.iptalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cokGizliCheckBox
            // 
            this.cokGizliCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cokGizliCheckBox.AutoSize = true;
            this.cokGizliCheckBox.Location = new System.Drawing.Point(124, 120);
            this.cokGizliCheckBox.Name = "cokGizliCheckBox";
            this.cokGizliCheckBox.Size = new System.Drawing.Size(111, 17);
            this.cokGizliCheckBox.TabIndex = 0;
            this.cokGizliCheckBox.Text = "Beni Anında Öldür";
            this.cokGizliCheckBox.UseVisualStyleBackColor = true;
            // 
            // kaydetButton
            // 
            this.kaydetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kaydetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kaydetButton.Location = new System.Drawing.Point(264, 222);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(83, 23);
            this.kaydetButton.TabIndex = 1;
            this.kaydetButton.Text = "Kaydet ve Çık";
            this.kaydetButton.UseVisualStyleBackColor = true;
            // 
            // iptalButton
            // 
            this.iptalButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iptalButton.Location = new System.Drawing.Point(183, 222);
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(75, 23);
            this.iptalButton.TabIndex = 2;
            this.iptalButton.Text = "İptal";
            this.iptalButton.UseVisualStyleBackColor = true;
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(359, 257);
            this.Controls.Add(this.iptalButton);
            this.Controls.Add(this.kaydetButton);
            this.Controls.Add(this.cokGizliCheckBox);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ayarlar";
            this.Text = "MCTerminal Ayarları";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cokGizliCheckBox;
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.Button iptalButton;
    }
}