using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Selenium_Demo
{
    public class clsArrays
    {
        [Test]
        public void VerifySingleDArray()
        {
            //int[] arrNumbers = new int[4] {10,20,30,40};
            int[] arrNumbers = new int[4];
            arrNumbers[0] = 10;
            arrNumbers[1] = 20;
            arrNumbers[2] = 30;
            arrNumbers[3] = 40;
            //arrNumbers[4] = 50;
            Console.WriteLine(arrNumbers[1]);
        }

        [Test]
        public void Verify2DArray()
        {
            //int[] arrNumbers = new int[4] {10,20,30,40};
            int[,] arrNumbers = new int[2,3];
            arrNumbers[0,0] = 10;
            arrNumbers[0,1] = 20;
            arrNumbers[0,2] = 30;
            arrNumbers[1,0] = 40;
            arrNumbers[1,1] = 60;
            arrNumbers[1,2] = 70;

            Console.WriteLine(arrNumbers[1,1]);
        }
    }
}
