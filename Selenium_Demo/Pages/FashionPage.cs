using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace Selenium_Demo.Pages
{
    public class FashionPage: TestBase
    {
        IWebDriver dr;
        
        public FashionPage(IWebDriver driver)
        {
            this.dr = driver;
        }
        public IWebElement Mens=> dr.FindElement(By.XPath("(//div[@class='subnav-div']//a//span)[3]"));

        public void hoverMens()
        {
            Actions _action = new Actions(dr);
            _action.MoveToElement(Mens).Perform();
        }

        public IWebElement mensClothing => dr.FindElement(By.XPath("(//a[text()='Explore Store']//following-sibling::h3)[4]"));
        public IList<IWebElement> getLinks => dr.FindElements(By.XPath("//div[@id='sobe_d_b_ms_1-carousel\']//a"));
        public IList<IWebElement> displayDepartments => dr.FindElements(By.XPath("(//div[@role='radiogroup'])[1]"));
        public IList<IWebElement> displayBrands => dr.FindElements(By.XPath("//div[@aria-labelledby='brands']/span"));

        public IWebElement clickOnSeeMore => dr.FindElement(By.XPath("//a[text()='See more']"));
    }
}
