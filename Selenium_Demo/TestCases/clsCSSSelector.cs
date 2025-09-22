using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Demo.TestCases
{
    public class clsCSSSelector
    {
        IWebDriver dr = null;
        [SetUp]
        public void setup()
        {
            dr = new ChromeDriver();
        }
        [Test]
        public void LearnCssNthChild()
        {
            dr.Navigate().GoToUrl("https://google.com");
            //dr.FindElement(By.CssSelector("textarea[name='q']")).SendKeys("India");
            dr.FindElement(By.CssSelector("a:nth-of-type(1)")).Click();
            Assert.IsTrue(dr.Url.Contains("about.google"),"css is not working");

        }
    }
}
