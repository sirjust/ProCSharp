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
            Console.WriteLine("*** Fun with Class Types ***\n");

            InstantiateMultipleCars();
            // FirstCar();
            Console.ReadLine();
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
