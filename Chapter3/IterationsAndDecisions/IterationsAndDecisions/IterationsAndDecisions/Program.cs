using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoopExample();
            ForEachLoopExample();
            //WhileLoopExample();
            //DoWhileLoopExample();
            IfElseExample();
            ExecuteIfElseUsingConditionalOperator();
            //SwitchExample();
            //SwitchOnEnumExample();
            //SwitchWithGoto();
            //ExecutePatternMatchingSwitch();
            ExecutePatternMatchingSwitchWithThen();
            Console.ReadLine();
        }

        static void ForLoopExample()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is: {0}", i);
            }
        }

        static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
            {
                Console.WriteLine(c);
            }
            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
        }

        static void WhileLoopExample()
        {
            string userIsDone = "";
            while (userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("In while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
        }

        static void DoWhileLoopExample()
        {
            string userIsDone = "";
            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes");
        }

        static void IfElseExample()
        {
            string stringData = "My yextual data";
            if (stringData.Length > 0)
            {
                Console.WriteLine("string is greater that 0 characters");
            } 
            else
            {
                Console.WriteLine("string is not greater that 0 characters");
            }
        }

        static void ExecuteIfElseUsingConditionalOperator()
        {
            string stringData = "My yextual data";
            Console.WriteLine(stringData.Length > 0 ? "string is greater than 0 characters" : "string is not greater than 0 characters");
        }

        static void SwitchExample()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.Write("Please pick your language preference: ");
            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);
            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case 2:
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                default:
                    Console.WriteLine("Well... good luck with that!");
                    break;
            }
        }

        static void SwitchOnEnumExample()
        {
            Console.Write("Enter your favorite day of the week: ");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad Input!");
                return;
            }
            switch (favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Football!!!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dollar!");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it is not Monday.");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday...");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules...");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed.");
                    break;
            }
        }

        public static void SwitchWithGoto()
        {
            var foo = 5;
            switch (foo)
            {
                case 1:
                    goto case 2;
                case 2:
                    break;
                case 3:
                    goto default;
                default:
                    break;
            }
        }

        static void ExecutePatternMatchingSwitch()
        {
            Console.WriteLine("1 [Integer (5)], 2 [String(\"Hi\")], 3 [Decimal (2.5)]");
            Console.Write("Please choose an option: ");
            string userChoice = Console.ReadLine();
            object choice;
            switch (userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = 2.5;
                    break;
                default:
                    choice = 5;
                    break;
            }

            switch (choice)
            {
                case int i:
                    Console.WriteLine("Your choice is an integer.");
                    break;
                case string s:
                    Console.WriteLine("Your choice is a string.");
                    break;
                case decimal d:
                    Console.WriteLine("Your choice is a decimal.");
                    break;
                default:
                    Console.WriteLine("Your choice is something else");
                    break;
            }
        }

        static void ExecutePatternMatchingSwitchWithThen()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.Write("Please pick your language preference: ");
            object langChoice = Console.ReadLine();
            var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;

            switch (choice)
            {
                case int i when i == 2:
                case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("VB: OOP, multithreading and more!");
                    break;
                case int i when i == 1:
                case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("Good choice, C# is a fine language");
                    break;
                default:
                    Console.WriteLine("Well... Good luck");
                    break;
            }
        }
    }
}
