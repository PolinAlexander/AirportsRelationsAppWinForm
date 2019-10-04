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
    public partial class SelectPilotWIthP : Form
    {
        public SelectPilotWIthP()
        {
            InitializeComponent();
            sqlDataSource1.Fill();
        }
    }
}
