using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Demo
{
    public interface InfStud
    {
        
        void getStudBySno();
        void getStudBySname();
        void getAllStudDetails();
            public void GetCollegename()
            {
                Console.WriteLine("VRSEC");
            }

    }

    public class clsChild1: InfStud
    {
        public void getStudBySno()
        {

        }
        public void getStudBySname()
        {

        }
        public void getAllStudDetails()
        {

        }
    }
}
