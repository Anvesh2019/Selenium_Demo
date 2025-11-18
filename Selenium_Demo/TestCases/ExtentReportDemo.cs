using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Immutable;

namespace Selenium_Demo.TestCases
{
    public class ExtentReportDemo
    {
        IWebDriver driver;
        ExtentReports extent;
        ExtentTest test;

        [OneTimeSetUp]
        public void Setup()
        {
            // Specify report location
            var htmlReporter = new ExtentHtmlReporter(@"C:\Reports\Report.html");
           
            // Create ExtentReports and attach reporter
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Host Name", "LocalHost");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("User Name", "Anand Gummadilli");  
        }

        [SetUp]
        public void Init()
        {
          //  driver = new ChromeDriver("C:\\Users\\anand\\source\\repos\\Selenium_Demo\\Selenium_Demo\\DriverHelper\\");
        }

        [Test]
        public void GoogleSearchTest()
        {
            test = extent.CreateTest("Google Search Test").Info("Test Started");

            //driver.Navigate().GoToUrl("https://www.google.com");
            //test.Log(Status.Info, "Navigated to Google");

            //string title = driver.Title;
            //test.Log(Status.Info, "Page title: " + title);

            //Assert.AreEqual("Google", title);
            //test.Log(Status.Pass, "Title verified successfully");
        }

        [TearDown]
        public void CloseBrowser()
        {
           // driver.Quit();
            test.Log(Status.Info, "Browser closed");
            extent.Flush();
        }

        [OneTimeTearDown]
        public void GenerateReport()
        {
            extent.Flush();  // Writes everything to the report
        }
    }
}
