using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Demo
{
    public class carTests
    {
        clsAddInfo objCar = new clsAddInfo();

        [Test]
        public void VerifyCarColor()
        {

            clsAddInfo objCar = new clsAddInfo();
            objCar.color = "red";
            
            objCar.DisplayCarName();

            clsAddInfo objCar2 = new clsAddInfo("Black");
            objCar2.DisplayCarName();

            objCar.DisplayTodaysDate();

            clsAddInfo.GetCarPrice();

            Console.WriteLine(clsAddInfo.AuxCompatable);

        }
        [Test]
        public void VerifyAddNumbers()
        {
            
            int sum = objCar.AddNumbers(150, 210);
            Console.Write("Sum1 is:" + sum);

            int sum2 = objCar.AddNumbers(175, 255);
            Console.Write("Sum2 is:" + sum2);

        }
        [Test]
        public void VerifyCityName()
        {
         string cityName=objCar.VerifyPincode("502032");
         Console.WriteLine(cityName);
        }

        [Test]
        public void VerifyIsMinor()
        {
          Console.WriteLine("student is Minor: " + objCar.isMinor(25));
        }

        [Test]
        public void LearnExceptionHandling()
        {
            try
            {
                int x = 10;
                int y = 0;
                int z = x / y;
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }
    }
}
