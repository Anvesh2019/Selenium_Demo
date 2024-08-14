using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Selenium_Demo.Common;
namespace Selenium_Demo.TestCases
{
    public class Class1
    {
        public clsCommon _common = null;
        public IWebDriver dr;
        [SetUp]
        public void Setup()
        {
            dr = new ChromeDriver(@"C:\Users\HP\Downloads\chromedriver-win64");
             _common = new clsCommon(dr);
        }

        [Test]
        public void VerifyUniversityDetails()
        {
            clsUniversity objUni = new clsUniversity();
            Console.WriteLine("Univercity Type is:" + objUni.uType);
            objUni.founder = "KCR";
            Console.WriteLine("Univercity founder is:" + objUni.founder);
            objUni.DisplayUnivName();
            Console.WriteLine("Univercity is good:" + objUni.isGood);
            Console.WriteLine(DateTime.Now.Year);
            objUni.DisplayStudName("Anvesh");
        }
        [Test]
        public void VerifyCommonMethods()
        {
            dr.Navigate().GoToUrl("https:\\www.google.com");
            IWebElement linkGmail = dr.FindElement(By.LinkText("Gmail"));
            _common.ClickonElement(linkGmail);
        }

    }
}
