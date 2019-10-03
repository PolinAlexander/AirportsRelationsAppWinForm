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
            this.insertSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.modifySimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.listBox1 = new DevExpress.XtraEditors.ListBoxControl();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.insertSimpleButton.Location = new System.Drawing.Point(13, 409);
            this.insertSimpleButton.Name = "simpleButton1";
            this.insertSimpleButton.Size = new System.Drawing.Size(94, 29);
            this.insertSimpleButton.TabIndex = 0;
            this.insertSimpleButton.Text = "Insert";
            // 
            // simpleButton2
            // 
            this.modifySimpleButton.Location = new System.Drawing.Point(353, 409);
            this.modifySimpleButton.Name = "simpleButton2";
            this.modifySimpleButton.Size = new System.Drawing.Size(94, 29);
            this.modifySimpleButton.TabIndex = 1;
            this.modifySimpleButton.Text = "Modify";
            // 
            // simpleButton3
            // 
            this.DeleteSimpleButton.Location = new System.Drawing.Point(693, 409);
            this.DeleteSimpleButton.Name = "simpleButton3";
            this.DeleteSimpleButton.Size = new System.Drawing.Size(94, 29);
            this.DeleteSimpleButton.TabIndex = 2;
            this.DeleteSimpleButton.Text = "Delete";
            // 
            // listBox1
            //             
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(774, 388);
            this.listBox1.TabIndex = 3;
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
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton insertSimpleButton;
        private DevExpress.XtraEditors.SimpleButton modifySimpleButton;
        private DevExpress.XtraEditors.SimpleButton DeleteSimpleButton;
        private DevExpress.XtraEditors.ListBoxControl listBox1;
    }
}