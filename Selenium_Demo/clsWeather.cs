using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Demo
{
    public abstract class clsWeather1
    {
        public abstract void displayWeatherByCity();
        public void DisplayCountry()
        {
            Console.WriteLine("India");
        }

       
    }

    public class clsNormalWeather: clsWeather1
    {
        public override void displayWeatherByCity()
        {
            Console.WriteLine("I am from child class");
        }
    }
}
