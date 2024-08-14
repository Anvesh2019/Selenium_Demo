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
using OpenQA.Selenium.Interactions;
using log4net;
using Selenium_Demo_Abstract;
using Selenium_Demo.Pages;
using Selenium_Demo.Common;
using SeleniumExtras.WaitHelpers;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Runtime.Intrinsics.X86;

using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.Reflection;
using NUnit.Framework.Interfaces;
using Selenium_Demo.TestCases;




namespace Selenium_Demo
{
    public class LoginTests
    {
        public static ExtentReports extent;
        public static ExtentTest testlog;
        public clsCommon _common;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        clsMyLogger objLogger = new clsMyLogger();
        
        public IWebDriver dr;
        AxisMfPage _axisPage;
        [OneTimeSetUp]
        public void StartReport()
        {
            string path = Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            string reportPath = projectPath + "Reports\\";

            System.IO.Directory.CreateDirectory(reportPath);
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("Tester", Environment.UserName);
            extent.AddSystemInfo("MachineName", Environment.MachineName);

        }
        [SetUp]
        public void Setup()
        {
            StartExtentTest(TestContext.CurrentContext.Test.Name);
            Console.WriteLine("I am from setup method");
            dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads");
            //dr = new ChromeDriver();

            //objLogger.logsEnabled = true;
            //_axisPage = new AxisMfPage(dr);
            _common = new clsCommon(dr);
        }
       
        public static void StartExtentTest(string testsToStart)
        {
            testlog = extent.CreateTest(testsToStart);
        }
        [Test]
        public void OpenGoogleSite()
        {
            dr.Navigate().GoToUrl("https://google.com"); //opening google site
            //dr.FindElement(By.Name("q")).SendKeys("India"); //entering india
            //dr.FindElement(By.Name("q")).SendKeys(Keys.Enter); //pressing enter button

            dr.FindElement(By.XPath("//textarea[@name='q']")).SendKeys("India"); //entering india
            dr.FindElement(By.XPath("//textarea[@name='q']")).SendKeys(Keys.Enter);
            Console.WriteLine(dr.Url);
        }
        [Test]
        public void LearnLinkText()
        {
            dr.Navigate().GoToUrl("https://google.com"); //opening google site
            //dr.FindElement(By.LinkText("Gmail")).Click();
            dr.FindElement(By.XPath("//a[@aria-label='Gmail ']")).Click();
            string currentURL = dr.Url;
            Assert.IsTrue(currentURL.Contains("gmail")==true,"Not loaded gmail site");
        
        }
        [Test]
        public void LearnPartialLinkText()
        {
            dr.Navigate().GoToUrl("https://techtutorialz.com"); //opening google site
            Thread.Sleep(3000);
            dr.FindElement(By.PartialLinkText("DEMO")).Click();
            string currentURL = dr.Url;
            Assert.IsTrue(currentURL.Contains("https://techtutorialz.com/contact/") == true, "Not loaded contact page");
        }
        [Test]
        public void OpenGoogleSite1()
        {
            _common.NavigateToApp("https://google.com");
            IWebElement txtSrch = dr.FindElement(By.Name("q"));
            //_common.EnterText("q", "India");
            //_common.EnterText("q", Keys.Enter);
            _common.EnterText(txtSrch, "India");
            _common.EnterText(txtSrch, Keys.Enter);

            Console.WriteLine(dr.Url);
        }
        [Test]
        public void OpenAmazonCupons()
        {
            dr.Navigate().GoToUrl("https://www.amazon.in/");
            //opening google site
            dr.FindElement(By.LinkText("Mobiles")).Click(); //entering india
            dr.FindElement(By.PartialLinkText("miniTV")).Click();
            Console.WriteLine(dr.Url);
        }
        [Test]
        public void VerifyLoginOptions()
        {
            
            _axisPage.NavigatetoAxisMF();
        }
        [Test]
        public void CheckExtensionMethods()
        {
            int x = 300;
            bool check= x.IsGreaterThan(100);
            Console.WriteLine(check);   
        }
        [Test]
        public void CheckStringExtensionMethod()
        {
            string city = "hyderabad";
            string finalCity = city.ToUpperExtension();
            Console.WriteLine(finalCity);
        }
        [Test]
        public void testcase1()
        {
            //sample code
        }
        [Test]
        public void OpenMySite()
        {
          
            
            dr.Navigate().GoToUrl("http://google.com");
            dr.Manage().Window.Maximize();

            dr.FindElement(By.Name("q")).SendKeys("techtutorialz");
            dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            dr.Close();
        }
        [Test]
        public void NavigateToGmail()
        {
            dr.Navigate().GoToUrl("http://google.com");
            IWebElement linkGmail = dr.FindElement(By.XPath("//a[text()='Gmail']"));
            linkGmail.Click();

            //dr.FindElement(By.XPath("//a[text()='Gmail']")).Click();
        }
        [Test]
        public void LearnFluentWait()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(dr);
            /* Setting the timeout in seconds */
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(2);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found";

