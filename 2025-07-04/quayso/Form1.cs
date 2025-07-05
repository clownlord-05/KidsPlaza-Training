using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quayso
{
    public partial class Form1 : Form
    {
        private SoundPlayer choinhac;

        int coin = 100;
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
            choinhac = new SoundPlayer("sound.wav");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnplat_Click(object sender, EventArgs e)
        {
            if (coin < 20)
                MessageBox.Show("Bạn không đủ coin, nạp thêm để tiếp tục:");
            else
                coin = coin - 20;
            txttien.Text = coin + "";
            timer1.Start();
        }

        private void btnnewgame_Click(object sender, EventArgs e)
        {
            coin = 100;
            txttien.Text = coin + "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl1.Text = rd.Next(0,7)+"";
            lbl2.Text = rd.Next(0, 9) + "";
            lbl3.Text = rd.Next(0, 10) + "";
        }

        private void btnsttop_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            
            if (lbl1.Text == "7" && lbl2.Text == "7" && lbl3.Text == "7")
            {
                coin += 1000000;
                MessageBox.Show("Nổ hũ! Bạn đã trúng 1,000,000 coin!");
            }
            else
            {
                if (lbl1.Text == "7")
                    coin += 30;

                if (lbl2.Text == "7")
                    coin += 40;

                if (lbl3.Text == "7")
                    coin += 50;
            }

            txttien.Text = coin + "";
        }

        private void btnend_Click(object sender, EventArgs e)
        {
            Close();
        }
        }
        private void txttien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void chkmusic_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
