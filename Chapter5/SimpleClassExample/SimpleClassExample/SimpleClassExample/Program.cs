using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****");
            Car myCar = new Car();
            myCar.carName = "Nikolay";
            myCar.currSpeed = 10;

            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }

            Car chuck = new Car();
            chuck.PrintState();
            Car mary = new Car("Mary");
            mary.PrintState();
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();

            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.name);
            Console.ReadLine();
        }
    }
}
