using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Edge;
using System.IO;
using System.Drawing;
using System.Threading;
using System.Collections.ObjectModel;

namespace Selenium_Demo.TestCases
{
    public class BookMyShowTests
    {
        IWebDriver dr; 

        [SetUp]
        public void Setup()
        {
            dr = new ChromeDriver();
        }

        [Test]
        public void OpenBookMyShow()
        {

            
            dr.Navigate().GoToUrl("https://bookmyshow.com");
            dr.Manage().Window.Maximize();
            //dr.Close();
            string myURL = dr.Url;
            Console.WriteLine(myURL);
            Console.WriteLine(dr.Title);
        }

        [Test]
        public void OpenEvents()
        {
            
            dr.Navigate().GoToUrl("https://bookmyshow.com");
            dr.Manage().Window.Maximize();
            IWebElement linkHyd = dr.FindElement(By.XPath("//span[text()='Hyderabad']"));
            linkHyd.Click();
            dr.FindElement(By.LinkText("Events")).Click();

            Assert.IsTrue(dr.Url.Contains("events-hyderabad"));
            Assert.IsTrue(dr.Title.Contains("Hyderabad"), "Hyderabad is not displayed in title");
            IWebElement headingHyd = dr.FindElement(By.XPath("//h1[text()='Events in Hyderabad']"));
            Assert.IsTrue(headingHyd.Displayed == true);
            Assert.IsTrue(headingHyd.Size != Size.Empty);
            dr.Close();
        }
        [Test]
        public void NavigationCommands()
        {
            dr.Navigate().GoToUrl("https://google.com");
            dr.Manage().Window.Maximize();
            dr.FindElement(By.Name("q")).SendKeys("India vs Pak");
            dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            dr.Navigate().Back();
            dr.Navigate().Forward();
            dr.Navigate().Refresh();
        }
        [Test]
        public void OpenEvents_Mahesh()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://bookmyshow.com");
            dr.Manage().Window.Maximize();
            IWebElement linkHyd = dr.FindElement(By.XPath("//span[text()='Hyderabad']"));
            linkHyd.Click();
            dr.FindElement(By.LinkText("Events")).Click();
            Assert.IsTrue(dr.Url.Contains("events-hyderabad"));
            Assert.IsTrue(dr.Title.Contains("Hyderabad"), "Hyderabad is not displayed in title");

        }

        [Test]
        public void SearchSelenium()
        {
           
            dr.Navigate().GoToUrl("https://techtutorialz.com");
            dr.Manage().Window.Maximize();
            //dr.FindElement(By.Id("s")).SendKeys("Selenium");
            dr.FindElement(By.XPath("(//input[@name='s'])[2]")).SendKeys("Selenium");
        }
        [Test]
        public void VerifyBrokenLinks()
        {
            dr.Navigate().GoToUrl("https://techtutorialz.com");
            dr.Manage().Window.Maximize();
            ReadOnlyCollection<IWebElement> listLinks=  dr.FindElements(By.XPath("//a"));
            //Console.WriteLine(listLinks.Count);
            for(int i=0;i<listLinks.Count;i++)
            {
                  string navLink= listLinks[i].GetAttribute("href");
                if (string.IsNullOrEmpty(navLink))
                {
                    Console.WriteLine(listLinks[i].Text);
                }
            }
        }

    }
}
