using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Demo
{
    public abstract class clsCity
    {
        string sname = "Priyanka";
        string city = "Hyderabad";

        public abstract void DisplayName();
        public void Printname()
        {

        }

    }
    public class ChildCity: clsCity
    {
       
        public override void DisplayName()
        {
            Console.WriteLine("City name is: Hyd");
        }
    }
}
