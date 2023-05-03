using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    internal class Rectangle : Shape2D
    {
        public Rectangle(double width, double height) 
            : base(width, height)
        {
        }

        public override double GetArea()
        {
            return Length * Width;
        }
    }
}
