using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            // MakeABunchOfTuples();
            // FillTheseValues();
            //var samples = FillTheseValuesWithTuples();
            //Console.WriteLine($"Int is: {samples.a}");
            //Console.WriteLine($"String is: {samples.b}");
            //Console.WriteLine($"Bool is: {samples.c}");

            Point point = new Point(7,5);
            var pointValues = point.Deconstruct();
            Console.WriteLine($"X is: {pointValues.XPos}");
            Console.WriteLine($"Y is: {pointValues.YPos}");

            Console.ReadLine();
        }
        private static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string";
            c = true;
        }

        private static (int a, string b, bool c) FillTheseValuesWithTuples()
        {
            return (9, "Enjoy your string.", true);
        }
        private static void MakeABunchOfTuples()
        {
            (string, int, string) values = ("a", 5, "c");
            var otherValues = ("a", 5, "c");
            (string FirstLetter, int TheNumber, string SecondLetter) valuesWithNames = ("j", 10, "k");
            var valuesWithNames2 = (FirstLetter: "m", TheNumber: 20, SecondLetter: "n");

            Console.WriteLine($"First item: {values.Item1}");
            Console.WriteLine($"Second item: {values.Item2}");
            Console.WriteLine($"Third item: {values.Item3}");

            Console.WriteLine($"First item in valuesWithNames: {valuesWithNames.FirstLetter}");
            Console.WriteLine($"Second item in valuesWithNames: {valuesWithNames.TheNumber}");
            Console.WriteLine($"Third item in valuesWithNames: {valuesWithNames.SecondLetter}");

            // using the item notation still works
            Console.WriteLine($"First item in valuesWithNames: {valuesWithNames.Item1}");
            Console.WriteLine($"Second item in valuesWithNames: {valuesWithNames.Item2}");
            Console.WriteLine($"Third item in valuesWithNames: {valuesWithNames.Item3}");

            (int, int) example = (Custom1: 5, Custom2: 7);
            (int Field1, int Field2) example2 = (Custom1: 5, Custom2: 7);

            // Inferring Variable Names
            Console.WriteLine("=> Inferred Tuple Names");
            var foo = new { Prop1 = "first", Prop2 = "second" };
            var bar = (foo.Prop1, foo.Prop2);
            Console.WriteLine($"{bar.Prop1};{bar.Prop2}");
        }
    }
}
