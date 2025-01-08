using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Drawing;
using System.Threading;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.IO;

namespace Selenium_Demo.TestCases
{
    public class clsActions
    {

        public IWebDriver dr;
        clsMyLogger logger;
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
                                                    //dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads\");
            //dr = new EdgeDriver("C:\\Users\\Anand.Gummadilli\\Downloads\\edgedriver_win64");
            dr = new EdgeDriver($"{Directory.GetCurrentDirectory()}\\DriverHelper");

            logger = new clsMyLogger();
        }

        [Test]
        [Category("Regression")]
        public void VerifyOptions()
        {
            dr.Navigate().GoToUrl("https://google.com");
            dr.FindElement(By.Name("q")).SendKeys("India");
        }
        [Test]
        public void OpenRedBus()
        {
            dr.Navigate().GoToUrl("https://www.google.com/search?gs_ssp=eJzj4tLP1TcwM403SUpXYDRgdGDwYitKTUkqLQYASIEGPg&q=redbus&rlz=1C1CHBD_enIN1082IN1082&oq=red&gs_lcrp=EgZjaHJvbWUqGAgCEC4YQxiDARjHARixAxjRAxiABBiKBTIOCAAQRRg5GEMYgAQYigUyEggBEAAYQxiDARixAxiABBiKBTIYCAIQLhhDGIMBGMcBGLEDGNEDGIAEGIoFMhIIAxAAGEMYgwEYsQMYgAQYigUyDAgEEAAYQxiABBiKBTISCAUQABhDGIMBGLEDGIAEGIoFMhIIBhAAGEMYgwEYsQMYgAQYigUyGAgHEC4YQxiDARjHARixAxjRAxiABBiKBTISCAgQLhhDGLEDGIAEGOUEGIoFMhMICRAuGIMBGMcBGLEDGNEDGIAE0gEJMzM2N2owajE1qAIIsAIB&sourceid=chrome&ie=UTF-8");
        }
        [Test]
        [Category("Actions")]
        public void MovetoElementAndClick()
        {
            dr.Navigate().GoToUrl("https://www.browserstack.com/");
            Actions action = new Actions(dr);
            IWebElement btnGetstartedFree = dr.FindElement(By.XPath("//a[@id='signupModalProductButton']"));
            action.MoveToElement(btnGetstartedFree).Click().Build().Perform();
            string expectedURL = "https://www.browserstack.com/users/sign_up";
            string actualURL = dr.Url;
            //Assert.AreEqual(expectedURL, actualURL, "User is not navigated to signup page");
            Assert.IsTrue(actualURL.Contains("https://www.browserstack.com/users/"));

        }
        [Test]
        [Category("Actions")]

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
        [Category("Actions")]

        public void RightClickonElement()
        {
            dr.Navigate().GoToUrl("https://www.Techtutorialz.com/");
            dr.Manage().Window.Maximize();
            Actions action = new Actions(dr);
            IWebElement element = dr.FindElement(By.XPath("//a[text()='View Tutorial Library']"));
            action.ContextClick(element).Build().Perform();
            // dr.Close();

        }
        [Test]
        [Category("Actions")]

        public void DoubleClickonElement()
        {
            dr.Navigate().GoToUrl("https://www.Techtutorialz.com/");
            dr.Manage().Window.Maximize();
            Actions action = new Actions(dr);
            IWebElement element = dr.FindElement(By.XPath("//a[text()='View Tutorial Library']"));
            action.DoubleClick(element).Build().Perform();

        }
        [Test]
        [Category("Actions")]

        public void KeyDownonElement()
        {
            dr.Navigate().GoToUrl("https://www.Techtutorialz.com/");
            dr.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Actions action = new Actions(dr);
            IWebElement linkTL = dr.FindElement(By.XPath("//a[text()='View Tutorial Library']"));
            action.KeyDown(linkTL, Keys.Enter).Build().Perform();
            string actualURL = dr.Url;
            Assert.IsTrue(actualURL.Contains("tutorials-library"), "Not reached to Tutorial library page");
            dr.Close();
        }
        [Test]
        [Category("Actions")]

