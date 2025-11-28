using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_Demo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
{
    
}

namespace Selenium_Demo.TestCases
{
    public class AmazonFashionPageTest:TestBase
    {
       
        [Test]
        public void VerifyFashionPage()
        {
            _amazonpage.NavigatetoAmazon();
            Thread.Sleep(2000);
            _amazonpage.linkFashion.Click();
            _fpage.hoverMens();
            Thread.Sleep(2000);
            _fpage.mensClothing.Click();
            Console.WriteLine("Links are:");
            foreach (var item in _fpage.getLinks)
            {
                Console.WriteLine(item.GetAttribute("href"));
            }
            Console.WriteLine("Departments are:");
            foreach (var item in _fpage.displayDepartments)
            {
                Console.WriteLine(item.Text);
            }
            objCommon.ClickonElement(_fpage.clickOnSeeMore);
            Console.WriteLine("First five brands are:");
            //Console.WriteLine("Brands count:" + _fpage.displayBrands.Count);
            for (int i = 0; i < _fpage.displayBrands.Count; i++)
            {
               
                if (i==5)
                {
                    break;
                }
                Console.WriteLine(i + ": " + _fpage.displayBrands[i].Text);
            }
        }
    }
}
