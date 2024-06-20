using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_Demo.utilities;

namespace Selenium_Demo.TestCases
{
    internal class clsDatadrivenTests
    {
        IWebDriver dr;
        clsUtilities _utilities;
        [SetUp]
        public void Setup()
        {
            dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads");
            _utilities = new clsUtilities();
        }
        [Test]
        public void SearchCountry()
        {
          
            DataTable dtAnvesh= _utilities.ReadExcel("C:\\Anand_Details\\Anvesh.xlsx");
            Console.WriteLine("Rows count is:" + dtAnvesh.Rows);
            for(int i=0; i<dtAnvesh.Rows.Count;i++)
            {
                dr.Navigate().GoToUrl("http://google.com");
                dr.FindElement(By.Name("q")).SendKeys(dtAnvesh.Rows[i][0].ToString());
                dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);
                
            }
            dr.Close();

        }
    }
}
