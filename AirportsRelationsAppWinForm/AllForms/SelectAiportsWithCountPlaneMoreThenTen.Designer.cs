namespace AirportsRelationsAppWinForm.AllForms
{
    partial class SelectAiportsWithCountPlaneMoreThenTen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAirportName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcountPlane = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "AirportsRelationsWF";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "SELECT AirportName, COUNT(PilotName) AS countPlane\r\nFROM Airport AS a INNER JOIN " +
    "Pilot AS p ON a.OID = p.Airport\r\nGROUP BY AirportName\r\nHAVING COUNT(PilotName) >" +
    " 10;\r\n";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlF1ZXJ5Ij48RmllbGQgTmFtZ" +
    "T0iQWlycG9ydE5hbWUiIFR5cGU9IlN0cmluZyIgLz48RmllbGQgTmFtZT0iY291bnRQbGFuZSIgVHlwZ" +
    "T0iSW50MzIiIC8+PC9WaWV3PjwvRGF0YVNldD4=";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(788, 438);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAirportName,
            this.colcountPlane});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colAirportName
            // 
            this.colAirportName.FieldName = "AirportName";
            this.colAirportName.MinWidth = 25;
            this.colAirportName.Name = "colAirportName";
            this.colAirportName.Visible = true;
            this.colAirportName.VisibleIndex = 0;
            this.colAirportName.Width = 94;
            // 
            // colcountPlane
            // 
            this.colcountPlane.FieldName = "countPlane";
            this.colcountPlane.MinWidth = 25;
            this.colcountPlane.Name = "colcountPlane";
            this.colcountPlane.OptionsFilter.AllowFilter = false;
            this.colcountPlane.Visible = true;
            this.colcountPlane.VisibleIndex = 1;
            this.colcountPlane.Width = 94;
            // 
            // SelectAiportsWithCountPlaneMoreThenTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "SelectAiportsWithCountPlaneMoreThenTen";
            this.Text = "SelectAiportsWithCountPlaneMoreThenTen";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAirportName;
        private DevExpress.XtraGrid.Columns.GridColumn colcountPlane;
    }
}