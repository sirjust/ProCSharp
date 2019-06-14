using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with nullable data *****\n");

            //DisplayNullableTypes();

            UseNullCoalescingOperator();

            Console.ReadLine();
        }

        private static void UseNullCoalescingOperator()
        {
            DatabaseReader dr = new DatabaseReader();

            // If the value from GetIntFromDatabase() is null, assign lcoal variable to 100
            int? myData = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine($"Value of {nameof(myData)}: {myData}");
        }

        private static void LocalNullableVariables()
        {
            // Define some local nullable variables
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[10];
        }

        private static void DisplayNullableTypes()
        {
            DatabaseReader dr = new DatabaseReader();

            // Get int from "database"
            int? i = dr.GetIntFromDatabase();
            if (i.HasValue)
                Console.WriteLine($"Value of {nameof(i)} is: {i.Value}");
            else
                Console.WriteLine($"Value of '{nameof(i)}' is undefined");
            // Get bool from "database
            bool? b = dr.GetBoolFromDatabase();
            if (b != null)
                Console.WriteLine($"Value of {nameof(b)} is: {b.Value}");
            else
                Console.WriteLine($"Value of '{nameof(b)}' is undefined");
        }
    }
}
