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
            this.insertSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.modifySimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.session1 = new DevExpress.Xpo.Session(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.colPilotName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            this.SuspendLayout();
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
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpServerCollectionSource1;
            this.gridControl1.Location = new System.Drawing.Point(13, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(774, 391);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPilotName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.DefaultSorting = "Airport ASC";
            this.xpServerCollectionSource1.DisplayableProperties = "PilotName;Airport;Planes";
            this.xpServerCollectionSource1.ObjectType = typeof(AirportsRelationsApp.Module.BusinessObjects.Pilot);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
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
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colPilotName;
    }
}