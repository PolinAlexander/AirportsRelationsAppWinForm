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
            DevExpress.XtraEditors.TableLayout.ItemTemplateBase itemTemplateBase1 = new DevExpress.XtraEditors.TableLayout.ItemTemplateBase();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement1 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement2 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement3 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            this.insertSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.modifySimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.listBox1 = new DevExpress.XtraEditors.ListBoxControl();
            this.session1 = new DevExpress.Xpo.Session(this.components);
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
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
            // listBox1
            // 
            this.listBox1.DataSource = this.xpCollection1;
            this.listBox1.DisplayMember = "Planes.This";
            this.listBox1.ItemHeight = 75;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(774, 388);
            this.listBox1.TabIndex = 3;
            itemTemplateBase1.Columns.Add(tableColumnDefinition1);
            itemTemplateBase1.Columns.Add(tableColumnDefinition2);
            itemTemplateBase1.Columns.Add(tableColumnDefinition3);
            templatedItemElement1.FieldName = "PilotName";
            templatedItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement1.Text = "PilotName";
            templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement2.ColumnIndex = 1;
            templatedItemElement2.FieldName = "Planes.This";
            templatedItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement2.Text = "Planes.This";
            templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement3.ColumnIndex = 2;
            templatedItemElement3.FieldName = "This";
            templatedItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement3.Text = "This";
            templatedItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            itemTemplateBase1.Elements.Add(templatedItemElement1);
            itemTemplateBase1.Elements.Add(templatedItemElement2);
            itemTemplateBase1.Elements.Add(templatedItemElement3);
            itemTemplateBase1.Name = "template1";
            tableRowDefinition1.Length.Value = 19D;
            tableRowDefinition2.Length.Value = 40D;
            itemTemplateBase1.Rows.Add(tableRowDefinition1);
            itemTemplateBase1.Rows.Add(tableRowDefinition2);
            this.listBox1.Templates.Add(itemTemplateBase1);
            this.listBox1.ValueMember = "Planes.This.Count()";
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(AirportsRelationsApp.Module.BusinessObjects.Pilot);
            this.xpCollection1.Session = this.session1;
            // 
            // FormListPilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DeleteSimpleButton);
            this.Controls.Add(this.modifySimpleButton);
            this.Controls.Add(this.insertSimpleButton);
            this.Name = "FormListPilot";
            this.Text = "List Pilots";
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton insertSimpleButton;
        private DevExpress.XtraEditors.SimpleButton modifySimpleButton;
        private DevExpress.XtraEditors.SimpleButton DeleteSimpleButton;
        private DevExpress.XtraEditors.ListBoxControl listBox1;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.Xpo.Session session1;
    }
}