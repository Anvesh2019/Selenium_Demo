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
            options.AddArgument("useAutomationExtension");
            options.AddArgument("disable-extensions"); //disables existing extentions
            options.AddArgument("disable-popup-blocking"); //disabled popups displayed from chrome browser
            options.AddArgument("disable-infobars");//disables info bars
            dr = new ChromeDriver(@"C:\Users\DSC\Desktop\chromedriver.exe",options);
        }

        [Test]
        public void VerifyOptions()
        {
            dr.Navigate().GoToUrl("http://google.com");
            dr.FindElement(By.Name("q")).SendKeys("India");
        }
        [Test]
        public void OpenRedBus()
        {
            dr.Navigate().GoToUrl("https://www.google.com/search?gs_ssp=eJzj4tLP1TcwM403SUpXYDRgdGDwYitKTUkqLQYASIEGPg&q=redbus&rlz=1C1CHBD_enIN1082IN1082&oq=red&gs_lcrp=EgZjaHJvbWUqGAgCEC4YQxiDARjHARixAxjRAxiABBiKBTIOCAAQRRg5GEMYgAQYigUyEggBEAAYQxiDARixAxiABBiKBTIYCAIQLhhDGIMBGMcBGLEDGNEDGIAEGIoFMhIIAxAAGEMYgwEYsQMYgAQYigUyDAgEEAAYQxiABBiKBTISCAUQABhDGIMBGLEDGIAEGIoFMhIIBhAAGEMYgwEYsQMYgAQYigUyGAgHEC4YQxiDARjHARixAxjRAxiABBiKBTISCAgQLhhDGLEDGIAEGOUEGIoFMhMICRAuGIMBGMcBGLEDGNEDGIAE0gEJMzM2N2owajE1qAIIsAIB&sourceid=chrome&ie=UTF-8");
        }
    }
}
