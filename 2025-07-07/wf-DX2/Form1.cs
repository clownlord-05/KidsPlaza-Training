using DevExpress.Utils.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataAccess.Excel;
using System.IO;
using System.Security.Cryptography;

namespace wf_DX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) 
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select file";
            openFileDialog.Filter = "exel files (*.xlsx)|*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
                ExcelDataSource excel = new ExcelDataSource();
                excel.FileName = textBox1.Text  ;
                ExcelWorksheetSettings excelWorksheetSettings = new ExcelWorksheetSettings("my data","A1:D100 ");
                excel.SourceOptions = new ExcelSourceOptions(excelWorksheetSettings);
                excel.SourceOptions = new CsvSourceOptions() { CellRange = "A1:D100" };
                excel.SourceOptions.SkipEmptyRows = false;
                excel.SourceOptions.UseFirstRowAsHeader = true;
                excel.Fill();
                gcdata.DataSource = excel;



            }
        }
    }
}
