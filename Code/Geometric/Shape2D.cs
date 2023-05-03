using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    internal abstract class Shape2D : IHasArea
    {
        public double Width { get; }
        public double Length { get; }

        public Shape2D(double width, double height)
        {
            Width = width;
            Length = height;
        }

        public abstract double GetArea();
    }
}
