using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTuples
{
    struct Point
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

        public (int XPos, int YPos) Deconstruct() => (X, Y);
    }
}