            dr.Url = "https://google.com";
            dr.FindElement(By.Name("q")).SendKeys("LambdaTest" + Keys.Enter);

        }

        [Test]
        public void NavigateToAdbTutorial()
        {
            
            dr.Navigate().GoToUrl("http://techtutorialz.com");
            dr.Manage().Window.Maximize();
            dr.FindElement(By.XPath("//a[@title='Tutorials']")).Click();
            Thread.Sleep(2000);
            dr.FindElement(By.XPath("//a[@title='ADB Tutorial']")).Click();
            
        }

        [Test]
        public void VerifyAllLinks()
        {
            dr.Navigate().GoToUrl("http://google.com");
            dr.Manage().Window.Maximize();
            IReadOnlyCollection<IWebElement>  allLinks = dr.FindElements(By.XPath("//a"));
            Console.WriteLine("Link count is:" + allLinks.Count);
            foreach(var item in allLinks)
            {
                Console.WriteLine(item.Text);
            }
        }
        [Test]
        public void LearnAutoIt()
        {
           // AutoItX3Lib.AutoItX3 autoit = new AutoItX3Lib.AutoItX3();
            //autoit.Run("C:\\Anand_Details\\OpenFile.exe");
            
            //Autoit Code
            //WinWaitActive("Open");
            //ControlSend("Open", "", "Edit1", "C:\Anand_Details\Banners\Banner_15.png");
            //ControlClick("Open", "&Open", "Button1");
        }

        [Test]
        public void VerifyInvalidPANNumber()
        {
            //try
            //{
            //    objLogger.LogMessage("VerifyInvalidPANNumber Started executing");

                dr.Navigate().GoToUrl("https://axismf.com");
                dr.Manage().Window.Maximize();
                log.Info("Home page loaded");
                dr.FindElement(By.XPath("//ion-button[@class='new-investor new-login ng-star-inserted ion-color ion-color-burgundy md button button-round button-solid ion-activatable ion-focusable hydrated']")).Click();
                //Implicit wait
                dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //Explicit Wait
               WebDriverWait _wait = new WebDriverWait(dr,TimeSpan.FromSeconds(10));
               IWebElement txtPannumber= _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//input[@class='native-input sc-ion-input-md'])[6]")));
               //IWebElement txtPannumber = dr.FindElement(By.XPath("(//input[@class='native-input sc-ion-input-md'])[6]"));
               txtPannumber.SendKeys("1234");
               objLogger.LogMessage("Entered invalid PAN numbver");

                Thread.Sleep(3000);
            //dr.Close();
            //IWebElement errMsg = dr.FindElement(By.XPath("//div[text()='Please enter a correct PAN']"));
            //Assert.IsTrue(errMsg.Size!=Size.Empty);

            WebDriverWait _wait1 = new WebDriverWait(dr, TimeSpan.FromSeconds(10));
            IWebElement labelError = _wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[text()='Please enter a correct PAN']")));

            //IReadOnlyCollection<IWebElement> listerrMsg = dr.FindElements(By.XPath("//div[text()='Please enter a correct PAN']"));
                Assert.IsTrue(labelError.Displayed == true, "Error is not displayed"); // displayed

                objLogger.LogMessage("Verified PAN error message ");

                IWebElement btnOTP = dr.FindElement(By.Id("btn-1"));
                Assert.IsTrue(btnOTP.Enabled == false, "Generate OTP button is enabled"); //disabled

                objLogger.LogMessage("VerifyInvalidPANNumber passed successfully");
            //}
            //catch(Exception ex)
            //{
            //    objLogger.LogMessage(ex.Message);
            //}
        }
        [Test]
        public void LearnJavascriptExecuter()
        {
            dr.Navigate().GoToUrl("https://www.google.com/");
            IJavaScriptExecutor je = (IJavaScriptExecutor)dr;
            //je.ExecuteScript("alert(document.title);");
            je.ExecuteScript("document.getElementByName('q').setAttribute('value', 'India')");
        }

