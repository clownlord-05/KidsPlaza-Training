using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf
{
    public partial class Form1 : Form
    {
       
        string connectionString = @"Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = nhanvien; Integrated Security = True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["ID"].Value != null)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtnhanvien.Text = row.Cells["TenNhanVien"].Value?.ToString();
                txtchucvu.Text = row.Cells["ChucVu"].Value?.ToString();
                txtluong.Text = row.Cells["Luong"].Value?.ToString();
                txtphongban.Text = row.Cells["PhongBan"].Value?.ToString();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Users WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (TenNhanVien, ChucVu, Luong, PhongBan) VALUES (@TenNhanVien, @ChucVu, @Luong, @PhongBan)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenNhanVien", txtnhanvien.Text);
                cmd.Parameters.AddWithValue("@ChucVu", txtchucvu.Text);
                cmd.Parameters.AddWithValue("@Luong", Convert.ToDecimal(txtluong.Text));
                cmd.Parameters.AddWithValue("@PhongBan", txtphongban.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }


        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Users SET TenNhanVien=@TenNhanVien, ChucVu=@ChucVu, Luong=@Luong, PhongBan=@PhongBan WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenNhanVien", txtnhanvien.Text);
                    cmd.Parameters.AddWithValue("@ChucVu", txtchucvu.Text);
                    cmd.Parameters.AddWithValue("@Luong", Convert.ToDecimal(txtluong.Text));
                    cmd.Parameters.AddWithValue("@PhongBan", txtphongban.Text);
                    cmd.Parameters.AddWithValue("@ID", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
