using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Passing Person object by value *****");
            Person fred = new Person("Fred", 12);
            Console.WriteLine("Before by value call, Person is: ");
            fred.Display();
            SendAPersonByValue(fred);
            Console.WriteLine("After by value call, Person is: ");
            fred.Display();

            Console.WriteLine("\n***** Passing Person object by reference *****");
            Person mel = new Person("Mel", 23);
            Console.WriteLine("Before by value call, Person is: ");
            mel.Display();
            SendAPersonByReference(ref mel);
            Console.WriteLine("After by value call, Person is: ");
            mel.Display();
            Console.ReadLine();
        }

        static void SendAPersonByValue(Person p)
        {
            p.personAge = 99;
            p = new Person("Nikki", 99);
        }

        static void SendAPersonByReference(ref Person p)
        {
            p.personAge = 55;
            p = new Person("Nikki", 99);
        }
    }

    class Person
    {
        public string personName;
        public int personAge;

        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }

        public Person() { }

        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
        }
    }
}
