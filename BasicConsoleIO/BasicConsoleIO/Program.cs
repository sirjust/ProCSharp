using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****");
            //GetUserData();
            //FormatNumericalData();
            //DisplayMessage();
            //LocalVarDeclarations();
            //DefaultDeclarations();
            //NewingDataTypes();
            //ObjectFunctionality();
            DataTypeFunctionality();
            Console.ReadLine();
        }

        private static void GetUserData()
        {
            // Get name and age
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();

            // change echo color
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            // echo to the console
            Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);

            // restore previous color
            Console.ForegroundColor = prevColor;
        }

        private static void FormatNumericalData()
        {
            var myNumber = 99999;
            Console.WriteLine("The value {0} in various formats:", myNumber);
            Console.WriteLine("c format: {0:c}", myNumber);
            Console.WriteLine("d9 format: {0:d9}", myNumber);
            Console.WriteLine("f3 format: {0:f3}", myNumber);
            Console.WriteLine("n format: {0:n}", myNumber);

            // Notice that upper- or lowercasing for hex determines if letters are upper or lowercase
            Console.WriteLine("E format: {0:E}", myNumber);
            Console.WriteLine("e format: {0:e}", myNumber);
            Console.WriteLine("X format: {0:X}", myNumber);
            Console.WriteLine("x format: {0:x}", myNumber);
        }

        static void DisplayMessage()
        {
            // use string.format() to format a string literal
            string userMessage = string.Format("100000 in hex is {0:x}", 100000);

            // Must reference PresentationFramework.dll to run this line
            // right-click on References in Solution Explorer, add reference and select the library
            System.Windows.MessageBox.Show(userMessage);
        }

        static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");
            int myInt = 0;
            string myString;
            myString = "This is my character's data";

            //Declare 3 bools on a single line
            bool b1 = true, b2 = false, b3 = b1;
            // Use System.Boolean data type to declare a bool
            System.Boolean b4 = false;

            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);
            Console.WriteLine();
        }

        static void DefaultDeclarations()
        {
            Console.WriteLine("=> Default Declarations:");
            int myInt = default;

        }

        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool();
            int i = new int();
            double d = new double();
            DateTime dt = new DateTime();
            Console.WriteLine("{0}, {1}, {2}, {3}", b,i,d,dt);
            Console.WriteLine();
        }

        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality:");

            // A C# int is really a shorthand for System.Int32, which inherits the following members from System.Object
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }

        static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type Functionality:");

            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
            Console.WriteLine();
        }
    }
}
