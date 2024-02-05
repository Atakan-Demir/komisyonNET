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

namespace KomisyonNET
{
    public partial class FormMain : MaterialForm
    {
        public FormMain()
        {
            InitializeComponent();
            /*
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            
            // Renk şemasını ayarla
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey800, // Primary color (Koyu gri, şıklık ve asaleti temsil eder)
                Primary.Grey900, // Dark primary color (Daha koyu gri, derinlik katar)
                Primary.Grey500, // Light primary color (Açık gri, kontrast sağlar)
                Accent.Lime200,  // Accent color (Canlı lime rengi, önemli öğeleri vurgular)
                TextShade.WHITE  // Text color (Beyaz metin, okunabilirlik için)
            );
            */
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Renk şemasını ayarla
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey500, // Primary color (Mavi-gri, sakin ve profesyonel)
                Primary.BlueGrey700, // Dark primary color (Daha koyu mavi-gri, derinlik katar)
                Primary.BlueGrey100, // Light primary color (Açık mavi-gri, yumuşaklık sağlar)
                Accent.Orange400,  // Accent color (Canlı turuncu, dikkat çekici ve enerjik)
                TextShade.BLACK  // Text color (Siyah metin, netlik ve okunabilirlik için)
            );


            // MaterialSwitch kontrolünü tanımla (örneğin, formunuzda themeSwitch adında bir switch varsa)
            MaterialSwitch themeSwitch = this.themeSwitch;

            // Switch'in arka plan rengini, temanın birincil rengi olarak ayarla
            themeSwitch.BackColor = materialSkinManager.ColorScheme.AccentColor;


            // all text poppins font family
            foreach (Control c in this.Controls)
            {
                if (c is MaterialLabel ||c is MaterialSwitch || c is MaterialRadioButton || c is MaterialDivider || c is MaterialTabControl || c is MaterialTabSelector || c is MaterialListView || c is MaterialProgressBar || c is MaterialRadioButton || c is MaterialDivider || c is MaterialTabControl || c is MaterialTabSelector || c is MaterialListView || c is MaterialProgressBar || c is MaterialRadioButton || c is MaterialDivider || c is MaterialTabControl || c is MaterialTabSelector || c is MaterialListView || c is MaterialProgressBar || c is MaterialRadioButton || c is MaterialDivider || c is MaterialTabControl || c is MaterialTabSelector || c is MaterialListView || c is MaterialProgressBar || c is MaterialRadioButton || c is MaterialDivider || c is MaterialTabControl || c is MaterialTabSelector || c is MaterialListView || c is MaterialProgressBar || c is MaterialRadioButton || c is MaterialDivider || c is MaterialTabControl || c is MaterialTabSelector || c is MaterialListView || c is MaterialProgressBar || c is MaterialRadioButton || c is MaterialDivider || c is MaterialTabControl || c is MaterialTabSelector || c is MaterialListView || c is MaterialProgressBar)
                {
                    c.Font = new Font("Poppins", c.Font.Size, c.Font.Style);
                }
            }
            themeSwitch.Font = new Font("Poppins", themeSwitch.Font.Size, themeSwitch.Font.Style);
            // label1 font family poppins



        }

        private void themeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            // if checked
            if (themeSwitch.Checked)
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

                // Renk şemasını ayarla
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Grey800, // Primary color (Koyu gri, şıklık ve asaleti temsil eder)
                    Primary.Grey900, // Dark primary color (Daha koyu gri, derinlik katar)
                    Primary.Grey500, // Light primary color (Açık gri, kontrast sağlar)
                    Accent.Lime200,  // Accent color (Canlı lime rengi, önemli öğeleri vurgular)
                    TextShade.WHITE  // Text color (Beyaz metin, okunabilirlik için)
                );

                FormMain.DefaultForeColor = Color.White;
            }
            else
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                // Renk şemasını ayarla
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.BlueGrey500, // Primary color (Mavi-gri, sakin ve profesyonel)
                    Primary.BlueGrey700, // Dark primary color (Daha koyu mavi-gri, derinlik katar)
                    Primary.BlueGrey100, // Light primary color (Açık mavi-gri, yumuşaklık sağlar)
                    Accent.Orange400,  // Accent color (Canlı turuncu, dikkat çekici ve enerjik)
                    TextShade.BLACK  // Text color (Siyah metin, netlik ve okunabilirlik için)
                );

            }
        }
    }
}
