using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Selenium_Demo
{
    public class clsCollections
    {
        [Test]
        public void VerifySingleDArray()
        {
            int[] arrNumbers = new int[4] {10,20,30,40};
            //int[] arrNumbers = new int[4];
            //arrNumbers[0] = 10;
            //arrNumbers[1] = 20;
            //arrNumbers[2] = 30;
            //arrNumbers[3] = 40;
            //arrNumbers[4] = 50;
            for(int i=0;i<arrNumbers.Length;i++)
            {
                Console.WriteLine(arrNumbers[i]);
            }

            
        }
        [Test]
        public void LearnStringArray()
        {
            string[] states = new string[4] { "Texas", "Florida", "Maryland", "Michigon" };
            for (int i = 1; i < states.Length; i=i+2)
            {
                Console.WriteLine(states[i]);
            }


        }
        [Test]
        public void Verify2DArray()
        {
            //int[] arrNumbers = new int[4] {10,20,30,40};
            int[,] arrNumbers = new int[2, 3]
{
{10,20,30},
{40,60,70}
};

            //int[,] arrNumbers = new int[2,3];
            //arrNumbers[0,0] = 10;
            //arrNumbers[0,1] = 20;
            //arrNumbers[0,2] = 30;
            //arrNumbers[1,0] = 40;
            //arrNumbers[1,1] = 60;
            //arrNumbers[1,2] = 70;
            Console.WriteLine(arrNumbers[1,1]);
            
        }
        [Test]
        public void LearnArrayList()
        {
            ArrayList arlist1 = new ArrayList();

            var arlist2 = new ArrayList()
                            {
                                1, "Bill", " ", true, 4.5, null
                            };

            arlist1.Add("Anand"); //0
            arlist1.Add(10); //1
            arlist1.Add(null);
            arlist1.Add("Anand");
            Console.WriteLine(arlist1.Count);

            arlist1[0] = "Bhavya";
            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            arlist1.AddRange(arlist2); //adding arraylist in arraylist 
            arlist1.AddRange(arr); //adding array in arraylist 
            arlist1.AddRange(myQ); //adding Queue in arraylist 

            Console.WriteLine("ArrayList Elements");

            Console.WriteLine(arlist1.Count);
            //arlist1.Clear();
            
           Console.WriteLine("contains anand " + arlist1.Contains("Anand"));

            for (int i = 0; i < arlist1.Count; i++)
                Console.WriteLine(arlist1[i]);

        }
        [Test]
        public void LearnList()
        {

            // adding elements using add() method
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            
            Console.WriteLine("No of elelemts: " + primeNumbers.Count);
            
            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null); // null is allowed

            Console.WriteLine("No of elelemts: " + cities.Count);

            // adding elements using collection initializer syntax
            var bigCities = new List<string>() { "New York", "London", "Mumbai", "Chicago" };
            bigCities.Add("Dallas");
            Console.WriteLine("No of big cities: " + bigCities.Count);

        }
        [Test]
        public void LearnDictionary()
        {
            IDictionary<int, string> States = new Dictionary<int, string>();

            States.Add(1, "NY");
            States.Add(2, "NJ");
            States.Add(3, "MD");
            States.Add(4, "NY");
            States.Add(5, "WA");

            foreach (KeyValuePair<int, string> kvp in States)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

        }

    }
}
