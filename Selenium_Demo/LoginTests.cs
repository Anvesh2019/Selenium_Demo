using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
namespace Selenium_Demo
{
    public class LoginTests
    {

        public IWebDriver dr;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("I am from setup method");
            dr = new ChromeDriver(@"C:\Users\v-anandag\Desktop");

        }

        [Test]
        public void VerifySearch()
        {
            dr.Navigate().GoToUrl("https://google.com");
            dr.FindElement(By.Name("q")).SendKeys("India");
            dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        }

        [Test]
        public void VerifyStudname()
        {
            clsStud objStud = new clsStud();
            objStud.DisplaySname();
        }
        [Test]
        [TestCase("India")]
        [TestCase("Daton")]
        [TestCase("Cleveland")]

        public void Errormsg(string city)
        {
            dr.Navigate().GoToUrl("https://www.axismf.com");
            
            dr.FindElement(By.XPath("(//ion-button[@id='origin'])[2]")).Click();
            Thread.Sleep(2000);
            dr.FindElement(By.XPath("(//input[@name='pan'])[2]")).SendKeys(city);
            IWebElement pan = dr.FindElement(By.XPath("//div[text()='Please enter a correct PAN']"));
            Thread.Sleep(2000);
            Assert.IsTrue(pan.Displayed == true, "Error message is not displayed");

        }
        [Test]
        public void NavigationCommands()
        {
            
            dr.Navigate().GoToUrl("http://axismf.com");
            dr.Manage().Window.Maximize();
            //dr.FindElement(By.XPath("//a[@href='about-us']")).Click();
            //dr.FindElement(By.LinkText("About Us")).Click();
            //dr.FindElement(By.XPath("//a[text()=' About Us ']")).Click();
            dr.FindElement(By.XPath("(//a[@id='top-pane-label'])[2]")).Click();
            string currenturl = dr.Url;
            Assert.IsTrue(currenturl== "https://www.axismf.com/about-us","Aboutus page is not loaded");
            string pageTitle = dr.Title;
            Assert.IsTrue(pageTitle.Contains("About Us"),"Aboutus page is not loaded");
            Assert.AreEqual("About Us - Axis Mutual Fund Company in India| Axis MF",pageTitle,"Page title is not matching");
            dr.Navigate().Back();
            currenturl = dr.Url;
            Assert.IsTrue(currenturl== "https://www.axismf.com/","Home page is not loaded");
            //dr.Navigate().Forward();
            //pageTitle = dr.Title;
            //Assert.IsTrue(pageTitle.Contains("About Us"), "Aboutus page is not loaded");
            dr.Navigate().Refresh();
        }

        [Test]
        public void Testcase2()
        {
            
            DisplayName("Arun");
            //Assert.Pass();
            string dateTime  = DateTime.Now.ToString("yyyyMMdd");
            Console.WriteLine(dateTime);
        }
        [Test]
        public void LoginGmail()
        {
            dr.Navigate().GoToUrl("https://www.gmail.com");
            dr.Manage().Window.Maximize();
            //  dr.FindElement(By.XPath("//input[@type='email']")).Click();
            IWebElement uid = dr.FindElement(By.Name("identifier"));
            uid.Clear();
            //dr.FindElement(By.Name("identifier")).Clear();
            //dr.FindElement(By.Name("identifier")).SendKeys("pallavi.pulivarthy@myplanet.com");
            uid.SendKeys("pallavi.pulivarthy@myplanet.com");
            Console.WriteLine("Uid text is:" + uid.GetAttribute("value"));
            Console.WriteLine("Uid type is:" + uid.GetAttribute("type"));

            dr.FindElement(By.XPath("(//span[@jsname='V67aGc'])[2]")).Click();

        }

        [Test]
        public void InteractWithCheckBox()
        {
            dr.Navigate().GoToUrl("https://www.ironspider.ca/forms/checkradio.htm");
            IWebElement chkBlue = dr.FindElement(By.XPath("//input[@value='blue']"));
            //Console.WriteLine("blue color is selected:" + chkBlue.Selected);
            if(chkBlue.Selected==false)
            {
                chkBlue.Click();
            }
            IWebElement radioOpera = dr.FindElement(By.XPath("(//input[@type='radio'])[3]"));
            Console.WriteLine("Opera is selected1:" + radioOpera.Selected);
            if(radioOpera.Selected==false)
            {
                radioOpera.Click();
            }
            Console.WriteLine("Opera is selected2:" + radioOpera.Selected);


        }
        [Test]
        public void HandlingSelectBox()
        {
            dr.Navigate().GoToUrl("https://demo.guru99.com/test/newtours/register.php");
            IWebElement ddCountry = dr.FindElement(By.Name("country"));
            //ddCountry.SendKeys("Hyderabad");
            SelectElement objSelect = new SelectElement(dr.FindElement(By.Name("country")));
            objSelect.SelectByIndex(2);
            objSelect.SelectByText("INDIA");
            objSelect.SelectByValue("CHINA");
        }

        public void DisplayName(string sname)
        {
            Console.WriteLine("My name is:" + sname);
        }

//        Returns Course Fee
//Parameter: Course name
//Manual Testing: 15000
//Selenium: 25000

        [Test]
        public void VerifyFeeDetails()
        {
            int fee= GetFeeDetails("Manual Testing");
            //Assert.IsTrue(fee == 15000, "Fee is not same as expected");
            Assert.AreEqual(fee, 25000, "Fee is not same as expected");
        }
        public int GetFeeDetails(string cname)
        {
            int fee = 0;
            if(cname=="Manual Testing")
            {
                fee= 15000;
            }
            else
            {
                fee = 25000;
            }
            return fee;
        }
        [TearDown]
        public void Cleanup()
        {
            Console.WriteLine("I am cleanup method");
        }
    }
}