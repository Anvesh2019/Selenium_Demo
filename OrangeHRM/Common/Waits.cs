using OpenQA.Selenium;
using OrangeHRM.Webdriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Common
{
    public static class Waits
    {

        public static IWebDriver driver;
        
        public static void ShortWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }
    }
}
