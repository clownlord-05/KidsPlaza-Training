using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            // dieu huong trinh duyet
            IWebDriver driver = new ChromeDriver(service);
            driver.Navigate().GoToUrl("https://www.google.com.vn");
           // driver.Close();
           IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys(txtUrl.Text);     

        }

        private void button2_Click(object sender, EventArgs e) //close dong taap hien hanh, quit dong tat ca
        {
            ChromeDriverService dv = ChromeDriverService.CreateDefaultService();
            dv.HideCommandPromptWindow = true;
            IWebDriver dr = new ChromeDriver(dv);
            dr.Url = txtUrl.Text;
            dr.Navigate().Back();

           // dr.Navigate();
        }
    }
}
