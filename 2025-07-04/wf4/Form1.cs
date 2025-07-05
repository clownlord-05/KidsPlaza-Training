using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtten.Text == "")
                errorProvider1.SetError(txtten, "Bạn chưa nhập tên");
        }

        private void txtcccd_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
            if (txtcccd.Text == "")
                errorProvider2.SetError(txtcccd, "Bạn chưa nhập số CCCD");
            else if (txtcccd.Text.Length != 12)
                errorProvider2.SetError(txtcccd, "Số CCCD phải có 12 chữ số");
        }

        private void txtssdt_TextChanged(object sender, EventArgs e)
        {
            errorProvider3.Clear();
            if (txtssdt.Text == "")
                errorProvider3.SetError(txtssdt, "Bạn chưa nhập số điện thoại");
            else if (txtssdt.Text.Length != 9)
                errorProvider3.SetError(txtssdt, "Số điện thoại phải có 9 chữ số");
        }

        private void txtcutru_TextChanged(object sender, EventArgs e)
        {
            errorProvider4.Clear();
            if (txtcutru.Text == "")
                errorProvider4.SetError(txtcutru, "Bạn chưa nhập địa chỉ cư trú");
        }

        private void btndangki_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();

            bool isValid = true;

           
            if (txtten.Text == "")
            {
                errorProvider1.SetError(txtten, "Bạn chưa nhập tên");
                isValid = false;
            }

            if (txtcccd.Text == "")
            {
                errorProvider2.SetError(txtcccd, "Bạn chưa nhập số CCCD");
                isValid = false;
            }
            else if (txtcccd.Text.Length != 12)
            {
                errorProvider2.SetError(txtcccd, "Số CCCD phải có 12 chữ số");
                isValid = false;
            }
            if (txtssdt.Text == "")
            {
                errorProvider3.SetError(txtssdt, "Bạn chưa nhập số điện thoại");
                isValid = false;
            }
            else if (txtssdt.Text.Length != 10)
            {
                errorProvider3.SetError(txtssdt, "Số điện thoại phải có 10 chữ số");
                isValid = false;
            }

            
            if (txtcutru.Text == "")
            {
                errorProvider4.SetError(txtcutru, "Bạn chưa nhập địa chỉ cư trú");
                isValid = false;
            }

            if (isValid)
            {
                MessageBox.Show("Đăng kí không thành công. Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Bạn đã đăng kí thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
