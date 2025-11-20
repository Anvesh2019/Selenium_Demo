using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Drawing;
using System.Threading;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.IO;
using Selenium_Demo.Common;


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
        public void FillForm()
        {
            dr.Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");
            IWebElement txt = dr.FindElement(By.Id("name"));
            txt.SendKeys("Sumanth");
        }
    }
}
