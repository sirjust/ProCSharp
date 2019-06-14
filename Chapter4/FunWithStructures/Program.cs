using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** A First Look at Structures *****\n");

            // Create an initial Point
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();

            // Adjust the X and Y values
            myPoint.Increment();
            myPoint.Display();

            Point p2 = new Point(50, 60);
            p2.Display();
            ReferenceTypeAssignment();
            ValueTypeContainingRefType();

            Console.ReadLine();
        }

        static void ReferenceTypeAssignment()
        {
            Console.WriteLine("Assigning reference types\n");
            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;

            // Print both point refs
            p1.Display();
            p2.Display();

            // Change p1.X and print again
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            // Since p2 tracks the same reference, it's X value also changes
            p2.Display();
        }

        static void ValueTypeContainingRefType()
        {
            // Create the first Rectangle
            Console.WriteLine("=> Creating r1");
            Rectangle r1 = new Rectangle("First Rectangle", 10, 10, 50, 50);

            // Now assign a new Rectangle to r1
            Console.WriteLine("=> Assigning r2 to r1");
            Rectangle r2 = r1;

            // Change some values of r2
            Console.WriteLine("Original values");
            r1.Display();
            r2.Display();
            Console.WriteLine("=> Changing values of r2");
            r2.RectInfo.InfoString = "This is new info!";
            r2.RectBottom = 4444;

            // Print values of both rectangles
            r1.Display();
            r2.Display();
        }
    }
}
