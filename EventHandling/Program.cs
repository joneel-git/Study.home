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
    //sharing fields from Car using constructor
    public E(string c, int g) : base(c, g)
    {
        name = c;
        gasLevel = g;
    }
}