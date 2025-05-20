using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Demo.TestCases
{
    public class StringFunctions
    {
        [Test]
        public void ReverseString()
        {
            string str1 = "MaheshKumar"; //11
            char[] arrChars= str1.ToCharArray();
            string strRev = "";

            for (int i = arrChars.Length - 1; i >= 0; i--)
            {
                strRev=strRev + arrChars[i];
            }

            Console.WriteLine(strRev);
        }

        [Test]
        public void LearnSubstr()
        {
            string str1 = "MaheshKumar"; //11
            Console.WriteLine(str1.Substring(1,3));
            Console.WriteLine(str1.ToLower());
            Console.WriteLine(str1.ToUpper());
                       
            Console.WriteLine(str1.Replace('M', 'R'));

            Console.WriteLine(str1.IndexOf('h'));
            string str2 = "MaheshKumar";
            Console.WriteLine(str1.CompareTo(str2));
            Console.WriteLine(str1.Contains("Mahesh123"));
            Assert.IsTrue(str1.Contains("Mahesh")==true,"Mahesh123 is not there");

            string str3 = "My name is Mahesh";
            string[] arrWords = str3.Split(' ');
            Console.WriteLine(arrWords.Length);
            //Console.WriteLine(arrWords[4]);
        }

    }
}
