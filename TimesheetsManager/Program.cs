using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Drawing;

namespace TimesheetsManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();

            UserLookAndFeel.Default.SetSkinStyle("Metropolis");

            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 8.25F);
            Application.Run(new Dashboard());
        }
    }
}
