using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    internal abstract class GeometricPrism : IGeometricVolume, IGeometricArea
    {
        public double Width { get; }
        public double Length { get; }
        public double Height { get; }

        protected GeometricPrism(
            double width, 
            double length, 
            double height)
        {
            Width = width;
            Length = length;
            Height = height;
        }

        public abstract double GetVolume();

        public abstract double GetArea();
    }
}
