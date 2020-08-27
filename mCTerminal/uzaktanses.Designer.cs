namespace mCTerminal
{
    partial class uzaktanses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uzaktanses));
            this.sesSiddetProgressBar = new System.Windows.Forms.ProgressBar();
            this.sesSiddetGauge = new System.Windows.Forms.AGauge();
            this.sesCihazComboBox = new System.Windows.Forms.ComboBox();
            this.sesCihaziBilgiGuncellemeTimer = new System.Windows.Forms.Timer(this.components);
            this.sesSiddetLabel = new System.Windows.Forms.Label();
            this.sesDinlemeButton = new System.Windows.Forms.Button();
            this.onbellekSayiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sesSiddetProgressBar
            // 
            this.sesSiddetProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sesSiddetProgressBar.Location = new System.Drawing.Point(12, 82);
            this.sesSiddetProgressBar.Name = "sesSiddetProgressBar";
            this.sesSiddetProgressBar.Size = new System.Drawing.Size(310, 14);
            this.sesSiddetProgressBar.TabIndex = 0;
            // 
            // sesSiddetGauge
            // 
            this.sesSiddetGauge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sesSiddetGauge.BackColor = System.Drawing.Color.Maroon;
            this.sesSiddetGauge.BaseArcColor = System.Drawing.Color.Gray;
            this.sesSiddetGauge.BaseArcRadius = 15;
            this.sesSiddetGauge.BaseArcStart = 135;
            this.sesSiddetGauge.BaseArcSweep = 270;
            this.sesSiddetGauge.BaseArcWidth = 2;
            this.sesSiddetGauge.Center = new System.Drawing.Point(25, 25);
            this.sesSiddetGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sesSiddetGauge.Location = new System.Drawing.Point(283, 1);
            this.sesSiddetGauge.MaxValue = 100F;
            this.sesSiddetGauge.MinValue = 0F;
            this.sesSiddetGauge.Name = "sesSiddetGauge";
            this.sesSiddetGauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.sesSiddetGauge.NeedleColor2 = System.Drawing.Color.DimGray;
            this.sesSiddetGauge.NeedleRadius = 15;
            this.sesSiddetGauge.NeedleType = System.Windows.Forms.NeedleType.Simple;
            this.sesSiddetGauge.NeedleWidth = 2;
            this.sesSiddetGauge.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.sesSiddetGauge.ScaleLinesInterInnerRadius = 15;
            this.sesSiddetGauge.ScaleLinesInterOuterRadius = 15;
            this.sesSiddetGauge.ScaleLinesInterWidth = 1;
            this.sesSiddetGauge.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.sesSiddetGauge.ScaleLinesMajorInnerRadius = 8;
            this.sesSiddetGauge.ScaleLinesMajorOuterRadius = 8;
            this.sesSiddetGauge.ScaleLinesMajorStepValue = 10F;
            this.sesSiddetGauge.ScaleLinesMajorWidth = 2;
            this.sesSiddetGauge.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.sesSiddetGauge.ScaleLinesMinorInnerRadius = 15;
            this.sesSiddetGauge.ScaleLinesMinorOuterRadius = 20;
            this.sesSiddetGauge.ScaleLinesMinorTicks = 2;
            this.sesSiddetGauge.ScaleLinesMinorWidth = 1;
            this.sesSiddetGauge.ScaleNumbersColor = System.Drawing.Color.Black;
            this.sesSiddetGauge.ScaleNumbersFormat = null;
            this.sesSiddetGauge.ScaleNumbersRadius = 100;
            this.sesSiddetGauge.ScaleNumbersRotation = 0;
            this.sesSiddetGauge.ScaleNumbersStartScaleLine = 0;
            this.sesSiddetGauge.ScaleNumbersStepScaleLines = 1;
            this.sesSiddetGauge.Size = new System.Drawing.Size(50, 50);
            this.sesSiddetGauge.TabIndex = 22;
            this.sesSiddetGauge.Text = "aGauge1";
            this.sesSiddetGauge.Value = 0F;
            // 
            // sesCihazComboBox
            // 
            this.sesCihazComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sesCihazComboBox.FormattingEnabled = true;
            this.sesCihazComboBox.Location = new System.Drawing.Point(12, 12);
            this.sesCihazComboBox.Name = "sesCihazComboBox";
            this.sesCihazComboBox.Size = new System.Drawing.Size(270, 21);
            this.sesCihazComboBox.TabIndex = 24;
            this.sesCihazComboBox.TextChanged += new System.EventHandler(this.sesCihazComboBox_TextChanged);
            // 
            // sesCihaziBilgiGuncellemeTimer
            // 
            this.sesCihaziBilgiGuncellemeTimer.Enabled = true;
            this.sesCihaziBilgiGuncellemeTimer.Interval = 1;
            this.sesCihaziBilgiGuncellemeTimer.Tick += new System.EventHandler(this.sesCihaziBilgiGuncellemeTimer_Tick);
            // 
            // sesSiddetLabel
            // 
            this.sesSiddetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sesSiddetLabel.Location = new System.Drawing.Point(288, 42);
            this.sesSiddetLabel.Name = "sesSiddetLabel";
            this.sesSiddetLabel.Size = new System.Drawing.Size(36, 13);
            this.sesSiddetLabel.TabIndex = 25;
            this.sesSiddetLabel.Text = "%100";
            this.sesSiddetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sesDinlemeButton
            // 
            this.sesDinlemeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sesDinlemeButton.Location = new System.Drawing.Point(12, 39);
            this.sesDinlemeButton.Name = "sesDinlemeButton";
            this.sesDinlemeButton.Size = new System.Drawing.Size(125, 23);
            this.sesDinlemeButton.TabIndex = 27;
            this.sesDinlemeButton.Text = "Aygıtı Dinlemeye Başla";
            this.sesDinlemeButton.UseVisualStyleBackColor = true;
            this.sesDinlemeButton.Click += new System.EventHandler(this.sesDinlemeButton_Click);
            // 
            // onbellekSayiLabel
            // 
            this.onbellekSayiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.onbellekSayiLabel.Location = new System.Drawing.Point(9, 65);
            this.onbellekSayiLabel.Name = "onbellekSayiLabel";
            this.onbellekSayiLabel.Size = new System.Drawing.Size(160, 14);
            this.onbellekSayiLabel.TabIndex = 28;
            this.onbellekSayiLabel.Text = "Kullanılacak Önbellek Sayısı: 0";
            // 
            // uzaktanses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(334, 104);
            this.Controls.Add(this.onbellekSayiLabel);
            this.Controls.Add(this.sesDinlemeButton);
            this.Controls.Add(this.sesSiddetProgressBar);
            this.Controls.Add(this.sesSiddetLabel);
            this.Controls.Add(this.sesCihazComboBox);
            this.Controls.Add(this.sesSiddetGauge);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 143);
            this.Name = "uzaktanses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mCTerminal Uzak Ses | (CİHAZ_ADI)";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.uzaktanses_FormClosing);
            this.Load += new System.EventHandler(this.uzaktanses_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar sesSiddetProgressBar;
        private System.Windows.Forms.AGauge sesSiddetGauge;
        private System.Windows.Forms.ComboBox sesCihazComboBox;
        private System.Windows.Forms.Timer sesCihaziBilgiGuncellemeTimer;
        private System.Windows.Forms.Label sesSiddetLabel;
        private System.Windows.Forms.Button sesDinlemeButton;
        private System.Windows.Forms.Label onbellekSayiLabel;
    }
}