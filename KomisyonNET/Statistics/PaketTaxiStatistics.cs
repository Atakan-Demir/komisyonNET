using ClosedXML.Excel;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomisyonNET.PaketTaxi;
using System.Windows;
using LiveCharts.WinForms;
using System.Windows.Media;
using System.IO;

namespace KomisyonNET.Statistics
{
    internal class PaketTaxiStatistics
    {

        // Hata yakalamayi Unutma !!!!!!!!!!!!!!!!
        public List<PaketTaxiModel> ReadExcelFile(string filePath)
        {
            var models = new List<PaketTaxiModel>();
            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1);
                    foreach (var row in worksheet.RowsUsed().Skip(1))
                    {
                        models.Add(new PaketTaxiModel
                        {
                            nameSurname = row.Cell(1).GetValue<string>(),
                            tInvoice = row.Cell(2).GetValue<double>(),
                            fee = row.Cell(3).GetValue<double>(),
                            commission = row.Cell(4).GetValue<double>()
                        });
                    }
                }
                return models;
            }
            catch (IOException ex)
            {

                MessageBox.Show("Dosya başka bir işlem tarafından kullanılıyor: " + ex.Message, "Hata!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return null;

            }
            catch (FormatException ex)
            {

                MessageBox.Show("Dönüşüm hatası: " + ex.Message, "Hata!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return null;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message, "Bilinmeyen Hata!", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;

            }
        }

        public SeriesCollection PieChart(List<PaketTaxiModel> models)
        {
            double totalFee = models.Sum(x => x.fee);
            double totalCom = models.Sum(x => x.commission);

            return new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Aidat",
                    Values = new ChartValues<double> { totalFee },
                    DataLabels = true,
                    LabelPoint = chartPoint => string.Format("{0:N2}", chartPoint.Y),
                    //Fill = System.Windows.Media.Brushes.Green
                },
                new PieSeries
                {
                    Title = "Komisyon",
                    Values = new ChartValues<double> { totalCom },
                    DataLabels = true,
                    LabelPoint = chartPoint => string.Format("{0:N2}", chartPoint.Y),
                    Fill = System.Windows.Media.Brushes.Orange
                }
            };
        }


        public SeriesCollection StackedColumn(List<PaketTaxiModel> models)
        {
            var totalFee = models.Sum(x => x.fee);
            var totalCommission = models.Sum(x => x.commission);
            var feeSeries = new StackedColumnSeries
            {
                Title = "Aidat",
                Values = new ChartValues<double> { totalFee },
                DataLabels = true,
                //Fill = System.Windows.Media.Brushes.Blue 
                LabelPoint = chartPoint => string.Format("{0:N2}", chartPoint.Y),
            };

            var commissionSeries = new StackedColumnSeries
            {
                Title = "Komisyon",
                Values = new ChartValues<double> { totalCommission },
                DataLabels = true,
                Fill = System.Windows.Media.Brushes.Orange, // Komisyon için turuncu renk
                LabelPoint = chartPoint => string.Format("{0:N2}", chartPoint.Y),
            };

            return new SeriesCollection { feeSeries, commissionSeries };
        }

        public SeriesCollection OrderedColumn(List<PaketTaxiModel> models)
        {
            var totalFee = models.Sum(x => x.fee);
            var totalCommission = models.Sum(x => x.commission);
            var feeSeries = new ColumnSeries
            {
                Title = "Aidat",
                Values = new ChartValues<double> { totalFee },

                DataLabels = true,
                //Fill = System.Windows.Media.Brushes.Blue 
                LabelPoint = chartPoint => string.Format("{0:N2}", chartPoint.Y),

            };

            var commissionSeries = new ColumnSeries
            {
                Title = "Komisyon",
                Values = new ChartValues<double> { totalCommission },

                DataLabels = true,
                Fill = System.Windows.Media.Brushes.Orange, // Komisyon için turuncu renk
                LabelPoint = chartPoint => string.Format("{0:N2}", chartPoint.Y),
            };

            return new SeriesCollection { feeSeries, commissionSeries };
        }


        public double TotalInvoice(List<PaketTaxiModel> models)
        {
            return models.Sum(x => x.tInvoice);
        }
        public double TotalProfit(List<PaketTaxiModel> models)
        {
            return models.Sum(x => x.fee + x.commission);
        }






        /*
        public double CalculateAverageCommissionAbove(List<PaketTaxiModel> models)
        {
            double averageCommission = models.Average(x => x.commission);
            return models.Count(x => x.commission > averageCommission);
        }
        */


        /****************************************************************/

        public double CalculatePercentageChange(double oldIncome, double newIncome)
        {
            if (oldIncome == 0)
            {
                throw new InvalidOperationException("Eski gelir sıfır olamaz.");
            }

            double change = (newIncome - oldIncome) / oldIncome;
            return change * 100; // Yüzde olarak dönüş
        }

        //public void UpdateSolidGauge(SolidGauge solidGauge, double percentageChange)
        public SolidGauge UpdateSolidGauge(double percentageChange)
        {
            var solidGauge = new SolidGauge();
            solidGauge.Value = Math.Abs(percentageChange); // Değerin mutlak değerini ayarla

            if (percentageChange > 0)
            {
                // Artış varsa yeşil renk
                solidGauge.From = 0;
                solidGauge.To = 100;
                solidGauge.FromColor = Colors.Green;
                solidGauge.ToColor = Colors.LightGreen;
                solidGauge.Base.LabelsVisibility = Visibility.Visible;
                solidGauge.Base.Foreground = new SolidColorBrush(Colors.Green);
                solidGauge.LabelFormatter = value => "+" + value.ToString("0.##") + "%";
                return solidGauge;
            }
            else if (percentageChange < 0)
            {
                // Düşüş varsa kırmızı renk
                solidGauge.From = 0;
                solidGauge.To = 100;
                solidGauge.FromColor = Colors.Red;
                solidGauge.ToColor = Colors.OrangeRed;
                solidGauge.Base.LabelsVisibility = Visibility.Visible;
                solidGauge.Base.Foreground = new SolidColorBrush(Colors.Red);
                solidGauge.LabelFormatter = value => "-" + value.ToString("0.##") + "%";
                return solidGauge;
            }
            else
            {
                // Değişiklik yoksa gri renk
                solidGauge.From = 0;
                solidGauge.To = 100;
                solidGauge.FromColor = Colors.Gray;
                solidGauge.ToColor = Colors.LightGray;
                solidGauge.Base.LabelsVisibility = Visibility.Visible;
                solidGauge.Base.Foreground = new SolidColorBrush(Colors.Gray);
                solidGauge.LabelFormatter = value => "0%";
                return solidGauge;
            }
        }

        public double UpdateFeesAndCommissions(List<PaketTaxiModel> models, double newFee, double newComm)
        {

            double total = 0;
            foreach (var model in models)
            {
                double tempFee = newFee;
                double tempCommission = model.tInvoice * newComm / 100;
                total += tempFee + tempCommission;
            }
            return total;
        }


    }

}
