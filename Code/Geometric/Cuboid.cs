using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    internal class Cuboid : GeometricPrism
    {
        public Cuboid(double height, 
            double width, 
            double length) 
            : base(height, width, length)
        {
        }

        public override double GetArea()
        {
            return (Width * Length + Width * Height + Height * Length) / 2;
        }

        public override double GetVolume()
        {
            return Width * Length * Height;
        }
    }
}
