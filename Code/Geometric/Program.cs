namespace Geometric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometricPrism cuboid = new Cuboid(3, 4, 5);
            GeometricPrism triangularPrism = new TriangularPrism(
                Math.Pow(3, 3/2), Math.Pow(4, 3 / 2), Math.Pow(4, 3 / 2));
            IHasArea rectangle = new Rectangle(3, 4);
            IHasArea triangle = new Triangle(3, 4);

            IHasArea[] shapes = { cuboid, triangularPrism, rectangle, triangle };

            foreach (IHasArea shape in shapes)
            {
                Console.WriteLine("Shape {0} has area {1}",
                    shape.GetType(), shape.GetArea());
                if (shape is GeometricPrism)
                {
                    GeometricPrism shapeAsPrism = (GeometricPrism)shape;
                    if (shapeAsPrism is Cuboid)
                    {
                        Console.WriteLine("\tand it is a cuboid");
                    }
                    
                    Console.WriteLine("\tand it also has a volume of {0}",
                        shapeAsPrism.GetVolume());
                }
            }
        }
    }
}