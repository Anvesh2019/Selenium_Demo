using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Demo.TestCases
{
    public class clsDemo
    {
        [TestCase("India")]
        [TestCase("Chaina")]

        public void SearchInGoogle(string strCountry)
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://google.com");

            dr.Manage().Window.Maximize();
            Assert.IsTrue(dr.Title.Contains("Google") == true, "google page not loaded");
            Assert.IsTrue(dr.Url.Contains("https://www.google.com/"),"google page is not loaded");
            dr.FindElement(By.Name("q")).SendKeys(strCountry);
            dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            //dr.FindElement(By.PartialLinkText("Narendra")).Click();
            //dr.Close();       
            
        }
    }
}
