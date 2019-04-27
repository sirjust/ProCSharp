using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            // DeclareImplicitVars();
            // LinqQueryOverInts();
            // DoWhileLoopExample();
            // ConditionalOperator();
            // SwitchOnIntExample();
            // SwitchOnStringExample();
            // SwitchOnEnumExample();
            // PatternMatchingSwitch();
            PatternMatchingSwitchWithWhen();

            Console.ReadLine();
        }

        private static void PatternMatchingSwitchWithWhen()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.Write("Please pick your language preference: ");

            object langChoice = Console.ReadLine();
            var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;

            switch (choice)
            {
                case int i when i == 2:
                case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                case int i when i == 1:
                case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
            }
            Console.WriteLine();
        }

        private static void PatternMatchingSwitch()
        {
            Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
            Console.Write("Please choose an option: ");
            string userChoice = Console.ReadLine();
            object choice;

            // This is a standard constant pattern switch statement to set up the example
            switch (userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = 2.5M;
                    break;
                default:
                    choice = 5;
                    break;
            }
            // This is the new pattern matching switch statement
            switch (choice)
            {
                case int i:
                    Console.WriteLine("Your choice is an integer {0}.", i);
                    break;
                case string s:
                    Console.WriteLine("Your choice is a string {0}.", s);
                    break;
                case decimal d:
                    Console.WriteLine("Your choice is a decimal {0}.", d);
                    break;
                default:
                    Console.WriteLine("Your choice is something else.");
                    break;
            }
            Console.WriteLine();
        }

        private static void SwitchOnEnumExample()
        {
            Console.WriteLine("Enter your favorite day of the week: ");
            DayOfWeek favDay;

            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                return;
            }

            switch (favDay)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dollar.");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it's not Monday.");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day.");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost {0}", DayOfWeek.Friday.ToString());
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules!");
                    break;
                // This demonstrates having multiple case statments producing the same result
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's the weekend!");
                    break;
            }
            Console.WriteLine();
        }

        private static void SwitchOnStringExample()
        {
            Console.WriteLine("C# or VB");
            Console.Write("Please pick your language preference: ");

            string langChoice = Console.ReadLine();

            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
        }

        private static void SwitchOnIntExample()
        {
            // Switch on a numerical value
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
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
        }

        private static void ConditionalOperator()
        {
            string stringData = "My textual data";
            Console.WriteLine(stringData.Length > 0 ? "string is greater than 0 characters" : "string is not greater than 0 characters");
            Console.WriteLine();
        }

        private static void DoWhileLoopExample()
        {
            string userIsDone;
            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes"); // note the semicolon
        }

        private static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            // LINQ Query
            var subset = from i in numbers where i < 10 select i;
            Console.Write("Values in subset: ");
            foreach (var i in subset)
            {
                Console.Write("{0} ", i);
            }
        }

        private static void DeclareImplicitVars()
        {
            // Implicitly typed local vars
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            // Print out the underlying type using reflection
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);

        }
    }
}
