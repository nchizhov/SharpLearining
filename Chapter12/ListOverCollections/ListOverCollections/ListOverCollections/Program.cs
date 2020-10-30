using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOverCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ over Generic Collections *****");
            List<Car> myCars = new List<Car>()
            {
                new Car{PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
                new Car{PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
                new Car{PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
                new Car{PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
                new Car{PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
            };
            GetFastCars(myCars);
            Console.WriteLine();
            GetFastBMWs(myCars);
            Console.WriteLine();
            LINQOverArrayList();
            Console.WriteLine();
            OfTypeAsFilter();
            Console.ReadLine();
        }
        static void GetFastCars(List<Car> myCars)
        {
            var fastCars = from c in myCars
                           where c.Speed > 55
                           select c;
            foreach (var car in fastCars)
            {
                Console.WriteLine("{0} is going too fast!", car.PetName);
            }
        }
        static void GetFastBMWs(List<Car> myCars)
        {
            var fastCars = from c in myCars
                           where c.Speed > 90 && c.Make == "BMW"
                           select c;
            foreach (var car in fastCars)
            {
                Console.WriteLine("{0} is going too fast!", car.PetName);
            }
        }
        static void LINQOverArrayList()
        {
            Console.WriteLine("***** LINQ over ArrayList *****");
            ArrayList myCars = new ArrayList()
            {
                new Car{PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
                new Car{PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
                new Car{PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
                new Car{PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
                new Car{PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
            };
            var myCarsEnum = myCars.OfType<Car>();
            var fastCars = from c in myCarsEnum
                           where c.Speed > 55
                           select c;
            foreach (var car in fastCars)
            {
                Console.WriteLine("{0} is going too fast!", car.PetName);
            }
        }
        static void OfTypeAsFilter()
        {
            ArrayList myStaff = new ArrayList();
            myStaff.AddRange(new object[] { 10, 400, 8, false, new Car(), "string data" });
            var myInts = myStaff.OfType<int>();
            foreach (int i in myInts)
            {
                Console.WriteLine("Int value: {0}", i);
            }
        }
    }
}
