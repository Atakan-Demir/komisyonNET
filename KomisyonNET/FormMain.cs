using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KomisyonNET.Settings;
using System.IO;
using KomisyonNET.PaketTaxi;
using System.Media;
using ClosedXML.Excel;
using System.Windows.Forms.DataVisualization.Charting;
using KomisyonNET.Statistics;
using LiveCharts;
using DocumentFormat.OpenXml.Drawing.Charts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using LiveCharts.Definitions.Charts;
using System.Windows;
using Series = LiveCharts.Wpf.Series;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System.Windows.Data;
using MessageBox = System.Windows.Forms.MessageBox;
namespace KomisyonNET
{
    public partial class FormMain : MaterialForm
    {

        // settings manager
        private SettingsManager conf = new SettingsManager();

        private string languageS;
        private double feeS;
        private double comS;
        private int themeS;
        private int colorSchemaS;
        private string exportPathS;


        // MaterialSkinManager
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        // cup
        private string folderPath;
        List<PaketTaxiModel> statisticModels = new List<PaketTaxiModel>();



        // statistics
        private string statisticsPath;
        PaketTaxiStatistics statistics = new PaketTaxiStatistics();


        // operations
        PaketTaxiOperations ptOperations = new PaketTaxiOperations();
        public static string[] pdfFiles;




        public FormMain()
        {
            InitializeComponent();



            if (conf.GetIsFt())
            {
                exportPathS = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                conf.SetExportPath(exportPathS);
                conf.SetIsFt(false);
                
            }
            else
            {
                exportPathS = conf.GetExportPath();
            }

            materialSkinManager.AddFormToManage(this);





            LoadSettings();


            AddEventHandlers();

            BtnSave.Enabled = false;


            // solid gauge

            statistics.UpdateSolidGauge(solidGauge1);

            
            

        }



        /***************************************** Settings Start *****************************************/
        #region Settings


        // Load Settings function
        private void LoadSettings()
        {

            txtBoxExportPath.Text = conf.GetExportPath();
            exportPathS = conf.GetExportPath();

            MaskTxtBoxFee.Text = conf.GetFee().ToString();
            feeS = conf.GetFee();

            MaskTxtBoxComm.Text = conf.GetCom().ToString();
            comS = conf.GetCom();

            languageS = conf.GetLanguage();
            if (conf.GetLanguage() == "tr")
            {
                mComboBoxLanguage.SelectedIndex = 0;
            }
            else
            {
                mComboBoxLanguage.SelectedIndex = 1;
            }

            colorSchemaS = conf.GetColorSchema();
            if (conf.GetColorSchema() == 1)
            {
                materialRadioButton1.Checked = true;
            }
            else if (conf.GetColorSchema() == 0)
            {
                materialRadioButton2.Checked = true;
            }
            else if (conf.GetColorSchema() == 2)
            {
                materialRadioButton3.Checked = true;
            }

            themeS = conf.GetTheme();
            //theme switch
            if (conf.GetTheme() == 1)
            {
                themeSwitch.Checked = true;
            }
            else
            {
                themeSwitch.Checked = false;
            }

        }

        // Save button click
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // save settings
            if (themeSwitch.Checked)
            {
                conf.SetTheme(1);
            }
            else
            {
                conf.SetTheme(0);
            }

            conf.SetExportPath(txtBoxExportPath.Text);

