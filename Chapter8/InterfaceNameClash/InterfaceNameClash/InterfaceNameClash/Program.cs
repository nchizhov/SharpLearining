using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interface Name Clashes *****");
            Octagon oct = new Octagon();
            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();
            ((IDrawToPrinter)oct).Draw();
            if (oct is IDrawToMemory dtm)
                dtm.Draw();
            Console.ReadLine();
        }
    }
}
