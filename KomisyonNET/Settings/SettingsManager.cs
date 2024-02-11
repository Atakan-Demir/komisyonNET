using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisyonNET.Settings
{
    internal class SettingsManager
    {

        /* ***** Theme ***** */
        public int GetTheme()
        {
            return (int)Properties.Settings.Default.themeS;
        }

        public void SetTheme(int themeS)
        {
            Properties.Settings.Default.themeS = themeS;
            Properties.Settings.Default.Save();
        }

        /* ***** Color Schema ***** */

        public int GetColorSchema()
        {
            return (int)Properties.Settings.Default.colorSchemaS;
        }

        public void SetColorSchema(int colorSchemaS)
        {
            Properties.Settings.Default.colorSchemaS = colorSchemaS;
            Properties.Settings.Default.Save();
        }


        /* ***** Language ***** */

        public string GetLanguage()
        {
            return Properties.Settings.Default.languageS;
        }

        public void SetLanguage(string language)
        {
            Properties.Settings.Default.languageS = language;
            Properties.Settings.Default.Save();
        }

        /* ***** Export Path ***** */

        public string GetExportPath()
        {
            return Properties.Settings.Default.exportPathS;
        }

        public void SetExportPath(string exportPath)
        {
            Properties.Settings.Default.exportPathS = exportPath;
            Properties.Settings.Default.Save();
        }

        /* ***** Fee ***** */

        public double GetFee()
        {
            return Properties.Settings.Default.feeS;
        }

        public void SetFee(double fee)
        {
            Properties.Settings.Default.feeS = fee;
            Properties.Settings.Default.Save();
        }


        /* ***** Com ***** */

        public double GetCom()
        {
            return Properties.Settings.Default.comS;
        }

        public void SetCom(double com)
        {
            Properties.Settings.Default.comS = com;
            Properties.Settings.Default.Save();
        }


        /* ***** IsFt ***** */

        public bool GetIsFt()
        {
            return Properties.Settings.Default.isFtS;
        }

        public void SetIsFt(bool isFt)
        {
            Properties.Settings.Default.isFtS = isFt;
            Properties.Settings.Default.Save();
        }

       
    }
}
