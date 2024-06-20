using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Demo.TestCases
{
    public static class StringExtensions
    {
        public static string ToUpperExtension(this string str)
        { 
            return str.ToUpper(); 
        }

    }
}
