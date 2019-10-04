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
    public partial class SelectAiportsWithCountPlaneMoreThenTen : Form
    {
        public SelectAiportsWithCountPlaneMoreThenTen()
        {
            InitializeComponent();
            sqlDataSource1.Fill();
        }
    }
}
