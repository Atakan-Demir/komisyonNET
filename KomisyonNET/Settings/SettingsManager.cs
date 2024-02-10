using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisyonNET.Settings
{
    internal class SettingsManager
    {

        public int GetTheme()
        {
            return (int)Properties.Settings.Default.themeS;
        }

        public void SetTheme(int themeS)
        {
            Properties.Settings.Default.themeS = themeS;
            Properties.Settings.Default.Save();
        }
    }
}
