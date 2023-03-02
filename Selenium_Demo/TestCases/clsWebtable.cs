using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Demo.TestCases
{
    public class clsWebtable
    {
        public IWebDriver dr;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("I am from setup method");
            dr = new ChromeDriver(@"C:\Users\v-anandag\Desktop");

        }

        [Test]
        public void Get2ndCompanyDetails()
        {
            Console.WriteLine("started executing Get2ndCompanyDetails at" + DateTime.Now.ToString());
            dr.Navigate().GoToUrl("https://www.moneycontrol.com/stocks/marketinfo/marketcap/bse/index.html");
            IWebElement secondCompany = dr.FindElement(By.XPath("//table[@class='Topfilter_web_tbl_indices__1oyWE undefined']/tbody/tr[2]/td[1]"));
            Console.WriteLine("2nd company name is:" + secondCompany.Text);
            IWebElement secondCompanyPrice = dr.FindElement(By.XPath("//table[@class='Topfilter_web_tbl_indices__1oyWE undefined']/tbody/tr[2]/td[2]"));
            Console.WriteLine("2nd company price is:" + secondCompanyPrice.Text);
            Console.WriteLine("Ended executing Get2ndCompanyDetails at" + DateTime.Now.ToString());

        }
    }
}
