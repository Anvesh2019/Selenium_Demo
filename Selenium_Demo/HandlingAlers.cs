using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Selenium_Demo
{
    public class HandlingAlers
    {
        public IWebDriver dr;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("I am from setup method");
            dr = new ChromeDriver(@"C:\Users\v-anandag\Desktop");

        }
        [Test]
        public void HandlingAlerts()
        {
            // Alert Message handling
            dr.Navigate().GoToUrl("http://demo.guru99.com/test/delete_customer.php");
            dr.FindElement(By.Name("cusid")).SendKeys("53920");
            dr.FindElement(By.Name("submit")).Click();
            // Switching to Alert        
            IAlert alert = dr.SwitchTo().Alert();
            // Capturing alert message.    
            String alertMessage = dr.SwitchTo().Alert().Text;
            // Displaying alert message		
            Console.WriteLine(alertMessage);
            
            Thread.Sleep(5000);
            if(alertMessage== "Do you really want to delete this Customer?")
            {
                // Accepting alert		
                alert.Accept();
            }
            Thread.Sleep(2000);
            IAlert alertDelete = dr.SwitchTo().Alert();
            string actualMsg = alertDelete.Text;
            Assert.AreEqual("Customer Successfully Delete!", actualMsg,"Customer is not deleted");
            alertDelete.Accept(); //Click on OK button
        }
    }
}
