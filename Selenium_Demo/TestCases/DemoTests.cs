using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Selenium_Demo.TestCases
{
    public class DemoTests
    {
       
        [Test]
        [Category("Amazon1")]
        public void LoadAmazon()
        {
            Console.WriteLine("Load Amazon Test case");
        }
        [Test]
        [Category("Amazon1")]
        public void LoadAmazon2()
        {
            Console.WriteLine("Load Amazon Test case2");
        }
        [Test]
        [Category("Amazon1")]
        public void LoadAmazon3()
        {
            Console.WriteLine("Load Amazon Test case3");
        }
    }
}
