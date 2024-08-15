using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Common
{
    public   class Actions
    {
        public IWebDriver driver;

        public Actions(IWebDriver driver) 
        { 
            this.driver = driver;
        }

        public IWebElement findElement(By element)
        {
            return driver.FindElement(element);
        }
       public void clickOnElement(By element)
        {
            findElement(element).Click();
        }
        public void EnterText(By element,string text)
        {
            findElement(element).SendKeys(text);
        }
        public void NavigateToApp(string appUrl)
        {
            driver.Navigate().GoToUrl(appUrl);
        }
    }
}
