using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
namespace Selenium_Demo.TestCases
{
    public class Class1
    {
        [Test]
        public void VerifyUniversityDetails()
        {
            clsUniversity objUni = new clsUniversity();
            Console.WriteLine("Univercity Type is:" + objUni.uType);
            objUni.founder = "KCR";
            Console.WriteLine("Univercity founder is:" + objUni.founder);
            objUni.DisplayUnivName();
            Console.WriteLine("Univercity is good:" + objUni.isGood);

            Console.WriteLine(DateTime.Now.Year);

            objUni.DisplayStudName("Anvesh");
        }



    }
}
