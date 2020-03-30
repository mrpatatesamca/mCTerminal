namespace mCTerminal
{
    partial class anaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaEkran));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.bağlantıyıBaşlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hataGidermeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.haritayıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uzakGörüntüyüGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hamVeriyiGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamEkranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.destekSayfasınaGitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleştirmeleriKontrolEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.COMPortList = new System.Windows.Forms.ToolStripComboBox();
            this.baudRatePortList = new System.Windows.Forms.ToolStripComboBox();
            this.hamVeriTextBox1 = new System.Windows.Forms.TextBox();
            this.baglantiNoktasi_label = new System.Windows.Forms.Label();
            this.baglantiHizi_label = new System.Windows.Forms.Label();
            this.aliciModeli_label = new System.Windows.Forms.Label();
            this.baglantiGrup = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sinyalGucuLabel = new System.Windows.Forms.Label();
            this.uyduSayiLabel = new System.Windows.Forms.Label();
            this.snrSeviyesiLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.voltajLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gkuvvetLabel = new System.Windows.Forms.Label();
            this.irtifaLabel = new System.Windows.Forms.Label();
            this.irtifaBaroLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.enlemLabel = new System.Windows.Forms.Label();
            this.yatayHizLabel = new System.Windows.Forms.Label();
            this.boylamLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.voltajGrafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1.SuspendLayout();
            this.baglantiGrup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voltajGrafik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton3,
            this.COMPortList,
            this.baudRatePortList});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(565, 26);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bağlantıyıBaşlatToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(52, 23);
            this.toolStripDropDownButton2.Text = "Dosya";
            // 
            // bağlantıyıBaşlatToolStripMenuItem
            // 
            this.bağlantıyıBaşlatToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bağlantıyıBaşlatToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bağlantıyıBaşlatToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bağlantıyıBaşlatToolStripMenuItem.Name = "bağlantıyıBaşlatToolStripMenuItem";
            this.bağlantıyıBaşlatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.bağlantıyıBaşlatToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.bağlantıyıBaşlatToolStripMenuItem.Text = "Bağlantıyı Başlat";
            this.bağlantıyıBaşlatToolStripMenuItem.Click += new System.EventHandler(this.bağlantıyıBaşlatToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItem1.Text = "Kaydet";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItem2.Text = "Yenile";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStripMenuItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItem3.Text = "Çık";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem,
            this.hataGidermeToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(57, 23);
            this.toolStripDropDownButton1.Text = "Araçlar";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ayarlarToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ayarlarToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // hataGidermeToolStripMenuItem
            // 
            this.hataGidermeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.hataGidermeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.hataGidermeToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hataGidermeToolStripMenuItem.Name = "hataGidermeToolStripMenuItem";
            this.hataGidermeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F2)));
            this.hataGidermeToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.hataGidermeToolStripMenuItem.Text = "Hata Giderme";
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.haritayıGösterToolStripMenuItem,
            this.uzakGörüntüyüGösterToolStripMenuItem,
            this.hamVeriyiGösterToolStripMenuItem,
            this.tamEkranToolStripMenuItem});
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(62, 23);
            this.toolStripDropDownButton4.Text = "Pencere";
            // 
            // haritayıGösterToolStripMenuItem
            // 
            this.haritayıGösterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.haritayıGösterToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.haritayıGösterToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.haritayıGösterToolStripMenuItem.Name = "haritayıGösterToolStripMenuItem";
            this.haritayıGösterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.haritayıGösterToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.haritayıGösterToolStripMenuItem.Text = "Haritayı Göster";
            this.haritayıGösterToolStripMenuItem.Click += new System.EventHandler(this.haritayıGösterToolStripMenuItem_Click);
            // 
            // uzakGörüntüyüGösterToolStripMenuItem
            // 
            this.uzakGörüntüyüGösterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.uzakGörüntüyüGösterToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uzakGörüntüyüGösterToolStripMenuItem.Name = "uzakGörüntüyüGösterToolStripMenuItem";
            this.uzakGörüntüyüGösterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.uzakGörüntüyüGösterToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.uzakGörüntüyüGösterToolStripMenuItem.Text = "Uzak Görüntüyü Göster";
            // 
            // hamVeriyiGösterToolStripMenuItem
            // 
            this.hamVeriyiGösterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.hamVeriyiGösterToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hamVeriyiGösterToolStripMenuItem.Name = "hamVeriyiGösterToolStripMenuItem";
            this.hamVeriyiGösterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hamVeriyiGösterToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.hamVeriyiGösterToolStripMenuItem.Text = "Ham Veriyi Göster";
            this.hamVeriyiGösterToolStripMenuItem.Click += new System.EventHandler(this.hamVeriyiGösterToolStripMenuItem_Click);
            // 
            // tamEkranToolStripMenuItem
            // 
            this.tamEkranToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tamEkranToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tamEkranToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tamEkranToolStripMenuItem.Name = "tamEkranToolStripMenuItem";
            this.tamEkranToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
            this.tamEkranToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.tamEkranToolStripMenuItem.Text = "Tam Ekran";
            this.tamEkranToolStripMenuItem.Click += new System.EventHandler(this.tamEkranToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.destekSayfasınaGitToolStripMenuItem,
            this.güncelleştirmeleriKontrolEtToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(57, 23);
            this.toolStripDropDownButton3.Text = "Yardım";
            // 
            // destekSayfasınaGitToolStripMenuItem
            // 
            this.destekSayfasınaGitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.destekSayfasınaGitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.destekSayfasınaGitToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.destekSayfasınaGitToolStripMenuItem.Name = "destekSayfasınaGitToolStripMenuItem";
            this.destekSayfasınaGitToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.destekSayfasınaGitToolStripMenuItem.Text = "Destek Sayfasına Git";
            // 
            // güncelleştirmeleriKontrolEtToolStripMenuItem
            // 
            this.güncelleştirmeleriKontrolEtToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.güncelleştirmeleriKontrolEtToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.güncelleştirmeleriKontrolEtToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.güncelleştirmeleriKontrolEtToolStripMenuItem.Name = "güncelleştirmeleriKontrolEtToolStripMenuItem";
            this.güncelleştirmeleriKontrolEtToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.güncelleştirmeleriKontrolEtToolStripMenuItem.Text = "Güncelleştirmeleri Kontrol Et";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.hakkındaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.hakkındaToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // COMPortList
            // 
            this.COMPortList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.COMPortList.AutoSize = false;
            this.COMPortList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.COMPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMPortList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.COMPortList.Margin = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.COMPortList.Name = "COMPortList";
            this.COMPortList.Size = new System.Drawing.Size(75, 23);
            // 
            // baudRatePortList
            // 
            this.baudRatePortList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.baudRatePortList.AutoSize = false;
            this.baudRatePortList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.baudRatePortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRatePortList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.baudRatePortList.Name = "baudRatePortList";
            this.baudRatePortList.Size = new System.Drawing.Size(90, 23);
            // 
            // hamVeriTextBox1
            // 
            this.hamVeriTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hamVeriTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hamVeriTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hamVeriTextBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hamVeriTextBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hamVeriTextBox1.Location = new System.Drawing.Point(1, 271);
            this.hamVeriTextBox1.Multiline = true;
            this.hamVeriTextBox1.Name = "hamVeriTextBox1";
            this.hamVeriTextBox1.ReadOnly = true;
            this.hamVeriTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hamVeriTextBox1.Size = new System.Drawing.Size(564, 90);
            this.hamVeriTextBox1.TabIndex = 5;
            this.hamVeriTextBox1.Text = resources.GetString("hamVeriTextBox1.Text");
            // 
            // baglantiNoktasi_label
            // 
            this.baglantiNoktasi_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baglantiNoktasi_label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baglantiNoktasi_label.Location = new System.Drawing.Point(6, 15);
            this.baglantiNoktasi_label.Name = "baglantiNoktasi_label";
            this.baglantiNoktasi_label.Size = new System.Drawing.Size(250, 14);
            this.baglantiNoktasi_label.TabIndex = 6;
            this.baglantiNoktasi_label.Text = "Bağlantı Noktası: COMXX";
            this.baglantiNoktasi_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baglantiHizi_label
            // 
            this.baglantiHizi_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baglantiHizi_label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baglantiHizi_label.Location = new System.Drawing.Point(6, 31);
            this.baglantiHizi_label.Name = "baglantiHizi_label";
            this.baglantiHizi_label.Size = new System.Drawing.Size(250, 14);
            this.baglantiHizi_label.TabIndex = 7;
            this.baglantiHizi_label.Text = "Bağlantı Hızı: 9600";
            this.baglantiHizi_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aliciModeli_label
            // 
            this.aliciModeli_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aliciModeli_label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aliciModeli_label.Location = new System.Drawing.Point(6, 46);
            this.aliciModeli_label.Name = "aliciModeli_label";
            this.aliciModeli_label.Size = new System.Drawing.Size(250, 14);
            this.aliciModeli_label.TabIndex = 8;
            this.aliciModeli_label.Text = "Alıcı Modeli: ORIONID";
            this.aliciModeli_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baglantiGrup
            // 
            this.baglantiGrup.Controls.Add(this.baglantiNoktasi_label);
            this.baglantiGrup.Controls.Add(this.aliciModeli_label);
            this.baglantiGrup.Controls.Add(this.baglantiHizi_label);
            this.baglantiGrup.Location = new System.Drawing.Point(12, 29);
            this.baglantiGrup.Name = "baglantiGrup";
            this.baglantiGrup.Size = new System.Drawing.Size(262, 70);
            this.baglantiGrup.TabIndex = 9;
            this.baglantiGrup.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.sinyalGucuLabel);
            this.groupBox1.Controls.Add(this.uyduSayiLabel);
            this.groupBox1.Controls.Add(this.snrSeviyesiLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 70);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::mCTerminal.Properties.Resources.uydu;
            this.pictureBox3.Location = new System.Drawing.Point(228, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::mCTerminal.Properties.Resources.snr_seviye;
            this.pictureBox2.Location = new System.Drawing.Point(228, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mCTerminal.Properties.Resources.wifi_icon;
            this.pictureBox1.Location = new System.Drawing.Point(228, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // sinyalGucuLabel
            // 
            this.sinyalGucuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sinyalGucuLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinyalGucuLabel.Location = new System.Drawing.Point(6, 15);
            this.sinyalGucuLabel.Name = "sinyalGucuLabel";
            this.sinyalGucuLabel.Size = new System.Drawing.Size(238, 14);
            this.sinyalGucuLabel.TabIndex = 6;
            this.sinyalGucuLabel.Text = "Sinyal Gücü: -200.99dB";
            this.sinyalGucuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uyduSayiLabel
            // 
            this.uyduSayiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uyduSayiLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyduSayiLabel.Location = new System.Drawing.Point(6, 45);
            this.uyduSayiLabel.Name = "uyduSayiLabel";
            this.uyduSayiLabel.Size = new System.Drawing.Size(238, 14);
            this.uyduSayiLabel.TabIndex = 8;
            this.uyduSayiLabel.Text = "Bağlanılan Uydu: 20";
            this.uyduSayiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // snrSeviyesiLabel
            // 
            this.snrSeviyesiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.snrSeviyesiLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.snrSeviyesiLabel.Location = new System.Drawing.Point(6, 30);
            this.snrSeviyesiLabel.Name = "snrSeviyesiLabel";
            this.snrSeviyesiLabel.Size = new System.Drawing.Size(238, 14);
            this.snrSeviyesiLabel.TabIndex = 7;
            this.snrSeviyesiLabel.Text = "SNR Seviyesi: -15.99dB";
            this.snrSeviyesiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.voltajLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 84);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::mCTerminal.Properties.Resources.guc_durum;
            this.pictureBox4.Location = new System.Drawing.Point(228, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "Batarya Kapasitesi: 2500mAh";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // voltajLabel
            // 
            this.voltajLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voltajLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.voltajLabel.Location = new System.Drawing.Point(6, 15);
            this.voltajLabel.Name = "voltajLabel";
            this.voltajLabel.Size = new System.Drawing.Size(206, 14);
            this.voltajLabel.TabIndex = 6;
            this.voltajLabel.Text = "Voltaj: 15.99v";
            this.voltajLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Şarj: %100";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "Akım: 2.99A";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gkuvvetLabel);
            this.groupBox3.Controls.Add(this.irtifaLabel);
            this.groupBox3.Controls.Add(this.irtifaBaroLabel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.enlemLabel);
            this.groupBox3.Controls.Add(this.yatayHizLabel);
            this.groupBox3.Controls.Add(this.boylamLabel);
            this.groupBox3.Location = new System.Drawing.Point(280, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 125);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // gkuvvetLabel
            // 
            this.gkuvvetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gkuvvetLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gkuvvetLabel.Location = new System.Drawing.Point(6, 43);
            this.gkuvvetLabel.Name = "gkuvvetLabel";
            this.gkuvvetLabel.Size = new System.Drawing.Size(260, 14);
            this.gkuvvetLabel.TabIndex = 12;
            this.gkuvvetLabel.Text = "G Kuvveti: 6g";
            this.gkuvvetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // irtifaLabel
            // 
            this.irtifaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.irtifaLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.irtifaLabel.Location = new System.Drawing.Point(6, 58);
            this.irtifaLabel.Name = "irtifaLabel";
            this.irtifaLabel.Size = new System.Drawing.Size(260, 14);
            this.irtifaLabel.TabIndex = 11;
            this.irtifaLabel.Text = "İrtifa: 3000m";
            this.irtifaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // irtifaBaroLabel
            // 
            this.irtifaBaroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.irtifaBaroLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.irtifaBaroLabel.Location = new System.Drawing.Point(6, 72);
            this.irtifaBaroLabel.Name = "irtifaBaroLabel";
            this.irtifaBaroLabel.Size = new System.Drawing.Size(260, 14);
            this.irtifaBaroLabel.TabIndex = 10;
            this.irtifaBaroLabel.Text = "İrtifa (Barometrik): 3200m";
            this.irtifaBaroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "Dikey Hız: 200m/h";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // enlemLabel
            // 
            this.enlemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enlemLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enlemLabel.Location = new System.Drawing.Point(6, 15);
            this.enlemLabel.Name = "enlemLabel";
            this.enlemLabel.Size = new System.Drawing.Size(260, 14);
            this.enlemLabel.TabIndex = 6;
            this.enlemLabel.Text = "Enlem: 45.67890";
            this.enlemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yatayHizLabel
            // 
            this.yatayHizLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yatayHizLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yatayHizLabel.Location = new System.Drawing.Point(6, 86);
            this.yatayHizLabel.Name = "yatayHizLabel";
            this.yatayHizLabel.Size = new System.Drawing.Size(260, 14);
            this.yatayHizLabel.TabIndex = 8;
            this.yatayHizLabel.Text = "Yatay Hız: 15m/h";
            this.yatayHizLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // boylamLabel
            // 
            this.boylamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boylamLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boylamLabel.Location = new System.Drawing.Point(6, 29);
            this.boylamLabel.Name = "boylamLabel";
            this.boylamLabel.Size = new System.Drawing.Size(260, 14);
            this.boylamLabel.TabIndex = 7;
            this.boylamLabel.Text = "Boylam: 34.56789";
            this.boylamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Location = new System.Drawing.Point(268, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 84);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(6, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(272, 14);
            this.label15.TabIndex = 9;
            this.label15.Text = "Yedek Aviyonik Sistem: Devre Dışı!";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(6, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(272, 14);
            this.label16.TabIndex = 6;
            this.label16.Text = "Koni: Ayrılmadı";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(6, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(272, 14);
            this.label17.TabIndex = 8;
            this.label17.Text = "Video Yayını: Aktif";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(6, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(272, 14);
            this.label18.TabIndex = 7;
            this.label18.Text = "Orta Gövde: Ayrılmadı";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // voltajGrafik
            // 
            this.voltajGrafik.BackColor = System.Drawing.Color.Transparent;
            this.voltajGrafik.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            this.voltajGrafik.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.voltajGrafik.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.voltajGrafik.Legends.Add(legend1);
            this.voltajGrafik.Location = new System.Drawing.Point(564, 35);
            this.voltajGrafik.Name = "voltajGrafik";
            this.voltajGrafik.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.voltajGrafik.Series.Add(series1);
            this.voltajGrafik.Size = new System.Drawing.Size(200, 200);
            this.voltajGrafik.TabIndex = 10;
            this.voltajGrafik.Text = "voltajGrafik";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(770, 35);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series2.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(200, 200);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // anaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.voltajGrafik);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.baglantiGrup);
            this.Controls.Add(this.hamVeriTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(580, 400);
            this.Name = "anaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mCTerminal v0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.anaEkran_FormClosing);
            this.Load += new System.EventHandler(this.anaEkran_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.baglantiGrup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.voltajGrafik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox COMPortList;
        private System.Windows.Forms.ToolStripComboBox baudRatePortList;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hataGidermeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destekSayfasınaGitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleştirmeleriKontrolEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem bağlantıyıBaşlatToolStripMenuItem;
        private System.Windows.Forms.TextBox hamVeriTextBox1;
        private System.Windows.Forms.Label baglantiNoktasi_label;
        private System.Windows.Forms.Label baglantiHizi_label;
        private System.Windows.Forms.Label aliciModeli_label;
        private System.Windows.Forms.GroupBox baglantiGrup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sinyalGucuLabel;
        private System.Windows.Forms.Label uyduSayiLabel;
        private System.Windows.Forms.Label snrSeviyesiLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label voltajLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label irtifaBaroLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label enlemLabel;
        private System.Windows.Forms.Label yatayHizLabel;
        private System.Windows.Forms.Label boylamLabel;
        private System.Windows.Forms.Label irtifaLabel;
        private System.Windows.Forms.Label gkuvvetLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart voltajGrafik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem haritayıGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uzakGörüntüyüGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamEkranToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolStripMenuItem hamVeriyiGösterToolStripMenuItem;
    }
}