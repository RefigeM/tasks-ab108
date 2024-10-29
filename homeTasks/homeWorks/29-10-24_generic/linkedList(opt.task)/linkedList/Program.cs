namespace linkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myNumbers = new LinkedList<int>();
            myNumbers.AddFirst(6);
            var node = myNumbers.AddFirst(7);
            myNumbers.AddLast(2);
            myNumbers.AddAfter(node, 5);
            myNumbers.AddFirst(1);

            foreach (var item in myNumbers)
            {
                Console.WriteLine(item);
            }


        }
    }
}
