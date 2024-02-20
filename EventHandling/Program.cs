namespace EventHandling
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car mycar = new Car("volvo", 4); //normal car
            E ecar = new E("tesla", 4); //electric car
            if (mycar is E)
            {
                //true our car is an ECar
                ecar.Drive();
                Console.WriteLine("True our car is a " + ecar.name);

            }
            else
            {
                mycar.Drive();
                Console.WriteLine("False our car is a " + mycar.name);
            }
            Console.ReadLine();
        }
    }
}

