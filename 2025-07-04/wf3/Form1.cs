using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace wf3
{
    public partial class Form1 : Form
    {
        private SoundPlayer choinhac;

        public Form1()
        {

            InitializeComponent();
            choinhac = new SoundPlayer("sound.wav");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btntap_Click(object sender, EventArgs e)
        {
            if (picxuong.Visible == false)
            {
                picxuong.Visible = true;
                piclen.Visible = false;
            }
            else
            {
                piclen.Visible = true;
                picxuong.Visible = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picxuong.Visible = true;
            piclen.Visible = false;
        }

        private SoundPlayer GetChoinhac()
        {
            return choinhac;
        }

        private void chknhac_CheckedChanged(object sender, EventArgs e)
        {
            chknhac_CheckedChanged(sender, e, choinhac);
        }

        private void chknhac_CheckedChanged(object sender, EventArgs e, SoundPlayer choinhac)
        {
            if (chknhac.Checked == true)
                choinhac.Play();
            
            else
                choinhac.Stop();
            
        }
    }
}
