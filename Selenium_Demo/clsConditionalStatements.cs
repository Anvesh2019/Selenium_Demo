using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
//using AventStack.ExtentReports.Model;
using NUnit.Framework;

namespace Selenium_Demo
{
    public class clsConditionalStatements
    {
        [Test]
        public void VerifyCondition()
        {
            string sname = "MH";
            if(sname=="MH")
            {
                Console.WriteLine("Capital city is mumbai");
            }
            else if(sname=="TS")
            {
                Console.WriteLine("Capital city is hyderabad");
            }
            else if (sname == "GOA")
            {
                Console.WriteLine("Capital city is panaji");
            }
            else
            {
                Console.WriteLine("unknown capital");
            }
        }

         [Test]
        public void VerifyIfstatement()
        {
            int x = 45;
            if(x>10 && x <30)
            {
                Console.WriteLine("x is > 10 and < 30");
            }
            else if(x>30 && x <40)
            {
                Console.WriteLine("x is > 30");
            }
            else
            {
                Console.WriteLine("x is > 40");
            }
        }
        [Test]
        public void VerifySwitchstatement()
        {
            int x = 30;
           switch(x)
            {
                case 20:
                    Console.WriteLine("X is 20");
                    break;
                case 30:
                    Console.WriteLine("X is 30");
                    break;
                case 40:
                    Console.WriteLine("X is 40");
                    break;
                 default:
                    Console.WriteLine("X is:" + x);
                    break;
            }
        }

        [Test]
        public void VerifyForLoop()
        {
            int i = 0;
            for ( i = 0; i < 10; i++)
            {
               
                    Console.WriteLine("i value is:" + i);
                
                
            }
            Console.WriteLine("i value after loop is:" + i);
        }
        [Test]
        public void PrintEvenNumbers()
        {
            int i = 0;
            for(i=0;i<=10;i=i+2) // 0 2 4 6 8 10
            {
                Console.WriteLine("i value is:" + i);

            }
            
        }

        [Test]
        public void VerifyWhileLoop()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("i value is:" + i);
                i = i + 1;
            }
            Console.WriteLine("i value after while loop is:" + i);
        }

        [Test]
        public void VerifyDoWhileLoop()
        {
            int i = 10;
            do
            {
                Console.WriteLine("i value is:" + i);
                i = i + 1;
            }
            while (i < 5);
            Console.WriteLine("i value after while loop is:" + i);
        }
        [Test]
        [Category("Actions")]
        public void WeatherTest()
        {
            clsWeatherInfo objWeather = new clsWeatherInfo();
            int currentTemp = objWeather.GetWeatherByZipcode("12345");
            Console.WriteLine("temp is:" + currentTemp);
        }
        [Test]
        public void VerifyRanks()
        {
            clsStudentNew objStud = new clsStudentNew();
            Hashtable hsRanks = objStud.GetRanks();
            //Console.WriteLine(hsRanks.Count);
            foreach(DictionaryEntry de in hsRanks) 
            {
                Console.WriteLine(de.Key + "=" + de.Value);
            }
        }
        [Test]
        public void LearnInheritance()
        {
            clsSelenium objChild = new clsSelenium();
            objChild.DisplayName();
            objChild.DisplayStudName();
            Console.WriteLine(objChild.city);
            objChild.DisplayStudName("Anand");

            objChild.DisplayName();

            DecBatch objDec = new DecBatch();
            objDec= new clsSelenium();
            objDec.DisplayName();

           Console.WriteLine(DecBatch.cname);
           Console.WriteLine(DecBatch.GetCity());

          

        }

    }
}
