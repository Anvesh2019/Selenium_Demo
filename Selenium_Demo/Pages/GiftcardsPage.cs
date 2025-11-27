using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Demo.Pages
{
    public class GiftcardsPage
    {
        IWebDriver dr;
        public GiftcardsPage(IWebDriver driver) 
        { 
            this.dr= driver;
        }
        public IWebElement spanAddGcard=> dr.FindElement(By.XPath("//span[text()='Add Gift Card']"));
       
        
    }
}
