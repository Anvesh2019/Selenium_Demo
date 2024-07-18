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
    }
}
