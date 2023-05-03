using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    internal abstract class GeometricPrism : IHasArea
    {
        public double Height { get; }
        public double Width { get; }
        public double Length { get; }
    
        public GeometricPrism(double height, 
            double width, 
            double length)
        {
            Height = height;
            Width = width;
            Length = length;
        }

        public abstract double GetVolume();
        public abstract double GetArea();
    }
}
