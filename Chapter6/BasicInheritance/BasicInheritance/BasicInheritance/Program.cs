using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Inheritance ******");
            Car myCar = new Car(80);
            myCar.Speed = 50;
            Console.WriteLine("My Car if going {0} MPH", myCar.Speed);

            MiniVan myVan = new MiniVan();
            myVan.Speed = 10;
            Console.WriteLine("My Van is going {0} MPH", myVan.Speed);
            Console.ReadLine();
        }
    }
}
