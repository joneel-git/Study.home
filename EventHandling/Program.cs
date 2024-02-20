namespace EventHandling
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car mycar = new Car("volvo", 4); //normal car
            E ecar = new E("tesla", 4); //electric car
            Bike bike = new Bike("Ninja", 3);

            //to see different output change ecar to mycar;
            if (ecar is E || bike is Bike)
            {
                ecar.Drive();
                Console.WriteLine("True our car is a " + ecar.name);
                Console.WriteLine("");
                bike.PutHelmetOn();
                Console.WriteLine("the Bike is a " + bike.name);
            }
            else
            {
                Console.WriteLine("");
                mycar.Drive();
                Console.WriteLine(" our car is a " + mycar.name);

            }
            mycar.GasSimulation();

            Console.ReadLine();
        }
    }
}

