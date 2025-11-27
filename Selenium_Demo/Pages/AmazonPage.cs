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
        public IWebElement linkGiftcards=>dr.FindElement(By.XPath("//span[contains(text(),'Gift Cards') and @id='nav-search-label-id']"));
        //public IWebElement linkFashion => dr.FindElement(By.XPath("//span[contains(text(),'Fashion') and @id='nav-search-label-id']"));
        public IWebElement linkFashion => dr.FindElement(By.XPath("//a[text()='Fashion']"));

        public IWebElement cart => dr.FindElement(By.XPath("//span[@id='nav-cart-count']"));
        public IWebElement headingCartEmpty => dr.FindElement(By.XPath("//h3[contains(text(),'Your Amazon Cart is empty')]"));
        public IWebElement btnSignupNow => dr.FindElement(By.XPath("//span[contains(text(),'Sign up now')]"));
        public IWebElement btnSrch => dr.FindElement(By.Id("nav-search-submit-button"));
        public IWebElement txtSearch => dr.FindElement(By.Id("twotabsearchtextbox"));
        public void ClickOnCart()
        {
            cart.Click();
        }

        public void clickonSignup()
        {
            btnSignupNow.Click();
        }

        public void NavigatetoAmazon()
        {
            dr.Navigate().GoToUrl("https://amazon.in");
            dr.Manage().Window.Maximize();

        }
    }
}
