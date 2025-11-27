using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Selenium_Demo.Common;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;



namespace Selenium_Demo.TestCases
{
    public class NewSumanthTests
    {
         public IWebDriver dr;
    [SetUp]
        public void setup()
        { 
            Console.WriteLine("I am from setup method");
            dr = new ChromeDriver(@"C:\Users\dasar\Downloads");
        }
        [Test]
        public void FillForm()
        {
            dr.Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");
            IWebElement txt0 = dr.FindElement(By.Id("name"));
            txt0.SendKeys("Sumanth");
            IWebElement txt1 = dr.FindElement(By.Id("email"));
            txt1.SendKeys("dasarisumanth44@gmail.com");
            IWebElement num = dr.FindElement(By.Id("phone"));
            num.SendKeys("9063295248");
            IWebElement txt3 = dr.FindElement(By.Id("textarea"));
            txt3.SendKeys("Flat no 101 gadudadri grand beeramguda Hyderbad pin:502032");
            
            IWebElement chkMale = dr.FindElement(By.Id("male"));
            chkMale.Click();

            IList<IWebElement> selectDays = dr.FindElements(By.XPath("//input[@class='form-check-input']"));
            foreach (IWebElement ele in selectDays)
            {
                if (ele.GetAttribute("id")=="monday" || ele.GetAttribute("id") == "tuesday")
                {
                    ele.Click();
                }
                //Console.WriteLine(ele.GetAttribute("id"));
            }
            Console.WriteLine(selectDays.Count);
            //List<IWebElement> selDays = dr.FindElements(By.ClassName("form-check form-check-inline"));
            
        }
        [Test]
        public void ItemCount()
        {
            dr.Navigate().GoToUrl("https://www.amazon.in/");
            Thread.Sleep(3000);
            IWebElement product = dr.FindElement(By.Id("twotabsearchtextbox"));
            product.SendKeys("yonex badminton bats");
            IWebElement search = dr.FindElement(By.Id("nav-search-submit-button"));
            search.Click();
            IWebElement product1 = dr.FindElement(By.XPath("(//div[@data-cy='title-recipe']//h2//span)[5]"));
            if (product1.Text== "YONEX ZR 100 Light Aluminium Strung Badminton Racket with Full Racket Cover (Blue) | For Beginners | 95 grams | High Durability")
            {
                IWebElement addToCart = dr.FindElement(By.Id("a-autoid-5-announce"));
                addToCart.Click();
            }
            else
            {
                Console.WriteLine("Product not found");
            }
            Thread.Sleep(2000);
            IWebElement cart = dr.FindElement(By.Id("nav-cart-count"));
            cart.Click();
            IList<IWebElement> cartCount = dr.FindElements(By.XPath("//div[@data-itemid]"));
            Console.WriteLine(cartCount.Count);
        }
        [Test]
        public void PrintLinks()
        {
            dr.Navigate().GoToUrl("https://www.amazon.in/");
            Thread.Sleep(3000);
            IList<IWebElement> menuOptions = dr.FindElements(By.XPath("//div[@id='nav-xshop-container']//a"));
            Console.WriteLine("No of links in the menu bar are:"+menuOptions.Count);
            foreach (var item in menuOptions)
            {
                Console.WriteLine("Link of the menu option is:"+item.GetAttribute("href"));

            }
            
        }
    }
}
