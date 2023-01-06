using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
using System.Collections;
//using Dotnetselenium
using System.IO;
using System.Collections.Generic;

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
        public void VerifyNavigationCommands()
        {
            dr.Navigate().GoToUrl("https://techtutorialz.com");
            dr.Manage().Window.Maximize();
            dr.FindElement(By.XPath("//a[@title='Resumes']")).Click(); //Navigate to Resumes page
            dr.Navigate().Back(); //browser back
            //string expectedURL = "https://techtutorialz.com/";
            //Assert.IsTrue(dr.Url == expectedURL, "Home page is not loaded");

            IWebElement viewLibrary = dr.FindElement(By.XPath("//a[text()='View Tutorial Library']"));
            Assert.IsTrue(viewLibrary.Size!=Size.Empty); //Element presents
            dr.Navigate().Forward(); //navigate to resumes page

            IWebElement bcLink = dr.FindElement(By.XPath("//div[@class='page-breadcrum']/div/ul/li/a[text()='Resumes']"));
            Assert.IsTrue(bcLink.Text == "Resumes", "Resumes page is not loaded");
            Thread.Sleep(2000);
            dr.Navigate().Refresh();
        }
            [Test]
        public void VerifyResumes()
        {
            dr.Navigate().GoToUrl("https://techtutorialz.com");
            dr.Manage().Window.Maximize();

            dr.FindElement(By.XPath("//a[@title='Resumes']")).Click();
            //string actualUrl = dr.Url;
            //Assert.AreEqual("https://techtutorialz.com/category/resumes/", actualUrl,"Resumes page is not loaded");

            //IWebElement heading = dr.FindElement(By.XPath("//h2[@class='category-page-title']"));
            //Assert.IsTrue(heading.Text == "RESUMES", "Resumes page not loaded");

            IWebElement bcLink = dr.FindElement(By.XPath("//div[@class='page-breadcrum']/div/ul/li/a[text()='Resumes']"));
            Assert.IsTrue(bcLink.Text=="Resumes","Resumes page is not loaded");
        }
        [Test]
        public void VerifyTraining()
        {
            dr.Navigate().GoToUrl("https://techtutorialz.com");
            dr.Manage().Window.Maximize();

            //dr.FindElement(By.XPath("//a[@title='Training']")).Click();
            dr.FindElement(By.LinkText("TRAINING")).Click();
            //string actualUrl = dr.Url;
            //Assert.AreEqual("https://techtutorialz.com/category/resumes/", actualUrl,"Resumes page is not loaded");

            //IWebElement heading = dr.FindElement(By.XPath("//h2[@class='category-page-title']"));
            //Assert.IsTrue(heading.Text == "RESUMES", "Resumes page not loaded");

            IWebElement bcLink = dr.FindElement(By.XPath("//div[@class='page-breadcrum']/div/ul/li/a[text()='training']"));
            Assert.IsTrue(bcLink.Text == "training", "training page is not loaded");
        }
        [Test]
        public void OpenGmail()
        {
            dr.Navigate().GoToUrl("https://google.com");
            Console.WriteLine("Title is:" + dr.Title);

            dr.FindElement(By.LinkText("Gmail")).Click();
            dr.FindElement(By.LinkText("Sign in")).Click();
            dr.FindElement(By.Id("identifierId")).SendKeys("agummadilli@gmail.com");
            dr.FindElement(By.XPath("//span[text()='Next']")).Click();
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
       
        public void VerifyPanNumberErrormsg()
        {
            dr.Navigate().GoToUrl("https://www.axismf.com");
            dr.FindElement(By.XPath("(//ion-button[@id='origin'])[2]")).Click(); //click on Login button
            //Thread.Sleep(5000);
            WebDriverWait wait = new WebDriverWait(dr,TimeSpan.FromSeconds(20));
            
            //IWebElement elementPan = dr.FindElement(By.XPath("(//input[@name='pan'])[2]"));
           
            var elementPan = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@name='pan'])[2])")));

            elementPan.SendKeys("India"); //enter india in PAn number
            
            IWebElement panError = dr.FindElement(By.XPath("//div[text()='Please enter a correct PAN']"));
            Thread.Sleep(2000);
            //Assert.IsTrue(panError.Displayed == true, "Error message is not displayed");
            Assert.IsTrue(panError.Size != Size.Empty,"validation error is not displayed for PAN"); //Error is displayed

        }
        [Test]

        public void Getscreenshot()
        {
            try
            {
                dr.Navigate().GoToUrl("https://www.axismf.com");
                dr.FindElement(By.XPath("(//ion-button[@id='origin'])[2]")).Click(); //click on Login button

                IWebElement elementPan = dr.FindElement(By.XPath("(//input[@name='pan'])[2]"));
                elementPan.SendKeys("India"); //enter india in PAn number

                IWebElement panError = dr.FindElement(By.XPath("//div[text()='Please enter a correct PAN']"));
                Thread.Sleep(2000);
                Assert.IsTrue(panError.Size != Size.Empty, "validation error is not displayed for PAN"); //Error is displayed

            }
            catch(ElementClickInterceptedException clickex)
            {
                Console.WriteLine(clickex.Message);
            }
            catch(NoSuchElementException nosuchex)
            {
                Console.WriteLine(nosuchex.Message);
            }
            catch(NoSuchWindowException ex)
            {
                ITakesScreenshot screenshotDriver = dr as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                // Creating UIScreenshot folder if not exists
                System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "/UIScreenshots/");
                string fileName = Environment.CurrentDirectory + "/UIScreenshots/" + "sampletestcase" + "_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".png";
                screenshot.SaveAsFile(fileName, ScreenshotImageFormat.Png);
            }

        }

        [Test]
        public void HandleMultipleTabs()
        {
            dr.Navigate().GoToUrl("https://demoqa.com/browser-windows");

            string windowhandleParent = dr.CurrentWindowHandle; //getting parentwindow handle
            IWebElement btnNewwindow = dr.FindElement(By.XPath("//button[@id='tabButton']"));
            btnNewwindow.Click();
            System.Collections.ObjectModel.ReadOnlyCollection<string> lstWindow = dr.WindowHandles;
            foreach (var handle in lstWindow)
            {
                Console.WriteLine(handle);
            }
            //Switching the driver to 2nd window
            dr.SwitchTo().Window(lstWindow[1]);
            IWebElement sampleText = dr.FindElement(By.XPath("//h1[@id='sampleHeading']"));
            Assert.IsTrue(sampleText.Displayed, "Sample text is not displayed");
            dr.Navigate().GoToUrl("http://google.com");
            dr.SwitchTo().Window(windowhandleParent); //return to parent window
            Console.WriteLine(dr.Title); //get the parent window title and print
        }

        [Test]
        public void HandleMultipleWindows()
        {
            dr.Navigate().GoToUrl("https://demoqa.com/browser-windows");

            string windowhandleParent = dr.CurrentWindowHandle;
            IWebElement btnNewwindow = dr.FindElement(By.XPath("//button[@id='windowButton']"));
            btnNewwindow.Click();
            System.Collections.ObjectModel.ReadOnlyCollection<string> lstWindow = dr.WindowHandles;
            foreach (var handle in lstWindow)
            {
                Console.WriteLine(handle);
            }
            //Switching the driver to 2nd window
            dr.SwitchTo().Window(lstWindow[1]);
            IWebElement sampleText = dr.FindElement(By.XPath("//h1[@id='sampleHeading']"));
            Assert.IsTrue(sampleText.Displayed,"Sample text is not displayed");
            dr.SwitchTo().Window(windowhandleParent); //return to parent window
            Console.WriteLine(dr.Title);
        }
        [Test]
        public void Devidebyzero()
        {
            try
            {
                int x = 10;
                int y = 0;
                int z = x / y;
            }
           catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
            Assert.IsTrue(currenturl == "https://www.axismf.com/about-us", "Aboutus page is not loaded");
            string pageTitle = dr.Title;
            Assert.IsTrue(pageTitle.Contains("About Us"), "Aboutus page is not loaded");
            Assert.AreEqual("About Us - Axis Mutual Fund Company in India| Axis MF", pageTitle, "Page title is not matching");
            dr.Navigate().Back();
            currenturl = dr.Url;
            Assert.IsTrue(currenturl == "https://www.axismf.com/", "Home page is not loaded");
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
            string dateTime = DateTime.Now.ToString("yyyyMMdd");
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
            Console.WriteLine("area label is:" + uid.GetAttribute("aria-label"));

            dr.FindElement(By.XPath("(//span[@jsname='V67aGc'])[2]")).Click();

        }

        [Test]
        public void InteractWithCheckBoxAndRadio()
        {
            dr.Navigate().GoToUrl("https://www.ironspider.ca/forms/checkradio.htm");
            IWebElement chkBlue = dr.FindElement(By.XPath("//input[@value='blue']"));
            //Console.WriteLine("blue color is selected:" + chkBlue.Selected);
            if (chkBlue.Selected == false)
            {
                chkBlue.Click(); //unselect
            }
            IWebElement radioOpera = dr.FindElement(By.XPath("(//input[@type='radio'])[3]"));
            Console.WriteLine("Opera is selected1:" + radioOpera.Selected);
            if (radioOpera.Selected == false)
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
            //ddCountry.SendKeys("HYDERABAD");
            //SelectElement objSelect = new SelectElement(dr.FindElement(By.Name("country")));
            SelectElement objSelect = new SelectElement(ddCountry);

            //objSelect.SelectByIndex(2);
            //objSelect.SelectByText("INDIA");
            objSelect.SelectByValue("CHINA");
            Console.WriteLine("Multiple values allowed:" + objSelect.IsMultiple);

            int optCount = objSelect.Options.Count;
            Console.WriteLine("options count is:" + optCount);

            objSelect.DeselectByValue("CHINA");
           
        }
        [Test]
        public void InteractWithListbox()
        {
            dr.Navigate().GoToUrl("https://output.jsbin.com/osebed/2");
            IWebElement fruitsLB = dr.FindElement(By.XPath("//select[@id='fruits']"));
            SelectElement objSelect = new SelectElement(fruitsLB);
            
            Console.WriteLine("Multi select allowed:" + objSelect.IsMultiple);
            objSelect.SelectByValue("apple");
            objSelect.SelectByText("Grape");
            Console.WriteLine("Selected options count before:" + objSelect.AllSelectedOptions.Count);
            objSelect.DeselectByText("Apple");
            Console.WriteLine("Selected options count after:" + objSelect.AllSelectedOptions.Count);

        }
        [Test]
        public void test1()
        {

        }
        [Test]
        public void test3_anveshbranch()
        {
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
            //dr.Close();
        }
    }
}