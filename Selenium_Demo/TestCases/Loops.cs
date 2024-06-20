using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Demo.TestCases
{
    public class Loops
    {
        [Test]
        public void LearnForLoop()
        {
            int i = 0;
            for(i=0;i<10;i=i+2)
            {
                Console.WriteLine("I am bhavya :" + i);
            }

        }
        [Test]
        public void LearnWhileLoop()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("I am bhavya :" + i); //0,2,4,6,8
                i = i + 2;
            }
            Console.WriteLine("outside while loop:" + i);
        }
        [Test]
        public void LearnDoWhileLoop()
        {
            int i = 0;
            do
            {
                Console.WriteLine("I am bhavya :" + i); //0,2,4,6,8
                i = i + 2;
            } while (i < 10);
            Console.WriteLine("outside do while loop:" + i);
        }
    }
}
