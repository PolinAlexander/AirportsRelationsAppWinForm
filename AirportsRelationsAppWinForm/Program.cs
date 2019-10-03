using AirportsRelationsAppWinForm.AllForms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System;
using System.Windows.Forms;

namespace AirportsRelationsAppWinForm
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string ConnectionString = @"XpoProvider=MSSqlServer;data source=(localdb)\MSSQLLocalDB;integrated security=SSPI;initial catalog=AirportsRelationsWF";
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(ConnectionString, AutoCreateOption.DatabaseAndSchema);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            Application.Run(new MainForm());
        }
    }
}
