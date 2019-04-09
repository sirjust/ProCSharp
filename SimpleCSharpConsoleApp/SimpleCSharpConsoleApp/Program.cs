using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up Console UI (CUI)
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************");
            Console.WriteLine("***** Welcome to My Rocking App *****");
            Console.WriteLine("***********************");
            //Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
            MessageBox.Show("All done!");
        }
    }
}
