using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    internal class Cuboid : GeometricPrism
    {
        public Cuboid(double width, double length, double height)
            : base(width, length, height) { }

        public override double GetVolume()
        {
            return Height * Width * Length;
        }

        public override double GetArea()
        {
            return (Height * Width + Width * Length * Length * Height) * 2;
        }
    }
}
