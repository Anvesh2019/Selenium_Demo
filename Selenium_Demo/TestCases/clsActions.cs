﻿using System.Collections.Generic;
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
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized"); //Maximize the window when it starts
            //options.AddArgument("incognito");
            //options.AddArgument("headless");
            options.AddArgument("useAutomationExtension");
            options.AddArgument("disable-extensions"); //disables existing extentions
            options.AddArgument("disable-popup-blocking"); //disabled popups displayed from chrome browser
            options.AddArgument("disable-infobars");//disables info bars
            dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads\");
        }

        [Test]
        public void VerifyOptions()
        {
          //  dr.Navigate().GoToUrl("https://google.com");
            dr.FindElement(By.Name("q")).SendKeys("India");
        }
        [Test]
        public void OpenRedBus()
        {
            dr.Navigate().GoToUrl("https://www.google.com/search?gs_ssp=eJzj4tLP1TcwM403SUpXYDRgdGDwYitKTUkqLQYASIEGPg&q=redbus&rlz=1C1CHBD_enIN1082IN1082&oq=red&gs_lcrp=EgZjaHJvbWUqGAgCEC4YQxiDARjHARixAxjRAxiABBiKBTIOCAAQRRg5GEMYgAQYigUyEggBEAAYQxiDARixAxiABBiKBTIYCAIQLhhDGIMBGMcBGLEDGNEDGIAEGIoFMhIIAxAAGEMYgwEYsQMYgAQYigUyDAgEEAAYQxiABBiKBTISCAUQABhDGIMBGLEDGIAEGIoFMhIIBhAAGEMYgwEYsQMYgAQYigUyGAgHEC4YQxiDARjHARixAxjRAxiABBiKBTISCAgQLhhDGLEDGIAEGOUEGIoFMhMICRAuGIMBGMcBGLEDGNEDGIAE0gEJMzM2N2owajE1qAIIsAIB&sourceid=chrome&ie=UTF-8");
        }
        [Test]
        public void MovetoElementAndClick()
        {
            dr.Navigate().GoToUrl("https://www.browserstack.com/");
            Actions action = new Actions(dr);
            IWebElement btnGetstartedFree = dr.FindElement(By.XPath("//a[@id='signupModalProductButton']"));
            action.MoveToElement(btnGetstartedFree).Click().Build().Perform();
            string expectedURL = "https://www.browserstack.com/users/sign_up";
            string actualURL = dr.Url;
            Assert.AreEqual(expectedURL, actualURL, "User is not navigated to signup page");
        }
        [Test]
        public void MovetoElementAndClick_withoutActions()
        {
            dr.Navigate().GoToUrl("https://www.browserstack.com/");
            IWebElement btnGetstartedFree = dr.FindElement(By.XPath("//a[@id='signupModalProductButton']"));
            btnGetstartedFree.Click();
            string expectedURL = "https://www.browserstack.com/users/sign_up";
            string actualURL = dr.Url;
            Assert.AreEqual(expectedURL, actualURL, "User is not navigated to signup page");
        }
        [Test]
        public void RightClickonElement()
        {
            dr.Navigate().GoToUrl("https://www.Techtutorialz.com/");
            dr.Manage().Window.Maximize();
            Actions action = new Actions(dr);
            IWebElement element = dr.FindElement(By.XPath("//a[text()='View Tutorial Library']"));
            action.ContextClick(element).Build().Perform();
            dr.Close();

        }
        [Test]
        public void DoubleClickonElement()
        {
            dr.Navigate().GoToUrl("https://www.Techtutorialz.com/");
            dr.Manage().Window.Maximize();
            Actions action = new Actions(dr);
            IWebElement element = dr.FindElement(By.XPath("//a[text()='View Tutorial Library']"));
            action.DoubleClick(element).Build().Perform();

        }
        [Test]
        public void KeyDownonElement()
        {
            dr.Navigate().GoToUrl("https://www.Techtutorialz.com/");
            dr.Manage().Window.Maximize();
            Actions action = new Actions(dr);
            IWebElement linkTL = dr.FindElement(By.XPath("//a[text()='View Tutorial Library']"));
            action.KeyDown(linkTL, Keys.Enter).Build().Perform();
            string actualURL = dr.Url;
            Assert.IsTrue(actualURL.Contains("tutorials-library"), "Not reached to Tutorial library page");
            dr.Close();
        }
        [Test]
        public void KeyDownonElement1()
        {
            dr.Navigate().GoToUrl("https://www.Techtutorialz.com/");
            dr.Manage().Window.Maximize();
            Actions action = new Actions(dr);
            IWebElement element = dr.FindElement(By.XPath("//a[text()='View Tutorial Library']"));
            element.Click();
            string actualURL = dr.Url;
            Assert.IsTrue(actualURL.Contains("tutorials-library"), "Not reached to Tutorial library page");
            dr.Close();
        }
        [Test]
        public void KeyDownonElement2()
        {
            dr.Navigate().GoToUrl("https://www.google.com/");
            dr.Manage().Window.Maximize();
            Actions action = new Actions(dr);
            IWebElement txtSrch = dr.FindElement(By.Name("q"));
            action.KeyDown(txtSrch,"I").Build().Perform();
            action.KeyDown(txtSrch, "N").Build().Perform();
            action.KeyDown(txtSrch, "D").Build().Perform();
            action.KeyDown(txtSrch, "I").Build().Perform();
            action.KeyDown(txtSrch, "A").Build().Perform();


            //dr.Close();
        }
        [Test]
        public void VerifyPrivacyNote()
        {
            dr.Navigate().GoToUrl("http://amazon.in");
            IWebElement linkPrivacy = dr.FindElement(By.XPath("//a[text()='Privacy Notice']"));
            Actions action = new Actions(dr);
            action.ScrollToElement(linkPrivacy).Build().Perform();
            //action.SendKeys(Keys.PageDown).Build().Perform();
            linkPrivacy.Click();
        }

        [Test]
        public void DragAndDropElement()
        {
            dr.Navigate().GoToUrl("http://demo.guru99.com/test/drag_drop.html");

            //Element which needs to drag.    		
            IWebElement From = dr.FindElement(By.XPath("//*[@id='credit2']/a"));

            //Element on which need to drop.		
            IWebElement To = dr.FindElement(By.XPath("//*[@id='bank']/li"));

            //Using Action class for drag and drop.		
            Actions action = new Actions(dr);

            //Dragged and dropped.		
            action.DragAndDrop(From, To).Build().Perform();
            Thread.Sleep(2000);

            IWebElement debtMovement = dr.FindElement(By.XPath("//td[normalize-space(text())='Debit Movement']"));
            Assert.IsTrue(debtMovement.Size != Size.Empty, "Debit movement is not displayed");
        }
    }
}
