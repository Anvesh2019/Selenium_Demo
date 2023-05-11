using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Demo_Abstract
{
    public abstract class clsAbstractDept
    {
        public void DisplayDeptname()
        {
            Console.WriteLine("I am DisplayDeptname from abstract class");
        }

        public abstract void DisplayDeptAddr();
        public abstract void DisplayWeaterRept();
        public void DisplayDeptAddr(string dname)
        {
            Console.WriteLine("I am DisplayDeptAddr from clsAbstractDept");
        }
      
    }

    public class ClsDeptDetails : clsAbstractDept
    {
        public override void DisplayDeptAddr()
        {
            Console.WriteLine("I am DisplayDeptAddr from ClsDeptDetails");
        }

        public override void DisplayWeaterRept()
        {
            throw new NotImplementedException();
        }
    }
}
