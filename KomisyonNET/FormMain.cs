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

        // get username
        private string userName = Environment.UserName;
        //private string exportPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private string folderPath;



        // constructor
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

            if (MaskTxtBoxFee.Text != "")
            {
               conf.SetFee(Convert.ToDouble(MaskTxtBoxFee.Text));
            }
            
            if (MaskTxtBoxComm.Text != "")
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

            }
            else
            {

                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                pictureBoxPTlogo.Image = Properties.Resources.ptLogoWhite;

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
                pdfFiles=ptOperations.getPdfFiles(folderPath);

                if (pdfFiles != null)
                {
                    labelPtInfo.Text = "*** " + pdfFiles.Length + " Adet Fatura Bulundu.";

                    BtnCalculate.Enabled = true;

                    foreach (var item in pdfFiles)
                    {
                        richTextBox1.AppendText(item + "\n");
                    }
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
            FormProgress formProgress = new FormProgress();
            // evente metod at
            formProgress.ProgressCompleted += FormProgress_ProgressCompleted;

            formProgress.ShowDialog();

            // event isleyiciyi kaldir
            formProgress.ProgressCompleted -= FormProgress_ProgressCompleted;


            formProgress.Dispose();
        }

        // Event tetiklendiğinde çağrılacak metod
        private void FormProgress_ProgressCompleted(object sender, EventArgs e)
        {
            // Burada FormMain'i yenileyebilirsiniz
            RefreshMainForm();
        }

        private void RefreshMainForm()
        {
            pdfFiles = null;
            txtBoxFolderPath.Clear();
            BtnCalculate.Enabled = false;
            labelPtInfo.Text = "**Öncelikle Faturaların Bulunduğu Klasörü Seçmelisiniz.";
        }





        #endregion




        #region Statistic

       


        
        #endregion

        

       

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xlsm;*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;
                PaketTaxiStatistics statistics = new PaketTaxiStatistics();
                var models = statistics.ReadExcelFile(filePath);

                // PieChart'ı doldur
                pieChart1.Series = statistics.CreatePieChart(models);



                // StackedColumn grafiğini doldur
                cartesianChart1.Series = statistics.CreateStackedColumnForCommissionsAndFees(models);

                // Column grafiğini doldur
                cartesianChart2.Series = statistics.CM(models);
                cartesianChart2.AxisY.Clear();
                cartesianChart2.AxisX.Clear();


                // SolidGauge'ı doldur
                double averageAbove = statistics.CalculateAverageCommissionAbove(models);
                solidGauge1.From = 0;
                solidGauge1.To = models.Count;
                solidGauge1.Value = averageAbove;
                solidGauge1.LabelFormatter = val => val + " kişi ortalamanın üstünde";

                // materialListView1'ı doldur
                materialListView1.Items.Clear();
                
                foreach (var model in models)
                {
                    var item = new ListViewItem();
                    item.SubItems[0].Text = model.nameSurname;
                    item.SubItems.Add(model.tInvoice.ToString());
                    item.SubItems.Add(model.fee.ToString());
                    item.SubItems.Add(model.commission.ToString());
                    materialListView1.Items.Add(item);
                }
            }
        }
    }
}
