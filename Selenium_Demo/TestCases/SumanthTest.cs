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


namespace Selenium_Demo.TestCases {
    public class SumanthTest
    {
        public IWebDriver dr;
    [Setup]
    {
    Console .WriteLine("I am from setup");
    dr = new ChromeDriver(@"C:\Users\dasar\Downloads")
    }
[Test]
public void FillForm1() {
    dr .Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");
    IWebElement txt=dr.FindElement(By.Id("name")).SendKeys("Sumanth");
}
    [Test]
     public void PrintSTatement()
    {
        Console.WriteLine("SUmanth");
    }
    [Test]
    public void PrintSTatement2() {
    Console .WriteLine("SUmanth");
    }
    [Test]
    }
}
