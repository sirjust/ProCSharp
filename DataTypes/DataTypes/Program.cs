using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine();

            CharFunctionality();
            ParseFromStrings();
            ParseFromStringsWithTryParse();
            UseDatesAndTimes();
            UseBigInteger();
            DigitSeparators();
            BinaryLiterals();
            BasicStringFunctionality();
            StringConcatenation();
            EscapeChars();

            Console.ReadLine();
        }

        static void CharFunctionality()
        {
            Console.WriteLine("=> char type Functionality:");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhitespace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhitespace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }

        static void ParseFromStrings()
        {
            Console.WriteLine("=> Data type parsing:");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("99.884");
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = Char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);
            Console.WriteLine();
        }

        static void ParseFromStringsWithTryParse()
        {
            Console.WriteLine("=> Data type parsing with TryParse:");
            if (bool.TryParse("True", out bool b))
            {
                Console.WriteLine("Value of b: {0}", b);
            }
            if (bool.TryParse("true", out bool b2))
            {
                Console.WriteLine("Value of b2: {0}", b2);
            }
            string value = "Hello";
            if (double.TryParse(value, out double d))
            {
                Console.WriteLine("Value of d: {0}", d);
            }
            else
            {
                Console.WriteLine("Failed to convert the input ({0}) to a double.", value);
            }

            Console.WriteLine();
        }

        static void UseDatesAndTimes()
        {
            Console.WriteLine("=> Dates and Times:");
            // this constructor takes (year, month, day)
            DateTime dt = new DateTime(2015, 10, 17);
            // what day of the month is it?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
            // month is now december
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
            // this constructor takes (hours, minutes, seconds)
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);
            // subtract 15 minutes from the current timespan and print the result
            Console.WriteLine(ts.Subtract(new TimeSpan(0,15,0)));
        }


        static void UseBigInteger()
        {
            Console.WriteLine("=> Use BigInteger");
            BigInteger biggy = BigInteger.Parse("99999999999999999999999999999999999999999");
            Console.WriteLine("Value of {0} is: {1}", nameof(biggy), biggy);
            Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
            Console.WriteLine("Is {0} a power of two?: {1}", nameof(biggy), biggy.IsPowerOfTwo);
            BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("88888888888888888888888888888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}", reallyBig);
            Console.WriteLine();
        }

        static void DigitSeparators()
        {
            Console.WriteLine("=> Use Digit Separators:");
            Console.WriteLine("Integer:");
            Console.WriteLine(123_456);
            Console.WriteLine("Long:");
            Console.WriteLine(123_456_789L);
            Console.WriteLine("Float:");
            Console.WriteLine(123_456.1234F);
            Console.WriteLine("Double:");
            Console.WriteLine(123_456.12);
            Console.WriteLine("Decimal:");
            Console.WriteLine(123_456.12M);
            Console.WriteLine();
        }

        static void BinaryLiterals()
        {
            Console.WriteLine("=> Use Binary Literals:");
            Console.WriteLine("Sixteen: {0}", 0b0001_0000);
            Console.WriteLine("Thirty two: {0}", 0b0010_0000);
            Console.WriteLine("Sixty four: {0}", 0b0100_0000);
            Console.WriteLine();
        }

        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine($"Value of {nameof(firstName)}: {firstName}");
            Console.WriteLine($"firstName has {firstName.Length} characters.");
            Console.WriteLine($"firstName in uppercase: {firstName.ToUpper()}");
            Console.WriteLine($"firstName in lowercase: {firstName.ToLower()}");
            Console.WriteLine($"firstName contains the letter y?: {firstName.Contains("y")}");
            Console.WriteLine($"firstName after replace: {firstName.Replace("dy", "")}");
            Console.WriteLine();

        }

        static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation");
            string s1 = "Programming the ";
            string s2 = "Psychodrill (PTP)";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine();
        }

        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a";
            Console.WriteLine(strWithTabs);

            Console.WriteLine("Everyone love \"Hello World\"\a");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a");

            //Adds a total of 4 blank lines (then beep again)
            Console.WriteLine("All finished.\n\n\n\n\a");
        }

        static void VerbatimStrings()
        {

        }
    }
}
