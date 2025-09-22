using MongoDB.Driver;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Demo
{
    public class clsLaptop
    {
        string model = "dell inspiron";
        int price = 42000;
        string storage ="512GB";
        string RAM ="16GB";
        string color ="silver";

        public void DisplayName()
        {
            Console.WriteLine("laptop model is:" + model);
        }
        public string GetLaptopStorage()
        {
            return storage;
        }
        public int GetLaptopPrice()
        {
            return price;
        }
        private string[] GetCars()
        {
            string[] carList= new string[3] {"Scoda","BMW","Thar" };
            return carList;
        }
       

        [Test]
        public void LearnMethods()
        {
            clsLaptop L1 = new clsLaptop();
            L1.DisplayName();
            string st = L1.GetLaptopStorage();
            Console.WriteLine(st);
            int pr = L1.GetLaptopPrice();
            Console.WriteLine("price is:" + pr);
            string[] carList = L1.GetCars();
            Console.WriteLine(carList.Length);
            Console.WriteLine(carList[1]);
            Console.WriteLine(GetCarName("5"));
        }
        public string GetCarName(string rank)
        {
            string carName = "";
            switch (rank)
            {
                case "1" :
                carName = "scoda";
                break;
                case "2":
                carName = "Thar";
                break;
                default:
                carName = "BMW";
                break;
        }

            return carName;
        }

}
}