            if (MaskTxtBoxFee.Text == "" || !double.TryParse(MaskTxtBoxFee.Text, out double fee))
            {

                MessageBox.Show("Lütfen geçerli bir ücret giriniz.\nÖrnek :\n Aidat - 500", "Girilen Değerde Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {

                conf.SetFee(Convert.ToDouble(MaskTxtBoxFee.Text));

            }

            if (MaskTxtBoxComm.Text == "" || !double.TryParse(MaskTxtBoxComm.Text, out double commission))
            {

                MessageBox.Show("Lütfen geçerli bir komisyon giriniz.\nÖrnek :\n Komisyon - 10,5", "Girilen Değerde Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {

                conf.SetCom(Convert.ToDouble(MaskTxtBoxComm.Text));

            }


            if (mComboBoxLanguage.SelectedIndex == 0)
            {
                conf.SetLanguage("tr");
            }
            else
            {
                conf.SetLanguage("en");
            }


            if (materialRadioButton1.Checked)
            {
                conf.SetColorSchema(1);
            }
            else if (materialRadioButton2.Checked)
            {
                conf.SetColorSchema(0);
            }
            else if (materialRadioButton3.Checked)
            {
                conf.SetColorSchema(2);
            }

            LoadSettings();
            BtnSave.Enabled = false;

        }

        // Reset button click
        private void BtnReset_Click(object sender, EventArgs e)
        {
            LoadSettings();
            BtnSave.Enabled = false;
        }

        private void BtnExportPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = txtBoxExportPath.Text;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtBoxExportPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void AddEventHandlers()
        {
            // watch for changes
            txtBoxExportPath.TextChanged += ControlChanged;
            MaskTxtBoxFee.TextChanged += ControlChanged;
            MaskTxtBoxComm.TextChanged += ControlChanged;
            mComboBoxLanguage.SelectedIndexChanged += ControlChanged;
            materialRadioButton1.CheckedChanged += ControlChanged;
            materialRadioButton2.CheckedChanged += ControlChanged;
            materialRadioButton3.CheckedChanged += ControlChanged;

            // watch for keypress
            MaskTxtBoxFee.KeyPress += new KeyPressEventHandler(MaskTxtBoxFee_KeyPress);
            MaskTxtBoxComm.KeyPress += new KeyPressEventHandler(MaskTxtBoxComm_KeyPress);
            MaskTxtBoxNewFee.KeyPress += new KeyPressEventHandler(MaskTxtBoxFee_KeyPress);
            MaskTxtBoxNewComm.KeyPress += new KeyPressEventHandler(MaskTxtBoxComm_KeyPress);
        }


        private void ControlChanged(object sender, EventArgs e)
        {

            BtnSave.Enabled = true;

        }



        private void MaskTxtBoxFee_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void MaskTxtBoxComm_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }


        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (materialTabControl1.SelectedTab == settingsPage)
            {
                CheckChangesAndEnableSaveButton();

            }
            else
            {
                BtnSave.Enabled = false;
            }

        }

        private void CheckChangesAndEnableSaveButton()
        {

            bool hasChanged = false;
            if (txtBoxExportPath.Text != exportPathS ||
                Convert.ToDouble(MaskTxtBoxFee.Text) != feeS ||
                Convert.ToDouble(MaskTxtBoxComm.Text) != comS ||
                /*mComboBoxLanguage.SelectedItem.ToString() != languageS ||*/
                (themeSwitch.Checked ? 1 : 0) != themeS)
            {
                hasChanged = true;
            }

            BtnSave.Enabled = hasChanged;
        }

