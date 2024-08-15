using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.TestCases
{
    public class LoginTest:BaseTest
    {
       
        
        [Test]
        public void login()
        {
            loginPage.ClickOnLogin("Admin", "admin123");
        }
    }
}
