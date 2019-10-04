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
    public partial class FormListPlane : Form
    {
        private void dataGridView1_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && dataGridView1.Columns[e.ColumnIndex].Name.Equals("planeNameDataGridViewTextBoxColumn"))
            {
                if (e.Value.ToString().Contains('A')) { e.CellStyle.ForeColor = Color.Green; }
            }
        }
        public FormListPlane()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
        }

        private void InsertSimpleButton_Click(object sender, EventArgs e)
        {
            FormPlane plForm = new FormPlane();
            DialogResult result = plForm.ShowDialog(this);

            if (result == DialogResult.Cancel) return;

            Plane plane = new Plane(xpCollection1.Session);
            var planeName = plForm.textEdit1.Text;
            if (planeName.Length > 199) planeName = null;
            if (plForm.comboBoxEdit1 != null)
            {
                var nameAirport = plForm.comboBoxEdit1.ToString();
                var airport = xpCollection1.OfType<Airport>().FirstOrDefault(n => n.ToString() == nameAirport);
                plane.Airport = airport;
            }
            if (plForm.comboBoxEdit2 != null)
            {
                var namePilot = plForm.comboBoxEdit2.ToString();
                var pilot = xpCollection1.OfType<Pilot>().FirstOrDefault(n => n.ToString() == namePilot);
                plane.Pilots.Add(pilot);
            }
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(planeName))
                {
                    MessageBox.Show("Field cannot be empty");
                    return;
                    //throw new ArgumentException("Field cannot be empty", "PilotName"); 
                }
                plane.PlaneName = planeName;
                xpCollection1.Add(plane);
                MessageBox.Show($"Added new pilot - {plane.PlaneName}");
            }

        }

    }
}
