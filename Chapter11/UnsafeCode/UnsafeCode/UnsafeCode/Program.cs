using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafeCode
{
    struct Point
    {
        public int x;
        public int y;
        public override string ToString() => $"({x}, {y})";
    }
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int myInt = 10;
                SquarePointer(&myInt);
                Console.WriteLine("myInt: {0}", myInt);
            }
            PrintValueAndAddress();
            Console.WriteLine();
            Console.WriteLine("***** Calling method with unsafe code *****");
            int i = 10, j = 20;
            Console.WriteLine("***** Safe Swap *****");
            Console.WriteLine("Values before safe swap: i = {0}, j = {1}", i, j);
            SafeSwap(ref i, ref j);
            Console.WriteLine("Values after safe swap: i = {0}, j = {1}", i, j);
            Console.WriteLine("***** Unsafe Swap *****");
            Console.WriteLine("Values before unsafe swap: i = {0}, j = {1}", i, j);
            unsafe
            {
                UnsafeSwap(&i, &j);
            }
            Console.WriteLine("Values after safe swap: i = {0}, j = {1}", i, j);
            Console.WriteLine();
            UsePointerToPoint();
            Console.WriteLine();
            UnsafeStackAlloc();
            Console.WriteLine();
            UseAndPinPoint();
            Console.WriteLine();
            UseSizeOfOperator();
            Console.ReadLine();
        }
        static unsafe void SquarePointer(int* myIntPointer)
        {
            *myIntPointer *= *myIntPointer;
        }
        static unsafe void PrintValueAndAddress()
        {
            int myInt;
            int* ptrToMyInt = &myInt;
            *ptrToMyInt = 123;
            Console.WriteLine("Value of myInt {0}", myInt);
            Console.WriteLine("Address of myInt {0:X}", (int)&ptrToMyInt);
        }
        public unsafe static void UnsafeSwap(int* i, int* j)
        {
            int temp = *i;
            *i = *j;
            *j = temp;
        }
        public static void SafeSwap(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
        static unsafe void UsePointerToPoint()
        {
            Point point;
            Point* p = &point;
            p->x = 100;
            p->y = 200;
            Console.WriteLine(p->ToString());
            Point point2;
            Point* p2 = &point2;
            (*p2).x = 100;
            (*p2).y = 200;
            Console.WriteLine((*p2).ToString());
        }
        static unsafe void UnsafeStackAlloc()
        {
            char* p = stackalloc char[256];
            for (int k = 0; k < 256; k++)
                p[k] = (char)k;
        }
        public unsafe static void UseAndPinPoint()
        {
            PointRef pt = new PointRef
            {
                x = 5,
                y = 6
            };
            fixed (int* p = &pt.x)
            {
                // Use x
            }
            Console.WriteLine("Point is: {0}", pt);
        }
        static unsafe void UseSizeOfOperator()
        {
            Console.WriteLine("The size of short is {0}", sizeof(short));
            Console.WriteLine("The size of int is {0}", sizeof(int));
            Console.WriteLine("The size of long is {0}", sizeof(long));
            Console.WriteLine("The size of Point is {0}", sizeof(Point));
        }
    }
}
