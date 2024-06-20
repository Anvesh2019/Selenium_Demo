using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Demo
{
    public abstract class absStud
    {
        public abstract string getStudName(int sno);
        public string GetStudName(int sno)
        {
            if(sno==20)
            {
                return "Anand";
            }
            else
            {
                return "bhavya";
            }
        }
        
    }
}
