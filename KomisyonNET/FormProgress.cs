using KomisyonNET.PaketTaxi;
using KomisyonNET.Settings;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomisyonNET
{
    public partial class FormProgress : MaterialForm
    {
        // Event 
        public event EventHandler ProgressCompleted;

        PaketTaxiOperations ptOperations = new PaketTaxiOperations();

        string excelPath;
        public FormProgress()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            

            // form koselerini yuvarla
            GraphicsPath path = new GraphicsPath();
            int radius = 36; // yaricap
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.AddFormToManage(this);

            ReadFile();

           
        }




        // read file function
        
        private async void ReadFile()
        {
            var progress = new Progress<(int progress, string message)>(value =>
            {
                mProgressBarRead.Value = (int)((double)value.progress / FormMain.pdfFiles.Length * 100);
                mLabelRead.Text = value.message;
            });

            // error progress
            var progressError = new Progress<(int progress, string message,List<string> errorPath)>( value =>
            {
                //mProgressBarError.Value = (int)((double)value.progress / FormMain.pdfFiles.Length * 100);
                
                materialExpansionPanel1.Description = value.message;
                if (value.errorPath.Count>0)
                {
                    materialExpansionPanel1.Visible = true;
                    richTextBox1.Clear();
                    richTextBox1.Text += " Hatalı Dosyalar: \n";
                    foreach (var item in value.errorPath)
                    {
                        richTextBox1.Text += item + "\n";
                    }
                }
                else
                {
                    materialExpansionPanel1.Visible = false;
                    richTextBox1.Text = "Hata Bulunamadı.";
                }
            });
            

            List<PaketTaxiModel> data = await ptOperations.ExtractPdf(FormMain.pdfFiles, progress ,progressError);

            WriteFile(data);
        }



        // wrie file function
        private async void WriteFile(List<PaketTaxiModel> dt)
        {
            var progress = new Progress<(int progress, string message)>(value =>
            {
                mProgressBarWrite.Value = (int)((double)value.progress / dt.Count * 100);
                mLabelWrite.Text = value.message;
            });

            excelPath = await ptOperations.CreateExcelTableAsync(dt, progress);

            pictureBox1.Image = Properties.Resources.success;
            BtnClose.Enabled = true;
            BtnOpenExcel.Visible = true;
            mLabelInfo.Text = "** İşlemler Tamamlandı.";
        }

        private void BtnOpenExcel_Click(object sender, EventArgs e)
        {
            // open excel file
            System.Diagnostics.Process.Start(excelPath);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        // FormProgress kapandiginda event'i tetikle
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            // Eventi tetikle
            ProgressCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
