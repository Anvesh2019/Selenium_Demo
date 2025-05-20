using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Demo
{
    public interface infCar
    {
       public void Accelerate();
     // public string GetCarname();
       
    }

    public class childInf: infCar
    {
        public void Accelerate()
        {
            Console.WriteLine(" I am accelerate method");
        }
       
    }
}
