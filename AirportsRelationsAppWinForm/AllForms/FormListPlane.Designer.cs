namespace AirportsRelationsAppWinForm
{
    partial class FormListPlane
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
            this.session1 = new DevExpress.Xpo.Session(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.planeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planeNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.xpCollection1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(774, 390);
            this.dataGridView1.TabIndex = 3;            
            // 
            // planeNameDataGridViewTextBoxColumn
            // 
            this.planeNameDataGridViewTextBoxColumn.DataPropertyName = "PlaneName";
            this.planeNameDataGridViewTextBoxColumn.HeaderText = "PlaneName";
            this.planeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.planeNameDataGridViewTextBoxColumn.Name = "planeNameDataGridViewTextBoxColumn";
            this.planeNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(AirportsRelationsApp.Module.BusinessObjects.Plane);
            this.xpCollection1.Session = this.session1;
            // 
            // FormListPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteSimpleButton);
            this.Controls.Add(this.modifySimpleButton);
            this.Controls.Add(this.insertSimpleButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormListPlane";
            this.Text = "List Planes";            
            ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton insertSimpleButton;
        private DevExpress.XtraEditors.SimpleButton modifySimpleButton;
        private DevExpress.XtraEditors.SimpleButton DeleteSimpleButton;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.Xpo.Session session1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeNameDataGridViewTextBoxColumn;
    }
}