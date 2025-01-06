using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using Selenium_Demo.utilities;

namespace Selenium_Demo.TestCases
{
    internal class clsDatadrivenTests
    {
        IWebDriver dr;
        clsMyLogger logger;
        clsUtilities _utilities;
        [SetUp]
        public void Setup()
        {
            //dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads");
            dr = new EdgeDriver("C:\\Users\\Anand.Gummadilli\\Downloads\\edgedriver_win64");

            _utilities = new clsUtilities();
            logger=new clsMyLogger();
        }
        [Test]
        public void SearchCountry()
        {
          
            DataTable dtAnvesh= _utilities.ReadExcel("C:\\Anand_Details\\Marks.xlsx",null);
            Console.WriteLine("Rows count is:" + dtAnvesh.Rows);
            for(int i=0; i<dtAnvesh.Rows.Count;i++)
            {
                dr.Navigate().GoToUrl("http://google.com");
                dr.FindElement(By.Name("q")).SendKeys(dtAnvesh.Rows[i][0].ToString());
                dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);
                
            }
            dr.Close();

        }

        [Test]
        public void Datadriventest2()
        {

            DataTable dtAnvesh = _utilities.ReadExcel("C:\\Anand_Details\\Marks.xlsx","Students");
            Console.WriteLine("Rows count is:" + dtAnvesh.Rows);
            for (int i = 0; i < dtAnvesh.Rows.Count; i++)
            {
                dr.Navigate().GoToUrl("http://google.com");
                logger.LogMessage("Opened Google site");
                dr.FindElement(By.Name("q")).SendKeys(dtAnvesh.Rows[i][0].ToString());
                dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);
                logger.LogMessage("searched for:" + dtAnvesh.Rows[i][0].ToString());

            }
            dr.Close();

        }
    }
}
