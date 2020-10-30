using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUsingEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryStringsWithOperators();
            Console.WriteLine();
            QueryStringsWithEnumerableAndLambdas();
            Console.WriteLine();
            QueryStringsWithAnonymousMethods();
            Console.WriteLine();
            VeryComplexQueryExpression.QueryStringsWithRawDelegates();
            Console.ReadLine();
        }
        static void QueryStringsWithOperators()
        {
            Console.WriteLine("***** Using Query Operators *****");
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
            var subset = from game in currentVideoGames
                         where game.Contains(" ")
                         orderby game
                         select game;
            foreach (string s in subset)
                Console.WriteLine("Item: {0}", s);
        }
        static void QueryStringsWithEnumerableAndLambdas()
        {
            Console.WriteLine("***** Using Enumerable / Lambda Expressions *****");
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
            var subset = currentVideoGames.Where(game => game.Contains(" "))
                .OrderBy(game => game)
                .Select(game => game);
            foreach (var game in subset)
                Console.WriteLine("Item: {0}", game);
        }
        static void QueryStringsWithAnonymousMethods()
        {
            Console.WriteLine("***** Using Anonymous Methods *****");
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
            Func<string, bool> searchFilter =
                delegate (string game) { return game.Contains(" "); };
            Func<string, string> itemToProcess =
                delegate (string s) { return s; };
            var subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);
            foreach (var game in subset)
                Console.WriteLine("Item: {0}", game);
        }
    }
}
