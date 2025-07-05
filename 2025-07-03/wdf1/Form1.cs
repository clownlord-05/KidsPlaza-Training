using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wdf1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tong;
    
            tong = int.Parse(txta.Text) + int.Parse(txtb.Text);
            lblkq.Text = txta.Text + " + " + txtb.Text + " = " + tong + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblkq.Text = "";
            txtb.Text = "";
            txta.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int hieu;
            
            hieu = int.Parse(txta.Text) - int.Parse(txtb.Text);
            lblkq.Text = txta.Text+ " - "+txtb.Text +"=" +hieu +"";
        }
    }
}