        public void NormalClickOnElement()
        {
            dr.Navigate().GoToUrl("https://www.Techtutorialz.com/");
            dr.Manage().Window.Maximize();

            IWebElement element = dr.FindElement(By.XPath("//a[text()='View Tutorial Library']"));
            element.Click();
            string actualURL = dr.Url;
            Assert.IsTrue(actualURL.Contains("tutorials-library"), "Not reached to Tutorial library page");
            dr.Close();
        }
        [Test]
        [Category("Actions")]

        public void EnterTextWithoutSendKeys()
        {
            dr.Navigate().GoToUrl("https://www.google.com/");
            dr.Manage().Window.Maximize();
            Actions action = new Actions(dr);
            IWebElement txtSrch = dr.FindElement(By.Name("q"));

            string str1 = "I LOVE INDIA";
            char[] arrChars = str1.ToCharArray();
            for (int i = 0; i < arrChars.Length; i++)
            {
                action.KeyDown(txtSrch, arrChars[i].ToString()).Build().Perform();
            }
            //action.KeyDown(txtSrch,"I").Build().Perform();
            //action.KeyDown(txtSrch, "N").Build().Perform();
            //action.KeyDown(txtSrch, "D").Build().Perform();
            //action.KeyDown(txtSrch, "I").Build().Perform();
            //action.KeyDown(txtSrch, "A").Build().Perform();


            //dr.Close();
        }
        [Test]
        [Category("Actions")]

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
        [Category("Actions")]

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
        [Test]
        [Category("Actions")]
        public void VerifyRerunTests()
        {
            int x = 10;
            int y = 0;
            int z = x / y;
        }
        [Test]
        [Category("Regression")]
        public void LoginThroughPAN()
        {
            dr.Navigate().GoToUrl("https://axismf.com");
            dr.Manage().Window.Maximize();
            
            dr.FindElement(By.XPath("//ion-button[@class='new-investor new-login ng-star-inserted ion-color ion-color-burgundy md button button-round button-solid ion-activatable ion-focusable hydrated']")).Click();
            WebDriverWait _wait = new WebDriverWait(dr, TimeSpan.FromSeconds(10));
            IWebElement txtPannumber = _wait.Until(ExpectedConditions.ElementExists(By.XPath("(//input[@name='pan'])[2]")));
            txtPannumber.SendKeys("1234");
            
           // Thread.Sleep(3000);
           
            //WebDriverWait _wait1 = new WebDriverWait(dr, TimeSpan.FromSeconds(10));
            //IWebElement labelError = _wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[text()='Please enter a correct PAN']")));

            //Assert.IsTrue(labelError.Displayed == true, "Error is not displayed"); // displayed
  
        }
        [Test]
        public void guru99tutorials()
        {
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            String eTitle = "Demo Guru99 Page";
            String aTitle = "";
            
            dr.Navigate().GoToUrl("http://demo.guru99.com/test/guru99home/");
            dr.Manage().Window.Maximize();
            aTitle = dr.Title;
            if (aTitle == eTitle)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
        }
        [Test]
        public void CheckLogger()
        {

            int x = 10;
            logger.LogMessage("x value is:" + x);

            int y = 0;

            logger.LogMessage("y value is:" + y);
            int z = x / y;
            logger.LogMessage("z value is:" + z);
        }

        [Test]
        public void Devide2Numbers()
        {

            int x = 10;
            logger.LogMessage("x value is:" + x);

            int y = 0;

            logger.LogMessage("y value is:" + y);
            int z = x / y;
            logger.LogMessage("z value is:" + z);

            try
            {
                
                Console.WriteLine("z value is:" + z);
                int[] nums = new int[3] {10,20,30 };
                Console.WriteLine(nums[10]);

            }
            //catch(IndexOutOfRangeException iex)
            //{
            //    Console.WriteLine(iex.Message);
            //}

            catch(DivideByZeroException dex)
            {
                Console.WriteLine(dex.StackTrace);
            }
            catch (Exception ex)
            {
                try
                {
                    Console.WriteLine(ex.Message);
                }
                catch(Exception ex1)
                {
                    Console.WriteLine(ex1.Message);
                }
                
            }
        }
    }
}
