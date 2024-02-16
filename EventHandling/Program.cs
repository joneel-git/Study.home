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
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
        }
    }
}

class Car
{
    public string name = ""; //fields
    public int gasLevel = 0; //fields
    public Car(string c, int g)
    {
        name = c;
        gasLevel = g;
    }
}
class E : Car
{
    public E(string c, int g) : base(c, g)
    {
        name = c;
        gasLevel = g;
    }
}