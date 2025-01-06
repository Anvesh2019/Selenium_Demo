using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using Selenium_Demo.Common;
using Selenium_Demo.Pages;

namespace Selenium_Demo.TestCases
{
    public class AmazonTests
    {
        IWebDriver dr;
        AmazonPage _apage;
        clsCommon objCommon;
        [SetUp]
        public void setup()
        {
            //dr = new EdgeDriver("C:\\Users\\Anand.Gummadilli\\Downloads\\edgedriver_win64");
            dr = new EdgeDriver($"{Directory.GetCurrentDirectory()}\\DriverHelper");

            _apage = new AmazonPage(dr);
            objCommon = new clsCommon(dr);
            
        }
        [Test]
        public void VerifyCart() 
        {
            dr.Navigate().GoToUrl("https://amazon.in");
            _apage.cart.Click();
            Assert.IsTrue(_apage.headingCartEmpty.Displayed==true,"Not navigated to cart page");
        }
        [Test]
        public void VerifySignupNow()
        {
            objCommon.NavigateToApp("https://amazon.in");
            dr.Manage().Window.Maximize();
            //_apage.cart.Click();
            _apage.ClickOnCart();
            Assert.IsTrue(_apage.headingCartEmpty.Displayed == true, "Not navigated to cart page");
            //_apage.btnSignupNow.Click();
            _apage.clickonSignup();
        }
    }
}
