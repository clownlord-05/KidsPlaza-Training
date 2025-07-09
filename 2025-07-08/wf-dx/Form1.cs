using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_dx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrdm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            radialMenu1.ShowPopup(new Point(Top));
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
