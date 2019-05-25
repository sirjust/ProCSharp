using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnums
{
    enum EmployeeType : byte
    {
        Manager = 102,
        Grunt,
        Contractor,
        VicePresident
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Enums ***");
            // Make an EmployeeType variable.
            EmployeeType emp = EmployeeType.Contractor;
            AskForBonus(emp);
            Console.ReadLine();
        }

        private static void AskForBonus(EmployeeType emp)
        {
            switch (emp)
            {
                case EmployeeType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmployeeType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmployeeType.Contractor:
                    Console.WriteLine("You already have enough cash...");
                    break;
                case EmployeeType.VicePresident:
                    Console.WriteLine("Very good, sir!");
                    break;
            }
        }
    }
}
