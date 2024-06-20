using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Demo.TestCases
{
    public class clsWebtable
    {
        public IWebDriver dr;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("I am from setup method");
            dr = new ChromeDriver(@"C:\Users\Anand.Gummadilli\Downloads");

        }

        [Test]
        public void VerifyRows()
        {
            dr.Navigate().GoToUrl("https://www.moneycontrol.com/stocks/marketinfo/marketcap/bse/index.html");
            Thread.Sleep(10000);
            IList<IWebElement> listCompanies=  dr.FindElements(By.XPath("//table[@class='Topfilter_web_tbl_indices__Wa1Sj undefined']/tbody/tr"));
            Console.WriteLine(listCompanies.Count);
            IWebElement topComp = dr.FindElement(By.XPath("//table[@class='Topfilter_web_tbl_indices__Wa1Sj undefined']/tbody/tr[1]/td[1]"));
            Console.WriteLine("Top company name:" + topComp.Text);

        }
        [Test]
        public void Get2ndCompanyDetails()
        {
            Console.WriteLine("started executing Get2ndCompanyDetails at" + DateTime.Now.ToString());
            dr.Navigate().GoToUrl("https://www.moneycontrol.com/stocks/marketinfo/marketcap/bse/index.html");
            IWebElement secondCompany = dr.FindElement(By.XPath("//table[@class='Topfilter_web_tbl_indices__1oyWE undefined']/tbody/tr[2]/td[1]"));
            Console.WriteLine("2nd company name is:" + secondCompany.Text);
            IWebElement secondCompanyPrice = dr.FindElement(By.XPath("//table[@class='Topfilter_web_tbl_indices__1oyWE undefined']/tbody/tr[2]/td[2]"));
            Console.WriteLine("2nd company price is:" + secondCompanyPrice.Text);
            Console.WriteLine("Ended executing Get2ndCompanyDetails at" + DateTime.Now.ToString());

        }
        [Test]
        public void GetHighestCompany()
        {
            string cname = GetCompanyNameByRank(3);
            Console.WriteLine(cname);
            dr.Close();


        }
        public string GetCompanyNameByRank(int rankNum)
        {
            dr.Navigate().GoToUrl("https://www.moneycontrol.com/stocks/marketinfo/marketcap/bse/index.html");
            IWebElement elemTopComp = dr.FindElement(By.XPath("//table/tbody/tr[" + rankNum + "]/td[1]/a"));
            string cname = elemTopComp.Text;
            // Console.WriteLine("Top company name is:" + cname);
            return cname;
        }
        [Test]
        public void GetRankByCompanyName()
        {
            int rank = GetRankByCompany("SBI");
            Console.WriteLine("SBI Rank is:" + rank);

        }
        public int GetRankByCompany(String company)
        {
            IWebElement ElementbyRank;
            string raname = string.Empty;
            int index = 0;
            dr.Navigate().GoToUrl("https://www.moneycontrol.com/stocks/marketinfo/marketcap/bse/index.html");
            dr.Manage().Window.Maximize();
            Thread.Sleep(30000);
            ReadOnlyCollection<IWebElement> rowList = dr.FindElements(By.XPath("//table/tbody/tr"));

            for (int i = 1; i <= rowList.Count; i++)
            {
                ElementbyRank = dr.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/a"));
                raname = ElementbyRank.Text;
                if (company == raname)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }


    }
}