        private void themeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            // if checked
            if (themeSwitch.Checked)
            {

                this.materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

                pictureBoxPTlogo.Image = Properties.Resources.ptLogoDark;
                pictureBoxMainLogo.Image = Properties.Resources.logo_dark;
            }
            else
            {

                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                pictureBoxPTlogo.Image = Properties.Resources.ptLogoWhite;

                pictureBoxMainLogo.Image = Properties.Resources.logo_light;

            }
        }








        /*****************/
        public void SeconderyColorTheme()
        {

            materialSkinManager.ColorScheme = new ColorScheme(// Teal & Amber Tema
                unchecked((Primary)0xFF009688), // Primary
                unchecked((Primary)0xFF00796B), // Dark Primary
                unchecked((Primary)0xFFB2DFDB), // Light Primary
                unchecked((Accent)0xFFFFC107),  // Accent
                TextShade.WHITE                 // Text Color
                );

        }
        public void PrimaryColorTheme()
        {
            materialSkinManager.ColorScheme = new ColorScheme(
                // Koyu Mavi & Pembe Tema
                unchecked((Primary)0xFF303F9F), // Primary
                unchecked((Primary)0xFF3F51B5), // Dark Primary
                unchecked((Primary)0xFFC5CAE9), // Light Primary
                unchecked((Accent)0xFFFF4081),  // Accent
                TextShade.WHITE                 // Text Color
                                );

        }
        public void TertiaryColorTheme()
        {
            materialSkinManager.ColorScheme = new ColorScheme(// Deep Purple & Lime Tema
                unchecked((Primary)0xFF673AB7), // Primary
                unchecked((Primary)0xFF512DA8), // Dark Primary
                unchecked((Primary)0xFFD1C4E9), // Light Primary
                unchecked((Accent)0xFFCDDC39),  // Accent
                TextShade.WHITE);

        }

        /*****************/

        // material radio button color change
        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PrimaryColorTheme();
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SeconderyColorTheme();
        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            TertiaryColorTheme();
        }

        #endregion
        /***************************************** Settings End *****************************************/


        // Folder select button click

        private void BtnFolderSelect_Click(object sender, EventArgs e)
        {

            folderPath = ptOperations.FolderSelect();
            txtBoxFolderPath.Text = folderPath;
            if (folderPath != null)
            {
                pdfFiles = ptOperations.getPdfFiles(folderPath);

                if (pdfFiles != null)
                {
                    labelPtInfo.Text = "*** " + pdfFiles.Length + " Adet Fatura Bulundu.";

                    BtnCalculate.Enabled = true;

                }
                else
                {
                    labelPtInfo.Text = "** Fatura Bulunamadı!!";
                }

            }


        }





        // ***** HEsaplama sonrasi formu yenile *****

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            OpenFormProgress();
        }

        #region RefreshMainForm
        private void OpenFormProgress()
        {
            this.Hide();

            FormProgress formProgress = new FormProgress();
            // evente metod at
            formProgress.ProgressCompleted += FormProgress_ProgressCompleted;

            formProgress.ShowDialog();

            // event isleyiciyi kaldir
            formProgress.ProgressCompleted -= FormProgress_ProgressCompleted;


            formProgress.Dispose();
        }

        // tetiklenince formu yenile
        private void FormProgress_ProgressCompleted(object sender, EventArgs e)
        {
            RefreshMainForm();
        }

        private void RefreshMainForm()
        {
            this.Show();
            pdfFiles = null;
            txtBoxFolderPath.Clear();
            BtnCalculate.Enabled = false;
            labelPtInfo.Text = "**Öncelikle Faturaların Bulunduğu Klasörü Seçmelisiniz.";
        }





        #endregion




        #region Statistic

        private void mRadioBtnColumn_CheckedChanged(object sender, EventArgs e)
        {
            cartesianChart1.Series = null;
            var models = statistics.ReadExcelFile(statisticsPath);
            if (models != null)
            {
                cartesianChart1.Series = statistics.OrderedColumn(models);
            }

        }

        private void mRadioBtnStacked_CheckedChanged(object sender, EventArgs e)
        {
            cartesianChart1.Series = null;
            var models = statistics.ReadExcelFile(statisticsPath);
            if (models != null)
            {
                cartesianChart1.Series = statistics.StackedColumn(models);
            }

        }

        private void mBtnFileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xlsm;*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mBtnCalculateStatistic.Enabled = true;


                statisticsPath = openFileDialog.FileName;

                mBtnFileSelect.Text = "Değiştir";
            }
        }
        private void mBtnCalculateStatistic_Click(object sender, EventArgs e)
        {

            mBtnFileSelect.Text = "Dosya Seç";
            mBtnFileSelect.Enabled = false;
            mBtnClear.Enabled = true;
            mCbxPreview.Enabled = true;
            tableLayoutPanelRadio.Enabled = true;

            statisticModels = statistics.ReadExcelFile(statisticsPath);

            if (statisticModels != null)
            {
                mLabelTInvoice.Text = statistics.TotalInvoice(statisticModels).ToString("N2");
                mLabelTProfit.Text = statistics.TotalProfit(statisticModels).ToString("N2");

                // PieChart'ı doldur
                pieChart1.Series = statistics.PieChart(statisticModels);

                // StackedColumn grafiğini doldur
                cartesianChart1.Series = statistics.StackedColumn(statisticModels);




                // materialListView1'ı doldur
                mListViewTable.Items.Clear();
                var p = statistics.TotalProfit(statisticModels);
                foreach (var model in statisticModels)
                {
                    var item = new ListViewItem();
                    item.SubItems[0].Text = model.nameSurname;
                    item.SubItems.Add(model.tInvoice.ToString());
                    item.SubItems.Add(model.fee.ToString());
                    item.SubItems.Add(model.commission.ToString());
                    item.SubItems.Add((model.fee + model.commission).ToString());
                    item.SubItems.Add(((model.fee + model.commission) / p * 100).ToString("N6"));
                    mListViewTable.Items.Add(item);
                }





                mCardTable.Enabled = true;
                mBtnCalculateStatistic.Enabled = false;
            }


        }
        // Steacked Column Basic Column change
        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (mCbxPreview.Checked)
            {
                mCardPreview.Enabled = true;
                solidGauge1.Visible = true;
            }
            else
            {
                mCardPreview.Enabled = false;
                //solidGauge1.Visible = false;
            }
        }

        private void mBtnClear_Click(object sender, EventArgs e)
        {
            statisticsPath = "";
            if (statisticModels != null)
            {
                statisticModels.Clear();
            }


            mLabelTInvoice.Text = "0,00";
            mLabelTProfit.Text = "0,00";
            pieChart1.Series = null;
            mRadioBtnStacked.Checked = true;
            cartesianChart1.Series = null;
            tableLayoutPanelRadio.Enabled = false;
            mListViewTable.Items.Clear();
            MaskTxtBoxNewFee.Text = "";
            MaskTxtBoxNewComm.Text = "";
            statistics.UpdateSolidGauge(solidGauge1);
            labelTest.Text = "0,00";

            //mRadioBtnEarn.Checked = false;
            //mRadioBtnName.Checked = false;
            if (!mRadioBtnStacked.Checked)
            {
                mRadioBtnStacked.Checked = true;
            }
            if (mRadioBtnEarn.Checked)
            {
                mRadioBtnEarn.Checked = false;
            }
            else if (mRadioBtnName.Checked)
            {
                mRadioBtnName.Checked = false;
            }

            mCardTable.Enabled = false;
            mCardPreview.Enabled = false;
            mCbxPreview.Checked = false;
            mCbxPreview.Enabled = false;
            mBtnFileSelect.Enabled = true;


            mBtnClear.Enabled = false;


        }

        private void mBtnPreview_Click(object sender, EventArgs e)
        {
            //clear solid gauge


            double oldIncome = statistics.TotalProfit(statisticModels);
            // check if new fee and commission is empty or not double
            if (MaskTxtBoxNewFee.Text == "" || MaskTxtBoxNewComm.Text == "" || !double.TryParse(MaskTxtBoxNewFee.Text, out double fee) || !double.TryParse(MaskTxtBoxNewComm.Text, out double comm))
            {
                MessageBox.Show("Lütfen geçerli bir ücret ve komisyon giriniz.\nÖrnek :\n Aidat - 500\n Komisyon - 10,5", "Girilen Değerlerde Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                List<PaketTaxiModel> statisticModelsPreview = new List<PaketTaxiModel>(statisticModels);

                double newIncome = statistics.UpdateFeesAndCommissions(statisticModelsPreview, Convert.ToDouble(MaskTxtBoxNewFee.Text), Convert.ToDouble(MaskTxtBoxNewComm.Text));

                double percentageChange = statistics.CalculatePercentageChange(oldIncome, newIncome);


                labelTest.Text = $"{Math.Round(newIncome - oldIncome):N2}";


                statistics.UpdateSolidGauge(solidGauge1, percentageChange);



            }



        }

        private void mRadioBtnName_CheckedChanged(object sender, EventArgs e)
        {
            if (mRadioBtnName.Checked)
            {
                mListViewTable.Items.Clear();
                var p = statistics.TotalProfit(statisticModels);
                foreach (var model in statisticModels.OrderBy(x => x.nameSurname))
                {
                    var item = new ListViewItem();
                    item.SubItems[0].Text = model.nameSurname;
                    item.SubItems.Add(model.tInvoice.ToString());
                    item.SubItems.Add(model.fee.ToString());
                    item.SubItems.Add(model.commission.ToString());
                    item.SubItems.Add((model.fee + model.commission).ToString());
                    item.SubItems.Add(((model.fee + model.commission) / p * 100).ToString("N6"));
                    mListViewTable.Items.Add(item);
                }
            }
        }

        private void mRadioBtnEarn_CheckedChanged(object sender, EventArgs e)
        {
            if (mRadioBtnEarn.Checked)
            {
                mListViewTable.Items.Clear();
                var p = statistics.TotalProfit(statisticModels);
                foreach (var model in statisticModels.OrderByDescending(x => x.fee + x.commission))
                {
                    var item = new ListViewItem();
                    item.SubItems[0].Text = model.nameSurname;
                    item.SubItems.Add(model.tInvoice.ToString());
                    item.SubItems.Add(model.fee.ToString());
                    item.SubItems.Add(model.commission.ToString());
                    item.SubItems.Add((model.fee + model.commission).ToString());
                    item.SubItems.Add(((model.fee + model.commission) / p * 100).ToString("N6"));
                    mListViewTable.Items.Add(item);
                }
            }
        }

      #endregion


    }
}
