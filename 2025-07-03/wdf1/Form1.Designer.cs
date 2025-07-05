namespace wdf1
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
            this.btntong = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btntong
            // 
            this.btntong.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btntong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntong.Location = new System.Drawing.Point(47, 325);
            this.btntong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(98, 33);
            this.btntong.TabIndex = 2;
            this.btntong.Text = "cộng";
            this.btntong.UseVisualStyleBackColor = false;
            this.btntong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btntru
            // 
            this.btntru.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btntru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntru.Location = new System.Drawing.Point(277, 325);
            this.btntru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(98, 33);
            this.btntru.TabIndex = 3;
            this.btntru.Text = "trừ";
            this.btntru.UseVisualStyleBackColor = false;
            this.btntru.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(483, 325);
            this.btnreset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(98, 33);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(277, 443);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(98, 33);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(43, 154);
            this.lbla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(45, 20);
            this.lbla.TabIndex = 7;
            this.lbla.Text = "số a";
            this.lbla.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(43, 243);
            this.lblb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(45, 20);
            this.lblb.TabIndex = 6;
            this.lblb.Text = "số b";
            this.lblb.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblkq
            // 
            this.lblkq.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblkq.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkq.Location = new System.Drawing.Point(0, 0);
            this.lblkq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(634, 100);
            this.lblkq.TabIndex = 8;
            this.lblkq.Text = "label3";
            this.lblkq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblkq.Click += new System.EventHandler(this.label3_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(142, 155);
            this.txta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(441, 27);
            this.txta.TabIndex = 0;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(142, 244);
            this.txtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(441, 27);
            this.txtb.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CancelButton = this.btnthoat;
            this.ClientSize = new System.Drawing.Size(634, 528);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.btntong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máy Tính";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntong;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label lblkq;
    }
}