        [Test]
        public void SearchIndia()
        {
            dr.Navigate().GoToUrl("https://google.com");
            Thread.Sleep(2000);
            dr.FindElement(By.Name("q")).SendKeys("Beeramguda");
            dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        }
        [Test]
        public void GetUsername()
        {

            //string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string userName = "Anand.Gummadilli";
            string path = "";
            string[] arrUsername = userName.Split('\\');
            if(arrUsername.Length>1)
            {
                path = @"C:\\Users\\" + arrUsername[1] + "\\Downloads\\" + "data.json";
            }
            else
            {
                path = @"C:\\Users\\" + userName + "\\Downloads\\" + "data.json";
            }
             
            Console.WriteLine(path);
        }
        [Test]
        public void VerifyValidPANNumber()
        {
            dr.Navigate().GoToUrl("http://axismf.com");
            dr.Manage().Window.Maximize();
            dr.FindElement(By.XPath("//ion-button[@class='new-investor new-login ng-star-inserted ion-color ion-color-burgundy md button button-round button-solid ion-activatable ion-focusable hydrated']")).Click();
            Thread.Sleep(3000);
            dr.FindElement(By.XPath("(//input[@class='native-input sc-ion-input-md'])[6]")).SendKeys("");
            Thread.Sleep(3000);

            IReadOnlyCollection<IWebElement> listerrMsg = dr.FindElements(By.XPath("//div[text()='Please enter a correct PAN']"));
            Assert.IsTrue(listerrMsg.Count == 0); //not displayed

            IWebElement btnOTP = dr.FindElement(By.Id("btn-1"));
            Assert.IsTrue(btnOTP.Enabled == true, "Generate OTP button is disabled"); //disabled
        }

        [Test]
        public void VerifyMaxlength()
        {
            dr.Navigate().GoToUrl("http://google.com");
            dr.Manage().Window.Maximize();
            IWebElement txtSearch = dr.FindElement(By.Name("q"));

            string strMaxlength = txtSearch.GetAttribute("maxlength");

            Assert.IsTrue(strMaxlength == "2048", "Max length is not matching");

            IWebElement linkSignin = dr.FindElement(By.XPath("//a[text()='Sign in']"));
            Console.WriteLine(linkSignin.GetAttribute("href"));

        }

            [Test]
        public void VerifyGetattribute()
        {
            dr.Navigate().GoToUrl("http://google.com");
            dr.Manage().Window.Maximize();
            IWebElement txtSearch = dr.FindElement(By.Name("q"));
            txtSearch.SendKeys("India");

            Console.WriteLine("Text is:" +txtSearch.GetAttribute("value"));
            string maxlength = txtSearch.GetAttribute("maxlength");
            Console.WriteLine("maxlength of text box is:" + maxlength);
        }
        [Test]
        public void VerifyLinkText()
        {
            dr.Navigate().GoToUrl("http://google.com");
            dr.Manage().Window.Maximize();
            IWebElement linkGmail = dr.FindElement(By.LinkText("Gmail"));

            Console.WriteLine("Gmail link is enabled:" + linkGmail.Enabled);
            if(linkGmail.Size==Size.Empty) //gamil link not exists
            {
                Console.WriteLine("Gmail link not displayed");
            }
            else
            {
                linkGmail.Click();
            }
               

            string strTitle= dr.Title;
            Console.WriteLine(strTitle);
            Assert.IsTrue(strTitle.Contains("Gmail")==true,"Gmail page is not loaded");

            string strUrl = dr.Url;
            Assert.IsTrue(strUrl.Contains("gmail"),"Gmail page is not loaded");
        }

