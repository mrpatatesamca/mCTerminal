namespace mCTerminal
{
    partial class hakkinda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hakkinda));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cosmosLogoTextPictureBox = new System.Windows.Forms.PictureBox();
            this.windowsXPPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cosmosLogoTextPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsXPPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(2, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 174);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "GitHub: @mrpatatesamca";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cosmosLogoTextPictureBox
            // 
            this.cosmosLogoTextPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.cosmosLogoTextPictureBox.Image = global::mCTerminal.Properties.Resources.COSMOSLogoTextGif;
            this.cosmosLogoTextPictureBox.Location = new System.Drawing.Point(12, 12);
            this.cosmosLogoTextPictureBox.Name = "cosmosLogoTextPictureBox";
            this.cosmosLogoTextPictureBox.Size = new System.Drawing.Size(256, 104);
            this.cosmosLogoTextPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cosmosLogoTextPictureBox.TabIndex = 3;
            this.cosmosLogoTextPictureBox.TabStop = false;
            // 
            // windowsXPPictureBox
            // 
            this.windowsXPPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.windowsXPPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.windowsXPPictureBox.Image = global::mCTerminal.Properties.Resources.windows_xp3D;
            this.windowsXPPictureBox.Location = new System.Drawing.Point(120, 101);
            this.windowsXPPictureBox.Name = "windowsXPPictureBox";
            this.windowsXPPictureBox.Size = new System.Drawing.Size(40, 40);
            this.windowsXPPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.windowsXPPictureBox.TabIndex = 4;
            this.windowsXPPictureBox.TabStop = false;
            // 
            // hakkinda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::mCTerminal.Properties.Resources.wallpaper1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(280, 344);
            this.Controls.Add(this.windowsXPPictureBox);
            this.Controls.Add(this.cosmosLogoTextPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "hakkinda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mCTerminal Hakkında";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.cosmosLogoTextPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsXPPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox cosmosLogoTextPictureBox;
        private System.Windows.Forms.PictureBox windowsXPPictureBox;
    }
}