using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Extension Methods *****");
            int myInt = 12345678;
            myInt.DisplayDefiningAssembly();
            System.Data.DataSet d = new System.Data.DataSet();
            d.DisplayDefiningAssembly();
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.DisplayDefiningAssembly();
            Console.WriteLine("Valueof myIny: {0}", myInt);
            Console.WriteLine("Reversed digits of myInt: {0}", myInt.ReverseDigits());
            Console.ReadLine();
        }
    }
}
