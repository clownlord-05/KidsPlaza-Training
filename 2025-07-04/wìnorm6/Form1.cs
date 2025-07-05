using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wìnorm6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldongho.Text = DateTime.Now.ToString("HH:mm:ss"); 
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1 .Stop();
        }
    }
}
