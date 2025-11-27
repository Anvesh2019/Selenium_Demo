using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Drawing;
using System.Threading;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.IO;
using Selenium_Demo.Common;
using System.Linq;
using System.Collections.ObjectModel;

namespace Selenium_Demo.TestCases
{
    internal class practiceCodes
    {
        public IWebDriver dr;
        [SetUp]
        public void setup()
        {
            Console.WriteLine("I am from setup method");
            dr = new ChromeDriver(@"C:\Users\dasar\Downloads");
        }
        [Test]

        public void HandlingSelectBox1()
        {
            dr.Navigate().GoToUrl("https://demo.guru99.com/test/newtours/register.php");
            IWebElement ddCountry = dr.FindElement(By.Name("country"));
            //ddCountry.SendKeys("HYDERABAD");
            //SelectElement objSelect = new SelectElement(dr.FindElement(By.Name("country")));
            SelectElement objSelect = new SelectElement(ddCountry);

            objSelect.SelectByIndex(8);
            Thread.Sleep(3000);
            objSelect.SelectByText("INDIA");
            Thread.Sleep(3000);
            objSelect.SelectByValue("CHINA");
            Console.WriteLine("Multiple values allowed:" + objSelect.IsMultiple);

            int optCount = objSelect.Options.Count;
            Console.WriteLine("options count is:" + optCount);

            //objSelect.DeselectByValue("CHINA");
            //for (int i = 0; i < optCount; i++)
            //{
            //    objSelect.SelectByIndex(i);
            //}
        }
    }
}
