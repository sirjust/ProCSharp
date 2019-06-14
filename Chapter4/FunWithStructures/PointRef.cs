using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    public class PointRef
    {
        // Same members as the Point structure...
        public int X;
        public int Y;

        // Be sure to change your constructor name to PointRef
        public PointRef(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }

        public void Increment()
        {
            X++; Y++;
        }

        public void Decrement()
        {
            X--; Y--;
        }

        public void Display()
        {
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
    }
}
