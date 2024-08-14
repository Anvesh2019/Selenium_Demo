using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Demo.Common
{
    public class clsCommon
    {

        public IWebDriver dr;
        public clsCommon(IWebDriver driver)
        {
            dr = driver;
        }
        public void NavigateToApp(string appUrl)
        {
            dr.Navigate().GoToUrl(appUrl);
        }
        public void EnterText(IWebElement element,string strText)
        {
            element.SendKeys(strText);
        }

        public void EnterText(string strName, string strText)
        {
           dr.FindElement(By.Name(strName)).SendKeys(strText);
        }

        public void Entertext(IWebElement txtEle, string strVal)
        {
            txtEle.SendKeys(strVal);
        }

        public void Entertext(string strID, string strVal)
        {
            dr.FindElement(By.Id(strID)).SendKeys(strVal);
        }

        public void Entertext(string strXpath, string strVal, string locatortype=null)
        {
            dr.FindElement(By.XPath(strXpath)).SendKeys(strVal);
        }

        public void ClickonElement(IWebElement ele)
        {
            ele.Click();
        }
        public void ClickonElement(string strId)
        {
            dr.FindElement(By.Id(strId)).Click();
        }
        public void ClickonElementByXpath(string strXpath)
        {
            dr.FindElement(By.XPath(strXpath)).Click();
        }
        public void ClickonElementByName(string strName)
        {
            dr.FindElement(By.Name(strName)).Click();
        }
    }
}
