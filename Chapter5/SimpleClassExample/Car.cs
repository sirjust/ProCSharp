using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        // the state of the car
        public string petName;
        public int currSpeed;

        // a custom default constructor
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        //public Car(string pn)
        //{
        //    petName = pn;
        //}

        public Car(string pn) => petName = pn;

        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        // the functionality of the car
        // using the expression-bodied member syntax
        public void PrintState() => Console.WriteLine($"{petName} is going {currSpeed} MPH.");

        public void SpeedUp(int delta) => currSpeed += delta;
    }
}
