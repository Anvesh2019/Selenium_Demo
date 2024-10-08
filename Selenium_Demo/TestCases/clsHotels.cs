﻿using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using System.Threading;
using System.Collections;
using System.Collections.ObjectModel;
using Selenium_Demo.Pages;

namespace Selenium_Demo
{
    public class clsHotels
    {
        HotelsHomePage _homepage;
        public IWebDriver dr;
        
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("I am from setup method");
            dr = new ChromeDriver();
            //dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Desktop");
            //dr = new ChromeDriver(@"C:\\Users\\Anand.Gummadilli\\OneDrive-Neudesic\\Desktop");
            _homepage = new HotelsHomePage(dr);

        }
        [Test]
        public void VerifyGoingToFieldIsRequiredField()
        {
            dr.Navigate().GoToUrl("http://hotels.com");

        }
        public void NavigateToSite(string strUrl)
        {
            dr.Navigate().GoToUrl(strUrl);
        }
        public void enterSearchCity(string strCity)
        {
            dr.FindElement(By.XPath("//button[@aria-label='Going to']")).Click();
            dr.FindElement(By.Id("destination_form_field")).SendKeys(strCity);
            System.Threading.Thread.Sleep(2000);
            dr.FindElement(By.XPath("//strong[text()='"+ strCity + "']")).Click();
        }

        public void ClickonSearchButton()
        {
            dr.FindElement(By.Id("search_button")).Click();
        }
        [Test]
        public void SearchHotel()
        {
            NavigateToSite("http://hotels.com");
            enterSearchCity("Goa");
            ClickonSearchButton();
        }
        [Test]
        public void VerifyPageElements()
        {
           
            dr.Navigate().GoToUrl("https://www.hotels.com"); //open the hotels.com home page
            Console.WriteLine(dr.Title);
            IWebElement txtGoingTo=  dr.FindElement(By.XPath("//button[@aria-label='Going to']"));
            Assert.IsTrue(txtGoingTo.Displayed==true); //Check going to field is displayed

            IWebElement datesField = dr.FindElement(By.Id("date_form_field-btn"));
            Assert.IsTrue(datesField.Size != Size.Empty,"Dates field is NOT displayed"); //Check dates field is displayed

            IWebElement lblTravellors = dr.FindElement(By.XPath("//label[text()='Travellers']"));
            Assert.IsTrue(lblTravellors.Size!=Size.Empty);

            txtGoingTo.Click();
            IWebElement txtDest = dr.FindElement(By.Id("destination_form_field"));
            txtDest.SendKeys("Orlando");
            System.Threading.Thread.Sleep(2000);

            IWebElement selectCity = dr.FindElement(By.XPath("(//div[contains(text(),'Florida')])[1]"));
            selectCity.Click();
        }
        [Test]
        public void VerifyGoingToIsRequired()
        {
            HotelsHomePage _homepage = new HotelsHomePage(dr);

            NavigateToSite("http://hotels.com");
            //dr.Navigate().GoToUrl("http://hotels.com");
            //dr.FindElement(By.Id("submit_button")).Click();
            //dr.FindElement(By.XPath("//button[@id='search_button']")).Click();
            _homepage.ClickonSearchButton();
            //IWebElement error = dr.FindElement(By.XPath("//div[text()='Please select a destination']"));
            //Assert.IsTrue(error.Size!=Size.Empty);
            Assert.IsTrue(_homepage.errorDestinationRequired.Displayed == true,"Going to field is not required field");
        }

        [Test]
        public void VerifyGoingToIsRequired_new()
        {
             NavigateToSite("http://hotels.com");
            _homepage.ClickonSearchButton();
            Assert.IsTrue(_homepage.errorDestinationRequired.Displayed == true, "Going to field is not required field");
        }

        [Test]
        public void GoogleSearch()
        {
            dr.Navigate().GoToUrl("http://google.com");
            dr.FindElement(By.Name("q")).SendKeys("India"); //entering india
            //IWebElement btnGsearch = dr.FindElement(By.Name("btnK"));
            //btnGsearch.Click();
            Thread.Sleep(2000);
            dr.FindElement(By.Name("btnK")).Click();
        }

        [Test]
        public void TotalLinksCount()
        {
            dr.Navigate().GoToUrl("http://google.com");
            Thread.Sleep(2000);
            ReadOnlyCollection<IWebElement> listLinks = dr.FindElements(By.XPath("//a"));
           
            Thread.Sleep(2000);
            Console.WriteLine("Links Counts is:" + listLinks.Count);
        }

        [Test]
        public void TotalTextboxCount()
        {
            dr.Navigate().GoToUrl("http://google.com");
            Thread.Sleep(2000);
            ReadOnlyCollection<IWebElement> listLinks = dr.FindElements(By.XPath("//input"));

            Thread.Sleep(2000);
            Console.WriteLine("Textbox Counts is:" + listLinks.Count);
        }
    }
}
