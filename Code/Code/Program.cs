namespace Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automobile honda = new Automobile(50, "Honda", 2001, 15);
            Automobile mazda = new FinancedAutomobile(100, "Mazda", 2021, 10000000, 6, 60);

            Automobile[] vehicles = { honda, mazda };
            foreach (Automobile vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
                vehicle.Drive(25);
                Console.WriteLine(vehicle);
            }
        }
    }
}