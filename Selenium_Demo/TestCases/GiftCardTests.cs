using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_Demo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
{
    
}

namespace Selenium_Demo.TestCases
{
    public class GiftCardTests:TestBase
    {
       
        [Test]
        public void VerifyGiftcarTypes()
        {
            _amazonpage.NavigatetoAmazon();
            _amazonpage.linkFashion.Click();
            _fpage.linkMensCloathing.Click();
        }
    }
}
