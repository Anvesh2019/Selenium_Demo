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
    
        public void ClickOnCart()
        {
            cart.Click();
        }

        public void clickonSignup()
        {
            btnSignupNow.Click();
        }
    }
}
