namespace mCTerminal
{
    partial class kamera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kamera));
            this.kameraAracMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tamEkranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoCaptureButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.üstteGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çözünürlükToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x1080ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x720ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x576ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x480ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x480ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.x240ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x120ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoCaptureComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.yuklemePictureBox = new System.Windows.Forms.PictureBox();
            this.videoCaptureBox = new System.Windows.Forms.PictureBox();
            this.kameraAracMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yuklemePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoCaptureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // kameraAracMenu
            // 
            this.kameraAracMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kameraAracMenu.AutoSize = false;
            this.kameraAracMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.kameraAracMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.kameraAracMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.kameraAracMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.videoCaptureButton,
            this.toolStripDropDownButton1,
            this.videoCaptureComboBox});
            this.kameraAracMenu.Location = new System.Drawing.Point(-1, 0);
            this.kameraAracMenu.Name = "kameraAracMenu";
            this.kameraAracMenu.ShowItemToolTips = false;
            this.kameraAracMenu.Size = new System.Drawing.Size(388, 26);
            this.kameraAracMenu.TabIndex = 1;
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tamEkranToolStripMenuItem});
            this.toolStripDropDownButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(71, 23);
            this.toolStripDropDownButton2.Text = "Görünüm";
            // 
            // tamEkranToolStripMenuItem
            // 
            this.tamEkranToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tamEkranToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tamEkranToolStripMenuItem.Image = global::mCTerminal.Properties.Resources.fullscreen;
            this.tamEkranToolStripMenuItem.Name = "tamEkranToolStripMenuItem";
            this.tamEkranToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.tamEkranToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tamEkranToolStripMenuItem.Text = "Tam Ekran";
            this.tamEkranToolStripMenuItem.Click += new System.EventHandler(this.tamEkranToolStripMenuItem_Click);
            // 
            // videoCaptureButton
            // 
            this.videoCaptureButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.videoCaptureButton.AutoToolTip = false;
            this.videoCaptureButton.BackColor = System.Drawing.Color.Transparent;
            this.videoCaptureButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.videoCaptureButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.videoCaptureButton.Image = global::mCTerminal.Properties.Resources.play;
            this.videoCaptureButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.videoCaptureButton.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.videoCaptureButton.Name = "videoCaptureButton";
            this.videoCaptureButton.Size = new System.Drawing.Size(23, 23);
            this.videoCaptureButton.Text = "Seçili aygıtı yükle";
            this.videoCaptureButton.ToolTipText = "Seçili aygıtı yükle";
            this.videoCaptureButton.Click += new System.EventHandler(this.videoCaptureButton_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üstteGösterToolStripMenuItem,
            this.çözünürlükToolStripMenuItem});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(76, 23);
            this.toolStripDropDownButton1.Text = "Seçenekler";
            // 
            // üstteGösterToolStripMenuItem
            // 
            this.üstteGösterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.üstteGösterToolStripMenuItem.Checked = true;
            this.üstteGösterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.üstteGösterToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.üstteGösterToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.üstteGösterToolStripMenuItem.Name = "üstteGösterToolStripMenuItem";
            this.üstteGösterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.üstteGösterToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.üstteGösterToolStripMenuItem.Text = "Üstte Göster";
            this.üstteGösterToolStripMenuItem.Click += new System.EventHandler(this.üstteGösterToolStripMenuItem_Click);
            // 
            // çözünürlükToolStripMenuItem
            // 
            this.çözünürlükToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.çözünürlükToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x1080ToolStripMenuItem,
            this.x720ToolStripMenuItem,
            this.x576ToolStripMenuItem,
            this.x480ToolStripMenuItem,
            this.x480ToolStripMenuItem1,
            this.x240ToolStripMenuItem,
            this.x120ToolStripMenuItem});
            this.çözünürlükToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.çözünürlükToolStripMenuItem.Image = global::mCTerminal.Properties.Resources.resolution;
            this.çözünürlükToolStripMenuItem.Name = "çözünürlükToolStripMenuItem";
            this.çözünürlükToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.çözünürlükToolStripMenuItem.Text = "Çözünürlük";
            // 
            // x1080ToolStripMenuItem
            // 
            this.x1080ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.x1080ToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.x1080ToolStripMenuItem.Name = "x1080ToolStripMenuItem";
            this.x1080ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.x1080ToolStripMenuItem.Text = "1920x1080";
            // 
            // x720ToolStripMenuItem
            // 
            this.x720ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.x720ToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.x720ToolStripMenuItem.Name = "x720ToolStripMenuItem";
            this.x720ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.x720ToolStripMenuItem.Text = "1280x720";
            // 
            // x576ToolStripMenuItem
            // 
            this.x576ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.x576ToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.x576ToolStripMenuItem.Name = "x576ToolStripMenuItem";
            this.x576ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.x576ToolStripMenuItem.Text = "720x576";
            this.x576ToolStripMenuItem.Click += new System.EventHandler(this.x576ToolStripMenuItem_Click);
            // 
            // x480ToolStripMenuItem
            // 
            this.x480ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.x480ToolStripMenuItem.Checked = true;
            this.x480ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.x480ToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.x480ToolStripMenuItem.Name = "x480ToolStripMenuItem";
            this.x480ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.x480ToolStripMenuItem.Text = "720x480";
            this.x480ToolStripMenuItem.Click += new System.EventHandler(this.x480ToolStripMenuItem_Click);
            // 
            // x480ToolStripMenuItem1
            // 
            this.x480ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.x480ToolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.x480ToolStripMenuItem1.Name = "x480ToolStripMenuItem1";
            this.x480ToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.x480ToolStripMenuItem1.Text = "640x480";
            this.x480ToolStripMenuItem1.Click += new System.EventHandler(this.x480ToolStripMenuItem1_Click);
            // 
            // x240ToolStripMenuItem
            // 
            this.x240ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.x240ToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.x240ToolStripMenuItem.Name = "x240ToolStripMenuItem";
            this.x240ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.x240ToolStripMenuItem.Text = "320x240";
            this.x240ToolStripMenuItem.Click += new System.EventHandler(this.x240ToolStripMenuItem_Click);
            // 
            // x120ToolStripMenuItem
            // 
            this.x120ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.x120ToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.x120ToolStripMenuItem.Name = "x120ToolStripMenuItem";
            this.x120ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.x120ToolStripMenuItem.Text = "160x120";
            this.x120ToolStripMenuItem.Click += new System.EventHandler(this.x120ToolStripMenuItem_Click);
            // 
            // videoCaptureComboBox
            // 
            this.videoCaptureComboBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.videoCaptureComboBox.AutoSize = false;
            this.videoCaptureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoCaptureComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.videoCaptureComboBox.Margin = new System.Windows.Forms.Padding(1, 0, 5, 0);
            this.videoCaptureComboBox.MaxDropDownItems = 30;
            this.videoCaptureComboBox.Name = "videoCaptureComboBox";
            this.videoCaptureComboBox.Size = new System.Drawing.Size(115, 23);
            // 
            // yuklemePictureBox
            // 
            this.yuklemePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yuklemePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.yuklemePictureBox.Image = global::mCTerminal.Properties.Resources.circle_loading2D;
            this.yuklemePictureBox.Location = new System.Drawing.Point(178, 126);
            this.yuklemePictureBox.Name = "yuklemePictureBox";
            this.yuklemePictureBox.Size = new System.Drawing.Size(28, 28);
            this.yuklemePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yuklemePictureBox.TabIndex = 2;
            this.yuklemePictureBox.TabStop = false;
            this.yuklemePictureBox.Visible = false;
            // 
            // videoCaptureBox
            // 
            this.videoCaptureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoCaptureBox.BackColor = System.Drawing.Color.Transparent;
            this.videoCaptureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.videoCaptureBox.Location = new System.Drawing.Point(-1, 26);
            this.videoCaptureBox.Name = "videoCaptureBox";
            this.videoCaptureBox.Size = new System.Drawing.Size(387, 255);
            this.videoCaptureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.videoCaptureBox.TabIndex = 0;
            this.videoCaptureBox.TabStop = false;
            // 
            // kamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.yuklemePictureBox);
            this.Controls.Add(this.kameraAracMenu);
            this.Controls.Add(this.videoCaptureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(335, 320);
            this.Name = "kamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mCTerminal Uzak Görüntü | (DIRECTSHOW_AYGIT)";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kamera_FormClosing);
            this.Load += new System.EventHandler(this.kamera_Load);
            this.kameraAracMenu.ResumeLayout(false);
            this.kameraAracMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yuklemePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoCaptureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox videoCaptureBox;
        private System.Windows.Forms.ToolStrip kameraAracMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem tamEkranToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton videoCaptureButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem üstteGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox videoCaptureComboBox;
        private System.Windows.Forms.PictureBox yuklemePictureBox;
        private System.Windows.Forms.ToolStripMenuItem çözünürlükToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x1080ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x720ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x576ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x480ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x480ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x240ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x120ToolStripMenuItem;
    }
}