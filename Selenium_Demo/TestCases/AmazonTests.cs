using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using Selenium_Demo.Common;
using Selenium_Demo.Pages;
using System.Threading;

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
            //dr = new EdgeDriver($"{Directory.GetCurrentDirectory()}\\DriverHelper");
            dr = new ChromeDriver();
            _apage = new AmazonPage(dr);
            objCommon = new clsCommon(dr);
            
        }
        [Test]
        [Category("Amazon")]
        public void VerifyCart() 
        {
            dr.Navigate().GoToUrl("https://amazon.in");
            _apage.cart.Click();
            Assert.IsTrue(_apage.headingCartEmpty.Displayed==true,"Not navigated to cart page");
        }
        [Test]
        [Category("Amazon")]
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
        [Test]
        public void VerifyLinks()
        {
            dr.Navigate().GoToUrl("https://amazon.in");
            IWebElement linkFashion = dr.FindElement(By.XPath("//a[text()='Fashion']"));
            Assert.IsTrue(linkFashion.Displayed == true);


            IWebElement linkElec = dr.FindElement(By.XPath("//a[normalize-space(text())='Electronics']"));
            Assert.IsTrue(linkElec.Displayed == true,"Electronics not displayed");
        }
        
        [Test]
        [Category("Amazon")]
        public void SearchGoldmedal()
        {
            string actValue = "Goldmedal";
            objCommon.NavigateToApp("https://amazon.in");
            dr.Manage().Window.Maximize();
            dr.FindElement(By.Id("twotabsearchtextbox")).SendKeys(actValue);
            //dr.FindElement(By.Id("nav-search-submit-button")).Click();
            Thread.Sleep(2000);
            dr.FindElement(By.XPath("(//input[@class='nav-input nav-progressive-attribute'])[2]")).Click();
            string srchItem = dr.FindElement(By.Id("twotabsearchtextbox")).GetAttribute("value");
            Console.WriteLine("product name is:" + srchItem);
            Assert.IsTrue(srchItem==actValue,"prod name not matching");

        }

        [Test]
        public void Apnaohio()
        {
            dr.Navigate().GoToUrl("https://apnaohio.com/new_ad.jsp");
            string source = dr.PageSource;
            Console.WriteLine(source);
        }
        [Test]
        public void SaisTestcase()
        {
            Console.Write("Sais test cases");
        }
        [Test]
        public void SaiTestCase2()
        {
            Console.WriteLine("Ram");
        }
        [Test]
        public void SearchItem()
        {

            try
            {
                objCommon.NavigateToApp("https://amazon.in");
                //_apage.NavigatetoAmazon();
                Thread.Sleep(5000);
                _apage.txtSearch.SendKeys("SonyTV");
                _apage.btnSrch.Click();
            }
            catch (Exception ex)
            {
                objCommon.GetScreenshot();
            }
        }
        [Test]
        public void test1()
        {
            Console.WriteLine("testcase1");
        }


    }
}
