using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CustomAppDomains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom AppDomains *****");
            AppDomain defaultAD = AppDomain.CurrentDomain;
            defaultAD.ProcessExit += (o, s) =>
            {
                Console.WriteLine("Default AD unloaded");
            };
            ListAllAssembliesInAppDomain(defaultAD);
            MakeNewAppDomain();
            Console.ReadLine();
        }

        private static void MakeNewAppDomain()
        {
            AppDomain newAD = AppDomain.CreateDomain("SecondAppDomain");
            newAD.DomainUnload += (o, s) =>
            {
                Console.WriteLine("The second AppDomain has been unloaded");
            };
            try
            {
                newAD.Load("CarLibrary");
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            ListAllAssembliesInAppDomain(newAD);
            AppDomain.Unload(newAD);
        }

        static void ListAllAssembliesInAppDomain(AppDomain ad)
        {
            var loadedAssemblies = from a in ad.GetAssemblies()
                                   orderby a.GetName().Name
                                   select a;
            Console.WriteLine("***** Here are the assemblies loaded in {0} *****", ad.FriendlyName);
            foreach (var a in loadedAssemblies)
            {
                Console.WriteLine("-> Name: {0}", a.GetName().Name);
                Console.WriteLine("-> Version: {0}", a.GetName().Version);
            }
        }
    }
}
