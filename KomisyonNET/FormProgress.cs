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

        PaketTaxiOperations ptOperations = new PaketTaxiOperations();

        public FormProgress()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            

            // Köşeleri yuvarlak bir form oluştur
            GraphicsPath path = new GraphicsPath();
            int radius = 36; // Yuvarlak köşe yarıçapı
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.AddFormToManage(this);




            //InitializeProgressBar();

            ReadFile();

           
        }




        // read file function

        /*
        private async void ReadFile()
        {
            List<PaketTaxiModel> data = new List<PaketTaxiModel>();


            for (int i = 0; i < FormMain.pdfFiles.Length; i++)
            {
                double prBarValue = 100 / FormMain.pdfFiles.Length;

                //await Task.Delay(200); // 100ms gecikme

                data.Add(await ptOperations.ExtractPdfAsync(FormMain.pdfFiles[i]));

                mProgressBarRead.Value += (int)prBarValue;
                mLabelRead.Text = "Faturalar Okunuyor(" + (i + 1) + " / " + FormMain.pdfFiles.Length.ToString() + ")";


                if (i + 1 == FormMain.pdfFiles.Length)
                {
                    mProgressBarRead.Value = 100;
                }

                
            }

            WriteFile(data);

        }
        */

        
        private async void ReadFile()
        {
            var progress = new Progress<(int progress, string message)>(value =>
            {
                mProgressBarRead.Value = (int)((double)value.progress / FormMain.pdfFiles.Length * 100);
                mLabelRead.Text = value.message;
            });

            List<PaketTaxiModel> data = await ptOperations.ExtractPdf(FormMain.pdfFiles, progress);

            WriteFile(data);
        }
        

        /*
        private async void WriteFile(List<PaketTaxiModel> dt)
        {
            // for dt
            for (int i = 0; i < dt.Count; i++)
            {
                double prBarValue = 100 / dt.Count;

                await Task.Delay(500); // 100ms gecikme

                

                mProgressBarWrite.Value += (int)prBarValue;
                mLabelWrite.Text = "Faturalar Yazılıyor(" + (i + 1) + " / " + dt.Count.ToString() + ")";
            }
            ptOperations.CreateExceltable(dt);


        }
        */

        private async void WriteFile(List<PaketTaxiModel> dt)
        {
            var progress = new Progress<(int progress, string message)>(value =>
            {
                mProgressBarWrite.Value = (int)((double)value.progress / dt.Count * 100);
                mLabelWrite.Text = value.message;
            });

            await ptOperations.CreateExcelTableAsync(dt, progress);
        }



        private async void InitializeProgressBar()
        {
            for (int i = 0; i < FormMain.pdfFiles.Length; i++)
            {
                double prBarValue = 100 / FormMain.pdfFiles.Length;

                await Task.Delay(500); // 100ms gecikme

                mProgressBarRead.Value += (int)prBarValue;
                mLabelRead.Text = "Faturalar Okunuyor("+(i+1)+" / "+ FormMain.pdfFiles.Length.ToString()+")";
                
                
                if (i+1==FormMain.pdfFiles.Length)
                {
                    mProgressBarRead.Value = 100;
                }
                
                // UI güncellemeleri için gerekiyorsa
                //this.Refresh();
            }
            

            InitializeProgressBar2();
        }


        private async void InitializeProgressBar2()
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(100); // 100ms gecikme
                mProgressBarWrite.Value += 1;
                

                // UI güncellemeleri için gerekiyorsa
                //materialProgressBar1.Refresh(); // veya this.Refresh();
            }

            //this.Close();
        }

    }
}
