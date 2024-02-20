namespace EventHandling
{
    public class Car
    {
        public string name = ""; //fields
        public int gasLevel = 0; //fields
        public Car(string c, int g)
        {
            name = c;
            gasLevel = g;
        }
    }
    public class E : Car
    {
        //sharing fields from Car using constructor
        public E(string c, int g) : base(c, g)
        {
            name = c;
            gasLevel = g;
        }
    }
}