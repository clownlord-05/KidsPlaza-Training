namespace wf3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.piclen = new System.Windows.Forms.PictureBox();
            this.picxuong = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btntap = new System.Windows.Forms.Button();
            this.chknhac = new System.Windows.Forms.CheckBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.piclen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picxuong)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // piclen
            // 
            this.piclen.Image = ((System.Drawing.Image)(resources.GetObject("piclen.Image")));
            this.piclen.Location = new System.Drawing.Point(31, 98);
            this.piclen.Name = "piclen";
            this.piclen.Size = new System.Drawing.Size(344, 292);
            this.piclen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclen.TabIndex = 0;
            this.piclen.TabStop = false;
            // 
            // picxuong
            // 
            this.picxuong.Image = ((System.Drawing.Image)(resources.GetObject("picxuong.Image")));
            this.picxuong.Location = new System.Drawing.Point(31, 98);
            this.picxuong.Name = "picxuong";
            this.picxuong.Size = new System.Drawing.Size(344, 292);
            this.picxuong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picxuong.TabIndex = 1;
            this.picxuong.TabStop = false;
            this.picxuong.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên người tập";
            // 
            // btntap
            // 
            this.btntap.Location = new System.Drawing.Point(31, 438);
            this.btntap.Name = "btntap";
            this.btntap.Size = new System.Drawing.Size(152, 59);
            this.btntap.TabIndex = 4;
            this.btntap.Text = "Tap";
            this.btntap.UseVisualStyleBackColor = true;
            this.btntap.Click += new System.EventHandler(this.btntap_Click);
            // 
            // chknhac
            // 
            this.chknhac.AutoSize = true;
            this.chknhac.Location = new System.Drawing.Point(311, 32);
            this.chknhac.Name = "chknhac";
            this.chknhac.Size = new System.Drawing.Size(61, 20);
            this.chknhac.TabIndex = 5;
            this.chknhac.Text = "Music";
            this.chknhac.UseVisualStyleBackColor = true;
            this.chknhac.CheckedChanged += new System.EventHandler(this.chknhac_CheckedChanged);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(123, 29);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(166, 22);
            this.txtten.TabIndex = 6;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(227, 443);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(148, 54);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoat";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 523);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.chknhac);
            this.Controls.Add(this.btntap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picxuong);
            this.Controls.Add(this.piclen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piclen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picxuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.PictureBox piclen;
        private System.Windows.Forms.PictureBox picxuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntap;
        private System.Windows.Forms.CheckBox chknhac;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button btnthoat;
    }
}

