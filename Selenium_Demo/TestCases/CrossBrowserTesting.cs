﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Configuration;

namespace Selenium_Demo
{
    public class CrossBrowserTesting: TestBase
    {
       
        //public IWebDriver dr;
        
        [SetUp]
        public void setup()
        {
            dr = TestBase.GetDriver();

        }

        [Test]
        public void getBrowserType()
        {

               string BrowserType = ConfigurationManager.AppSettings.Get("chrome");
            Console.WriteLine("Browser type is:" + BrowserType);
            
        }
        [Test]
        public void VerifyCrossBrowserTesting()
        {

            TestBase objBase = new TestBase();
            dr.Navigate().GoToUrl("https://google.com");
            dr.FindElement(By.Name("q")).SendKeys("India");
            dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            objBase.DisplayBrowserName();
        }
    }
}
