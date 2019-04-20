using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with type conversions *****");

            // add two shorts and print the result
            short numb1 = 9, numb2 = 10;
            Console.WriteLine("{0} + {1} = {2}", numb1,numb2, Add(numb1, numb2));

            // narrowing can result in data loss
            short numb3 = 30000, numb4 = 30000;
            short answer = (short)Add(numb3, numb4);
            Console.WriteLine("{0} + {1} = {2}", numb3, numb4, answer);
            //NarrowingAttempt();

            ProcessBytesWithException();
            ProcessBytesWithCodeBlock();

            Console.ReadLine();
        }

        private static void ProcessBytesWithException()
        {
            byte b1 = 100;
            byte b2 = 250;

            // now the compiler will add CIL code to throw an exception if overflow/underflow occurs
            try
            {
                byte sum = checked((byte) Add(b1, b2));

                // sum should not hold value of 350. However, we find the value of 94
                Console.WriteLine("sum = {0}", sum);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void ProcessBytesWithCodeBlock()
        {
            byte b1 = 100;
            byte b2 = 250;

            // we can define a checked scope here
            try
            {
                checked
                {
                    byte sum = (byte)Add(b1, b2);
                    Console.WriteLine("sum = {0}", sum);
                }

            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;

            //Explicitly cast the int into a byte (no loss of data).
            myByte = (byte) myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
