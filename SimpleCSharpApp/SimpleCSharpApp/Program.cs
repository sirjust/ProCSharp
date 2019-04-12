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
            // process incoming arguments with for loop
            for(int i=0; i < args.Length; i++)
            {
                Console.WriteLine("Arg with for loop: {0}", args[i]);
            }
            // process incoming arguments with foreach loop
            foreach(string arg in args)
            {
                Console.WriteLine("Arg with foreach loop: {0}", arg);
            }

            // get arguments using System.Environment
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
                Console.WriteLine("Arg from Environment: {0}", arg);

            // Helper method within the Program class
            ShowEnvironmentDetails();

            Console.ReadLine();
            return -1;
        }

        static void ShowEnvironmentDetails()
        {
            // Print out the drives on this machine
            // and other interesting details
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}", Environment.Version);
        }
    }
}
