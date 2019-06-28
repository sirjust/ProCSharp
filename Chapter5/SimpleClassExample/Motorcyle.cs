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
            Console.WriteLine("Yeeeeeee Haaaaaeewww!");
        }

        // put back the default constructor, which will set all data members to default values
        public Motorcyle() { }

        // our custom constructor
        public Motorcyle(int intensity)
            : this(intensity, "") { }
        public Motorcyle(string name)
            : this(0, name) { }

        // this is the master constructor that does all the real work
        public Motorcyle(int intensity, string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
    }
}
