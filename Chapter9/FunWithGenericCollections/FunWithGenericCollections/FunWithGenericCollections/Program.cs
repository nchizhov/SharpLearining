﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Generic Collections *****");
            UseGenericList();
            UseGenericStack();
            UseGenericQueue();
            UseSortedSet();
            UseDictionary();
            Console.ReadLine();
        }

        static void UseGenericList()
        {
            List<Person> people = new List<Person>()
            {
                new Person{ FirstName = "Homer", LastName = "Simpson", Age = 47},
                new Person{ FirstName = "Marge", LastName = "Simpson", Age = 45},
                new Person{ FirstName = "Lisa", LastName = "Simpson", Age = 9},
                new Person{ FirstName = "Bart", LastName = "Simpson", Age = 8}
            };
            Console.WriteLine("Items in list: {0}", people.Count);
            foreach (Person p in people)
                Console.WriteLine(p);
            Console.WriteLine("->Inserting new person");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine("Items in list: {0}", people.Count);
            Person[] arrayOfPeople = people.ToArray();
            foreach (Person p in arrayOfPeople)
            {
                Console.WriteLine("First Names: {0}", p.FirstName);
            }
        }

        static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            stackOfPeople.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            stackOfPeople.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });
            Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            try
            {
                Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
                Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error! {0}", ex.Message);
            }
        }

        static void GetCoffee(Person p)
        {
            Console.WriteLine("{0} got coffee!", p.FirstName);
        }

        static void UseGenericQueue()
        {
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            peopleQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            peopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });
            Console.WriteLine("{0} is first in line!", peopleQ.Peek().FirstName);
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            try
            {
                GetCoffee(peopleQ.Dequeue());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Error! {0}", e.Message);
            }
        }

        static void UseSortedSet()
        {
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person {FirstName = "Homer", LastName = "Simpson", Age = 47},
                new Person {FirstName = "Marge", LastName = "Simpson", Age = 45},
                new Person {FirstName = "Lisa", LastName = "Simpson", Age = 9},
                new Person {FirstName = "Bart", LastName = "Simpson", Age = 8}
            };
            foreach (Person p in setOfPeople)
                Console.WriteLine(p);
            setOfPeople.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
            setOfPeople.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });
            foreach (Person p in setOfPeople)
                Console.WriteLine(p);
        }

        static void UseDictionary()
        {
            Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
            peopleA.Add("Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            peopleA.Add("Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            peopleA.Add("Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });
            Person homer = peopleA["Homer"];
            Console.WriteLine(homer);
            Dictionary<string, Person> peopleB = new Dictionary<string, Person>()
            {
                {"Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 } },
                {"Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 } },
                {"Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 } }
            };
            Person lisa = peopleB["Lisa"];
            Console.WriteLine(lisa);
        }
    }
}
