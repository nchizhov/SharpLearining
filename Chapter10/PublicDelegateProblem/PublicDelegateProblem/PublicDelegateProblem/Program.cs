using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicDelegateProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Agh! No Encapsulation! *****");
            Car myCar = new Car();
            myCar.listOfHandlers = new Car.CarEngineHandler(CallWhenExploded);
            myCar.Accelerate(10);
            myCar.listOfHandlers = new Car.CarEngineHandler(CallHereToo);
            myCar.Accelerate(10);
            myCar.listOfHandlers.Invoke("hee, hee, hee...");
            Console.ReadLine();
        }
        static void CallWhenExploded(string msg)
        {
            Console.WriteLine(msg);
        }
        static void CallHereToo(string msg)
        {
            Console.WriteLine(msg); ;
        }
    }
}
