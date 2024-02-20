namespace EventHandling
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car mycar = new Car("volvo", 4); //normal car
            E ecar = new E("tesla", 4); //electric car
            if (ecar is E)
            {
                System.Console.WriteLine("our car is a: " + ecar.name);

            }
            else
            {
                System.Console.WriteLine("our car is a: " + mycar.name);
            }
            Console.ReadLine();
        }
    }
}

