using System;
using System.Collections.Generic;
using System.Text;

namespace _06.Problem
{
    class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Bottom
        {
            get
            {
                return Top - Height;
            }
        }
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public bool isInside(Rectangle other)
        {
            return (Left >= other.Left) &&
                    (Right <= other.Right) &&
                    (Top <= other.Top) &&
                    (Bottom <= other.Bottom);

        }
    }
}
