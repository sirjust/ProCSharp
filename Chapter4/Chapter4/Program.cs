using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            // DeclareImplicitArrays();
            // ArrayOfObjects();
            // RectMultidimensionalArray();
            // JaggedMultidimensionalArray();
            // PassAndReceiveArrays();
            // SystemArrayFunctionality();

            Console.ReadLine();
        }

        private static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> Working with System.Array.");
            // Initialize items at startup.
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

            // Print out names in declared order.
            Console.WriteLine("=> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            // Reverse them
            Array.Reverse(gothicBands);
            Console.WriteLine("=> The reversed array: ");
            // And print them
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine();

            // Clear out all but the first member.
            Console.WriteLine("=> Cleared out all but one...");
            Array.Clear(gothicBands, 1, 2);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine();
        }

        private static void PassAndReceiveArrays()
        {
            Console.WriteLine("Arrays as params and return values.");
            // Pass array as parameter.
            int[] ages = {20, 22, 23, 0};
            PrintArray(ages);

            // Get array as return value.
            string[] strs = GetStringArray();
            foreach(string s in strs)
            Console.WriteLine(s);

            Console.WriteLine();
        }

        private static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
        }

        private static string[] GetStringArray()
        {
            return new[] { "Hello", "from", "GetStringArray" };
        } 

        private static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("Jagged multidimensional array.");
            // A jagged MD array (ie, an array of arrays).
            // Here we have an array of 5 different arrays.
            int[][] myJagArray = new int[5][];

            // Create the jagged array.
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];

            // Print each row (remember, each element is defaulted to zero)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");
            // a rectangular MD array
            int[,] myMatrix;
            myMatrix = new int[3, 4];

            // Populate (3x4) array
            for(int i = 0; i<3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i, j] = i * j;

            // Print (3x4) array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects.");

            // An array of objects can be anything at all.
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";
            foreach (object obj in myObjects)
            {
                // Print the type and value for each item in the array
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }

        private static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");
            // a is really int[]
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());

            // b is really double[]
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());

            // c is really string[]
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();
        }
    }
}
