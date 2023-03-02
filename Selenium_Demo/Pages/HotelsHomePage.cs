using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Selenium_Demo.Pages
{
    public class HotelsHomePage
    {
        IWebDriver dr;
        public HotelsHomePage(IWebDriver _driver)
        {
            dr = _driver;
        }
     public IWebElement btnSearch =>   dr.FindElement(By.XPath("//button[@id='search_button']"));
     public IWebElement errorDestinationRequired=> dr.FindElement(By.XPath("//div[text()='Please select a destination']"));

        public void ClickonSearchButton()
        {
            btnSearch.Click();
        }

    }
}
