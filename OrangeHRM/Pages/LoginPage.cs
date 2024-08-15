using OpenQA.Selenium;
using OrangeHRM.Common;
using OrangeHRM.Webdriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Pages
{
    public class LoginPage
    {
        public Actions actions;
        public IWebDriver driver;
        public LoginPage(IWebDriver driver) 
        {
            this.driver = driver;
            actions = new Actions(driver);

        }
        By userName = By.Name("username");
        By passWord = By.Name("password");
        By login = By.XPath("//button[text()=' Login ']");

        public void ClickOnLogin(string username, string password)
        {
            actions.EnterText(userName, username);
            actions.EnterText(passWord, password);
            actions.clickOnElement(login);
            
        }

    }
}
