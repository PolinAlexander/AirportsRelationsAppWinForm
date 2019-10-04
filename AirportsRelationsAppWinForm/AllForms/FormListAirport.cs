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
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;

namespace AirportsRelationsAppWinForm
{
    public partial class FormListAirport : Form
    {
        public FormListAirport()
        {
            InitializeComponent();            
        }

        private void InsertSimpleButton_Click(object sender, EventArgs e)
        {
            FormAirportInsert plForm = new FormAirportInsert();
            DialogResult result = plForm.ShowDialog(this);

            if (result == DialogResult.Cancel) return;

            Airport airport = new Airport(xpCollection1.Session);
            airport.AirportName = plForm.textEdit1.Text;
            var namePilot = plForm.comboBoxEdit2.ToString();
            var pilot = xpCollection1.OfType<Pilot>().FirstOrDefault(n => n.ToString() == namePilot);
            airport.Pilots.Add(pilot);
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(pilot.PilotName)) { throw new ArgumentException("Field cannot be empty", "PilotName"); }
                xpCollection1.Add(airport);
                session1.Save(airport);
                MessageBox.Show($"Added new airport - {airport.AirportName}");
            }

        }
    }
}