        [Test]
        public void SearchCourse()
        {
            dr.Navigate().GoToUrl("http://techtutorialz.com");
            dr.Manage().Window.Maximize();
            dr.FindElement(By.Id("s")).SendKeys("Manual Testing");
            dr.FindElement(By.XPath("//button[text()='search']")).Click();
            dr.Navigate().Back();
            Thread.Sleep(2000);
            dr.Navigate().Forward();
            dr.Navigate().Refresh();
        }
        [Test]
        public void VerifyCardetails()
        {
            OpenMySite();
             clsBMW1 objBmw = new clsBMW1();
            string carname = objBmw.GetCarName();
            Console.WriteLine("Car name is:" + carname);
            Console.WriteLine("Car model is:" + objBmw.GetCarModel(2022));
            Console.WriteLine(objBmw.GetCarCity());
            Console.WriteLine(clsCar.GetCollegename());
            
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

            clsStudNew objStud = new clsStudNew();
           
            //objStud.DisplaySname();
            //clsStudNew objStud = new clsStudNew();
            //objStud.DisplaySname();
            //clsStud objStud = new clsStud();
            //objStud.sname = "prashanthi";
            //objStud.courseName = "Restsharp";
            //Console.WriteLine(clsStud.city); //

            //clsStud objStud2 = new clsStud();
            //objStud2.sname = "Anand";
            //objStud2.courseName = "Selenium";

            //objStud2.DisplaySname("Anvesh");

            //clsDept objDept = new clsDept();
            //objDept.DisplaySname();
            //objStud2.DisplaySname();

            //Parent parent = new Child(); //Assigning child object to parent ref. variable  
            //Child child = (Child)parent; //Down cast parent ref. variable to child.  
            //child.sleep(); //Calling child class sleep method and it will work fine.  

            //clsStud objStud3 = new clsDept();
            //clsDept objDept3 = (clsDept)objStud3;
            //objDept3.DisplaySname();

            clsDept objDept4 = new clsDept();
            clsStud objStud4 = objDept4;
            objStud4.DisplaySname();

        }
        [Test]
        public void InvokeAbstractMethod()
        {
            //clsAbstractDept objDept = new clsAbstractDept();
            ClsDeptDetails objDeptdetails = new ClsDeptDetails();
            objDeptdetails.DisplayDeptAddr();
            objDeptdetails.DisplayDeptAddr("Anand"); //normal method
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
        public void VerifyImplicitWait()
        {
            //dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            String eTitle = "Demo Guru99 Page";
            String aTitle = "";
            // launch Chrome and redirect it to the Base URL
            dr.Navigate().GoToUrl("http://demo.guru99.com/test/guru99home/");
            //Maximizes the browser window
            dr.Manage().Window.Maximize();
            //get the actual value of the title
            aTitle = dr.Title;
            //compare the actual title with the expected title
            if (aTitle.Contains(eTitle))
            {
                Console.WriteLine("Test Passed");
                dr.Close();
                Assert.Pass();
            }
            else
            {
                Console.WriteLine("Test Failed");
                Assert.Fail();
            }
            //close browser
           
        }

        [Test]
        public void VerifyFileUplaod()
        {
            dr.Navigate().GoToUrl("https://www.naukri.com/registration/createAccount?othersrcp=11499&wExp=N");
            string filePath = @"C:\Anand_Details\CSharp_Sessions.docx";
            dr.FindElement(By.XPath("//input[@type='file']")).SendKeys(filePath);
        }
        [Test]
       
        public void VerifyPanNumberErrormsg()
        {
          

            //dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            dr.Navigate().GoToUrl("https://www.axismf.com");
            dr.FindElement(By.XPath("(//ion-button[@id='origin'])[2]")).Click(); //click on Login button
            //Thread.Sleep(5000);
            WebDriverWait wait = new WebDriverWait(dr,TimeSpan.FromSeconds(20));
            
            //IWebElement elementPan = dr.FindElement(By.XPath("(//input[@name='pan'])[2]"));
           
            var elementPan = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("(//input[@name='pan'])[2])")));

