using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        public string carName;
        public int currSpeed;

        public Car()
        {
            carName = "Chuck";
            currSpeed = 10;
        }

        public Car(string cn)
        {
            carName = cn;
        }

        public Car(string cn, int cs)
        {
            carName = cn;
            currSpeed = cs;
        }

        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.", carName, currSpeed);
        }

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}
