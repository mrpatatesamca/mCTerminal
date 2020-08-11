namespace mCTerminal
{
    partial class harita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(harita));
            this.haritaAracMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tamEkranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitButon = new System.Windows.Forms.ToolStripButton();
            this.ekranGoruntusuCekButton = new System.Windows.Forms.ToolStripButton();
            this.boylamTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.enlemTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.üstteGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haritaSağlayıcısıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleHaritalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uyduHaritasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şehirHaritasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araziHaritasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bingHaritaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wikiMapiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harita1 = new GMap.NET.WindowsForms.GMapControl();
            this.haritaRoketEsle = new System.Windows.Forms.Timer(this.components);
            this.haritaortala_checkbox = new System.Windows.Forms.CheckBox();
            this.haritaAracMenu.SuspendLayout();
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
            this.gitButon,
            this.ekranGoruntusuCekButton,
            this.boylamTextBox,
            this.enlemTextBox,
            this.toolStripDropDownButton1});
            this.haritaAracMenu.Location = new System.Drawing.Point(0, 0);
            this.haritaAracMenu.Name = "haritaAracMenu";
            this.haritaAracMenu.ShowItemToolTips = false;
            this.haritaAracMenu.Size = new System.Drawing.Size(523, 25);
            this.haritaAracMenu.TabIndex = 0;
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
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(71, 22);
            this.toolStripDropDownButton2.Text = "Görünüm";
            // 
            // tamEkranToolStripMenuItem
            // 
            this.tamEkranToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tamEkranToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tamEkranToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tamEkranToolStripMenuItem.Image = global::mCTerminal.Properties.Resources.fullscreen;
            this.tamEkranToolStripMenuItem.Name = "tamEkranToolStripMenuItem";
            this.tamEkranToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.tamEkranToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.tamEkranToolStripMenuItem.Text = "Tam Ekran";
            this.tamEkranToolStripMenuItem.Click += new System.EventHandler(this.tamEkranToolStripMenuItem_Click);
            // 
            // gitButon
            // 
            this.gitButon.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.gitButon.AutoToolTip = false;
            this.gitButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gitButon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gitButon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gitButon.Image = global::mCTerminal.Properties.Resources.pin;
            this.gitButon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gitButon.Margin = new System.Windows.Forms.Padding(1, 0, 2, 0);
            this.gitButon.Name = "gitButon";
            this.gitButon.Size = new System.Drawing.Size(23, 25);
            this.gitButon.Text = "Git";
            this.gitButon.ToolTipText = "Yazılan koordinatlara git";
            this.gitButon.Click += new System.EventHandler(this.gitButon_Click);
            // 
            // ekranGoruntusuCekButton
            // 
            this.ekranGoruntusuCekButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ekranGoruntusuCekButton.AutoToolTip = false;
            this.ekranGoruntusuCekButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ekranGoruntusuCekButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ekranGoruntusuCekButton.Image = global::mCTerminal.Properties.Resources.screenshot;
            this.ekranGoruntusuCekButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ekranGoruntusuCekButton.Name = "ekranGoruntusuCekButton";
            this.ekranGoruntusuCekButton.Size = new System.Drawing.Size(23, 22);
            this.ekranGoruntusuCekButton.Text = "toolStripButton1";
            this.ekranGoruntusuCekButton.ToolTipText = "Haritanın görüntüsünü kaydet";
            this.ekranGoruntusuCekButton.Click += new System.EventHandler(this.ekranGoruntusuCekButton_Click);
            // 
            // boylamTextBox
            // 
            this.boylamTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.boylamTextBox.AutoSize = false;
            this.boylamTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.boylamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boylamTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boylamTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.boylamTextBox.Name = "boylamTextBox";
            this.boylamTextBox.Size = new System.Drawing.Size(110, 23);
            this.boylamTextBox.Text = "34.56789";
            // 
            // enlemTextBox
            // 
            this.enlemTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.enlemTextBox.AutoSize = false;
            this.enlemTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.enlemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enlemTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.enlemTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.enlemTextBox.Name = "enlemTextBox";
            this.enlemTextBox.Size = new System.Drawing.Size(110, 23);
            this.enlemTextBox.Text = "45.67890";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üstteGösterToolStripMenuItem,
            this.haritaSağlayıcısıToolStripMenuItem});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(76, 22);
            this.toolStripDropDownButton1.Text = "Seçenekler";
            // 
            // üstteGösterToolStripMenuItem
            // 
            this.üstteGösterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.üstteGösterToolStripMenuItem.Checked = true;
            this.üstteGösterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.üstteGösterToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.üstteGösterToolStripMenuItem.Image = global::mCTerminal.Properties.Resources.eye;
            this.üstteGösterToolStripMenuItem.Name = "üstteGösterToolStripMenuItem";
            this.üstteGösterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.üstteGösterToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.üstteGösterToolStripMenuItem.Text = "Üstte Göster";
            this.üstteGösterToolStripMenuItem.Click += new System.EventHandler(this.üstteGösterToolStripMenuItem_Click);
            // 
            // haritaSağlayıcısıToolStripMenuItem
            // 
            this.haritaSağlayıcısıToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.haritaSağlayıcısıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleHaritalarToolStripMenuItem,
            this.bingHaritaToolStripMenuItem,
            this.wikiMapiaToolStripMenuItem});
            this.haritaSağlayıcısıToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.haritaSağlayıcısıToolStripMenuItem.Image = global::mCTerminal.Properties.Resources.provider;
            this.haritaSağlayıcısıToolStripMenuItem.Name = "haritaSağlayıcısıToolStripMenuItem";
            this.haritaSağlayıcısıToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.haritaSağlayıcısıToolStripMenuItem.Text = "Harita Sağlayıcısı";
            // 
            // googleHaritalarToolStripMenuItem
            // 
            this.googleHaritalarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.googleHaritalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uyduHaritasıToolStripMenuItem,
            this.şehirHaritasıToolStripMenuItem,
            this.araziHaritasıToolStripMenuItem});
            this.googleHaritalarToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.googleHaritalarToolStripMenuItem.Name = "googleHaritalarToolStripMenuItem";
            this.googleHaritalarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.googleHaritalarToolStripMenuItem.Text = "Google Haritalar";
            // 
            // uyduHaritasıToolStripMenuItem
            // 
            this.uyduHaritasıToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.uyduHaritasıToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uyduHaritasıToolStripMenuItem.Name = "uyduHaritasıToolStripMenuItem";
            this.uyduHaritasıToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.uyduHaritasıToolStripMenuItem.Text = "Uydu Haritası";
            this.uyduHaritasıToolStripMenuItem.Click += new System.EventHandler(this.uyduHaritasıToolStripMenuItem_Click);
            // 
            // şehirHaritasıToolStripMenuItem
            // 
            this.şehirHaritasıToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.şehirHaritasıToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.şehirHaritasıToolStripMenuItem.Name = "şehirHaritasıToolStripMenuItem";
            this.şehirHaritasıToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.şehirHaritasıToolStripMenuItem.Text = "Şehir Haritası";
            this.şehirHaritasıToolStripMenuItem.Click += new System.EventHandler(this.şehirHaritasıToolStripMenuItem_Click);
            // 
            // araziHaritasıToolStripMenuItem
            // 
            this.araziHaritasıToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.araziHaritasıToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.araziHaritasıToolStripMenuItem.Name = "araziHaritasıToolStripMenuItem";
            this.araziHaritasıToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.araziHaritasıToolStripMenuItem.Text = "Arazi Haritası";
            this.araziHaritasıToolStripMenuItem.Click += new System.EventHandler(this.araziHaritasıToolStripMenuItem_Click);
            // 
            // bingHaritaToolStripMenuItem
            // 
            this.bingHaritaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bingHaritaToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bingHaritaToolStripMenuItem.Name = "bingHaritaToolStripMenuItem";
            this.bingHaritaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.bingHaritaToolStripMenuItem.Text = "Bing Haritalar";
            this.bingHaritaToolStripMenuItem.Click += new System.EventHandler(this.bingHaritaToolStripMenuItem_Click);
            // 
            // wikiMapiaToolStripMenuItem
            // 
            this.wikiMapiaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.wikiMapiaToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.wikiMapiaToolStripMenuItem.Name = "wikiMapiaToolStripMenuItem";
            this.wikiMapiaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.wikiMapiaToolStripMenuItem.Text = "Wiki Mapia ";
            this.wikiMapiaToolStripMenuItem.Click += new System.EventHandler(this.wikiMapiaToolStripMenuItem_Click);
            // 
            // harita1
            // 
            this.harita1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.harita1.Bearing = 0F;
            this.harita1.CanDragMap = true;
            this.harita1.EmptyTileColor = System.Drawing.Color.Indigo;
            this.harita1.GrayScaleMode = false;
            this.harita1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.harita1.LevelsKeepInMemmory = 5;
            this.harita1.Location = new System.Drawing.Point(0, 25);
            this.harita1.MarkersEnabled = true;
            this.harita1.MaxZoom = 22;
            this.harita1.MinZoom = 4;
            this.harita1.MouseWheelZoomEnabled = true;
            this.harita1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.harita1.Name = "harita1";
            this.harita1.NegativeMode = false;
            this.harita1.PolygonsEnabled = true;
            this.harita1.RetryLoadTile = 0;
            this.harita1.RoutesEnabled = true;
            this.harita1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.harita1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.harita1.ShowTileGridLines = false;
            this.harita1.Size = new System.Drawing.Size(522, 345);
            this.harita1.TabIndex = 1;
            this.harita1.Zoom = 0D;
            this.harita1.OnPositionChanged += new GMap.NET.PositionChanged(this.harita1_OnPositionChanged);
            this.harita1.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.harita1_OnMapZoomChanged);
            // 
            // haritaRoketEsle
            // 
            this.haritaRoketEsle.Enabled = true;
            this.haritaRoketEsle.Interval = 1000;
            this.haritaRoketEsle.Tick += new System.EventHandler(this.haritaRoketEsle_Tick);
            // 
            // haritaortala_checkbox
            // 
            this.haritaortala_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.haritaortala_checkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.haritaortala_checkbox.Checked = true;
            this.haritaortala_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.haritaortala_checkbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.haritaortala_checkbox.Location = new System.Drawing.Point(155, 0);
            this.haritaortala_checkbox.Name = "haritaortala_checkbox";
            this.haritaortala_checkbox.Size = new System.Drawing.Size(93, 24);
            this.haritaortala_checkbox.TabIndex = 2;
            this.haritaortala_checkbox.Text = "Haritayı Ortala";
            this.haritaortala_checkbox.UseVisualStyleBackColor = false;
            // 
            // harita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(521, 369);
            this.Controls.Add(this.harita1);
            this.Controls.Add(this.haritaortala_checkbox);
            this.Controls.Add(this.haritaAracMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(537, 408);
            this.Name = "harita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mCTerminal Harita";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.harita_FormClosing);
            this.Load += new System.EventHandler(this.harita_Load);
            this.haritaAracMenu.ResumeLayout(false);
            this.haritaAracMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip haritaAracMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripTextBox boylamTextBox;
        private System.Windows.Forms.ToolStripTextBox enlemTextBox;
        private System.Windows.Forms.ToolStripButton gitButon;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem üstteGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamEkranToolStripMenuItem;
        private GMap.NET.WindowsForms.GMapControl harita1;
        private System.Windows.Forms.ToolStripMenuItem haritaSağlayıcısıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleHaritalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bingHaritaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wikiMapiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uyduHaritasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şehirHaritasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araziHaritasıToolStripMenuItem;
        private System.Windows.Forms.Timer haritaRoketEsle;
        private System.Windows.Forms.CheckBox haritaortala_checkbox;
        private System.Windows.Forms.ToolStripButton ekranGoruntusuCekButton;
    }
}