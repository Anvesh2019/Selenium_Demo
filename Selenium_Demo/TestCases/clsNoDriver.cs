using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Selenium_Demo.TestCases
{
    public class clsNoDriver
    {
        [Test]
        public void AddNumbers()
        {
            int x = 30;
            int y = 50;
            int z = x + y;
            Console.WriteLine("Sum is:" + z);
        }
    }
}
