using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string name;
        public void SetDriverName(string name)
        {
            this.name = name;
        }
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaaewww!");
            }
        }

        public Motorcycle() {
            Console.WriteLine("In default ctor.");
        }
        public Motorcycle(int intensity) : this(intensity, "") {
            Console.WriteLine("In ctor taking an int.");
        }
        public Motorcycle(string name) : this(0, name) {
            Console.WriteLine("In ctor taking an string");
        }

        public Motorcycle(int intensity, string name)
        {
            Console.WriteLine("In master ctor");
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            this.name = name;
        }
    }
}
