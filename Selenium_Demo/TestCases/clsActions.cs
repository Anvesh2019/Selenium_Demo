using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Drawing;
using System.Threading;

namespace Selenium_Demo.TestCases
{
    public class clsActions
    {

        public IWebDriver dr;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("I am from setup method");
            dr = new ChromeDriver(@"C:\Users\v-anandag\Desktop");

        }

        [Test]
        public void MovetoElementAndClick()
        {
            dr.Navigate().GoToUrl("https://www.browserstack.com/");
            Actions action = new Actions(dr);
            IWebElement btnGetstartedFree = dr.FindElement(By.XPath("//a[@id='signupModalButton']"));
            action.MoveToElement(btnGetstartedFree).Click().Build().Perform();
            string expectedURL = "https://www.browserstack.com/users/sign_up";
            string actualURL = dr.Url;
            Assert.AreEqual(expectedURL, actualURL, "User is not navigated to signup page");
        }
        [Test]
        public void MovetoElementAndClick_withoutActions()
        {
            dr.Navigate().GoToUrl("https://www.browserstack.com/");

            IWebElement btnGetstartedFree = dr.FindElement(By.XPath("//a[@id='signupModalButton']"));
            btnGetstartedFree.Click();
            string expectedURL = "https://www.browserstack.com/users/sign_up";
            string actualURL = dr.Url;
            Assert.AreEqual(expectedURL, actualURL, "User is not navigated to signup page");
        }
        [Test]
        public void RightClickonElement()
        {
            dr.Navigate().GoToUrl("https://www.Techtutorialz.com/");
            Actions action = new Actions(dr);
            IWebElement element = dr.FindElement(By.XPath("//a[text()='View Tutorial Library']"));
            action.ContextClick(element).Build().Perform();

        }
        [Test]
        public void KeyDownonElement()
        {
            dr.Navigate().GoToUrl("https://www.Techtutorialz.com/");
            Actions action = new Actions(dr);
            IWebElement element = dr.FindElement(By.XPath("//a[text()='View Tutorial Library']"));
            action.KeyDown(element, Keys.Enter).Build().Perform();


        }
        [Test]
        public void VerifyPrivacyNote()
        {
            dr.Navigate().GoToUrl("http://amazon.in");
            IWebElement linkPrivacy = dr.FindElement(By.XPath("//a[text()='Privacy Notice']"));
            Actions action = new Actions(dr);
            action.ScrollToElement(linkPrivacy).Build().Perform();
            linkPrivacy.Click();
        }

        [Test]
        public void DragnDropElement()
        {
            dr.Navigate().GoToUrl("http://demo.guru99.com/test/drag_drop.html");

            //Element which needs to drag.    		
            IWebElement From = dr.FindElement(By.XPath("//*[@id='credit2']/a"));

            //Element on which need to drop.		
            IWebElement To = dr.FindElement(By.XPath("//*[@id='bank']/li"));

            //Using Action class for drag and drop.		
            Actions act = new Actions(dr);

            //Dragged and dropped.		
            act.DragAndDrop(From, To).Build().Perform();
            Thread.Sleep(2000);

            IWebElement debtMovement = dr.FindElement(By.XPath("//td[normalize-space(text())='Debit Movement']"));
            Assert.IsTrue(debtMovement.Size != Size.Empty, "Debit movement is not displayed");
        }
    }
}
