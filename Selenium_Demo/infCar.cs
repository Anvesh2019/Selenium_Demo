using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Demo
{
    public interface infCar
    {
        void Accelerate();
        //public string DisplayMyAddress();
     // public string GetCarname();
       
    }
    public interface infPlane
    {
        void GetPlaneInfo();

    }

    public class childInf: infCar,infPlane
    {
        public void Accelerate()
        {
            Console.WriteLine(" I am accelerate method");
        }
        public void GetPlaneInfo()
        {

        }
    }
}
