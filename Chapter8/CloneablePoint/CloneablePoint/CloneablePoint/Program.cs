using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Cloning *****");
            Console.WriteLine("Cloned p1 and stored new Point in p4");
            Point p1 = new Point(50, 50);
            Point p2 = (Point)p1.Clone();
            Console.WriteLine("Before modifications:");
            Console.WriteLine("p1: {0}", p1);
            Console.WriteLine("p2: {0}", p2);
            p2.desc.PetName = "MyNew Point";
            p2.X = 9;
            Console.WriteLine("Changed p2.desc.petName and p2.X");
            Console.WriteLine("p1: {0}", p1);
            Console.WriteLine("p2: {0}", p2);
            Console.ReadLine();
        }
    }
}
