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
        private string uname = "osmania";
        public clsStud()
        {
            age = 40;
            Console.WriteLine("My Age is:" + age);

        }
        public clsStud(int Studage)
        {
            age = Studage;
            Console.WriteLine("My Age is:" + Studage);

        }
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
            Console.WriteLine("univ name is:" + uname);
        }
        public string GetStudName(int sno)
        {
            string sname = "";
            if (sno == 20)
            {
                sname = "Anand";
            }
            else if (sno == 30)
            {
                sname = "Mahesh";
            }
            else
            {
                return "Sai";
            }
                return sname;
        }
        public bool CheckMajor(int age)
        {

            bool isMajor = false;
            if (age > 18)
            {
                isMajor = true;
            }
            return isMajor;
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
