using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****");

            Manager chucky = new Manager("Chucky", 50, 92, 100_000, "333-23-2322", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
            Console.WriteLine();
            CastingExamples();
            Console.WriteLine();
            AsHexagon();
            Console.ReadLine();
        }

        static void CastingExamples()
        {
            object fran = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            Hexagon hex;
            try
            {
                hex = (Hexagon)fran;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            GivePromotion((Manager)fran);
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);
        }

        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted!", emp.Name);
            switch(emp)
            {
                case SalesPerson s when s.SalesNumber > 5:
                    Console.WriteLine("{0} made {1} sale(s)!", emp.Name, s.SalesNumber);
                    break;
                case Manager m:
                    Console.WriteLine("{0} had {1} stock options...", emp.Name, m.StockOptions);
                    break;
            }
            Console.WriteLine();
        }

        static void AsHexagon()
        {
            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = false;
            things[2] = new Manager();
            things[3] = "Last thing";

            foreach (object item in things)
            {
                Hexagon h = item as Hexagon;
                if (h == null)
                {
                    Console.WriteLine("Item is not a hexagon");
                }
                else
                {
                    h.Draw();
                }
            }
        }
    }
}
