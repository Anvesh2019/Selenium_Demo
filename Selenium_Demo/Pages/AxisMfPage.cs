using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Selenium_Demo.Pages
{
    public class AxisMfPage
    {
        IWebDriver dr;
        public AxisMfPage(IWebDriver driver)
        {
            dr = driver;
        }

        public void NavigatetoAxisMF()
        {
            dr.Navigate().GoToUrl("https://axismf.com");
        }
    }
}
