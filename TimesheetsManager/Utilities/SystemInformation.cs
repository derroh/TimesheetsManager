using DevExpress.XtraEditors;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimesheetsManager.Utilities
{
    class SystemInformation
    {
        public static void StartSysInfo(string strSysInfo)
        {
            try
            {
                Process.Start(strSysInfo);
            }
            catch (Win32Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public static bool GetMsinfo32Path(ref string strPath)
        {
            strPath = String.Empty;
            object objTmp = null;
            RegistryKey regKey = Registry.LocalMachine;

            if (regKey != null)
            {
                regKey = regKey.OpenSubKey("Software\\Microsoft\\Shared Tools\\MSInfo");
                if (regKey != null)
                    objTmp = regKey.GetValue("Path");

                if (objTmp == null)
                {
                    regKey = regKey.OpenSubKey("Software\\Microsoft\\Shared Tools Location");
                    if (regKey != null)
                    {
                        objTmp = regKey.GetValue("MSInfo");
                        if (objTmp != null)
                            strPath = Path.Combine(objTmp.ToString(), "MSInfo32.exe");
                    }
                }
                else
                    strPath = objTmp.ToString();

                try
                {
                    FileInfo fi = new FileInfo(strPath);
                    return fi.Exists;
                }
                catch (ArgumentException)
                {
                    strPath = string.Empty;
                }
            }

            return false;
        }
    }
}
