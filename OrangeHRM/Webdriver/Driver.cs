using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Webdriver
{
    public static class Driver
    {

        public static IWebDriver dr = null;
        public static IWebDriver driver(string myDriver)
        {


               switch(myDriver)
            {
                case "chrome":
                    dr = new ChromeDriver(@"C:\\Users\\HP\\Downloads\\chromedriver-win64");
                    break;
                case "edge":
                    dr = new EdgeDriver();
                    break;

                case "firefox":
                    dr = new FirefoxDriver();
                    break;
            }
            return dr;
        }

    }
}
