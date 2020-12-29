using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DefaultAppDomainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with the default AppDomain *****");
            InitAD();
            DisplayDADStats();
            ListAllAssembliesInAppDomain();
            Console.ReadLine();
        }

        private static void DisplayDADStats()
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;
            Console.WriteLine("Name of this domain: {0}", defaultAD.FriendlyName);
            Console.WriteLine("ID of domain in this process: {0}", defaultAD.Id);
            Console.WriteLine("Is this the default domain?: {0}", defaultAD.IsDefaultAppDomain());
            Console.WriteLine("Base directory of this domain: {0}", defaultAD.BaseDirectory);
        }

        static void ListAllAssembliesInAppDomain()
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;
            var loadedAssemblies = from a in defaultAD.GetAssemblies()
                                   orderby a.GetName().Name
                                   select a;
            Console.WriteLine("***** Here are the assemlies loaded in {0} *****", defaultAD.FriendlyName);
            foreach (var a in loadedAssemblies)
            {
                Console.WriteLine("-> Name: {0}", a.GetName().Name);
                Console.WriteLine("-> Version: {0}", a.GetName().Version);
            }
        }

        private static void InitAD()
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;
            defaultAD.AssemblyLoad += (o, s) =>
            {
                Console.WriteLine("{0} has been loaded", s.LoadedAssembly.GetName().Name);
            };
        }
    }
}
