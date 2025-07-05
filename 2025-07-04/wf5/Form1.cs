using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            lstnv.Items.Add(x);
            textBox1.Clear();
            if (textBox1.Text == "")
                {
                errorProvider1.SetError(textBox1, "Bạn chưa nhập ");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (int i in lstnv.Items)
                tong += i;
            MessageBox.Show("Tổng nhân viên của bạn là : " + tong, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (lstnv.SelectedIndex != -1)
            {
                lstnv.Items.RemoveAt(lstnv.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phần tử để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lstnv.SelectedIndex != -1)
            {
                MessageBox.Show("Phần tử đang được chọn là: " + lstnv.SelectedItem.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có phần tử nào đang được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lstnv.SelectedIndex != -1)
            {
                int selectedValue;
                if (int.TryParse(lstnv.SelectedItem.ToString(), out selectedValue))
                {
                    string result = (selectedValue % 2 == 0) ? "chẵn" : "lẻ";
                    MessageBox.Show($"Phần tử đang chọn là {selectedValue} và nó là số {result}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Giá trị được chọn không phải là số nguyên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phần tử.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
