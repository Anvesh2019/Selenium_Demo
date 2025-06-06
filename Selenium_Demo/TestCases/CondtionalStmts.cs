using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Demo.TestCases
{
    public class CondtionalStmts
    {

        [Test]
        public void learnSwitchCase()
        {
            string city = "Dallas";
            switch (city)
            {
                case "Chicago":
                    Console.WriteLine("City is from Illinois");
                    break;

                case "Dallas":
                    Console.WriteLine("City is from Texas");
                    break;

                 default:
                    Console.WriteLine("City is from Florida");
                    break;


            }
            Console.WriteLine("out side of switch case");
        }
        [Test]
        public void LearnIfStatement()
        {
            
            int age = 15;
            if (age > 18)
            {
                Console.WriteLine("Stud is Major");
            }
            else
            {
                Console.WriteLine("Stud is minor");
            }
        }

        [Test]
        public void LearnIfelseIfStatement()
        {

            int age = 15;
            if (age < 1)
            {
                Console.WriteLine("Stud is a kid");
            }
            else if(age <18)
            {
                Console.WriteLine("Stud is minor");
            }
            else
            {
                Console.WriteLine("Stud is major");
            }
        }
        public void DisplayMyAge(int age)
        {
            Console.WriteLine("My age is:" + age);
        }
    }
}
