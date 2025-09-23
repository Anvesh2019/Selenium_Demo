using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;
using OpenQA.Selenium.Edge;
using System.IO;

namespace Selenium_Demo
{
    public class HandlingFrames
    {
        public IWebDriver dr;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("I am from setup method");
            dr = new ChromeDriver();
            // dr = new EdgeDriver("C:\\Users\\Anand.Gummadilli\\Downloads\\edgedriver_win64");
            //dr = new EdgeDriver($"{Directory.GetCurrentDirectory()}\\DriverHelper");

        }
        [Test]
        public void VerifyHandlingMultipleWindows()
        {
            dr.Navigate().GoToUrl("https://demo.guru99.com/test/guru99home/");
            string parentHandle = dr.CurrentWindowHandle;

            IWebElement elementFrame = dr.FindElement(By.XPath("//iframe[@name='a077aa5e']"));
            elementFrame.Click();
            //dr.SwitchTo().Frame(elementFrame);
            //IWebElement imgJmeter = dr.FindElement(By.XPath("//a[@href='http://www.guru99.com/live-selenium-project.html']"));
            //imgJmeter.Click();

            System.Collections.ObjectModel.ReadOnlyCollection<string> listHandles = dr.WindowHandles;
            
            dr.SwitchTo().Window(listHandles[1]); //switch to 2nd tab
            Console.WriteLine("2nd tab url:" + dr.Url);
            Thread.Sleep(3000);
           
            dr.FindElement(By.XPath("(//a[text()='Home'])[1]")).Click();


            //IWebElement txtEmail = dr.FindElement(By.Name("email"));
            //Actions action = new Actions(dr);
            //action.ScrollToElement(txtEmail);

            //txtEmail.SendKeys("radhika123@gmail.com");
            //dr.FindElement(By.Name("submit")).Click();

            //dr.SwitchTo().Window(listHandles[0]); //back to 1st window

            Console.WriteLine(dr.Url);
            ////Assert.IsTrue(dr.Url.Contains("live-selenium-project.html"),"Live project page is not loaded");

            //Assert.IsTrue(dr.Url== "https://demo.guru99.com/test/guru99home/");
            dr.SwitchTo().Window(parentHandle);
            Console.WriteLine("Last step after moving to parent window:" + dr.Url);

        }
    }
}
