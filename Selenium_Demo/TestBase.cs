using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Edge;
using Selenium_Demo.Common;

namespace Selenium_Demo
{
    public class TestBase
    {
        public static IWebDriver dr;
        public clsCommon objCommon;
       // public string browser = "chrome";
       piu
        public clsMyLogger logger;
        [SetUp]
        public void Setup()
        {
            logger = new clsMyLogger();
            logger.LogMessage("Setup from Testbase");
            Console.WriteLine("I am from setup method");

            if (browser == "firefox")
            {
                dr = new FirefoxDriver();
            }
            else if(browser=="edge")
            {
                dr = new EdgeDriver();
                logger.LogMessage("Edge browser initiated");
            }
            //Check if parameter passed as 'chrome'
            else if (browser == "chrome")
            {

                dr = new ChromeDriver();
                logger.LogMessage("chrome browser initiated");
            }
            else if (browser == "IE")
            {
                dr = new InternetExplorerDriver(@"C:\Users\DSC\Desktop\chromedriver.exe");
            }
            objCommon = new clsCommon(dr);
           
        }

        public static IWebDriver GetDriver()
        {
            return dr;
        }

        public void DisplayBrowserName()
        {
            Console.WriteLine("Browser name is:" + browser);
        }
    }
}
