using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Demo
{
    internal class Class1
    {
        public void Find()
        {
            Console.WriteLine("hello");
            Console.WriteLine("Rishi");
            Console.WriteLine("Sai Charan");
        }
        public void addNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine("sum is:" + result);
        }
        public int GetSumofNumbers(int x,int y)
        {
            return x + y;
        }
        public string Getcapitalcity(string sname)
        {
            string ccity = "";
            if (sname == "TS")
            {
                ccity = "HYD";
            }
            else if (sname == "AP")
            {
                ccity = "VIZ";
            }
            else if (sname == "MH")
            {
                ccity = "MUM";
            }
            else
            {
                ccity = "unknown";
            }
            return ccity;
        }
        public string[] GetWords(string strInput)
        {
            string[] arrStr = strInput.Split(' ');
            return arrStr;
        }

    }
}
