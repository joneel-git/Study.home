namespace EventHandling
{
    public class Car
    {
        public string name = ""; //fields
        public int gasLevel = 0; //fields
        public Car(string n, int g)
        {
            name = n;
            gasLevel = g;
        }
        public virtual void Drive()
        {
            Console.WriteLine("Motor_Engine goes Vroom.. ");
        }

    }
    public class E : Car
    {
        //sharing fields from Car using constructor
        public E(string n, int g) : base(n, g)
        {
            name = n;
            gasLevel = g;
        }
        public override void Drive()
        {
            Console.WriteLine("Electric_Engine go SssssHhhh  not Vroom.. ");
        }
    }
}