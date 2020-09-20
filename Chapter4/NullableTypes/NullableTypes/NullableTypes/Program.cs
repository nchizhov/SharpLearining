using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Nullable Data *****");
            DatabaseReader dr = new DatabaseReader();
            int? i = dr.GetIntFromDatabase();
            if (i.HasValue)
            {
                Console.WriteLine("Value of 'i' is: {0}", i.Value);
            } else
            {
                Console.WriteLine("Value of 'i' is undefined");
            }
            bool? b = dr.GetBoolFromDatabase();
            if (b != null)
            {
                Console.WriteLine("Value of 'b' is: {0}", b.Value);
            } else
            {
                Console.WriteLine("Value of 'i' is undefined");
            }
            int myData = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine("Value of myData: {0}", myData);
            TesterMethod(null);
            Console.ReadLine();
        }

        static void TesterMethod(string[] args)
        {
            Console.WriteLine($"U send me {args?.Length ?? 0} arguments");
        }
    }

    class DatabaseReader
    {
        public int? numericValue = null;
        public bool? boolValue = true;
        public int? GetIntFromDatabase()
        {
            return numericValue;
        }
        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }
    }
}
