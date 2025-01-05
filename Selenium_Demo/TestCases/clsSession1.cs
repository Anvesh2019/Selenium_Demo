using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Demo.TestCases
{
    public class clsSession1
    {

        int age = 35;
        string cname = "VRSEC";
        string uname = "osmania univ";
        bool isMajor = true;
        char gender = 'M';

        [Test]
        public void AddNumbers()
        {
            int x = 25;
            int y = 30;
            int result = x + y;
            Console.WriteLine(result);
        }
        [Test]
        public void SubtractNumbers()
        {
            int x = 200;
            int y = 100;
            int z = x - y;
            Console.WriteLine(z);
            DisplayCapital();
        }

        public void DisplayCapital()
        {
            Console.WriteLine("Capital city is Hyderabad");
        }
    }
}
