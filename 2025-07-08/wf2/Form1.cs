using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace wf2
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
            IWebDriver driver = new ChromeDriver(service);
            driver.Url = "https://upanh.1doi1.com/";
            driver.Navigate();
           IWebElement dau  = driver.FindElement( By.XPath("/html/body/div[1]/div/div[3]/div[2]/label[1]/span"));
            Thread.Sleep(1000);
            dau.Click();

            IWebElement upload = driver.FindElement(By.Id("uploadDropZone"));
            Thread.Sleep(1000);
            upload.SendKeys(textBox1.Text);

            Thread.Sleep(1000);
            IWebElement tailen = driver.FindElement(By.XPath("uploadDropZone"));
            tailen.Click();

            Thread.Sleep(3000);
            IWebElement link = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/label"));
            string text = link.GetAttribute("value");
            Console.WriteLine(text);
            textBox2.Text = text;

            driver.Quit();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
