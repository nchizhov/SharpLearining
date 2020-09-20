using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Automatic Properties *****");
            Car c = new Car();
            c.CarName = "Frank";
            c.Speed = 55;
            c.Color = "Red";
            Console.WriteLine("Your car name: {0}", c.CarName);
            c.DisplayStats();

            Garage g = new Garage();
            g.MyAuto = c;
            Console.WriteLine("Number of Cars: {0}", g.NumberOfCars);
            Console.WriteLine("Your garage car name: {0}", g.MyAuto.CarName);
            Console.ReadLine();
        }
    }
}
