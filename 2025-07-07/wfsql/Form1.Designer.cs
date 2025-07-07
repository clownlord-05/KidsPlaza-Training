namespace wfsql
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
            this.lblid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btntest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(47, 36);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(20, 16);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(47, 81);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(84, 16);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "USERNAME";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(47, 130);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(86, 16);
            this.lblpass.TabIndex = 2;
            this.lblpass.Text = "PASSWORD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "BIRTHDATE";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(605, 39);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(107, 37);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(605, 82);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(107, 37);
            this.btnsua.TabIndex = 5;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(605, 130);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(107, 37);
            this.btnxoa.TabIndex = 6;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(204, 36);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(301, 22);
            this.txtid.TabIndex = 7;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(204, 75);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(301, 22);
            this.txtname.TabIndex = 8;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(204, 121);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(301, 22);
            this.txtpass.TabIndex = 9;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(204, 174);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(301, 22);
            this.txtdate.TabIndex = 10;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(67, 265);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(673, 173);
            this.dgv.TabIndex = 11;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtis
            // 
            this.txtis.Location = new System.Drawing.Point(204, 219);
            this.txtis.Name = "txtis";
            this.txtis.Size = new System.Drawing.Size(301, 22);
            this.txtis.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "ISACTIVE";
            // 
            // btntest
            // 
            this.btntest.Location = new System.Drawing.Point(605, 191);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(107, 37);
            this.btntest.TabIndex = 14;
            this.btntest.Text = "test";
            this.btntest.UseVisualStyleBackColor = true;
            this.btntest.Click += new System.EventHandler(this.btntest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtis);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btntest;
    }
}

