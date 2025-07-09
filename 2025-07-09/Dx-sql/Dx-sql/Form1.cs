using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dx_sql
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=qlnguoidung;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private string str;

        public Form1(string connectionstring)
        {
            this.str = connectionstring;
            }

        void LoadData()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                command = new SqlCommand("SELECT * FROM Users", connection);
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);    
                gridControl1.DataSource = table;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối SQL: " + ex.Message);
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
                connection = new SqlConnection(connectionString);
                connection.Open();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối SQL: " + ex.Message);
            }


        }


        private void button3_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Users WHERE ID = @id";
            command.Parameters.AddWithValue("@id", int.Parse(txtid.Text));
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = $"UPDATE Users SET Username = '{txtname.Text}' , password = '{txtpass.Text}', birthdate = '{DateTime.Parse(txtdate.Text)}', ISactive ='{bool.Parse(txtis.Text)}' where id = '{txtid.Text}'";
            
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            DateTime txtdate2 = DateTime.Parse(txtdate.Text);
            bool txtis2 = bool.Parse(txtis.Text);
            command.CommandText = $"INSERT INTO Users (USERNAME,PASSWORD, BIRTHDATE,ISACTIVE) VALUES ('{txtname.Text}' , '{txtpass.Text}','{txtdate2}','{txtis2}')";
            
            LoadData();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (gridControl1.DataSource is DataTable dt)
                {
                    var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                    if (gridView != null)
                    {
                        int rowHandle = gridView.FocusedRowHandle;
                        if (rowHandle >= 0 && rowHandle < dt.Rows.Count)   
                        {
                            DataRow row = dt.Rows[rowHandle];
                            txtid.Text = row["Id"].ToString();
                            txtname.Text = row["Username"].ToString();
                            txtpass.Text = row["Password"].ToString();
                            txtdate.Text = row["Birthdate"].ToString();
                            txtis.Text = row["IsActive"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        private void LoadDataToGrid()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Users", connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        gridControl1.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(txtid.Text, out int userId))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Id = @id", connection))
                        {
                            command.Parameters.AddWithValue("@id", userId);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtname.Text = reader["Username"].ToString();
                                    txtpass.Text = reader["Password"].ToString();
                                    txtdate.Text = reader["Birthdate"].ToString();
                                    txtis.Text = reader["IsActive"].ToString();
                                }
                                else
                                {
                                    txtname.Text = "";
                                    txtpass.Text = "";
                                    txtdate.Text = "";
                                    txtis.Text = "";
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                txtname.Text = "";
                txtpass.Text = "";
                txtdate.Text = "";
                txtis.Text = "";
            }
        }
    }
}

