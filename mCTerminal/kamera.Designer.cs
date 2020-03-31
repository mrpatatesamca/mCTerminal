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
            this.haritaAracMenu = new System.Windows.Forms.ToolStrip();
            this.videoCaptureComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tamEkranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoCaptureButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.üstteGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoCaptureBox = new System.Windows.Forms.PictureBox();
            this.yuklemePictureBox = new System.Windows.Forms.PictureBox();
            this.haritaAracMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoCaptureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yuklemePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // haritaAracMenu
            // 
            this.haritaAracMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.haritaAracMenu.AutoSize = false;
            this.haritaAracMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.haritaAracMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.haritaAracMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.haritaAracMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.videoCaptureButton,
            this.toolStripDropDownButton1,
            this.videoCaptureComboBox});
            this.haritaAracMenu.Location = new System.Drawing.Point(-1, 0);
            this.haritaAracMenu.Name = "haritaAracMenu";
            this.haritaAracMenu.ShowItemToolTips = false;
            this.haritaAracMenu.Size = new System.Drawing.Size(388, 26);
            this.haritaAracMenu.TabIndex = 1;
            // 
            // videoCaptureComboBox
            // 
            this.videoCaptureComboBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.videoCaptureComboBox.AutoSize = false;
            this.videoCaptureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoCaptureComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.videoCaptureComboBox.Margin = new System.Windows.Forms.Padding(1, 0, 5, 0);
            this.videoCaptureComboBox.Name = "videoCaptureComboBox";
            this.videoCaptureComboBox.Size = new System.Drawing.Size(125, 23);
            // 
            // toolStripDropDownButton2
            // 
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
            this.tamEkranToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tamEkranToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tamEkranToolStripMenuItem.Name = "tamEkranToolStripMenuItem";
            this.tamEkranToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
            this.tamEkranToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tamEkranToolStripMenuItem.Text = "Tam Ekran";
            this.tamEkranToolStripMenuItem.Click += new System.EventHandler(this.tamEkranToolStripMenuItem_Click);
            // 
            // videoCaptureButton
            // 
            this.videoCaptureButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.videoCaptureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.videoCaptureButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.videoCaptureButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.videoCaptureButton.Image = global::mCTerminal.Properties.Resources.play;
            this.videoCaptureButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.videoCaptureButton.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.videoCaptureButton.Name = "videoCaptureButton";
            this.videoCaptureButton.Size = new System.Drawing.Size(23, 23);
            this.videoCaptureButton.Text = "Seçili Aygıtı Yükle";
            this.videoCaptureButton.Click += new System.EventHandler(this.videoCaptureButton_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üstteGösterToolStripMenuItem});
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
            this.üstteGösterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F11)));
            this.üstteGösterToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.üstteGösterToolStripMenuItem.Text = "Üstte Göster";
            this.üstteGösterToolStripMenuItem.Click += new System.EventHandler(this.üstteGösterToolStripMenuItem_Click);
            // 
            // videoCaptureBox
            // 
            this.videoCaptureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoCaptureBox.BackColor = System.Drawing.Color.Transparent;
            this.videoCaptureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.videoCaptureBox.Location = new System.Drawing.Point(1, 26);
            this.videoCaptureBox.Name = "videoCaptureBox";
            this.videoCaptureBox.Size = new System.Drawing.Size(386, 257);
            this.videoCaptureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.videoCaptureBox.TabIndex = 0;
            this.videoCaptureBox.TabStop = false;
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
            // kamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.yuklemePictureBox);
            this.Controls.Add(this.haritaAracMenu);
            this.Controls.Add(this.videoCaptureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 320);
            this.Name = "kamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mCTerminal Uzak Görüntü";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kamera_FormClosing);
            this.Load += new System.EventHandler(this.kamera_Load);
            this.haritaAracMenu.ResumeLayout(false);
            this.haritaAracMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoCaptureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yuklemePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox videoCaptureBox;
        private System.Windows.Forms.ToolStrip haritaAracMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem tamEkranToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton videoCaptureButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem üstteGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox videoCaptureComboBox;
        private System.Windows.Forms.PictureBox yuklemePictureBox;
    }
}