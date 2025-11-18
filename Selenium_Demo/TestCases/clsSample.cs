using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Drawing;
using OpenQA.Selenium.DevTools.V102.SystemInfo;


namespace Selenium_Demo.TestCases
{
    public class clsSample
    {
        [Test]
        public void AddNumbers()
        {
            int x = 20;
            int y = 30;
            int result = x + y;

            Console.WriteLine("sum is:" + result);
        }

        [Test]
        public void SubtractNumbers()
        {
            int x = 50;
            int y = 30;
            int result = x - y;

            Console.WriteLine("result is:" + result);
        }
        [Test]
        public void OpenGoogleSite()
        {
            IWebDriver dr;
            dr= new ChromeDriver(@"C:\Users\Anand\Downloads");
            //dr = new EdgeDriver($"{Directory.GetCurrentDirectory()}\\DriverHelper");

            dr.Navigate().GoToUrl("https://google.com");
            dr.FindElement(By.Name("q")).SendKeys("India");
            dr.FindElement(By.XPath("//textarea[@name='q']")).SendKeys(Keys.Enter);
            string title = dr.Title;
            Console.WriteLine("title is:" + title);
            Console.WriteLine("current url is:" + dr.Url);
            Thread.Sleep(15000);
            Assert.IsTrue(dr.Url.Contains("https://www.google.com/search"), "Search is not working");
            IWebElement linkPresident = dr.FindElement(By.XPath("//a[text()='Droupadi Murmu']"));
            Assert.IsTrue(linkPresident.Text == "Droupadi Murmu","search functionality is not worked");
        }
        [Test]
        public void LearnAssertion()
        {
            int x = 25;
            int y = 25;
            //Assert.IsTrue(x==y,"x is not equal to y");
            Assert.AreEqual(x,y,"x is not equal to y");
        }
        [Test]
        public void OpenGmail()
        {
            IWebDriver dr;
            dr = new EdgeDriver("C:\\Users\\Anand\\Downloads");
            //dr = new EdgeDriver($"{Directory.GetCurrentDirectory()}\\DriverHelper");

            //= new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads");
            dr.Navigate().GoToUrl("https://google.com");
            dr.FindElement(By.LinkText("Gmail")).Click();
            Assert.IsTrue(dr.Url.Contains("gmail"),"gmail page is not loaded");
            IWebElement linkSignin = dr.FindElement(By.XPath("(//span[text()='Sign in'])[2]"));
            Assert.IsTrue(linkSignin.Displayed == true,"Signin button not displayed");
            Assert.IsTrue(linkSignin.Size != System.Drawing.Size.Empty,"sign is NOT displyed");
        }
        [Test]
        public void VerifyLogs()
        {
            clsMyLogger logger = new clsMyLogger();
            logger.LogMessage("I am executing VerifyLogs test case");
        }
    }
    }
