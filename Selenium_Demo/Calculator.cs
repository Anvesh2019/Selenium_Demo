using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Demo
{
    public class Calculator
    {
        // Fields (optional)
        private string calculatorName;

        // Constructor
        public Calculator(string name)
        {
            calculatorName = name;
        }

        // Method 1: Add two numbers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method 2: Subtract two numbers
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Method 3: Multiply two numbers
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Method 4: Divide two numbers
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }

        // Method 5: Display calculator name
        public void DisplayName1()
        {
            Console.WriteLine($"Calculator Name: {calculatorName}");
        }
    }
    public class ClsGanesh
    {
        public ClsGanesh()
        {
            Console.WriteLine("i am constructor");
        }
        //public void DisplayName()
        //{
        //    Console.WriteLine("I Am ganesh");
        //}
        public int GetTotalDonationAmount()
        {
            return 79000;
        }
        public string HighestDonor()
        {
            return "Harikrishna";
        }
        public string HighestDonor(int dno)
        {
            string dname = "";
            if(dno==100)
            {
                dname = "Anand";
            }
            else
            {
                dname = "Anvesh";
            }
                return dname;
        }
        public int HighestDonationAmt()
        {
            return 20116;
        }
    }

   

}

