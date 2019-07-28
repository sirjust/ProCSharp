using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcyle
    {
        public int driverIntensity;
        public string driverName;

        public void SetDriverName(string name)
        {
            driverName = name;
        }
        public void PopAWheely()
        {
            for(int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww!");
            }
        }

        public Motorcyle(int intensity = 0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }

        // The following lines are an example of constructor chaining

        //// put back the default constructor, which will set all data members to default values
        //public Motorcyle()
        //{
        //    Console.WriteLine("In default ctor");
        //}

        //// our custom constructor
        //public Motorcyle(int intensity)
        //    : this(intensity, "")
        //{
        //    Console.WriteLine("In ctor taking an int");
        //}
        //public Motorcyle(string name)
        //    : this(0, name)
        //{
        //    Console.WriteLine("In ctor taking a string");
        //}

        //// this is the master constructor that does all the real work
        //public Motorcyle(int intensity, string name)
        //{
        //    Console.WriteLine("In master ctor");
        //    if (intensity > 10)
        //    {
        //        intensity = 10;
        //    }
        //    driverIntensity = intensity;
        //    driverName = name;
        //}
    }
}
