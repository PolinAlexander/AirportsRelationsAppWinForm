using AirportsRelationsApp.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportsRelationsAppWinForm
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormListAirport form1 = new FormListAirport();
            DialogResult result = form1.ShowDialog(this);

            if (result == DialogResult.Cancel) return;

            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormListAirport form1 = new FormListAirport();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
