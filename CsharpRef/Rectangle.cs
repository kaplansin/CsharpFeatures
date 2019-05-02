using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpRef
{
    public class Rectangle : IShape
    {
        public Point Start { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public Rectangle(Point start, int width, int length)
        {
            this.Start = start;
            this.Width = width;
            this.Length = length;
        }
       
    }
}
