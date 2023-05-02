namespace Geometric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometricPrism cuboid = new Cuboid(2.5, 2.5, 2.5);
            GeometricPrism triangularPrism = new TriangularPrism(3, 4, 5);
            Square square = new Square(2, 3);

            IGeometricArea[] geometricShapes = { cuboid, triangularPrism, square };

            foreach (IGeometricArea shape in geometricShapes)
            {
                if (shape is Square)
                {
                    Square sq = (Square)shape;
                    Console.WriteLine("{0}: {1}x{2} and has an area of {3}",
                        sq.GetType(), sq.Length,
                        sq.Width, sq.GetArea());
                }
                else if (shape is GeometricPrism)
                {
                    GeometricPrism prism = (GeometricPrism) shape;
                    Console.WriteLine("{0}: {1}x{2}x{3}, has a volume of {4}, has an area of {5}",
                        prism.GetType(), prism.Length,
                        prism.Width, prism.Height, prism.GetVolume(), prism.GetArea());
                }
            }
        }
    }
}