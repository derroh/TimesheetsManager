using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TimesheetsManager
{
    public partial class Dashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Dashboard()
        {
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            barStaticItem_User.Caption = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            barStaticItem1.Caption = "";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Thread.Sleep(8000);
        }
    }
}
