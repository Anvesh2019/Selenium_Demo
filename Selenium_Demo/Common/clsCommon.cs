using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Demo.Common
{
    public class clsCommon
    {

        public IWebDriver dr;
        public bool enableScreenshots = true;
        public clsCommon(IWebDriver driver)
        {
            dr = driver;
        }
        public void NavigateToApp(string appUrl)
        {
            dr.Navigate().GoToUrl(appUrl);
        }
        public void EnterText(IWebElement element,string strText)
        {
            element.SendKeys(strText);
        }

        public void EnterText(string strName, string strText)
        {
           dr.FindElement(By.Name(strName)).SendKeys(strText);
        }

        public void Entertext(IWebElement txtEle, string strVal)
        {
            txtEle.SendKeys(strVal);
        }

        public void Entertext(string strID, string strVal)
        {
            dr.FindElement(By.Id(strID)).SendKeys(strVal);
        }

        public void Entertext(string strXpath, string strVal, string locatortype=null)
        {
            dr.FindElement(By.XPath(strXpath)).SendKeys(strVal);
        }

        public void ClickonElement(IWebElement ele)
        {
            ele.Click();
        }
        public void ClickonElement(string strId)
        {
            dr.FindElement(By.Id(strId)).Click();
        }
        public void ClickonElementByXpath(string strXpath)
        {
            dr.FindElement(By.XPath(strXpath)).Click();
        }
        public void ClickonElementByName(string strName)
        {
            dr.FindElement(By.Name(strName)).Click();
        }
        public void ScrollDownVertical(int pixels)
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)dr;
            int pixelsToScroll = pixels / 5;
            for(int i=0;i<5;i++)
            {
                je.ExecuteScript("window.scrollBy(0," + pixelsToScroll + ")", "");
                Thread.Sleep(2000);
            }
            
        }
        public void ScrollHorizantal(int pixels)
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)dr;
            int pixelsToScroll = pixels / 5;
            for (int i = 0; i < 5; i++)
            {
                je.ExecuteScript("window.scrollBy("+ pixelsToScroll + ",0)", "");
                Thread.Sleep(2000);
            }

        }
        public void ScrollToLocation(int xpixels,int ypixels)
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)dr;
           
                je.ExecuteScript("window.scrollBy(" + xpixels + "," + ypixels+")", "");
                Thread.Sleep(2000);
           

        }

        public void ClickElementUsingJSE(IWebElement ele)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)dr;
            js.ExecuteScript("arguments[0].click(); return true", ele);
          
        }
        public void GetScreenshot()
        {
            if (enableScreenshots == true)
            {

                ITakesScreenshot screenshotDriver = dr as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                // Creating UIScreenshot folder if not exists
                System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "/UIScreenshots/");
                string fileName = Environment.CurrentDirectory + "/UIScreenshots/" + "sampletestcase" + "_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss");
                screenshot.SaveAsFile(fileName, ScreenshotImageFormat.Jpeg);
            }
        }
    }
}
