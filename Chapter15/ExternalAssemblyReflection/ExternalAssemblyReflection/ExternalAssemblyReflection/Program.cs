using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ExternalAssemblyReflection
{
    class Program
    {
        static void DisplayTypesInAsm(Assembly asm)
        {
            Console.WriteLine("***** Types in Assembly *****");
            Console.WriteLine("->{0}", asm.FullName);
            Type[] types = asm.GetTypes();
            foreach (Type t in types)
                Console.WriteLine("Type: {0}", t);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***** External Assemply Viewver *****");
            string asmName = "";
            Assembly asm = null;
            do
            {
                Console.WriteLine("Enter an assembly to evaluate");
                Console.Write("or enter Q to quit: ");
                asmName = Console.ReadLine();
                if (asmName.Equals("Q", StringComparison.OrdinalIgnoreCase))
                    break;
                try
                {
                    asm = Assembly.Load(asmName);
                    DisplayTypesInAsm(asm);
                }
                catch
                {
                    Console.WriteLine("Sorry, can't find assembly");
                }
            } while (true);
        }
    }
}
