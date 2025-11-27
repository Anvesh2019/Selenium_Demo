using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Demo.Pages
{
    public class FashionPage
    {
        IWebDriver dr;
        public FashionPage(IWebDriver driver)
        {
            this.dr = driver;
        }
        public IWebElement linkMensCloathing=> dr.FindElement(By.XPath("//span[text()=\"Men's clothing\t\"]"));
    }
}
