using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Demo
{
    public class clsStates
    {
        public static string cname = "USA";
        public int scount = 52;
        private string gname = "junior bush";

        public string DisplayTaxFreeStates()
        {
            return "TXFL";
        }
        public string DisplayTaxFreeStates(string sname)
        {
            string tempState = "";

            if (sname=="TX")
            {
                tempState= sname;
            }
            else
            {
                tempState = "not a tax free state";
            }
            return tempState;
        }
        public string DisplayTaxFreeStates(string sname, int sno)
        {
            string tempState = "";

            if (sname == "TX")
            {
                tempState = sname;
            }
            else
            {
                tempState = "not a tax free state";
            }
            return tempState;
        }
        public bool CheckLargeState(string sname)
        {
            if(sname=="TX")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class clsCapitals: clsStates
    {
        public void DisplayCapitalByState(string sname)
        {
            switch (sname)
            {
                case "TX":
                    Console.WriteLine("Austin");
                    break;

                case "MD":
                    Console.WriteLine("BAltimore");
                    break;
                case "FL":
                    Console.WriteLine("Jacksonville");
                    break;

                 default:
                    Console.WriteLine("unknown");
                    break;


            }
        }

        public bool CheckLargeState(string sname)
        {
            if (sname == "TX")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
