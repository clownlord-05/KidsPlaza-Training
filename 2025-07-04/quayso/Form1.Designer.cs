namespace quayso
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
            this.components = new System.ComponentModel.Container();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnplat = new System.Windows.Forms.Button();
            this.btnsttop = new System.Windows.Forms.Button();
            this.btnnewgame = new System.Windows.Forms.Button();
            this.btnend = new System.Windows.Forms.Button();
            this.txttien = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(48, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(161, 135);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "7";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(215, 28);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(161, 135);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "7";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(384, 28);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(161, 135);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "7";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "COIN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnplat
            // 
            this.btnplat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplat.Location = new System.Drawing.Point(112, 236);
            this.btnplat.Name = "btnplat";
            this.btnplat.Size = new System.Drawing.Size(95, 43);
            this.btnplat.TabIndex = 4;
            this.btnplat.Text = "Play";
            this.btnplat.UseVisualStyleBackColor = true;
            this.btnplat.Click += new System.EventHandler(this.btnplat_Click);
            // 
            // btnsttop
            // 
            this.btnsttop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsttop.Location = new System.Drawing.Point(281, 236);
            this.btnsttop.Name = "btnsttop";
            this.btnsttop.Size = new System.Drawing.Size(95, 43);
            this.btnsttop.TabIndex = 5;
            this.btnsttop.Text = "Stop";
            this.btnsttop.UseVisualStyleBackColor = true;
            this.btnsttop.Click += new System.EventHandler(this.btnsttop_Click);
            // 
            // btnnewgame
            // 
            this.btnnewgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewgame.Location = new System.Drawing.Point(450, 236);
            this.btnnewgame.Name = "btnnewgame";
            this.btnnewgame.Size = new System.Drawing.Size(95, 43);
            this.btnnewgame.TabIndex = 6;
            this.btnnewgame.Text = "New Game";
            this.btnnewgame.UseVisualStyleBackColor = true;
            this.btnnewgame.Click += new System.EventHandler(this.btnnewgame_Click);
            // 
            // btnend
            // 
            this.btnend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnend.Location = new System.Drawing.Point(281, 323);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(95, 43);
            this.btnend.TabIndex = 7;
            this.btnend.Text = "End";
            this.btnend.UseVisualStyleBackColor = true;
            this.btnend.Click += new System.EventHandler(this.btnend_Click);
            // 
            // txttien
            // 
            this.txttien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttien.Location = new System.Drawing.Point(112, 181);
            this.txttien.Name = "txttien";
            this.txttien.ReadOnly = true;
            this.txttien.Size = new System.Drawing.Size(433, 23);
            this.txttien.TabIndex = 8;
            this.txttien.Text = "100";
            this.txttien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttien.TextChanged += new System.EventHandler(this.txttien_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 397);
            this.Controls.Add(this.txttien);
            this.Controls.Add(this.btnend);
            this.Controls.Add(this.btnnewgame);
            this.Controls.Add(this.btnsttop);
            this.Controls.Add(this.btnplat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnplat;
        private System.Windows.Forms.Button btnsttop;
        private System.Windows.Forms.Button btnnewgame;
        private System.Windows.Forms.Button btnend;
        private System.Windows.Forms.TextBox txttien;
        private System.Windows.Forms.Timer timer1;
    }
}

