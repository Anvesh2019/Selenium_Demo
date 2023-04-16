using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Demo
{
    public class clsStud
    {
        public int age = 25;
        public string sname="Arun";
        public string addr = "Beeramguda";
        public string courseName="Selenium";
        public static string city = "Hyderabad";
        public virtual void DisplaySname()
        {
            Console.Write("Student name is Pallavi");
        }
        public void DisplaySname(string sname)
        {
            Console.Write("Student name is:" +  sname);
        }
        public void DisplayFee()
        {
            Console.Write("Student fee is:20000");
        }
        public virtual void GetDeptdetails()
        {

        }
    }
    public class clsDept:clsStud
    {
        public override void DisplaySname()
        {
            Console.Write("Student name is Anand");
        }
        public override void GetDeptdetails()
        {

        }
    }

    public class clsWeather: clsDept
    {
        public override void GetDeptdetails()
        {
            Console.Write("Student name is Anand");
        }
    }
}
