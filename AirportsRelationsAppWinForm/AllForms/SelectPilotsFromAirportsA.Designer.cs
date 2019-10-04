namespace AirportsRelationsAppWinForm.AllForms
{
    partial class SelectPilotsFromAirportsA
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPilotName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPilotName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPilotName});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // colPilotName
            // 
            this.colPilotName.FieldName = "PilotName";
            this.colPilotName.MinWidth = 25;
            this.colPilotName.Name = "colPilotName";
            this.colPilotName.Visible = true;
            this.colPilotName.VisibleIndex = 0;
            this.colPilotName.Width = 94;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource1;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "Query";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 426);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "AirportsRelationsWF";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "SELECT [PilotName]\r\nFROM [AirportsRelationsWF].[dbo].[Airport] AS air\r\nINNER JOIN" +
    " [AirportsRelationsWF].[dbo].[Pilot] AS p\r\nON p.[Airport] = air.[OID]\r\nWHERE [Ai" +
    "rportName] LIKE \'a%\';";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlF1ZXJ5Ij48RmllbGQgTmFtZ" +
    "T0iUGlsb3ROYW1lIiBUeXBlPSJTdHJpbmciIC8+PC9WaWV3PjwvRGF0YVNldD4=";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPilotName1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colPilotName1
            // 
            this.colPilotName1.FieldName = "PilotName";
            this.colPilotName1.MinWidth = 25;
            this.colPilotName1.Name = "colPilotName1";
            this.colPilotName1.Visible = true;
            this.colPilotName1.VisibleIndex = 0;
            this.colPilotName1.Width = 94;
            // 
            // SelectPilotsFromAirportsA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "SelectPilotsFromAirportsA";
            this.Text = "SelectPilotsFromAirportsA";
            this.Load += new System.EventHandler(this.SelectPilotsFromAirportsA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPilotName;
        private DevExpress.XtraGrid.Columns.GridColumn colPilotName1;
    }
}