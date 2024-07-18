using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Demo
{
    public class DataTypes
    {
        [Test]
        public void AddNumbers()
        {
            int x;
            x = 200;
            x = 500;
            int y = 300;
            int result = x + y;
            Console.WriteLine("sum is:" + result); //500

        }

        [Test]
        public void PrintCity()
        {
            string city = "Mumbai";
            string state = "Maharastra";
            string result = city + " is from " + state;
            Console.WriteLine(result);
        }
        [Test]
        public void CheckIsMajor()
        {
            int age = 15;
            bool isMajor = false;
            if(age<18)
            {
                isMajor = false;
            }
            else
            {
                isMajor = true;
            }
            Console.WriteLine("Student is major: " + isMajor);
        }
        [Test]
        public void CheckStudIsMajor()
        {
            int age = 45;
         
            if (age < 18)
            {
                Console.WriteLine("Student is minor");
            }
            else if(age >18 && age <30)
            {
                Console.WriteLine("Student is young");
            }
            else
            {
                Console.WriteLine("Student is old");
            }
           
        }
    }
}
