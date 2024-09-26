using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Selenium_Demo.Pages;
using Selenium_Demo.Common;

namespace Selenium_Demo.TestCases
{
    public class GoogleTests
    {
        public IWebDriver dr;
        GooglePage _objGooglePage;
        clsCommon objCommon;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("I am from setup method");
            dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads");
            _objGooglePage = new GooglePage(dr);
            objCommon = new clsCommon(dr);
        }

        [Test]
        public void VerifyName()
        {
            int x = 10;
            int y = 20;
            if(x>y)
            {
                Console.WriteLine("x is greater than y");
            }
            else
            {
                Console.WriteLine("x is less than y");
            }
            
        }

        [Test]
        public void GoogleSearch()
        {
            dr.Navigate().GoToUrl("http://google.com");
            //_objGooglePage.txtSearch.SendKeys("India");
            //_objGooglePage.txtSearch.SendKeys(Keys.Enter);
            _objGooglePage.SearchForKeyword("India");

            //objCommon.EnterText(_objGooglePage.txtSearch, "India");
            ////objCommon.EnterText("q", "India");
            //objCommon.EnterText(_objGooglePage.txtSearch, Keys.Enter);


            //dr.FindElement(By.Name("q")).SendKeys("India");
        }
        [Test]
        public void GoogleFeelingLuckySearch()
        {
            dr.Navigate().GoToUrl("http://google.com");
            _objGooglePage.SearchByFeelingLucky("India");

           
        }
        [Test]
        public void VerifyGmail()
        {
          objCommon.NavigateToApp("http://google.com");
          _objGooglePage.linkGmail.Click();
          Assert.IsTrue(dr.Url.Contains("gmail"),"Gmail page not displayed");
       
        }
    }
}
