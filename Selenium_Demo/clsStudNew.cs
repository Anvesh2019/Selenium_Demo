using AventStack.ExtentReports.Gherkin.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Demo
{
    public class clsStudentNew
    {

        int sno = 0;
        public clsStudentNew()
        {
            sno = 200;
            Console.WriteLine(" I am costructor");
        }
        public clsStudentNew(int snum)
        {
            sno = snum;
           
        }
        public void PrintMyname()
        {
            Console.WriteLine("My name is Anand");
        }


        public void PrintMyname(string strName)
        {
            Console.WriteLine("My name is " + strName);

        }

        public string GetSnameBySno(int sno)
        {
            string sname = "";
            if (sno == 10)
            {
                sname = "Anand";
            }
            else if (sno == 20)
            {
                sname = "Priyanka";
            }
            else
            {
                sname = "chandana";
            }

            return sname;

        }

        public int[] GetFirstRankStudents()
        {
            int[] arrRankers = new int[3] { 100, 200, 300 };
            return arrRankers;
        }

        public Hashtable GetRanks()
        {
            Hashtable hs1=new Hashtable();
            hs1.Add(1, "Anand");
            hs1.Add(2, "Sravani");
            hs1.Add(3, "Priyanka");
            hs1.Add(4, "Chandana");
            return hs1;

        }
    }

}