            elementPan.SendKeys("India"); //enter india in PAn number
            
            IWebElement panError = dr.FindElement(By.XPath("//div[text()='Please enter a correct PAN']"));
            //Thread.Sleep(2000);
            //Assert.IsTrue(panError.Displayed == true, "Error message is not displayed");
            Assert.IsTrue(panError.Size != Size.Empty,"validation error is not displayed for PAN"); //Error is displayed

        }
        [Test]
        public void VerifyTryCtach()
        {
            try
            {
                int x = 10;
                int y = 0;
                //Console.WriteLine("Z is:" + x / y);
                int[] nums = new int[2] {10,20 };
                Console.WriteLine(nums[5]);
            }
            catch (IndexOutOfRangeException dbyzex)
            {
                Console.WriteLine(dbyzex.Message);
                Console.WriteLine(dbyzex.StackTrace);
            }
            catch (DivideByZeroException dbyzex)
            {
                Console.WriteLine(dbyzex.Message);
                Console.WriteLine(dbyzex.StackTrace);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            
        }
        [Test]
        public void Devide2Numbers()
        {
            try
            {
                int x = 10;
                int y = 0;
                int z = x / y;
                Console.WriteLine("z value is:" + z);

            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [Test]
        public void DevideByZeroError()
        {
            try
            {
                int x = 20;
                int y = 0;
                int z = x / y;
                Console.WriteLine("z value is:" + z);
            }
            catch(NoSuchElementException nse)
            {
                Console.WriteLine(nse.Message);
            }
            catch(DivideByZeroException dbz)
            {
                Console.WriteLine(dbz.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I am finally block");
            }
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
                //Thread.Sleep(2000);
                Assert.IsTrue(panError.Size != Size.Empty, "validation error is not displayed for PAN"); //Error is displayed

            }
            catch (ElementClickInterceptedException clickex)
            {
                Console.WriteLine(clickex.Message);
              
                ITakesScreenshot screenshotDriver = dr as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                // Creating UIScreenshot folder if not exists
                System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "/UIScreenshots/");
                string fileName = Environment.CurrentDirectory + "/UIScreenshots/" + "sampletestcase" + "_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".png";
                //string fileName = Environment.CurrentDirectory + "/UIScreenshots/" + "Sample1.png";

            }
            catch (NoSuchElementException nosuchex)
            {
                Console.WriteLine(nosuchex.Message);
                ITakesScreenshot screenshotDriver = dr as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                // Creating UIScreenshot folder if not exists
                System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "/UIScreenshots/");
                string fileName = Environment.CurrentDirectory + "/UIScreenshots/" + "sampletestcase" + "_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".png";
                //string fileName = Environment.CurrentDirectory + "/UIScreenshots/" + "Sample1.png";

                screenshot.SaveAsFile(fileName, ScreenshotImageFormat.Png);
            }
            catch (NoSuchWindowException ex)
            {
                ITakesScreenshot screenshotDriver = dr as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                // Creating UIScreenshot folder if not exists
                System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "/UIScreenshots/");
                //string fileName = Environment.CurrentDirectory + "/UIScreenshots/" + "sampletestcase" + "_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".png";
                string fileName = Environment.CurrentDirectory + "/UIScreenshots/" + "Sample1.png";

                screenshot.SaveAsFile(fileName, ScreenshotImageFormat.Png);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        [Test]
        public void HandleMultipleTabs()
        {
            dr.Navigate().GoToUrl("https://demoqa.com/browser-windows");
            dr.Manage().Window.Maximize();
            string windowhandleParent = dr.CurrentWindowHandle; //getting parentwindow handle
            IWebElement btnNewwindow = dr.FindElement(By.XPath("//button[@id='tabButton']"));
            btnNewwindow.Click();
            System.Collections.ObjectModel.ReadOnlyCollection<string> lstWindow = dr.WindowHandles;
            Console.WriteLine("Tabs count:" + lstWindow.Count);

            foreach (var handle in lstWindow)
            {
                Console.WriteLine(handle);
            }
            //Switching the driver to 2nd window
            dr.SwitchTo().Window(lstWindow[1]);
            IWebElement sampleText = dr.FindElement(By.XPath("//h1[@id='sampleHeading']"));
            Assert.IsTrue(sampleText.Displayed, "Sample text is not displayed");
            dr.Navigate().GoToUrl("http://google.com");
            dr.SwitchTo().Window(lstWindow[0]); //return to parent window
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
        [Test]
        public void GetOutParam()
        {
            int sage = GetAge("Anand", out int age);
            Console.WriteLine("Student age is:" + sage);
        }
        public static int GetAge(string name, out int age)
        {
            if (name == "Anand")
            {
                age = 40;
            }
            else
            {
                age = 25;
            }
            return age;
        }

        [Test]
        public void LearnClass()
        {
            clsStates s1 = new clsStates();
            Console.WriteLine(s1.DisplayTaxFreeStates());
            Console.WriteLine(clsStates.cname);

            string mystate= s1.DisplayTaxFreeStates("MD");
            Console.WriteLine(mystate);
            

           // clsStates s2 = new clsStates();
           // s2.scount = 50;

           clsCapitals cap1=new clsCapitals();
           bool isLarge= cap1.CheckLargeState("TX");
            Console.WriteLine("Texas is large :" + isLarge);

            }
        [Test]
        public void CopyPaste()
        {

            dr.Navigate().GoToUrl("https://www.w3schools.com/howto/howto_css_register_form.asp");
            // Identify the first input box with xpath locator
            IWebElement e = dr.FindElement(By.XPath("(//*[@class='w3-input w3-light-grey w3-margin-bottom x'])[1]"));

            // enter some text
            e.SendKeys("Anvesh");

           
            // Actions class methods to select text
            Actions a = new Actions(dr);
            a.KeyDown(Keys.Control);
            a.SendKeys("a");
            a.KeyUp(Keys.Control);
            a.Build().Perform();

            // Actions class methods to copy text
            a.KeyDown(Keys.Control);
            a.SendKeys("c");
            a.KeyUp(Keys.Control);
            a.Build().Perform();

            // Action class methods to tab and reach to  the next input box
            a.SendKeys(Keys.Tab);
            a.Build().Perform();


            // Actions class methods to paste text
            a.KeyDown(Keys.Control);
            a.SendKeys("v");
            a.KeyUp(Keys.Control);
            a.Build().Perform();
        }
        [Test]
        public void InvokeMethod()
        {
            clsUniversity objUniv1 = new clsUniversity();
            //string studname = objUniv1.GetStudNameBySid(200);
            //Console.WriteLine("stud name is:" + studname);
            //objUniv1.DisplayCollegename();

            clsCollege objCol = new clsCollege();
            //objCol.DisplayUnivName();
            objCol.DisplayCollegename();

        }
        [OneTimeTearDown]
        public void EndReport()
        {
            LoggingTestStatusExtentReport();
            extent.Flush();
        }
        public static void LoggingTestStatusExtentReport()
        {
            try
            {
                var status = TestContext.CurrentContext.Result.Outcome.Status;
                var stacktrace = string.Empty + TestContext.CurrentContext.Result.StackTrace + string.Empty;
                var errorMessage = TestContext.CurrentContext.Result.Message;
                Status logstatus;
                switch (status)
                {
                    case TestStatus.Failed:
                        logstatus = Status.Fail;
                        testlog.Log(Status.Fail, "Test steps NOT Completed for Test case " + TestContext.CurrentContext.Test.Name + " ");
                        testlog.Log(Status.Fail, "Test ended with " + Status.Fail + " – " + errorMessage);
                        break;
                    case TestStatus.Skipped:
                        logstatus = Status.Skip;
                        testlog.Log(Status.Skip, "Test ended with " + Status.Skip);
                        break;
                    default:
                        logstatus = Status.Pass;
                        testlog.Log(Status.Pass, "Test steps finished for test case " + TestContext.CurrentContext.Test.Name);
                        testlog.Log(Status.Pass, "Test ended with " + Status.Pass);
                        break;
                }
            }
            catch (WebDriverException ex)
            {
                throw ex;
            }

        }
    }

}