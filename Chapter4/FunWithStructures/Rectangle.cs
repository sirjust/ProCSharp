using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    public struct Rectangle
    {
        // The Rectangle structure contains a reference type member
        public ShapeInfo RectInfo;

        public int RectTop, RectLeft, RectBottom, RectRight;

        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            RectInfo = new ShapeInfo(info);
            RectTop = top; RectBottom = bottom; RectLeft = left; RectRight = right;
        }

        public void Display()
        {
            Console.WriteLine($"String = {RectInfo.InfoString}, Top = {RectTop}, Bottom = {RectBottom}, Left = {RectLeft}, Right = {RectRight}");
        }
    }
}
