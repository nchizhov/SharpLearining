using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Conversions *****");
            Rectangle r = new Rectangle(15, 4);
            Console.WriteLine(r.ToString());
            r.Draw();
            Console.WriteLine();

            Square s = (Square) r;
            Console.WriteLine(s.ToString());
            s.Draw();
            Console.WriteLine();

            Rectangle rect = new Rectangle(10, 5);
            DrawSquare((Square)rect);
            Console.WriteLine();

            Square sq2 = (Square)90;
            Console.WriteLine("sq2 = {0}", sq2);
            int side = (int)sq2;
            Console.WriteLine("Side Length of sq2 = {0}", side);
            Console.WriteLine();

            Square s3 = new Square { Length = 7 };
            Rectangle rect2 = s3;
            Console.WriteLine("rect2 = {0}", rect2);
            Square s4 = new Square { Length = 3 };
            Rectangle rect3 = (Rectangle)s4;
            Console.WriteLine("rect3 = {0}", rect3);

            Console.ReadLine();
        }

        static void DrawSquare(Square sq)
        {
            Console.WriteLine(sq.ToString());
            sq.Draw();
        }
    }
}
