using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Demo
{
    public class clsWeatherInfo
    {
        public int GetWeatherByZipcode(string strZip)
        {
            int temp = 0;
            if (strZip == "523190")
            {
                temp = 20;
            }
            else if (strZip == "532230")
            {
                temp = 30;
            }
            else
            {
                temp = 40;
            }
            return temp;
        }
    }
}
