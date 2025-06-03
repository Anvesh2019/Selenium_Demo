using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Selenium_Demo.Pages
{
    public class AmazonPage
    {
        IWebDriver dr;
        public AmazonPage(IWebDriver driver) 
        { 
            dr= driver;
        }
        public IWebElement cart => dr.FindElement(By.XPath("//span[@id='nav-cart-count']"));
        public IWebElement headingCartEmpty => dr.FindElement(By.XPath("//h3[contains(text(),'Your Amazon Cart is empty')]"));
        public IWebElement btnSignupNow => dr.FindElement(By.XPath("//span[contains(text(),'Sign up now')]"));

        public IWebElement linkRetruns => dr.FindElement(By.Id("nav-orders"));
        public IWebElement smoothWalk => dr.FindElement(By.XPath("(//a[contains(text(),'Smoothwalk Ointment')])[1]"));

        public void ClickOnCart()
        {
            cart.Click();
        }

        public void clickonSignup()
        {
            btnSignupNow.Click();
        }

        public void clickOnReturns()
        {
            linkRetruns.Click();
        }
    }
}
