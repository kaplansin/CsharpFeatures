using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpRef
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
        }
    }
}
