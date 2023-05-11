using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Selenium_Demo
{
    public class clsCar
    {
        public static string collegeCity = "VJA";
        public int cost = 5000000;
        public string color = "black";
        private string carCity = "Dallas";
        public string GetCarModel()
        {
            return "Brezza";
        }

        public int AddNumbers(int x, int y)
        {
            int result = x + y;
            return result;
        }
        public string GetCarModel(int year)
        {
            switch(year)
            {
                case 2022:
                    return "Benz";
                    break;
                case 2023:
                    return "MG Hector";
                    break;

                default:
                    return "BMW";
            }
        }
        public virtual string GetCarCity()
        {
            return carCity;
        }
        public static string GetCollegename()
        {
            return "VRSEC";
        }

        [Test]
        public void VerifyAddNumbers()
        {
            Console.WriteLine(AddNumbers(20,250));
        }
    }

    public class clsBMW: clsCar
    {
        public int rank = 2;
        public string GetCarName()
        {
            return "BMW X5";
        }

        public override string GetCarCity()
        {
            return "Delhi";
        }
    }
    
    
}
