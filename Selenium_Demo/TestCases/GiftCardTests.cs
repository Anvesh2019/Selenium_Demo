using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_Demo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace Selenium_Demo.TestCases
{
    public class GiftCardTests:TestBase
    {
        public TestContext _tcontext { get; set; }

        [Test]
        public void VerifyGiftcarTypes()
        {
            TestContext.Out.WriteLine($"Starting test: {TestContext.CurrentContext.Test.Name}");
            Console.WriteLine(TestContext.CurrentContext.Test.ClassName);
            _amazonpage.NavigatetoAmazon();
            _amazonpage.linkFashion.Click();
            //_fpage.linkMensCloathing.Click();
        }
        [Test]
        public void VerifySettings()
        {
            //Console.WriteLine(TestContext.CurrentContext.Test.Properties.Count);
            string btype = ConfigurationManager.AppSettings["BrowserType"];
            Console.WriteLine(btype);
        }
    }
}
