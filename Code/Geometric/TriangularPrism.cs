using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    internal class TriangularPrism : GeometricPrism
    {
        public TriangularPrism(
            double height, 
            double width, 
            double length) 
            : base(height, width, length)
        {
        }

        public override double GetArea()
        {
            return Height * Width + Math.Sqrt(2) * Height * Length + Length * Width;
        }

        public override double GetVolume()
        {
            return Height * Width * Length / 2;
        }
    }
}
