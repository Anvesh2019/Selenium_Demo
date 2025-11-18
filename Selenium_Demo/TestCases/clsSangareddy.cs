using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Demo.TestCases
{
    public class clsSangareddy
    {
        public string cname = "sangareddy";
        public static int population = 10000;

        private int sal = 20000;
        public int getDetails()
        {
            return 500022;
        }
        public int getDetails(string cnmae)
        { 
            if(cname=="Beeramguda")
            {
                return 502032;
            }
            else
            {
                return 500022;
            }
                
        }

        public virtual void DisplayCountry(int sno)
        {
            Console.WriteLine("I am from parent class");
        }

    }
    public class clsChild: clsSangareddy
    {
        public void DisplayState()
        {
            Console.WriteLine("I am from Telangana");
        }

        public override void DisplayCountry(int sname)
        {
            Console.WriteLine("I am from child class");
        }
    }
}
