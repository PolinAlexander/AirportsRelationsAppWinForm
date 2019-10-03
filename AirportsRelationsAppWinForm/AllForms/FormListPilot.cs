using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirportsRelationsApp.Module.BusinessObjects;
using AirportsRelationsAppWinForm.AllForms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;

namespace AirportsRelationsAppWinForm
{
    public partial class FormListPilot : Form
    {
        public FormListPilot()
        {
            InitializeComponent();
        }

        private void InsertSimpleButton_Click(object sender, EventArgs e)
        {
            FormPilot plForm = new FormPilot();
            DialogResult result = plForm.ShowDialog(this);

            if (result == DialogResult.Cancel) return;

            Pilot pilot = new Pilot(xpCollection1.Session);
            pilot.PilotName = plForm.textEdit1.Text;
            if (plForm.comboBoxEdit1 != null)
            {
                var nameAirport = plForm.comboBoxEdit1.ToString();
                var airport = xpCollection1.OfType<Airport>().FirstOrDefault(n => n.ToString() == nameAirport);
                pilot.Airport = airport;                
            }
            if(plForm.comboBoxEdit2 != null)
            {
                var namePlane = plForm.comboBoxEdit2.ToString();
                var plane = xpCollection1.OfType<Plane>().FirstOrDefault(n => n.ToString() == namePlane);
                pilot.Planes.Add(plane);                
            }
            if(result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(pilot.PilotName)) { throw new ArgumentException("Field cannot be empty", "PilotName"); }
                xpCollection1.Add(pilot);
                MessageBox.Show($"Added new pilot - {pilot.PilotName}");
            }
            
        }
        
    }
}
