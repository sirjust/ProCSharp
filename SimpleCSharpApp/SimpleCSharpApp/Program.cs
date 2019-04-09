using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            // Display a smiple message to the user.
            Console.WriteLine("***** First C# App *****");
            Console.WriteLine("Hello world!");
            Console.WriteLine();

            // Wait for Enter key to be pressed before shutting down.
            Console.ReadLine();

            // Return an arbitrary error code
            return -1;
        }
    }
}
