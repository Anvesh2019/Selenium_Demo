using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Selenium_Demo
{
    public class HandlingAlerts
    {
        public IWebDriver dr;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("I am from setup method");
            dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads\");


        }
        [Test]
        public void HandlingAlerts_new()
        {
            // Alert Message handling
            dr.Navigate().GoToUrl("http://demo.guru99.com/test/delete_customer.php");
            dr.FindElement(By.Name("cusid")).SendKeys("53920");
            dr.FindElement(By.Name("submit")).Click();
            // Switching to Alert        
            IAlert alert = dr.SwitchTo().Alert(); //switch to 1st popup
            Console.WriteLine("1st alert text:" + alert.Text);
            alert.Accept(); //click on OK button
            Thread.Sleep(2000);
            //alert.SendKeys(Keys.Enter); //Click on Enter button
            //alert.Dismiss(); //Clikc on cancel button

            IAlert deleteAlert= dr.SwitchTo().Alert(); //Switch to delete popup
            Console.WriteLine("2nd alert text:" + alert.Text);
            deleteAlert.Accept(); //Click on OK

        }

        [Test]
        public void HandlingAlerts1()
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
