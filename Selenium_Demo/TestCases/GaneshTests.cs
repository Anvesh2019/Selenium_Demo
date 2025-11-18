using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Selenium_Demo.TestCases
{
    public class GaneshTests
    {
        [Test]
        public void GetHighestDonationAmt()
        {
            ClsGanesh g1=new ClsGanesh();
            Console.WriteLine(g1.HighestDonationAmt());
            Console.WriteLine(g1.HighestDonor());
            ClsGanesh g2 = new ClsGanesh();
            Console.WriteLine(g2.GetTotalDonationAmount());
            Console.WriteLine();
        }
    }
}
