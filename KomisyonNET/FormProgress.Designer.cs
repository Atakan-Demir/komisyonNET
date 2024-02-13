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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.mProgressBarWrite = new MaterialSkin.Controls.MaterialProgressBar();
            this.mLabelWrite = new MaterialSkin.Controls.MaterialLabel();
            this.mProgressBarRead = new MaterialSkin.Controls.MaterialProgressBar();
            this.mLabelRead = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
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
            this.materialCard1.Location = new System.Drawing.Point(17, 194);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(616, 169);
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
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::KomisyonNET.Properties.Resources.duck;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialCard1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProgress";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProgress";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialProgressBar mProgressBarWrite;
        private MaterialSkin.Controls.MaterialLabel mLabelWrite;
        private MaterialSkin.Controls.MaterialProgressBar mProgressBarRead;
        private MaterialSkin.Controls.MaterialLabel mLabelRead;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}