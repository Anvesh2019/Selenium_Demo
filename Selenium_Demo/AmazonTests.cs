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
using Selenium_Demo.Common;

namespace Selenium_Demo
{
    public class AmazonTests
    {
        IWebDriver dr;
        [SetUp]
        public void setup()
        {
            //dr =  new EdgeDriver("C:\\Users\\Anand.Gummadilli\\Downloads\\edgedriver_win64");
            dr = new ChromeDriver();
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
            IWebDriver dr = new EdgeDriver("C:\\Users\\Anand\\Downloads\\");
            dr.Navigate().GoToUrl("https://Amazon.com");
            dr.Manage().Window.Maximize();
            Console.WriteLine(dr.Title);
            Console.WriteLine(dr.Url);
            //dr.FindElement(By.Id("twotabsearchtextbox")).SendKeys("Sony TV");
            //dr.FindElement(By.XPath("//input[@name='field-keywords']")).SendKeys("Sonytv");
           dr.FindElement(By.XPath("//input[@id='twotabsearchtextbox']")).SendKeys("Sony tv");
           dr.Close();
        }
        [Test]
        public void VerifyPriceRange()
        {
            //IWebDriver dr = new ChromeDriver("C:\\Users\\Anand.Gummadilli\\Downloads\\chrome-win64\\chrome-win64");
            IWebDriver dr = new EdgeDriver("C:\\Users\\Anand\\Downloads\\");
            dr.Navigate().GoToUrl("https://Amazon.com");
            dr.Manage().Window.Maximize();
            dr.FindElement(By.Id("twotabsearchtextbox")).SendKeys("Sony TV");
            dr.FindElement(By.Id("nav-search-submit-button")).Click();

        }
        [Test]

        public void LearnGetAttribute()
        {
            IWebDriver dr = new EdgeDriver("C:\\Users\\Anand\\Downloads\\");
            dr.Navigate().GoToUrl("https://google.com");
            //dr.FindElement(By.LinkText("Gmail")).Click();
            //dr.FindElement(By.PartialLinkText("capable")).Click();

            IWebElement txtSrch = dr.FindElement(By.Name("q"));
            string mlength= txtSrch.GetAttribute("maxlength");
            Console.WriteLine("max length is:" + mlength);
            Assert.IsTrue(mlength=="3000","Max length is NOT 2048");

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
            //dr.FindElement(By.Name("q")).SendKeys("India");
            //IWebElement sicon = dr.FindElement(By.XPath("//div[@aria-label='Search by voice']"));
            IJavaScriptExecutor js= (IJavaScriptExecutor)dr;
            //js.ExecuteScript("arguments[0].click(); return true", sicon);
            js.ExecuteScript("document.getElementById('APjFqb').value='India'");
            //Thread.Sleep(2000);
            //sicon.Click();
        }
        [Test]
        public void ClickGmail()
        {
            dr.Navigate().GoToUrl("https://www.google.com/");
            IWebElement gmailLink = dr.FindElement(By.LinkText("Gmail"));
            clsCommon objCommon = new clsCommon(dr);
            objCommon.ClickElementUsingJSE(gmailLink);
        }
        private string GetAssemblyPath()
        {
            throw new NotImplementedException();
        }
        [Test]
        public void VerifyMethods()
        {
            Class1 obj1 = new Class1();
            obj1.addNumbers(50, 150);
            obj1.addNumbers(150, 1500);
            obj1.addNumbers(1500, 15000);

            int result=obj1.GetSumofNumbers(4000, 5500);
            Console.WriteLine(result);

           string ccity= obj1.Getcapitalcity("MH");
            Console.WriteLine(ccity);

            string[] arrStr=obj1.GetWords("My name is Anand");
            Console.WriteLine(arrStr.Length);

        }
    }
}
