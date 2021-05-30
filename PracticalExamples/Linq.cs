using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExamples
{
    class Linq
    {
        public static void Start()
        {
            Console.WriteLine("***** LINQ: Simple to WAY Complex *****\n");

            string[] names = { "Tom", "Dick", "Harry" };

            var enumerable = names.Where(n => n.Length >= 4);

            IEnumerable<string> filteredNamesEnumerable = Enumerable.OrderBy(enumerable, (string n) => n.Length);

            foreach (string n in filteredNamesEnumerable)
                Console.WriteLine(n);

            //fluent syntax
            //IEnumerable<string> filteredNames = names.Where(n => n.Length >= 4);
            var filteredNamesFluent = names.Where(n => n.Length >= 4);

            foreach (var item in filteredNamesFluent)
            {
                Console.WriteLine(item);
            }

            //query expression syntax
            IEnumerable<string> filteredNames = from n in names
                                                where n.Length >= 4
                                                orderby n.Length
                                                select n;



            //QueryStringWithOperators();
            //Console.WriteLine();
            //QueryStringsWithEnumerableAndLambdas();
            //Console.WriteLine();
            //QueryStringsWithAnonymousMethods();
            //Console.WriteLine();
            //VeryComplexQueryExpression.QueryStringsWithRawDelegates();
            //Console.ReadLine();
        }

        #region LINQ operators
        public static void QueryStringWithOperators()
        {
            Console.WriteLine("***** Using Query Operators *****");

            string[] currentVideoGames = {"Morrowind", "Uncharted 2",
                "Fallout 3", "Daxter", "System Shock 2"};

            var subset = (from game in currentVideoGames
                                          where game.Contains(" ")
                                          //orderby game descending
                                          select game).Skip(1).Take(1);

            //var subset2 = currentVideoGames.Where(game => game.Contains(" ")).OrderByDescending( a => a)
            //                .Skip(1).Take(1); 

            //foreach (string s in subset2)
            //    Console.WriteLine("Item: {0}", s);

            foreach (string s in subset)
                Console.WriteLine("Item: {0}", s);
        }
        #endregion

        #region LINQ using Enumerable and =>
        static void QueryStringsWithEnumerableAndLambdas()
        {
            Console.WriteLine("***** Using Enumerable / Lambda Expressions *****");

            string[] currentVideoGames = {"Morrowind", "Uncharted 2",
                "Fallout 3", "Daxter", "System Shock 2"};

            // Build a query expression using extension methods
            // granted to the Array via the Enumerable type.
            var subset = currentVideoGames.Where(game => game.Contains(" "))
              .OrderBy(game => game).Select(game => game);

            // Print out the results.
            foreach (var game in subset)
                Console.WriteLine("Item: {0}", game);
            Console.WriteLine();
        }

        static void QueryStringsWithEnumerableAndLambdas2()
        {
            Console.WriteLine("***** Using Enumerable / Lambda Expressions (version 2) *****");

            string[] currentVideoGames = {"Morrowind", "Uncharted 2",
                "Fallout 3", "Daxter", "System Shock 2"};

            // Break it down!
            var gamesWithSpaces = currentVideoGames.Where(game => game.Contains(" "));
            var orderedGames = gamesWithSpaces.OrderBy(game => game);
            var subset = orderedGames.Select(game => game);

            foreach (var game in subset)
                Console.WriteLine("Item: {0}", game);
            Console.WriteLine();
        }

        #endregion

        #region LINQ using anon methods
        static void QueryStringsWithAnonymousMethods()
        {
            Console.WriteLine("***** Using Anonymous Methods *****");

            string[] currentVideoGames = {"Morrowind", "Uncharted 2",
                "Fallout 3", "Daxter", "System Shock 2"};

            // Build the necessary Func<> delegates using anonymous methods.
            Func<string, bool> searchFilter = game => game.Contains(" ");

            Func<string, string> itemToProcess = s => s;

            // Pass the delegates into the methods of Enumerable.
            var subset = currentVideoGames.Where(searchFilter)
              .OrderBy(itemToProcess).Select(itemToProcess);

            // Print out the results.
            foreach (var game in subset)
                Console.WriteLine("Item: {0}", game);
            Console.WriteLine();
        }
        #endregion

    }

    class VeryComplexQueryExpression
    {
        public static void QueryStringsWithRawDelegates()
        {
            Console.WriteLine("***** Using Raw Delegates *****");

            string[] currentVideoGames = {"Morrowind", "Uncharted 2",
                "Fallout 3", "Daxter", "System Shock 2"};

            // Build the necessary Func<> delegates.
            Func<string, bool> searchFilter = new Func<string, bool>(Filter);
            Func<string, string> itemToProcess = new Func<string, string>(ProcessItem);

            // Pass the delegates into the methods of Enumerable.
            var subset = currentVideoGames
                .Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);

            // Print out the results.
            foreach (var game in subset)
                Console.WriteLine("Item: {0}", game);
            Console.WriteLine();
        }

        // Delegate targets.
        public static bool Filter(string game) { return game.Contains(" "); }
        public static string ProcessItem(string game) { return game; }
    }

}
