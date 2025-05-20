using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Demo
{
    public class clsParent
    {
        
        public void DisplayName()
        {
            Console.WriteLine("My name is mahesh");
        }
        public void DisplayName(string sname)
        {
            Console.WriteLine("My name is :" + sname);
        }
        public void DisplayName(string sname, int sno)
        {
            Console.WriteLine("My name is" + sname + "My rollno is:" + sno);
            
        }

        public virtual void Method1(int sno)
        {
            Console.WriteLine(" i am method1 from parent class");
        }


    }

    public class clsChild: clsParent
    {
        public override void Method1(int sno)
        {
            Console.WriteLine(" i am method1 from child class");
        }

    }
}
