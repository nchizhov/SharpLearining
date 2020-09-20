using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    struct Point
    {
        public int X;
        public int Y;

        public Point(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }

        public void Increment()
        {
            X++; Y++;
        }

        public void Decrement()
        {
            X--; Y--;
        }

        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }

    class PointRef
    {
        public int X;
        public int Y;

        public PointRef(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }

        public void Increment()
        {
            X++; Y++;
        }

        public void Decrement()
        {
            X--; Y--;
        }

        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }

    class ShapeInfo
    {
        public string InfoString;

        public ShapeInfo(string info)
        {
            InfoString = info;
        }
    }

    struct Rectange
    {
        public ShapeInfo RectInfo;
        public int RectTop, RectLeft, RectBottom, RectRight;
        public Rectange(string info, int top, int left, int bottom, int right)
        {
            RectInfo = new ShapeInfo(info);
            RectTop = top; RectBottom = bottom;
            RectLeft = left; RectRight = right;
        }
        public void Display()
        {
            Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, Left = {3}, Right = {4}", RectInfo.InfoString, RectTop, RectBottom, RectLeft, RectRight);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ValueTypeAssignment();
            ReferenceTypeAssignment();
            ValueTypeContainingRefType();
            Console.ReadLine();
        }

        static void ValueTypeAssignment()
        {
            Console.WriteLine("Assigning value types");
            Point p1 = new Point(10, 10);
            Point p2 = p1;

            p1.Display();
            p2.Display();
            p1.X = 100;
            Console.WriteLine("=> Changed p1.X");
            p1.Display();
            p2.Display();
        }

        static void ReferenceTypeAssignment()
        {
            Console.WriteLine("Assigning reference types");
            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;

            p1.Display();
            p2.Display();
            p1.X = 100;
            Console.WriteLine("=> Changed p1.X");
            p1.Display();
            p2.Display();
        }

        static void ValueTypeContainingRefType()
        {
            Console.WriteLine("-> Creating r1");
            Rectange r1 = new Rectange("First Rect", 10, 10, 50, 50);
            Console.WriteLine("-> Assigning r2 to r1");
            Rectange r2 = r1;
            Console.WriteLine("-> Changing values of r2");
            r2.RectInfo.InfoString = "This is New Info!";
            r2.RectBottom = 4444;
            r1.Display();
            r2.Display();
        }
    }
}
