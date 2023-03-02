﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Selenium_Demo.Pages
{
    public class GooglePage
    {
        IWebDriver dr;
        public GooglePage(IWebDriver driver)
        {
            dr = driver;
        }

        public IWebElement txtSearch => dr.FindElement(By.Name("q"));
    }
}
