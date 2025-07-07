namespace wf_DX2
{
    partial class Form1
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gcdata = new DevExpress.XtraGrid.GridControl();
            this.gvdata = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            ((System.ComponentModel.ISupportInitialize)(this.gcdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(105, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Path";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(386, 22);
            this.textBox1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(685, 32);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Browse";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gcdata
            // 
            this.gcdata.Location = new System.Drawing.Point(12, 108);
            this.gcdata.MainView = this.gvdata;
            this.gcdata.Name = "gcdata";
            this.gcdata.Size = new System.Drawing.Size(767, 330);
            this.gcdata.TabIndex = 3;
            this.gcdata.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvdata});
            // 
            // gvdata
            // 
            this.gvdata.GridControl = this.gcdata;
            this.gvdata.Name = "gvdata";
            this.gvdata.OptionsView.ShowGroupPanel = false;
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gcdata);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gcdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gcdata;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdata;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
    }
}

