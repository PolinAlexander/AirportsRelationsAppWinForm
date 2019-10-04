namespace AirportsRelationsAppWinForm.AllForms
{
    partial class MainForm
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAirportName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPilots = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xpInstantFeedbackSource1 = new DevExpress.Xpo.XPInstantFeedbackSource(this.components);
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.session1 = new DevExpress.Xpo.Session(this.components);
            this.xpCollection2 = new DevExpress.Xpo.XPCollection(this.components);
            this.xpCollection3 = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 168);
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(922, 610);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpInstantFeedbackSource1;
            this.gridControl1.Location = new System.Drawing.Point(6, 6);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.mainRibbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(910, 598);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAirportName,
            this.colPilots,
            this.colPlanes});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "AirportName", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAirportName, DevExpress.Data.ColumnSortOrder.Descending)});
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
            // colPilots
            // 
            this.colPilots.FieldName = "Pilots";
            this.colPilots.MinWidth = 25;
            this.colPilots.Name = "colPilots";
            this.colPilots.Visible = true;
            this.colPilots.VisibleIndex = 1;
            this.colPilots.Width = 94;
            // 
            // colPlanes
            // 
            this.colPlanes.FieldName = "Planes";
            this.colPlanes.MinWidth = 25;
            this.colPlanes.Name = "colPlanes";
            this.colPlanes.Visible = true;
            this.colPlanes.VisibleIndex = 2;
            this.colPlanes.Width = 94;
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.mainRibbonControl.SearchEditItem,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose,
            this.barButtonGroup1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem6,
            this.skinDropDownButtonItem1,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainRibbonControl.MaxItemId = 21;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(922, 168);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "SELECT Airports";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.Image = global::AirportsRelationsAppWinForm.Properties.Resources.add_16x16;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.ImageOptions.LargeImage = global::AirportsRelationsAppWinForm.Properties.Resources.add_32x32;
            this.bbiSave.Name = "bbiSave";
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Save And Close";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "Save And New";
            this.bbiSaveAndNew.Id = 4;
            this.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 10;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 12;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "ListAirport";
            this.barButtonItem6.Id = 13;
            this.barButtonItem6.ImageOptions.Image = global::AirportsRelationsAppWinForm.Properties.Resources.database_16x16;
            this.barButtonItem6.ImageOptions.LargeImage = global::AirportsRelationsAppWinForm.Properties.Resources.database_32x32;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem6_ItemClick);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 14;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "ListPlane";
            this.barButtonItem7.Id = 15;
            this.barButtonItem7.ImageOptions.Image = global::AirportsRelationsAppWinForm.Properties.Resources.database_16x161;
            this.barButtonItem7.ImageOptions.LargeImage = global::AirportsRelationsAppWinForm.Properties.Resources.database_32x321;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem7_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "ListPilot";
            this.barButtonItem8.Id = 16;
            this.barButtonItem8.ImageOptions.Image = global::AirportsRelationsAppWinForm.Properties.Resources.database_16x162;
            this.barButtonItem8.ImageOptions.LargeImage = global::AirportsRelationsAppWinForm.Properties.Resources.database_32x322;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem8_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Select Всех Аэропортов";
            this.barButtonItem9.Id = 17;
            this.barButtonItem9.ImageOptions.Image = global::AirportsRelationsAppWinForm.Properties.Resources.add_16x161;
            this.barButtonItem9.ImageOptions.LargeImage = global::AirportsRelationsAppWinForm.Properties.Resources.add_32x321;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem9_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Select Пилотов Аэропорта А";
            this.barButtonItem10.Id = 18;
            this.barButtonItem10.ImageOptions.Image = global::AirportsRelationsAppWinForm.Properties.Resources.add_16x162;
            this.barButtonItem10.ImageOptions.LargeImage = global::AirportsRelationsAppWinForm.Properties.Resources.add_32x322;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem10_ItemClick);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Select Самолетов аэропорта A";
            this.barButtonItem11.Id = 19;
            this.barButtonItem11.ImageOptions.Image = global::AirportsRelationsAppWinForm.Properties.Resources.add_16x163;
            this.barButtonItem11.ImageOptions.LargeImage = global::AirportsRelationsAppWinForm.Properties.Resources.add_32x323;
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem11_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "GenerateDB";
            this.barButtonItem12.Id = 20;
            this.barButtonItem12.ImageOptions.Image = global::AirportsRelationsAppWinForm.Properties.Resources.editdatasource_16x16;
            this.barButtonItem12.ImageOptions.LargeImage = global::AirportsRelationsAppWinForm.Properties.Resources.editdatasource_32x32;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem12_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Home";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.ItemLinks.Add(this.barButtonItem9);
            this.mainRibbonPageGroup.ItemLinks.Add(this.barButtonItem10);
            this.mainRibbonPageGroup.ItemLinks.Add(this.barButtonItem11);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonGroup1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Lists";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem12);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(922, 610);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(912, 600);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xpInstantFeedbackSource1
            // 
            this.xpInstantFeedbackSource1.DefaultSorting = "AirportName ASC";
            this.xpInstantFeedbackSource1.DisplayableProperties = "AirportName;Pilots;Planes";
            this.xpInstantFeedbackSource1.ObjectType = typeof(AirportsRelationsApp.Module.BusinessObjects.Airport);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Close";
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.ImageOptions.ImageUri.Uri = "Close";
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Close";
            this.barButtonItem4.Id = 7;
            this.barButtonItem4.ImageOptions.ImageUri.Uri = "Close";
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Reset Changes";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.ImageUri.Uri = "Reset";
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(AirportsRelationsApp.Module.BusinessObjects.Airport);
            this.xpCollection1.Session = this.session1;
            // 
            // xpCollection2
            // 
            this.xpCollection2.ObjectType = typeof(AirportsRelationsApp.Module.BusinessObjects.Pilot);
            this.xpCollection2.Session = this.session1;
            // 
            // xpCollection3
            // 
            this.xpCollection3.ObjectType = typeof(AirportsRelationsApp.Module.BusinessObjects.Plane);
            this.xpCollection3.Session = this.session1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(922, 778);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Ribbon = this.mainRibbonControl;
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Xpo.XPInstantFeedbackSource xpInstantFeedbackSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colAirportName;
        private DevExpress.XtraGrid.Columns.GridColumn colPilots;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.Xpo.XPCollection xpCollection2;
        private DevExpress.Xpo.XPCollection xpCollection3;
        private DevExpress.Xpo.Session session1;
    }
}