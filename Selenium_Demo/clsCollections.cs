using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.DevTools.V102.IndexedDB;

namespace Selenium_Demo
{
    public class clsCollections
    {
        [Test]
        public void VerifySingleDArray()
        {
<<<<<<< HEAD
            //int[] arrNumbers = new int[4] {10,20,30,40};
            int[] arrNumbers = new int[4];
            arrNumbers[0] = 10;
            arrNumbers[1] = 20;
            arrNumbers[2] = 30;
            arrNumbers[3] = 40;
            //arrNumbers[4] = 50;
            for (int i=0;i<arrNumbers.Length;i++) //0 1 2 3 
=======
            int[] arrNumbers = new int[4] {10,20,30,40};
            //int[] arrNumbers = new int[4];
            //arrNumbers[0] = 100;
            //arrNumbers[1] = 20;
            //arrNumbers[2] = 30;
            //arrNumbers[3] = 40;
            //arrNumbers[4] = 50;

            //Console.WriteLine(arrNumbers[5]);

            for(int i=0;i<arrNumbers.Length;i++) //0 1 2 3 
>>>>>>> master
            {
                Console.WriteLine(arrNumbers[i]);
            }

            
        }
        [Test]
        public void LearnStringArray()
        {
            string[] states = new string[4] { "Texas", "Florida", "Maryland", "Michigon" };
<<<<<<< HEAD
            for (int i = 0; i < states.Length; i++) // 1 3 
=======
            for (int i = 0; i < states.Length; i=i+1)  
>>>>>>> master
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
            Console.WriteLine(arrNumbers[1,2]);
            
        }
        [Test]
        public void Learn2DStringArray()
        {
            string[,] capitals = new string[5, 2]
            {
             {"TG", "Hyd"},
             {"AP", "Viz"},
             {"MH", "Mumbai"},
             {"KL", "Triv"},
             {"KA", "Blore"},
            };
            Console.WriteLine(capitals[1,0]); //AP
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
            arlist1.Add("Anvesh");
            Console.WriteLine(arlist1.Count);

            arlist1[0] = "Bhavya";
            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            arlist1.AddRange(arlist2); //adding arraylist in arraylist 
            arlist1.AddRange(arr); //adding array in arraylist 
            arlist1.AddRange(myQ); //adding Queue in arraylist 

            Console.WriteLine("ArrayList Elements after clear");
            //arlist1.Clear();
            arlist1.RemoveAt(3);
            Console.WriteLine(arlist1.Count);
            //arlist1.Clear();
            
           Console.WriteLine("contains " + arlist1.Contains("Bhavya"));

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
            var bigCities = new List<string>(){"New York", "London", "Mumbai", "Chicago"};
            bigCities.Add("Dallas");
            //bigCities.Clear();
            bigCities.RemoveAt(1);
            Console.WriteLine("No of big cities: " + bigCities.Count);
            for(int i = 0;i < bigCities.Count;i++)
            {
                Console.WriteLine(bigCities[i]);
            }

        }
        [Test]
        public void LearnDictionary()
        {
            IDictionary<int, string> States = new Dictionary<int, string>();

            States.Add(1, "NY"); //1
            States.Add(2, "NJ"); //2
            States.Add(3, "MD"); //3
            States.Add(4, "NY");
            States.Add(5, "WA");
            States.Remove(2);
            //States.Clear();
            Console.WriteLine(States.Count);
            foreach (KeyValuePair<int, string> kvp in States)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

        }
        [Test]
        public void sortarray()
        {
            int[] nums = new int[5] { 100,200,150,250,500};
            Array.Sort(nums);
            Console.WriteLine("3RD highest is:" + nums[2]); //3rd element

            string[] friends = { "sathish", "rajesh", "sharath" };
            Array.Sort(friends);
            foreach(string s in friends)
            {
                Console.WriteLine(s);
            }
            double[] ints = { 1.1, 2.3,3.4 };
            Array.Sort(ints);
            foreach(double s in ints)
            {
                Console.WriteLine(s);
            }
        }
        [Test]
        public void arraylistforloop()
        {
            string[] strings = { "sahith", "sai", "Tony" };
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }
        }
        [Test]
        public void arraylistforloop2()
        {
            int[,] numbers = { { 1, 2, 3 }, { 3, 4, 5 } };
            {
                Console.WriteLine(numbers[1,2]);
            }
        }
        [Test]
        public void arraylistforloop3()
        {
            int[,] number = { { 1, 2, 3 }, { 3, 4,9 } };
            for(int i=0; i<number.GetLength(0);i++)
            {
                for(int j=0; j<number.GetLength(1);j++)
                {
                    Console.Write(number[i,j]);
                }
            }
        }
        [Test]
        public void studentarraylist()
        {
            ArrayList student = new ArrayList();
             student.Add("anvesh");
             student.Add(8);
            for (int i = 0; i < student.Count; i++)
            {
                Console.WriteLine(student[i]);
            }
;        }
        [Test]
        public void stackarray()
        {
            //LIFO
            Stack <string> car = new Stack<string>();
             
            car.Push("BMW");
            car.Push("Thar");
            car.Push("scoda");
            Console.WriteLine(car.Count);
            car.Pop();
            car.Pop();
            Console.WriteLine(car.Count);
            foreach (string s in car)
            {
                Console.WriteLine(s);
            }

            
        }
        [Test]
        public void LearnQueue()
        {
            Queue<int> roommates = new Queue<int>();
            roommates.Enqueue(22);
            roommates.Enqueue(25);
            Console.WriteLine(roommates.Count);
            roommates.Dequeue();
            roommates.Dequeue();

            foreach (int friends in roommates)
            {
                Console.WriteLine(friends);
            }

        }
        [Test]
        public void list()
        {
            SortedList room= new SortedList();
            room.Add(2, "old room");
            room.Add(1, "new room");
            for(int i = 0;i < room.Count;i++)
            {

                Console.WriteLine("{0} : {1} ", room.GetKey(i),
                 room.GetByIndex(i));

            }
        }
        [Test]
        public void hashtable()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

            Hashtable hs = new Hashtable(dict);
            hs.Add("sahith", 26);
            hs.Add("rio", 26);

            foreach (DictionaryEntry de in hs)
            {
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            }
                

            //Console.WriteLine("My age is: "+age["sahith"]);
        }
        [Test]
        public void dictionary()
        {
            Dictionary<int,string> cities = new Dictionary<int,string>();
            cities.Add(2, "hyderabad");
            cities.Add(3, "mumbai");
            cities.Add(1, "bangalore");
            Console.WriteLine("city name is:" + cities[2]);
        }
        [Test]
        public void dictionary1()
        {
            IDictionary<int,string> name = new Dictionary<int,string>();
            name.Add(1, "sai");
            name.Add(2, "sudheer");
            name.Add(3, "sahith");
            name.Add(4, "shashi");
            name.Add(5, "shashi");
            name.Add(6, "shashi");
            name.Add(5, "sai krishna");
            foreach(KeyValuePair<int,string> pair in name)
            {
                Console.WriteLine("Key: {0},Value :{1}", pair.Key,pair.Value );
            }

            Console.WriteLine("add the line ");


            Console.WriteLine("testing1 added by anand");

        }
        [Test]
        public void DevideNumbers()
        {
            Calculator c1 = new Calculator("maths calc");
            double res=   c1.Divide(20.00, 10.5);
            Console.WriteLine(res);
        }
        
        
    }
}
