using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChromeDriver Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            var driver = Browser;
            Browser.Navigate().GoToUrl("file:///C:/Users/Dolghieru%20Rodica/Desktop/Logare/Login_v9/index.html");

            IWebElement SearchImput = Browser.FindElement(By.Name("username"));

            SearchImput.SendKeys("rodica");

            SearchImput = Browser.FindElement(By.Name("pass"));

            SearchImput.SendKeys("1113");
            string st = SearchImput.Text;
            Thread.Sleep(1000);

            SearchImput.SendKeys(OpenQA.Selenium.Keys.Enter);
            
            if (st.StartsWith("Logare"))
            {
                textBox1.Text = ("Logare Esuata");
                SearchImput = Browser.FindElement(By.Id("message"));
                Console.WriteLine("Error");
            }
            else { textBox1.Text = ("Logare cu succes");
                SearchImput = Browser.FindElement(By.Id("message"));
                Console.WriteLine("Succes");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
