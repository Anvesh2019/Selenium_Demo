using System;
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
        public IWebElement linkGmail => dr.FindElement(By.XPath("//a[text()='Gmail']"));
        public IWebElement linkImages => dr.FindElement(By.XPath("//a[text()='Images']"));
        public IWebElement btnFeelingLucky => dr.FindElement(By.XPath("(//input[@name='btnI'])[2]"));
        public void SearchForKeyword(string strKeyword)
        {
            txtSearch.SendKeys(strKeyword);
            txtSearch.SendKeys(Keys.Enter);

        }
        public void SearchByFeelingLucky(string strFeelingLucky)
        {
            txtSearch.SendKeys(strFeelingLucky);
            btnFeelingLucky.Click();

        }
    }
}
