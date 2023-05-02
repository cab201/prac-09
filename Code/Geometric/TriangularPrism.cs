using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    internal class TriangularPrism : GeometricPrism
    {
        public TriangularPrism(double width, double length, double height) 
            : base(width, length, height)
        {
        }

        public override double GetVolume()
        {
            return Height * Width * Length / 2;
        }

        public override double GetArea()
        {
            // This is an approximate, because it is too complex
            // for the properties we have
            return (Height * Width / 2 + Width * Length / 2 + Length * Height) * 2;
        }
    }
}
