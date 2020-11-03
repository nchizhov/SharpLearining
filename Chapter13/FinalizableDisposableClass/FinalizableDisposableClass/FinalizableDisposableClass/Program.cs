using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizableDisposableClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Dispose() / Destructor Combo Platter *****");
            MyResourceWrapper rw = new MyResourceWrapper();
            rw.Dispose();
            MyResourceWrapper rw2 = new MyResourceWrapper();
        }
    }
}
