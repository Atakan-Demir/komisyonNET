using Spire.Pdf.Utilities;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using static KomisyonNET.FormMain;
using KomisyonNET.Settings;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;

namespace KomisyonNET.PaketTaxi
{
    internal class PaketTaxiOperations
    {







        // settings manager
        private SettingsManager conf = new SettingsManager();

        //private List<PaketTaxiModel> paketTaxiModels = new List<PaketTaxiModel>();


        // folder select
        public string FolderSelect()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {

                folderBrowserDialog.Description = "Hesaplanmasını istediğiniz Paket Taxi Faturalarının bulunduğu klasörü seçiniz.";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;

                // new folder create disable
                folderBrowserDialog.ShowNewFolderButton = false;

                // Show the user the folder selection dialog
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    // Get the path to the selected folder
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;




                    return selectedFolderPath;

                }
                else
                {
                    //MessageBox.Show("Klasör seçilmedi.", "Klasör seçilmedi.",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return null;
                }
            }


        }

        // get pdf files
        public string[] getPdfFiles(string path)
        {
            string[] pdfFiles = Directory.GetFiles(path, "*.pdf");
            if (pdfFiles.Length > 0)
            {
                return pdfFiles;
            }
            else
            {
                return null;
            }
        }

        // extract pdfs

        /*
        public List<PaketTaxiModel> ExtractPdf(string[] pdfFiles)
        {
            List<PaketTaxiModel> paketTaxiModels = new List<PaketTaxiModel>();
            
            foreach (string file in pdfFiles)
            {
                using (PdfDocument pdf = new PdfDocument())
                {
                   
                    pdf.LoadFromFile(file);

                    PdfTableExtractor extractor = new PdfTableExtractor(pdf);
                    PdfTable[] pdfTables = extractor.ExtractTable(0);

                    PaketTaxiModel model = new PaketTaxiModel
                    {
                        nameSurname = pdfTables[0].GetText(1, 0),
                        tInvoice = TryDouble(pdfTables[1].GetText(10, 7)),
                        commission = CalculateCommission(TryDouble(pdfTables[1].GetText(10, 7))),
                        fee = conf.GetFee()

                    };
                    
                    paketTaxiModels.Add(model);

                    
                }
            }
            
            return paketTaxiModels;
            
            
        }
        */

        /*
        public async Task<List<PaketTaxiModel>> ExtractPdf(string[] pdfFiles, IProgress<(int progress, string message)> progress)
        {
            List<PaketTaxiModel> paketTaxiModels = new List<PaketTaxiModel>();
            List<string> errorPath = new List<string>();
            //for (int i = 0; i < pdfFiles.Length; i++)
            //{
            // string file = pdfFiles[i];
            using (PdfDocument pdf = new PdfDocument())
            {
                for (int i = 0; i < pdfFiles.Length; i++)
                {
                    pdf.LoadFromFile(pdfFiles[i]);

                    PdfTableExtractor extractor = new PdfTableExtractor(pdf);

                    PdfTable[] pdfTables = extractor.ExtractTable(0);

                    if (pdfTables == null)
                    {
                        errorPath.Add(pdfFiles[i]);
                        continue;
                    }
                    else
                    {
                        PaketTaxiModel model = new PaketTaxiModel
                        {
                            nameSurname = pdfTables[0].GetText(1, 0),
                            tInvoice = TryDouble(pdfTables[1].GetText(10, 7)),
                            commission = CalculateCommission(TryDouble(pdfTables[1].GetText(10, 7))),
                            fee = conf.GetFee()
                        };

                        paketTaxiModels.Add(model);
                    }

                    // İlerlemeyi rapor et
                    progress.Report((i + 1, $"Faturalar Okunuyor ({i + 1} / {pdfFiles.Length})"));
                    
                    await Task.Delay(100);
                }


            }

            
            //}

            return paketTaxiModels;
        }
        */
        public async Task<List<PaketTaxiModel>> ExtractPdf(string[] pdfFiles, IProgress<(int progress, string message)> progress, IProgress<(int progress, string message, List<string> errpath)> progressError)
        {
            List<PaketTaxiModel> paketTaxiModels = new List<PaketTaxiModel>();
            List<string> errorPath = new List<string>();

            for (int i = 0; i < pdfFiles.Length; i++)
            {
                var model = await Task.Run(() =>
                {
                    using (PdfDocument pdf = new PdfDocument())
                    {
                        pdf.LoadFromFile(pdfFiles[i]);

                        PdfTableExtractor extractor = new PdfTableExtractor(pdf);
                        PdfTable[] pdfTables = extractor.ExtractTable(0);

                        if (pdfTables == null)
                        {
                            errorPath.Add(pdfFiles[i]);
                            return null;
                        } 
                        else
                        {



                            var check = pdfTables.Length;

                            //MessageBox.Show(check.ToString()+" Adet Tablo Bulundu.");


                            int indexTable = 0;

                            // for loop ile tabloları kontrol et
                            var rowIndexInvoice = -1;
                            for (int j = 0; j < pdfTables.Length; j++)
                            {
                                for (int k = 0; k < pdfTables[j].GetRowCount(); k++)
                                {
                                    var rowText = pdfTables[j].GetText(k, 0);

                                    if (rowText.Contains("BRÜT HAKEDİŞ") && rowText.Contains("FATURA TUTARI"))
                                    {
                                        rowIndexInvoice = k;
                                        indexTable = j;
                                        break;
                                    }
                                }
                                
                            }




                            
                            /*
                            for (int j = 0; j < pdfTables[indexTable+1].GetRowCount(); j++)
                            {
                                var rowText = pdfTables[indexTable+1].GetText(j, 0); 

                                if (rowText.Contains("BRÜT HAKEDİŞ") && rowText.Contains("FATURA TUTARI"))
                                {
                                    rowIndexInvoice = j;
                                    break; 
                                }
                            }
                            */
                            if (rowIndexInvoice == -1)
                            {
                                
                                errorPath.Add(pdfFiles[i]+" Brüt Bulunamadı!");
                                return null;
                                
                            }
                            else
                            {
                                //MessageBox.Show(pdfTables[indexTable].GetText(1, 0));
                                return new PaketTaxiModel
                                {
                                    nameSurname = pdfTables[indexTable-1].GetText(1, 0),
                                    tInvoice = TryDouble(pdfTables[indexTable].GetText(rowIndexInvoice, 7)),
                                    commission = CalculateCommission(TryDouble(pdfTables[indexTable].GetText(rowIndexInvoice, 7))),
                                    fee = conf.GetFee()
                                };
                            }
                        }
                    }
                });

                if (model != null)
                {
                    if (model.tInvoice != 0)
                    {
                        // add model
                        paketTaxiModels.Add(model);
                    }
                    else
                    {
                        // add error path
                        errorPath.Add(pdfFiles[i]);
                    }

                }
                //hatalı fatura sayısını rapor et
                progressError.Report((errorPath.Count, $"Hatalı Fatura Sayısı: {errorPath.Count}/{pdfFiles.Length}", errorPath));


                // İlerlemeyi rapor et
                progress.Report((i + 1, $"Faturalar İşleniyor ({i + 1} / {pdfFiles.Length})"));

                //await Task.Delay(0);
            }

            return paketTaxiModels;
        }


        /*
        public async Task<List<PaketTaxiModel>> ExtractPdfAsync(string[] pdfFiles, IProgress<(int progress, string message)> progress, IProgress<(int progress, string message, List<string> errpath)> progressError)
        {
            List<PaketTaxiModel> paketTaxiModels = new List<PaketTaxiModel>();
            List<string> errorPath = new List<string>();

            foreach (var file in pdfFiles)
            {
                using (PdfDocument pdf = new PdfDocument())
                {
                    pdf.LoadFromFile(file);

                    PdfTableExtractor extractor = new PdfTableExtractor(pdf);
                    var tableCount = extractor.ExtractTableCount(0); // 0 numaralı sayfada tablo sayısını al

                    if (tableCount > 1) // En az 2 tablo olduğunu varsayıyoruz
                    {
                        var table = extractor.ExtractTable(0, 1); // İkinci tabloyu al (index 1)
                        int foundRow = -1;

                        for (int rowIndex = 0; rowIndex < table.GetRowCount(); rowIndex++)
                        {
                            var rowText = table.GetText(rowIndex, 0); // Satırın tamamını al
                            if (rowText.Contains("Brüt Hakediş (Fatura Tutarı)"))
                            {
                                foundRow = rowIndex;
                                break;
                            }
                        }

                        if (foundRow != -1)
                        {
                            // Bulunan satırın 10. sütunundaki veriyi çıkar
                            var tInvoiceText = table.GetText(foundRow, 9); // Sütun indexi 0'dan başladığı için 9 kullanılır
                            var tInvoice = TryDouble(tInvoiceText);

                            paketTaxiModels.Add(new PaketTaxiModel
                            {
                                // Diğer alanları doldur
                                tInvoice = tInvoice
                            });
                        }
                        else
                        {
                            errorPath.Add(file);
                        }
                    }
                    else
                    {
                        errorPath.Add(file);
                    }
                }

                // İlerlemeyi rapor et
                progress.Report((errorPath.Count, $"Faturalar İşleniyor ({errorPath.Count} / {pdfFiles.Length})"));
            }

            return paketTaxiModels;
        }


        */




        // try double function
        public double TryDouble(string value)
        {


            double result;


            //double.TryParse(value, out result)
            if (double.TryParse(value, out result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }

        // calculate commission
        public double CalculateCommission(double total)
        {
            double commission = total * (conf.GetCom() / 100);
            return Math.Round(commission, 2);
        }









        // create excel table
        public void CreateExceltable(List<PaketTaxiModel> models)
        {
            List<PaketTaxiModel> paketTaxiModels = models;

            // get DateTime
            string dateTime = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");


            string path = conf.GetExportPath() + @"\KomisyonNET " + dateTime + @".xlsx";

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("KomisyonNET Paket Taxi");

                // hücreleri birleştir


                // Başlık satırını ekle
                worksheet.Cell("A1").Value = "İsim Soyisim";
                worksheet.Cell("B1").Value = "Fatura Tutarı";
                worksheet.Cell("C1").Value = "Aidat Tutarı";
                worksheet.Cell("D1").Value = "Komisyon Miktarı";

                // Veri satırlarını ekle
                int row = 2;
                foreach (var item in paketTaxiModels)
                {
                    worksheet.Cell("A" + row).Value = item.nameSurname;
                    worksheet.Cell("B" + row).Value = item.tInvoice;
                    worksheet.Cell("C" + row).Value = item.fee;
                    worksheet.Cell("D" + row).Value = item.commission;
                    row++;
                }

                // Tablo olarak biçimlendir
                var range = worksheet.Range("A1:D" + (row - 1));
                var table = range.CreateTable();

                // Dosyayı kaydet
                workbook.SaveAs(path);
            }


        }


        public async Task<string> CreateExcelTableAsync(List<PaketTaxiModel> models, IProgress<(int, string)> progress)
        {
            string dateTime = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");
            string path = conf.GetExportPath() + @"\KomisyonNET " + dateTime + @".xlsx";

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("KomisyonNET Paket Taxi");
                worksheet.Cell("A1").Value = "İsim Soyisim";
                worksheet.Cell("B1").Value = "Fatura Tutarı";
                worksheet.Cell("C1").Value = "Aidat Tutarı";
                worksheet.Cell("D1").Value = "Komisyon Miktarı";

                int row = 2;
                for (int i = 0; i < models.Count; i++)
                {
                    var item = models[i];
                    worksheet.Cell("A" + row).Value = item.nameSurname;
                    worksheet.Cell("B" + row).Value = item.tInvoice;
                    worksheet.Cell("C" + row).Value = item.fee;
                    worksheet.Cell("D" + row).Value = item.commission;
                    row++;

                    // UI güncellemesi için progress raporu
                    progress.Report((i + 1, $"Faturalar Yazılıyor ({i + 1} / {models.Count})"));


                    await Task.Delay(10);
                }


                // Tablo olarak biçimlendir
                var range = worksheet.Range("A1:D" + (row - 1));
                var table = range.CreateTable();

                workbook.SaveAs(path);

                return path;
            }
        }

    }
}
