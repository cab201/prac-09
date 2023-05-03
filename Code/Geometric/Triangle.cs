using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    internal class Triangle : Shape2D
    {
        public Triangle(double width, double length) 
            : base(width, length)
        {
        }

        public override double GetArea()
        {
            return Width * Length / 2;
        }
    }
}
