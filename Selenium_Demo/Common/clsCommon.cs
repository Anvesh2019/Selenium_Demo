using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Demo.Common
{
    public class clsCommon
    {

        IWebDriver dr;
        public clsCommon(IWebDriver driver)
        {
            dr = driver;
        }

        public void EnterText(IWebElement element,string strText)
        {
            element.SendKeys(strText);
        }

        public void EnterText(string strName, string strText)
        {
           dr.FindElement(By.Name(strName)).SendKeys(strText);
        }
    }
}
