using ClosedXML.Excel;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomisyonNET.PaketTaxi;

namespace KomisyonNET.Statistics
{
    internal class PaketTaxiStatistics
    {
        /*
        public Func<ChartValues<double>, SeriesCollection> CreatePieChart = (chartValues) =>
        {
            var seriesCollection = new SeriesCollection
        {
            new PieSeries
            {
                Title = "Aidatlar",
                Values = new ChartValues<double> { chartValues[0] },
                DataLabels = true
            },
            new PieSeries
            {
                Title = "Komisyonlar",
                Values = new ChartValues<double> { chartValues[1] },
                DataLabels = true
            }
        };

            return seriesCollection;
        };

        public ChartValues<double> ReadExcelAndCalculate(string filePath)
        {
            var aidatlarToplami = 0.0;
            var komisyonlarToplami = 0.0;

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1);
                var rows = worksheet.RangeUsed().RowsUsed().Skip(1); // Başlık satırını atla

                foreach (var row in rows)
                {
                    aidatlarToplami += row.Cell(3).GetValue<double>(); // 2. sütun aidat varsayalım
                    komisyonlarToplami += row.Cell(4).GetValue<double>(); // 3. sütun komisyon varsayalım
                }
            }

            return new ChartValues<double> { aidatlarToplami, komisyonlarToplami };
        }
        */

        public List<PaketTaxiModel> ReadExcelFile(string filePath)
        {
            var models = new List<PaketTaxiModel>();
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1);
                foreach (var row in worksheet.RowsUsed().Skip(1))
                {
                    models.Add(new PaketTaxiModel
                    {
                        nameSurname = row.Cell(1).GetValue<string>(),
                        fee = row.Cell(3).GetValue<double>(),
                        tInvoice = row.Cell(2).GetValue<double>(),
                        commission = row.Cell(4).GetValue<double>()
                    });
                }
            }
            return models;
        }

        public SeriesCollection CreatePieChart(List<PaketTaxiModel> models)
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

        public SeriesCollection CreateStackedArea(List<PaketTaxiModel> models)
        {
            var seriesCollection = new SeriesCollection();

            var feeSeries = new StackedAreaSeries
            {
                Title = "Aidat",
                Values = new ChartValues<double>(models.Select(x => x.fee)),
                LineSmoothness = 0, // Düz çizgiler için 0
                DataLabels = true
            };



            var commissionSeries = new StackedAreaSeries
            {
                Title = "Komisyon",
                Values = new ChartValues<double>(models.Select(x => x.commission)),
                LineSmoothness = 0, // Düz çizgiler için 0
                DataLabels = true
            };

            seriesCollection.Add(feeSeries);
            //seriesCollection.Add(invoiceSeries);
            seriesCollection.Add(commissionSeries);

            return seriesCollection;
        }
        public SeriesCollection CreateStackedColumn(List<PaketTaxiModel> models)
        {
            var seriesCollection = new SeriesCollection();

            var feeSeries = new StackedColumnSeries
            {
                Title = "Aidat",
                Values = new ChartValues<double>(models.Select(x => x.fee)),
                StackMode = StackMode.Values,
                DataLabels = true
            };
            /*
            var invoiceSeries = new StackedColumnSeries
            {
                Title = "Fatura",
                Values = new ChartValues<double>(models.Select(x => x.tInvoice)),
                StackMode = StackMode.Values,
                DataLabels = true
            };
            */
            var commissionSeries = new StackedColumnSeries
            {
                Title = "Komisyon",
                Values = new ChartValues<double>(models.Select(x => x.commission)),
                StackMode = StackMode.Values,
                DataLabels = true
            };

            seriesCollection.Add(feeSeries);
            //seriesCollection.Add(invoiceSeries);
            seriesCollection.Add(commissionSeries);

            return seriesCollection;
        }
        public SeriesCollection CreateStackedColumnForCommissionsAndFees(List<PaketTaxiModel> models)
        {
            var totalFee = models.Sum(x => x.fee);
            var totalCommission = models.Sum(x => x.commission);
            var feeSeries = new StackedColumnSeries
            {
                Title = "Aidat",
                Values = new ChartValues<double>{ totalFee } ,
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

        public SeriesCollection CM(List<PaketTaxiModel> models)
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

        public double CalculateAverageCommissionAbove(List<PaketTaxiModel> models)
        {
            double averageCommission = models.Average(x => x.commission);
            return models.Count(x => x.commission > averageCommission);
        }
    }

}
