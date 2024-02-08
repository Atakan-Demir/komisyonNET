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
namespace KomisyonNET
{
    public partial class FormMain : MaterialForm
    {
        // settings manager
        private SettingsManager conf = new SettingsManager();
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public FormMain()
        {
            InitializeComponent();
            
            
            
            materialSkinManager.AddFormToManage(this);
            /*
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Renk şemasını ayarla
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey500, // Primary color (Mavi-gri, sakin ve profesyonel)
                Primary.BlueGrey700, // Dark primary color (Daha koyu mavi-gri, derinlik katar)
                Primary.BlueGrey100, // Light primary color (Açık mavi-gri, yumuşaklık sağlar)
                Accent.Orange400,  // Accent color (Canlı turuncu, dikkat çekici ve enerjik)
                TextShade.BLACK  // Text color (Siyah metin, netlik ve okunabilirlik için)
            );
            */

            
         


            



            // conf.settings dosyasından tema bilgisi oku
            int theme = conf.GetTheme();
             
            label1.Text = theme.ToString();
            if (theme == 1)
            {
                themeSwitch.Checked = true;
            }
            else
            {
                themeSwitch.Checked = false;
            }


        }

        private void themeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            // if checked
            if (themeSwitch.Checked)
            {
                
                this.materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

                /*
                // Renk şemasını ayarla
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Grey800, // Primary color (Koyu gri, şıklık ve asaleti temsil eder)
                    Primary.Grey900, // Dark primary color (Daha koyu gri, derinlik katar)
                    Primary.Grey500, // Light primary color (Açık gri, kontrast sağlar)
                    Accent.Lime200,  // Accent color (Canlı lime rengi, önemli öğeleri vurgular)
                    TextShade.WHITE  // Text color (Beyaz metin, okunabilirlik için)
                );
                */
                
            }
            else
            {
                
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                /*
                // Renk şemasını ayarla
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.BlueGrey500, // Primary color (Mavi-gri, sakin ve profesyonel)
                    Primary.BlueGrey700, // Dark primary color (Daha koyu mavi-gri, derinlik katar)
                    Primary.BlueGrey100, // Light primary color (Açık mavi-gri, yumuşaklık sağlar)
                    Accent.Orange400,  // Accent color (Canlı turuncu, dikkat çekici ve enerjik)
                    TextShade.BLACK  // Text color (Siyah metin, netlik ve okunabilirlik için)
                );
                */
            }












        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (themeSwitch.Checked)
            {
                conf.SetTheme(1);
            }
            else
            {
                conf.SetTheme(0);
            }
        }


        public void ApplyOrangeTheme()
        {
       
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Orange800, // Primary
                MaterialSkin.Primary.Orange900, // Dark
                MaterialSkin.Primary.Orange500, // Light
                MaterialSkin.Accent.Orange200,  // Accent
                MaterialSkin.TextShade.WHITE    // Text Color
            );
        }

        public void ApplyYellowTheme()
        {
            
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Green800,
                MaterialSkin.Primary.Green900,
                MaterialSkin.Primary.Green500,
                MaterialSkin.Accent.Green200,
                MaterialSkin.TextShade.WHITE
            );
        }

        public void ApplyBlueTheme()
        {
           
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue800,
                MaterialSkin.Primary.Blue900,
                MaterialSkin.Primary.Blue500,
                MaterialSkin.Accent.Blue200,
                MaterialSkin.TextShade.WHITE
            );
        }
        
        public void SpecialTheme()
        {
            materialSkinManager.ColorScheme = new ColorScheme((Primary)0x00C926b3, (Primary)0xA1008B, (Primary)0xDC2EFF, (Accent)0x006E70FF, TextShade.WHITE);
        }

        public void ApplyPurpleGreenLightTheme()
        {
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                Primary.Purple300, // Daha açık mor birincil renk
                Primary.Purple400, // Açık mor birincil karanlık renk
                Primary.Purple100, // Çok açık mor birincil açık renk
                Accent.LightGreen200, // Canlı yeşil vurgu rengi
                TextShade.BLACK // Metin rengi siyah
            );
        }


        public void ApplyBlueOrangeTheme()
        {
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                Primary.BlueGrey600, // Mavi gri birincil renk
                Primary.BlueGrey700, // Mavi gri birincil karanlık renk
                Primary.BlueGrey400, // Mavi gri birincil açık renk
                Accent.Orange700, // Daha koyu turuncu vurgu rengi
                TextShade.WHITE // Metin rengi beyaz
            );
        }


        public void ApplyRedPinkTheme()
        {
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                Primary.Red800, // Kırmızı birincil renk
                Primary.Red900, // Kırmızı birincil karanlık renk
                Primary.Red500, // Kırmızı birincil açık renk
                Accent.Pink200, // Pembe vurgu rengi
                TextShade.WHITE // Metin rengi
            );
        }

        public void ApplyGreenBlueTheme()
        {
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                Primary.Teal500, // Teal birincil renk
                Primary.Teal700, // Teal birincil karanlık renk
                Primary.Teal200, // Teal birincil açık renk
                Accent.LightBlue200, // Açık mavi vurgu rengi
                TextShade.WHITE // Metin rengi beyaz
            );
        }



        /*****************/
        public void ApplyTurquoisePurpleTheme()
        {
            
            materialSkinManager.ColorScheme = new ColorScheme(// Teal & Amber Tema
unchecked((Primary)0xFF009688), // Primary
unchecked((Primary)0xFF00796B), // Dark Primary
unchecked((Primary)0xFFB2DFDB), // Light Primary
unchecked((Accent)0xFFFFC107),  // Accent
TextShade.WHITE                 // Text Color
);
           
        }
        public void ApplyDarkBluePinkTheme()
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
        public void ApplyGreenYellowTheme()
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
           ApplyTurquoisePurpleTheme();
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ApplyDarkBluePinkTheme();
        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ApplyGreenYellowTheme();
        }
    }
}
