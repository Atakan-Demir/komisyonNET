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
            return (int)Properties.Settings.Default.theme;
        }

        public void SetTheme(int theme)
        {
            Properties.Settings.Default.theme = theme;
            Properties.Settings.Default.Save();
        }
    }
}
