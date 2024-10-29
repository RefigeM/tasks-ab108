namespace _29_10_24_generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant elephant = new Elephant(50.4d, true, 190);
            Wolf wolf = new Wolf(100, 0);
            wolf.Hunt(elephant);
        }
    }
}
