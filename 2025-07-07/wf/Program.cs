using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace wf
{
    internal static class Program  
    {
        
        public static string SqlConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=nhanvien;Integrated Security=True";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            

        }
    }
}
