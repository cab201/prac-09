using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    internal interface IHasArea
    {
        double Width { get; }
        double Length { get; }
        double GetArea();
    }
}
