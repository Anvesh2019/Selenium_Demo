using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Selenium_Demo.TestCases
{
    public class WeatherTests
    {
        [Test]
        public void GetWeaterByZip()
        {
            Console.WriteLine("Weather is 20 degrees");
        }
        [Test]
        public void GetWeaterByCityname(string City)
        {
            Console.WriteLine("Weather is 30 degrees for Hyderabad");
        }

    }
}
