using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Demo
{
    public class clsUniversity
    {
        string uname = "Osmania University";
        public string uType = "public";
        public string yearEstablished = "1918";
        public string founder = "Ali khan";
        public int staff = 445;
        public int studentsCount = 11000;
        public string addr = "Tarnaka";
        public bool isGood = true;

        public void DisplayUnivName()
        {
            Console.WriteLine("University name is:" + uname );
        }

        public void DisplayStudName(string sname)
        {
            Console.WriteLine("Student name is:" + sname);
        }
    }
}
