using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Demo
{
    public class DecBatch
    {
       private string studname = "Priyanka";
       public string city = "Hyderabad";
        public static string cname = "CBIT";

        public virtual void DisplayName()
        {
            Console.WriteLine("Stud name is Priyanka");
           
        }

        public static string GetCity()
        {
            return "Hyderabad";
        }

    }
    public class clsSelenium: DecBatch
    {
        public string sname = "Sravani";
        public string city = "Beeramguda";

        public override void DisplayName()
        {
            Console.WriteLine("Stud name is Chandana");
        }
        public void DisplayStudName()
        {
            Console.WriteLine("Stud name is Sravani");
        }

        public void DisplayStudName(string sname)
        {
            Console.WriteLine("Stud name is :" + sname);
        }
    }
}
