using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Demo
{
    public class clsUniversity
    {
        public static string uname = "Osmania University";
        public string uType = "public";
        public string yearEstablished = "1918";
        public string founder = "Ali khan";
        public int staff = 445;
        public int studentsCount = 11000;
        private string addr = "Tarnaka";
        public bool isGood = true;

        public void DisplayUnivName()
        {
            Console.WriteLine("University name is Osmania");
        }
        public void DisplayUnivName(string uname)
        {
            Console.WriteLine("University name is:" + uname);
        }
        public void DisplayStudName(string sname)
        {
            Console.WriteLine("Student name is:" + sname);
            sname = GetStudNameBySid(200);
        }
        protected string GetStudNameBySid(int sno)
        {
            string sname = "";
            switch(sno)
            {
                case 100:
                    sname = "Anvesh";
                    break;
                case 200:
                    sname = "Asha";
                    break;
                case 300:
                    sname = "Adwaith";
                    break;
                default:
                    sname = "unknown student";
                    break;

            }
            return sname;
        }
        public virtual void DisplayCollegename()
        {
            Console.WriteLine("I am from base class");
        }
    }
    public class clsCollege:clsUniversity
    {
        public override void DisplayCollegename()
        {
            Console.WriteLine("I Am from child class");
        }
    }
}
