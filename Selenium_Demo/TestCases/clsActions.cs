using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Drawing;
using System.Threading;

namespace Selenium_Demo.TestCases
{
    public class clsChromeOptions
    {

        public IWebDriver dr;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("I am from setup method");
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized"); //Maximize the window when it starts
            //options.AddArgument("incognito");
            //options.AddArgument("headless");
            options.AddArgument("disable-extensions"); //disables existing extentions
            options.AddArgument("disable-popup-blocking"); //disabled popups displayed from chrome browser
            options.AddArgument("disable-infobars");//disables info bars
            dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads",options);
        }

        [Test]
        public void VerifyOptions()
        {
            dr.Navigate().GoToUrl("http://google.com");
        }
    }
}
