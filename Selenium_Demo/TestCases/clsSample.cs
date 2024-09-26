using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


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
            IWebDriver dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads");
            dr.Navigate().GoToUrl("https://google.com");
            dr.FindElement(By.Name("q")).SendKeys("India");
            dr.FindElement(By.XPath("//textarea[@name='q']")).SendKeys(Keys.Enter);
            string title = dr.Title;
            Console.WriteLine("title is:" + title);
            Console.WriteLine("current url is:" + dr.Url);

            Assert.IsTrue(dr.Url.Contains("https://www.google.com/search123"), "Search is not working");
        }
        [Test]
        public void OpenGmail()
        {
            IWebDriver dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads");
            dr.Navigate().GoToUrl("https://google.com");
            dr.FindElement(By.LinkText("Gmail")).Click();

        }
        }
    }
