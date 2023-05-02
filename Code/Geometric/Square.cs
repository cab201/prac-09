using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    internal class Square : IGeometricArea, I2D
    {
        public double Length { get; }

        public double Width { get; }

        public Square(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double GetArea()
        {
            return Length * Width;
        }
    }
}
