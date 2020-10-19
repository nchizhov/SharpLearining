using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    public delegate int BinaryOp(int x, int y);
    public class SimpleMath
    {
        public int Add(int x, int y) => x + y;
        public int Subtrack(int x, int y) => x - y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Delegate Example *****");
            SimpleMath m = new SimpleMath();
            BinaryOp b = new BinaryOp(m.Add);
            DisplayDelegateInfo(b);
            Console.WriteLine("10 + 10 is {0}", b(10, 10));
            Console.ReadLine();
        }

        static void DisplayDelegateInfo(Delegate delObj)
        {
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Type Name: {0}", d.Target);
            }
        }
    }
}
