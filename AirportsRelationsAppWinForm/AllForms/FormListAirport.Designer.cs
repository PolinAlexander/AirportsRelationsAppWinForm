namespace AirportsRelationsAppWinForm
{
    partial class FormListAirport
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.session1 = new DevExpress.Xpo.Session(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
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
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.xpCollection1, "Pilots.PilotName", true));
            this.listBox1.DataSource = this.xpCollection1;
            this.listBox1.DisplayMember = "AirportName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(774, 388);
            this.listBox1.TabIndex = 3;
            this.listBox1.ValueMember = "Pilots.This";
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(AirportsRelationsApp.Module.BusinessObjects.Airport);
            this.xpCollection1.Session = this.session1;
            // 
            // FormListAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DeleteSimpleButton);
            this.Controls.Add(this.modifySimpleButton);
            this.Controls.Add(this.insertSimpleButton);
            this.Name = "FormListAirport";
            this.Text = "List Airports";
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton insertSimpleButton;
        private DevExpress.XtraEditors.SimpleButton modifySimpleButton;
        private DevExpress.XtraEditors.SimpleButton DeleteSimpleButton;
        private System.Windows.Forms.ListBox listBox1;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.Xpo.Session session1;
    }
}