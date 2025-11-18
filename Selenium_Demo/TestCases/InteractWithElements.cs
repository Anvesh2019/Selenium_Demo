using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
using System.Collections;
//using Dotnetselenium
using System.IO;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;
using System.Collections;
using log4net;
using OpenQA.Selenium.Edge;

namespace Selenium_Demo.TestCases
{
    public class InteractWithElements
    {
        public IWebDriver dr;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("I am from setup method");
            dr = new ChromeDriver(@"C:\Users\Anand\Downloads");
            //dr = new EdgeDriver($"{Directory.GetCurrentDirectory()}\\DriverHelper");
            //dr = new EdgeDriver(@"C:\Users\Anand\Downloads");

        }

        [Test]
        public void InteractWithtextbox()
        {
            dr.Navigate().GoToUrl("http://google.com");
            dr.FindElement(By.Name("q")).SendKeys("India");
            dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            IWebElement txtSrch2 = dr.FindElement(By.Name("q"));
            Console.WriteLine(txtSrch2.GetAttribute("value"));
            Assert.IsTrue(txtSrch2.GetAttribute("value")=="India", "Search keyword not matching");
            Assert.IsTrue(txtSrch2.GetAttribute("maxlength") == "2048", "maxlength not matching");
            Console.WriteLine(txtSrch2.GetAttribute("name"));
            
        }
        [Test]
        public void InteractWithtextbox1()
        {
            dr.Navigate().GoToUrl("http://Amazon.in");
            dr.FindElement(By.Id("twotabsearchtextbox")).SendKeys("Sony Tv");
            dr.FindElement(By.Id("nav-search-submit-button")).Click();
            IWebElement txtSrch2 = dr.FindElement(By.Id("twotabsearchtextbox"));
            Console.WriteLine(txtSrch2.GetAttribute("value"));
            Assert.IsTrue(txtSrch2.GetAttribute("value") == "Sony Tv", "Search keyword not matching");
        }

        [Test]
        public void InteractWithCheckBoxAndRadio()
        {
            dr.Navigate().GoToUrl("https://www.ironspider.ca/forms/checkradio.htm");
            IWebElement chkRed = dr.FindElement(By.XPath("//input[@value='red']"));
            //Console.WriteLine("blue color is selected:" + chkRed.Selected);
            if (chkRed.Selected == false)
            {
                 chkRed.Click(); //select
                //chkRed.SendKeys("india");
            }
            Console.WriteLine("Red check box is Selected:" + chkRed.Selected);

            IWebElement radioOpera = dr.FindElement(By.XPath("(//input[@type='radio'])[3]"));
            Console.WriteLine("Opera is selected1:" + radioOpera.Selected);
            if (radioOpera.Selected == false)
            {
                radioOpera.Click();
            }
            Console.WriteLine("Opera is selected2:" + radioOpera.Selected);
        }

        [Test]
        public void HandlingSelectBox()
        {
            dr.Navigate().GoToUrl("https://demo.guru99.com/test/newtours/register.php");
            IWebElement ddCountry = dr.FindElement(By.Name("country"));
            //ddCountry.SendKeys("HYDERABAD");
            //SelectElement objSelect = new SelectElement(dr.FindElement(By.Name("country")));
            SelectElement objSelect = new SelectElement(ddCountry);
           
            objSelect.SelectByIndex(8);
            Thread.Sleep(3000);
            objSelect.SelectByText("INDIA");
            Thread.Sleep(3000);
            objSelect.SelectByValue("CHINA");
            Console.WriteLine("Multiple values allowed:" + objSelect.IsMultiple);

            int optCount = objSelect.Options.Count;
            Console.WriteLine("options count is:" + optCount);

            //objSelect.DeselectByValue("CHINA");
            //for (int i = 0; i < optCount; i++)
            //{
            //    objSelect.SelectByIndex(i);
            //}
        }
        [Test]
        public void InteractWithListbox()
        {
            dr.Navigate().GoToUrl("https://output.jsbin.com/osebed/2");
            IWebElement fruitsLB = dr.FindElement(By.XPath("//select[@id='fruits']"));
            SelectElement objSelect = new SelectElement(fruitsLB);
            Console.WriteLine("Multi select allowed:" + objSelect.IsMultiple);
            objSelect.SelectByIndex(0);
            objSelect.SelectByValue("apple");
            objSelect.SelectByText("Grape");
            Console.WriteLine("Selected options count before:" + objSelect.AllSelectedOptions.Count);
            objSelect.DeselectByText("Apple");
            
            //objSelect.DeselectAll(); //deselect all selected options
            //objSelect.DeselectByText("Grape");
            Console.WriteLine("Selected options count after:" + objSelect.AllSelectedOptions.Count);
        
        }
        [TearDown]
        public void Cleanup()
        {
            Console.WriteLine(" I am cleanup method");
            //dr.Close();
        }
    }
}
