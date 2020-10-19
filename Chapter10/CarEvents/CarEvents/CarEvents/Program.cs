﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Events *****");
            Car c1 = new Car("SlugBug", 100, 10);
            c1.AboutToBlow += new Car.CarEngineHandler(CarIsAlmostDoomed);
            c1.AboutToBlow += new Car.CarEngineHandler(CarAboutToBlow);
            c1.Exploded += CarExploded;
            Console.WriteLine("**** Speeding up ****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            c1.Exploded -= CarExploded;
            Console.WriteLine("**** Speeding up ****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            Console.ReadLine();
        }

        public static void CarAboutToBlow(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void CarIsAlmostDoomed(string msg)
        {
            Console.WriteLine("=> Critical Message from Car: {0}", msg);
        }
        public static void CarExploded(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
