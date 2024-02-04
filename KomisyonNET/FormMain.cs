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

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange700, Primary.Pink900, Primary.Yellow500, Accent.Purple200, TextShade.BLACK);

            // all text poppins font family
            foreach (Control c in this.Controls)
            {
                if (c is MaterialLabel ||  c is MaterialRadioButton || c is MaterialDivider || c is MaterialTabControl || c is MaterialTabSelector || c is MaterialListView || c is MaterialProgressBar || c is MaterialRadioButton || c is MaterialDivider || c is MaterialTabControl || c is MaterialTabSelector || c is MaterialListView || c is MaterialProgressBar || c is MaterialRadioButton || c is MaterialDivider || c is MaterialTabControl || c is MaterialTabSelector || c is MaterialListView || c is MaterialProgressBar || c is MaterialRadioButton || c is MaterialDivider || c is MaterialTabControl || c is MaterialTabSelector || c is MaterialListView || c is MaterialProgressBar || c is MaterialRadioButton || c is MaterialDivider || c is MaterialTabControl || c is MaterialTabSelector || c is MaterialListView || c is MaterialProgressBar || c is MaterialRadioButton || c is MaterialDivider || c is MaterialTabControl || c is MaterialTabSelector || c is MaterialListView || c is MaterialProgressBar || c is MaterialRadioButton || c is MaterialDivider || c is MaterialTabControl || c is MaterialTabSelector || c is MaterialListView || c is MaterialProgressBar)
                {
                    c.Font = new Font("Poppins", c.Font.Size, c.Font.Style);
                }
            }

            // label1 font family poppins
            
            
            
        }
    }
}
