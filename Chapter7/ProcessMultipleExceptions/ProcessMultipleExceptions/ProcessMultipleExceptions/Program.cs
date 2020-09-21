﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Handling Multiple Exceptions *****");
            Car myCar = new Car("Rusty", 90);
            myCar.Accelerate(2000);
            try
            {
                myCar.Accelerate(10);
            }
            catch (CarIsDeadException e)
            when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
            {
                try
                {
                    //FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
                    Console.WriteLine(e.Message);
                }
                catch (Exception e2)
                {
                    throw new CarIsDeadException(e.Message, e2);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myCar.CrankTunes(false);
            }
            Console.ReadLine();
        }
    }
}
