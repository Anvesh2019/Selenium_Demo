using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Demo
{
    public class HandlingFrames
    {
        public IWebDriver dr;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("I am from setup method");
            dr = new ChromeDriver(@"C:\Users\v-anandag\Desktop");

        }
        [Test]
        public void VerifyHandlingFrames()
        {
            dr.Navigate().GoToUrl("https://demo.guru99.com/test/guru99home/");
            IWebElement elementFrame = dr.FindElement(By.XPath("//iframe[@name='a077aa5e']"));
            dr.SwitchTo().Frame(elementFrame);
            IWebElement imgJmeter = dr.FindElement(By.XPath("//a[@href='http://www.guru99.com/live-selenium-project.html']"));
            imgJmeter.Click();

            System.Collections.ObjectModel.ReadOnlyCollection<string> listHandles = dr.WindowHandles;
            
            dr.SwitchTo().Window(listHandles[1]);

            Console.WriteLine(dr.Url);
            Assert.IsTrue(dr.Url.Contains("live-selenium-project.html"),"Live project page is not loaded");
        }
    }
}
