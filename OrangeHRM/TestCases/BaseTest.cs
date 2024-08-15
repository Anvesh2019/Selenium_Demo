using OpenQA.Selenium;
using OrangeHRM.Common;
using OrangeHRM.Pages;
using OrangeHRM.Webdriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.TestCases
{
    public class BaseTest
    {
        public IWebDriver driver;
        public LoginPage loginPage;

        [SetUp]
        public void SetUp()
        {
            driver = Driver.driver("chrome");
           
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
           Thread.Sleep(3000);
            driver.Manage().Window.Maximize();
            loginPage = new LoginPage(driver);
        }
        [TearDown]
        public void teardown()
        {
            driver.Close();
        }
    }
}
