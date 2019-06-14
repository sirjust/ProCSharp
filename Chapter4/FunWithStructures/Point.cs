using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    public struct Point
    {
        // Fields of the structure
        public int X;
        public int Y;

        // A custom constructor
        public Point(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }

        // Add 1 to the (X, Y) position
        public void Increment()
        {
            X++; Y++;
        }

        // Subtract 1 from the (X, Y) position
        public void Decrement()
        {
            X--; Y--;
        }

        // Display the current position
        public void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }
    }
}
