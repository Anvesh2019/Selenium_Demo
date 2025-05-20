using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Threading;

namespace Selenium_Demo
{
    public class AmazonTests
    {
        IWebDriver dr;
        [SetUp]
        public void setup()
        {
            dr =  new EdgeDriver("C:\\Users\\Anand.Gummadilli\\Downloads\\edgedriver_win64");

        }
        public void OpenAmazon1()
        {
            Console.WriteLine("open amazon test case");
        }
        [Test]
        public void OpenAmazon()
        {
            OpenAmazon1();
            //IWebDriver dr = new ChromeDriver("C:\\Users\\Anand.Gummadilli\\Downloads\\chrome-win64\\chrome-win64");
            IWebDriver dr = new EdgeDriver("C:\\Users\\Anand.Gummadilli\\Downloads\\edgedriver_win64");
            dr.Navigate().GoToUrl("https://Amazon.com");
            dr.Manage().Window.Maximize();
            Console.WriteLine(dr.Title);
            Console.WriteLine(dr.Url);
            //dr.FindElement(By.Id("twotabsearchtextbox")).SendKeys("Sony TV");
            //dr.FindElement(By.XPath("//input[@name='field-keywords']")).SendKeys("Sonytv");
            dr.FindElement(By.XPath("//input[@id='twotabsearchtextbox']")).SendKeys("Sony tv");
            //dr.Close();
        }
        [Test]

        public void OpenGmail123()
        {
            IWebDriver dr = new EdgeDriver("C:\\Users\\Anand.Gummadilli\\Downloads\\edgedriver_win64");
            dr.Navigate().GoToUrl("https://google.com");
            //dr.FindElement(By.LinkText("Gmail")).Click();
            //dr.FindElement(By.PartialLinkText("capable")).Click();

            IWebElement txtSrch = dr.FindElement(By.Name("q"));
            string mlength= txtSrch.GetAttribute("maxlength");
            Assert.IsTrue(mlength=="2048","Max length is NOT 2048");

            string stitle= txtSrch.GetAttribute("title");
            Assert.IsTrue(stitle== "Search","title is not search");
        }
        [Test]
        public void search1()
        {
            dr.Navigate().GoToUrl("https://google.com");
            dr.FindElement(By.Name("q")).SendKeys("India");
            dr.FindElement(By.Id("voiceSearchButton")).Click();

           
        }
        [Test]
        public void LearnJavascriptExecuter()
        {
            dr.Navigate().GoToUrl("https://www.google.com/");
            dr.FindElement(By.Name("q")).SendKeys("India");
            IWebElement sicon = dr.FindElement(By.XPath("//div[@aria-label='Search by voice']"));
            Thread.Sleep(2000);
            sicon.Click();
        }
        private string GetAssemblyPath()
        {
            throw new NotImplementedException();
        }
    }
}
