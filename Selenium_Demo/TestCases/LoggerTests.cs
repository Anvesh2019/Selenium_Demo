using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Demo.TestCases
{
    public class LoggerTests
    {
        clsMyLogger logger;
        [SetUp]
        public void Setup()
        {
            logger = new clsMyLogger();
        }
        [Test]
        public void CheckLogger()
        {

            int x = 10;
            logger.LogMessage("x value is:" + x);

            int y = 0;

            logger.LogMessage("y value is:" + y);
            int z = x / y;
            logger.LogMessage("z value is:" + z);
        }
    }
}
