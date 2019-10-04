namespace AirportsRelationsAppWinForm
{
    partial class FormListPilot
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPlaneName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.insertSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.modifySimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.session1 = new DevExpress.Xpo.Session(this.components);
            this.unitOfWork2 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.xpServerCollectionSource2 = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.colPilotName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlaneName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPlaneName,
            this.colPlaneName1});
            this.gridView2.CustomizationFormBounds = new System.Drawing.Rectangle(460, 621, 322, 241);
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // colPlaneName
            // 
            this.colPlaneName.FieldName = "PlaneName";
            this.colPlaneName.MinWidth = 25;
            this.colPlaneName.Name = "colPlaneName";
            this.colPlaneName.Width = 94;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpServerCollectionSource2;
            gridLevelNode3.LevelTemplate = this.gridView2;
            gridLevelNode3.RelationName = "Planes";
            gridLevelNode2.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            gridLevelNode2.RelationName = "Pilots";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "Airport";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(774, 391);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.DefaultSorting = "Airport ASC";
            this.xpServerCollectionSource1.DisplayableProperties = "PilotName;Airport;Planes";
            this.xpServerCollectionSource1.ObjectType = typeof(AirportsRelationsApp.Module.BusinessObjects.Pilot);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPilotName,
            this.gridColumn1});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1051, 444, 322, 241);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Planes", null, "")});
            this.gridView1.Name = "gridView1";
            // 
            // insertSimpleButton
            // 
            this.insertSimpleButton.Location = new System.Drawing.Point(13, 409);
            this.insertSimpleButton.Name = "insertSimpleButton";
            this.insertSimpleButton.Size = new System.Drawing.Size(94, 29);
            this.insertSimpleButton.TabIndex = 0;
            this.insertSimpleButton.Text = "Insert";
            this.insertSimpleButton.Click += new System.EventHandler(this.InsertSimpleButton_Click);
            // 
            // modifySimpleButton
            // 
            this.modifySimpleButton.Location = new System.Drawing.Point(353, 409);
            this.modifySimpleButton.Name = "modifySimpleButton";
            this.modifySimpleButton.Size = new System.Drawing.Size(94, 29);
            this.modifySimpleButton.TabIndex = 1;
            this.modifySimpleButton.Text = "Modify";
            // 
            // DeleteSimpleButton
            // 
            this.DeleteSimpleButton.Location = new System.Drawing.Point(693, 409);
            this.DeleteSimpleButton.Name = "DeleteSimpleButton";
            this.DeleteSimpleButton.Size = new System.Drawing.Size(94, 29);
            this.DeleteSimpleButton.TabIndex = 2;
            this.DeleteSimpleButton.Text = "Delete";
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(AirportsRelationsApp.Module.BusinessObjects.Pilot);
            this.xpCollection1.Session = this.session1;
            // 
            // xpServerCollectionSource2
            // 
            this.xpServerCollectionSource2.DefaultSorting = "Planes ASC";
            this.xpServerCollectionSource2.DisplayableProperties = "PilotName;Airport;Planes";
            this.xpServerCollectionSource2.ObjectType = typeof(AirportsRelationsApp.Module.BusinessObjects.Pilot);
            this.xpServerCollectionSource2.Session = this.unitOfWork2;
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
            // colPlaneName1
            // 
            this.colPlaneName1.FieldName = "PlaneName";
            this.colPlaneName1.MinWidth = 25;
            this.colPlaneName1.Name = "colPlaneName1";
            this.colPlaneName1.Visible = true;
            this.colPlaneName1.VisibleIndex = 0;
            this.colPlaneName1.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Planes.PlaneName";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 94;
            // 
            // FormListPilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.DeleteSimpleButton);
            this.Controls.Add(this.modifySimpleButton);
            this.Controls.Add(this.insertSimpleButton);
            this.Name = "FormListPilot";
            this.Text = "List Pilots";
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton insertSimpleButton;
        private DevExpress.XtraEditors.SimpleButton modifySimpleButton;
        private DevExpress.XtraEditors.SimpleButton DeleteSimpleButton;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.Xpo.Session session1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colPlaneName;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource2;
        private DevExpress.Xpo.UnitOfWork unitOfWork2;
        private DevExpress.XtraGrid.Columns.GridColumn colPlaneName1;
        private DevExpress.XtraGrid.Columns.GridColumn colPilotName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}