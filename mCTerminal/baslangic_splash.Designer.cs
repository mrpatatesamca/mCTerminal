namespace mCTerminal
{
    partial class baslangic_splash
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baslangic_splash));
            this.commandLineTextBox = new System.Windows.Forms.TextBox();
            this.yuklemebaslatTimer = new System.Windows.Forms.Timer(this.components);
            this.yuklemebaslatTimer2 = new System.Windows.Forms.Timer(this.components);
            this.yuklemebaslatTimer3 = new System.Windows.Forms.Timer(this.components);
            this.yuklemebaslatTimer4 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // commandLineTextBox
            // 
            this.commandLineTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandLineTextBox.BackColor = System.Drawing.Color.Black;
            this.commandLineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commandLineTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.commandLineTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.commandLineTextBox.Location = new System.Drawing.Point(0, 0);
            this.commandLineTextBox.Multiline = true;
            this.commandLineTextBox.Name = "commandLineTextBox";
            this.commandLineTextBox.ReadOnly = true;
            this.commandLineTextBox.Size = new System.Drawing.Size(342, 197);
            this.commandLineTextBox.TabIndex = 0;
            this.commandLineTextBox.Text = "COSMOS TAKIMI SİSTEM TEST PROGRAMI V0.1";
            // 
            // yuklemebaslatTimer
            // 
            this.yuklemebaslatTimer.Enabled = true;
            this.yuklemebaslatTimer.Interval = 500;
            this.yuklemebaslatTimer.Tick += new System.EventHandler(this.yuklemebaslatTimer_Tick);
            // 
            // yuklemebaslatTimer2
            // 
            this.yuklemebaslatTimer2.Interval = 800;
            this.yuklemebaslatTimer2.Tick += new System.EventHandler(this.yuklemebaslatTimer2_Tick);
            // 
            // yuklemebaslatTimer3
            // 
            this.yuklemebaslatTimer3.Interval = 500;
            this.yuklemebaslatTimer3.Tick += new System.EventHandler(this.yuklemebaslatTimer3_Tick);
            // 
            // yuklemebaslatTimer4
            // 
            this.yuklemebaslatTimer4.Interval = 500;
            this.yuklemebaslatTimer4.Tick += new System.EventHandler(this.yuklemebaslatTimer4_Tick);
            // 
            // baslangic_splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(343, 196);
            this.Controls.Add(this.commandLineTextBox);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "baslangic_splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mCTerminal - @TERM $LOAD MAIN.PROC";
            this.Load += new System.EventHandler(this.baslangic_splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commandLineTextBox;
        private System.Windows.Forms.Timer yuklemebaslatTimer;
        private System.Windows.Forms.Timer yuklemebaslatTimer2;
        private System.Windows.Forms.Timer yuklemebaslatTimer3;
        private System.Windows.Forms.Timer yuklemebaslatTimer4;
    }
}

