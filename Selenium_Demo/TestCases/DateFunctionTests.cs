using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Demo.TestCases
{
    public class DateFunctionTests
    {
        [Test]
        public void learnDateFunc()
        {
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
        }
    }
}
