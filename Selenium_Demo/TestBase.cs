using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Selenium_Demo.Common;
using Selenium_Demo.Pages;
using Selenium_Demo.TestCases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Demo
{
    public class TestBase
    {
        public static IWebDriver dr;
        public clsCommon objCommon;
       public string browser = "chrome";
       
        //public clsMyLogger logger;
        public GiftcardsPage _gcpage;
        IWebDriver driver;
        public AmazonPage _amazonpage;
        public FashionPage _fpage;
        public clsActions _actions;
        [SetUp]
        public void Setup()
        {
            //logger = new clsMyLogger();
            //logger.LogMessage("Setup from Testbase");
            Console.WriteLine("I am from setup method");

            if (browser == "firefox")
            {
                dr = new FirefoxDriver();
            }
            else if(browser=="edge")
            {
                dr = new EdgeDriver();
                //logger.LogMessage("Edge browser initiated");
            }
            //Check if parameter passed as 'chrome'
            else if (browser == "chrome")
            {

                dr = new ChromeDriver(@"C:\Users\dasar\Downloads");
                //logger.LogMessage("chrome browser initiated");
            }
            else if (browser == "IE")
            {
                dr = new InternetExplorerDriver(@"C:\Users\DSC\Desktop\chromedriver.exe");
            }
            objCommon = new clsCommon(dr);
            //driver = new ChromeDriver("C:\\Users\\anand\\Downloads");
            _gcpage = new GiftcardsPage(dr);
            _amazonpage = new AmazonPage(dr);
            _fpage = new FashionPage(dr);
            _actions = new clsActions();
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
