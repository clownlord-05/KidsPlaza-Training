using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace wfsql
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=qlnguoidung;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void LoadData()
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Users";    
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgv.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu SQL: " + ex.Message);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(str);
                connection.Open();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối SQL: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            txtid.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtname.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txtpass.Text = dgv.Rows[i].Cells[2].Value.ToString();
            txtdate.Text = dgv.Rows[i].Cells[3].Value.ToString();
            txtis.Text = dgv.Rows[i].Cells[4].Value.ToString();

        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            DateTime txtdate2 = DateTime.Parse(txtdate.Text);
            bool txtis2 = bool.Parse(txtis.Text);
            //txtdate = DateTime.Parse(txtdate.Text);
            //command.CommandText = "INSERT INTO Users (USERNAME,PASSWORD, BIRTHDATE,ISACTIVE) VALUES ('" + txtname + "' , '" + txtpass + "','" + txtdate + "','" + txtis + "')";
            command.CommandText = $"INSERT INTO Users (USERNAME,PASSWORD, BIRTHDATE,ISACTIVE) VALUES ('{txtname.Text}' , '{txtpass.Text}','{txtdate2}','{txtis2}')";
            command.ExecuteNonQuery();
            LoadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Users WHERE ID = @id";
            command.Parameters.AddWithValue("@id", int.Parse(txtid.Text));
            command.ExecuteNonQuery();
            LoadData();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = $"UPDATE Users SET Username = '{txtname.Text}' , password = '{txtpass.Text}', birthdate = '{DateTime.Parse(txtdate.Text)}', ISactive ='{bool.Parse(txtis.Text)}' where id = '{txtid.Text}'";



            command.ExecuteNonQuery();
            LoadData();
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(str);
                connection.Open();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối SQL: " + ex.Message);
            }
        }
    }
}
