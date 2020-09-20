using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicityTypedLocalVars
{
    class Program
    {
        static void Main(string[] args)
        {
            DeclareImpliciVars();
            LinqQuesyOverInts();
            Console.ReadLine();
        }

        static void DeclareImpliciVars()
        {
            var myInt = 0;
            var myBool = true;
            var myString = "Time....";

            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
        }

        static void LinqQuesyOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            var subset = from l in numbers where l < 10 select l;
            Console.Write("Values in subset:");
            foreach (var i in subset)
            {
                Console.Write("{0}", i);
            }
            Console.WriteLine();
            Console.WriteLine("subset is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }
    }
}
