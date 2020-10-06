using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Generic Methods *****");
            int a = 10, b = 90;
            Console.WriteLine("Before swap: {0}, {1}", a, b);
            MyGenericMethods.Swap<int>(ref a, ref b);
            Console.WriteLine("After swap: {0}, {1}", a, b);
            Console.WriteLine();

            string s1 = "Hello", s2 = "There";
            Console.WriteLine("Before swap: {0}, {1}", s1, s2);
            MyGenericMethods.Swap<string>(ref s1, ref s2);
            Console.WriteLine("After swap: {0}, {1}", s1, s2);

            MyGenericMethods.DisplayBaseClass<int>();
            MyGenericMethods.DisplayBaseClass<string>();

            Console.ReadLine();
        }
    }

}
