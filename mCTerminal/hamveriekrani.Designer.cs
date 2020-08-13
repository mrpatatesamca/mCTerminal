namespace mCTerminal
{
    partial class hamveriekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hamveriekrani));
            this.verikontrol = new System.Windows.Forms.Timer(this.components);
            this.hamveritextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // verikontrol
            // 
            this.verikontrol.Enabled = true;
            this.verikontrol.Tick += new System.EventHandler(this.verikontrol_Tick);
            // 
            // hamveritextbox
            // 
            this.hamveritextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hamveritextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.hamveritextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hamveritextbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hamveritextbox.ForeColor = System.Drawing.Color.Chocolate;
            this.hamveritextbox.Location = new System.Drawing.Point(0, 0);
            this.hamveritextbox.Multiline = true;
            this.hamveritextbox.Name = "hamveritextbox";
            this.hamveritextbox.ReadOnly = true;
            this.hamveritextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hamveritextbox.Size = new System.Drawing.Size(634, 182);
            this.hamveritextbox.TabIndex = 0;
            this.hamveritextbox.Text = "hh:mm:ss --> Veri Bekleniyor...";
            // 
            // hamveriekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(634, 181);
            this.Controls.Add(this.hamveritextbox);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 220);
            this.Name = "hamveriekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mCTerminal Ham Veri";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.hamveriekrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer verikontrol;
        private System.Windows.Forms.TextBox hamveritextbox;
    }
}