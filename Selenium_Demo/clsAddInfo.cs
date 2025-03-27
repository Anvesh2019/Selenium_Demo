using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Demo
{
    public class clsAddInfo
    {
        public string color = "";
        private string yearMade = "2014";
        public bool USBCompatibility = true;
        public static bool AuxCompatable = true;
        public static string Company = "Maruthi Suzuki";
        public string model = "ZDI";
        public clsAddInfo()
        {
            color = "Blue";
        }
        public clsAddInfo(string inputColor)
        {
            color = inputColor;
        }
        public static void GetCarPrice()
        {
            Console.WriteLine("My car price is: 500000");
        }
       
        public void DisplayTodaysDate()
        {
            Console.WriteLine(DateTime.Now);
        }

        public void DisplayCarName()
        {
            Console.WriteLine("My car color is:" + color);
            Console.WriteLine("My car model is:" + yearMade);

        }
        public int AddNumbers(int x, int y)
        {
            int z = x + y;
            return z;
        }
        public string VerifyPincode(string zipcode)
        {
            string city = "";
            if (zipcode == "502295")
            {
                city = "Sangareddy";
            }
            else if (zipcode == "502032")
            {
                city = "Beeramguda";
            }
            else
            {
                city = "Hyderabad";
            }
            return city;
        }
        public bool isMinor(int age)
        {
           
            if (age < 18)
            {
           
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }

}
