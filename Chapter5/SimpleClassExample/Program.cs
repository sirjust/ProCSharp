using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("*** Fun with Class Types ***\n");
            MakeAccounts();
            // MakeSomeBikes();
            // InstantiateMotorcycles();
            // InstantiateMultipleCars();
            // FirstCar();
            Console.ReadLine();
        }

        private static void MakeAccounts()
        {
            Console.WriteLine("*** Fun with Static Data ***\n");
            SavingsAccount s1 = new SavingsAccount(50);
            SavingsAccount s2 = new SavingsAccount(100);

            // Print the current interest rate
            Console.WriteLine($"Interest rate is {SavingsAccount.GetInterestRate()}");

            SavingsAccount.SetInterestRate(0.08);

            // Make new object, doesn't reset the interest rate
            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine($"Interest Rate is {SavingsAccount.GetInterestRate()}");
        }

        private static void MakeSomeBikes()
        {
            // driverName = "", driverIntensity = 0
            Motorcyle m1 = new Motorcyle();
            Console.WriteLine($"Name: {m1.driverName}, Intensity: {m1.driverIntensity}");

            // driverName = "Tiny", driverIntensity = 0
            Motorcyle m2 = new Motorcyle(name:"Tiny");
            Console.WriteLine($"Name: {m2.driverName}, Intensity: {m2.driverIntensity}");

            // driverName = "", driverIntensity = 7
            Motorcyle m3 = new Motorcyle(7);
            Console.WriteLine($"Name: {m3.driverName}, Intensity: {m3.driverIntensity}");
        }

        private static void InstantiateMotorcycles()
        {
            // This has the same behavior using a constructor with optional arguments as with constructor chaining, minus the WriteLines

            // Make a motorcycle
            Motorcyle c = new Motorcyle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine($"Rider name is {c.driverName}");
        }

        private static void InstantiateMultipleCars()
        {
            Car chuck = new Car();
            chuck.PrintState();

            Car mary = new Car("Mary");
            mary.PrintState();

            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();
        }

        private static void FirstCar()
        {
            // allocate and configure a Car object
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            // speed up the car a few times and print the new state
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
        }
    }
}
