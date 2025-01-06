using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Edge;

namespace Selenium_Demo
{
    public class clsPractice_SepBatch
    {

        [Test]
        public void OpenGmail()
        {
            IWebDriver dr;
            //= new ChromeDriver(@"C:\Users\Anand.Gummadilli\Desktop");
            dr = new EdgeDriver("C:\\Users\\Anand.Gummadilli\\Downloads\\edgedriver_win64");

            dr.Navigate().GoToUrl("https://google.com");
            dr.FindElement(By.LinkText("Gmail")).Click();
        }


    }
}
