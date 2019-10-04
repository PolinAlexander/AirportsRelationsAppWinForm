using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportsRelationsAppWinForm.AllForms
{
    public partial class SelectPilotsFromAirportsA : Form
    {
        public SelectPilotsFromAirportsA()
        {
            InitializeComponent();            
            sqlDataSource1.Fill();
        }

        private void SelectPilotsFromAirportsA_Load(object sender, EventArgs e)
        {

        }
    }
}
