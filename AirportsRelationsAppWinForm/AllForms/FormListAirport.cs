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
    public partial class FormListAirport : Form
    {
        public FormListAirport()
        {
            InitializeComponent();
            //listBox1.DataSource = xpCollection1.LoadAsync();
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
            xpCollection1.Add(airport);
            MessageBox.Show($"Added new airport - {airport.AirportName}");

        }
    }
}
