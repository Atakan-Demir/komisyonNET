namespace KomisyonNET
{
    partial class FormProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProgress));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.mProgressBarWrite = new MaterialSkin.Controls.MaterialProgressBar();
            this.mLabelWrite = new MaterialSkin.Controls.MaterialLabel();
            this.mProgressBarRead = new MaterialSkin.Controls.MaterialProgressBar();
            this.mLabelRead = new MaterialSkin.Controls.MaterialLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new MaterialSkin.Controls.MaterialButton();
            this.mLabelInfo = new MaterialSkin.Controls.MaterialLabel();
            this.BtnOpenExcel = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.materialExpansionPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.mProgressBarWrite);
            this.materialCard1.Controls.Add(this.mLabelWrite);
            this.materialCard1.Controls.Add(this.mProgressBarRead);
            this.materialCard1.Controls.Add(this.mLabelRead);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 148);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(616, 170);
            this.materialCard1.TabIndex = 0;
            // 
            // mProgressBarWrite
            // 
            this.mProgressBarWrite.Cursor = System.Windows.Forms.Cursors.Default;
            this.mProgressBarWrite.Depth = 0;
            this.mProgressBarWrite.Location = new System.Drawing.Point(21, 145);
            this.mProgressBarWrite.MouseState = MaterialSkin.MouseState.HOVER;
            this.mProgressBarWrite.Name = "mProgressBarWrite";
            this.mProgressBarWrite.Size = new System.Drawing.Size(578, 5);
            this.mProgressBarWrite.TabIndex = 3;
            // 
            // mLabelWrite
            // 
            this.mLabelWrite.AutoSize = true;
            this.mLabelWrite.Depth = 0;
            this.mLabelWrite.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mLabelWrite.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.mLabelWrite.Location = new System.Drawing.Point(17, 94);
            this.mLabelWrite.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelWrite.Name = "mLabelWrite";
            this.mLabelWrite.Size = new System.Drawing.Size(212, 24);
            this.mLabelWrite.TabIndex = 2;
            this.mLabelWrite.Text = "Faturalar Yazılıyor (0/0)";
            // 
            // mProgressBarRead
            // 
            this.mProgressBarRead.Depth = 0;
            this.mProgressBarRead.Location = new System.Drawing.Point(21, 65);
            this.mProgressBarRead.MouseState = MaterialSkin.MouseState.HOVER;
            this.mProgressBarRead.Name = "mProgressBarRead";
            this.mProgressBarRead.Size = new System.Drawing.Size(578, 5);
            this.mProgressBarRead.TabIndex = 1;
            // 
            // mLabelRead
            // 
            this.mLabelRead.AutoSize = true;
            this.mLabelRead.Depth = 0;
            this.mLabelRead.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mLabelRead.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.mLabelRead.Location = new System.Drawing.Point(17, 14);
            this.mLabelRead.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelRead.Name = "mLabelRead";
            this.mLabelRead.Size = new System.Drawing.Size(221, 24);
            this.mLabelRead.TabIndex = 0;
            this.mLabelRead.Text = "Faturalar Okunuyor (0/0)";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(551, 102);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // materialExpansionPanel1
            // 
            this.materialExpansionPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel1.CancelButtonText = "";
            this.materialExpansionPanel1.Collapse = true;
            this.materialExpansionPanel1.Controls.Add(this.richTextBox1);
            this.materialExpansionPanel1.Depth = 0;
            this.materialExpansionPanel1.Description = "Açıklama";
            this.materialExpansionPanel1.ExpandHeight = 234;
            this.materialExpansionPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel1.Location = new System.Drawing.Point(17, 333);
            this.materialExpansionPanel1.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
            this.materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel1.Name = "materialExpansionPanel1";
            this.materialExpansionPanel1.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.materialExpansionPanel1.Size = new System.Drawing.Size(614, 48);
            this.materialExpansionPanel1.TabIndex = 3;
            this.materialExpansionPanel1.Title = "HATA Yakalandı : ";
            this.materialExpansionPanel1.UseAccentColor = true;
            this.materialExpansionPanel1.ValidationButtonEnable = true;
            this.materialExpansionPanel1.ValidationButtonText = "Kapat";
            this.materialExpansionPanel1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KomisyonNET.Properties.Resources.duck;
            this.pictureBox1.Location = new System.Drawing.Point(246, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.AutoSize = false;
            this.BtnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnClose.Depth = 0;
            this.BtnClose.Enabled = false;
            this.BtnClose.HighEmphasis = true;
            this.BtnClose.Icon = null;
            this.BtnClose.Location = new System.Drawing.Point(596, 3);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnClose.Size = new System.Drawing.Size(37, 36);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "X";
            this.BtnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.BtnClose.UseAccentColor = true;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // mLabelInfo
            // 
            this.mLabelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelInfo.Depth = 0;
            this.mLabelInfo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mLabelInfo.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.mLabelInfo.Location = new System.Drawing.Point(223, 120);
            this.mLabelInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabelInfo.Name = "mLabelInfo";
            this.mLabelInfo.Size = new System.Drawing.Size(215, 14);
            this.mLabelInfo.TabIndex = 5;
            this.mLabelInfo.Text = "** Lütfen İşlemler Bitene Kadar Bekleyin.";
            this.mLabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnOpenExcel
            // 
            this.BtnOpenExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnOpenExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnOpenExcel.Depth = 0;
            this.BtnOpenExcel.HighEmphasis = true;
            this.BtnOpenExcel.Icon = null;
            this.BtnOpenExcel.Location = new System.Drawing.Point(464, 92);
            this.BtnOpenExcel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnOpenExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnOpenExcel.Name = "BtnOpenExcel";
            this.BtnOpenExcel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnOpenExcel.Size = new System.Drawing.Size(167, 36);
            this.BtnOpenExcel.TabIndex = 6;
            this.BtnOpenExcel.Text = "Excel Dosyasını Aç";
            this.BtnOpenExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BtnOpenExcel.UseAccentColor = true;
            this.BtnOpenExcel.UseVisualStyleBackColor = true;
            this.BtnOpenExcel.Visible = false;
            this.BtnOpenExcel.Click += new System.EventHandler(this.BtnOpenExcel_Click);
            // 
            // FormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.ClientSize = new System.Drawing.Size(650, 401);
            this.Controls.Add(this.BtnOpenExcel);
            this.Controls.Add(this.mLabelInfo);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.materialExpansionPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialCard1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProgress";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProgress";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialExpansionPanel1.ResumeLayout(false);
            this.materialExpansionPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialProgressBar mProgressBarWrite;
        private MaterialSkin.Controls.MaterialLabel mLabelWrite;
        private MaterialSkin.Controls.MaterialProgressBar mProgressBarRead;
        private MaterialSkin.Controls.MaterialLabel mLabelRead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private MaterialSkin.Controls.MaterialButton BtnClose;
        private MaterialSkin.Controls.MaterialLabel mLabelInfo;
        private MaterialSkin.Controls.MaterialButton BtnOpenExcel;
    }
}