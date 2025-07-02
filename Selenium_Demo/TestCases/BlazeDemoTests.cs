using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Threading;
namespace Selenium_Demo.TestCases
{
    public class BlazeDemoTests
    {
        IWebDriver dr;
        [SetUp]
        public void setup()
        {

            dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://blazedemo.com/register");

        }
        [Test]
        public void VerifyRegistration()
        {   
            Assert.IsTrue(dr.Title=="BlazeDemo","Blazedemo Registration page not loaded");
            Assert.IsTrue(dr.Url=="https://blazedemo.com/register", "Registration page not loaded");
            dr.FindElement(By.Id("name")).SendKeys("Anand");
            dr.FindElement(By.Id("company")).SendKeys("Techtutorialz.com");
            dr.FindElement(By.Id("email")).SendKeys("anandg99@yahoo.com");
            dr.FindElement(By.Id("password")).SendKeys("1234");
            dr.FindElement(By.Id("password-confirm")).SendKeys("1234");
            dr.FindElement(By.XPath("//button[contains(text(),'Register')]")).Click();
        }
        [Test]
        public void VerifyRegistrationWithWrongPwd()
        {
            Assert.IsTrue(dr.Title == "BlazeDemo", "Blazedemo Registration page not loaded");
            Assert.IsTrue(dr.Url == "https://blazedemo.com/register", "Registration page not loaded");
            dr.FindElement(By.Id("name")).SendKeys("Anand");
            dr.FindElement(By.Id("company")).SendKeys("Techtutorialz.com");
            dr.FindElement(By.Id("email")).SendKeys("anandg99@yahoo.com");
            dr.FindElement(By.Id("password")).SendKeys("1234");
            dr.FindElement(By.Id("password-confirm")).SendKeys("12345");
            dr.FindElement(By.XPath("//button[contains(text(),'Register')]")).Click();
            IWebElement errmsg = dr.FindElement(By.XPath(""));
            Assert.IsTrue(errmsg.Displayed == true,"Registration successfull");
        }
        [Test]
        public void VerifyRequiredFields()
        {
            Assert.IsTrue(dr.Title == "BlazeDemo", "Blazedemo Registration page not loaded");
            Assert.IsTrue(dr.Url == "https://blazedemo.com/register", "Registration page not loaded");
           // dr.FindElement(By.Id("name")).SendKeys("Anand");
            dr.FindElement(By.Id("company")).SendKeys("Techtutorialz.com");
            dr.FindElement(By.Id("email")).SendKeys("anandg99@yahoo.com");
            dr.FindElement(By.Id("password")).SendKeys("1234");
            dr.FindElement(By.Id("password-confirm")).SendKeys("12345");
            dr.FindElement(By.XPath("//button[contains(text(),'Register')]")).Click();
            // IWebElement errmsg = dr.FindElement(By.XPath(""));
            //Assert.IsTrue(errmsg.Displayed == true, "Registration successfull");
            //IAlert alert = dr.SwitchTo().Alert();
            //alert.Accept();

        }
        [Test]
        public void VerifyElementsDisplayed()
        {
            dr.Navigate().GoToUrl("https://blazedemo.com/register");
            IWebElement regLabel = dr.FindElement(By.XPath("//div[text()='Register']"));
            Assert.IsTrue(regLabel.Displayed == true);
            Assert.IsTrue(regLabel.Size != Size.Empty);
            //dr.Close();
        }
        [Test]
        public void GetLinks()
        {
            dr.Navigate().GoToUrl("https://www.makemytrip.com/");
            dr.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement btnClose = dr.FindElement(By.XPath("//span[@data-cy='closeModal']"));
            btnClose.Click();
            ReadOnlyCollection <IWebElement> listCat=  dr.FindElements(By.XPath("(//span[@data-cy='item-wrapper'])/a/span[@class='headerIconTextAlignment chNavText darkGreyText'] "));
            for (int i = 0; i < listCat.Count; i++)
            {
                IWebElement link = listCat[i];
                //Assert.IsNotNull(link);
                Console.WriteLine(link.Text);   
                if(link.Text =="Cabs")
                {
                    link.Click();
                    Assert.IsTrue(dr.Url.Contains("cabs"),"Cabs page is not loaded");
                }
            }
            dr.Close();
            
        }
    }
}
