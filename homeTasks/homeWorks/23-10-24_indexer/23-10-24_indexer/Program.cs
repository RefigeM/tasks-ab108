using System;

namespace _23_10_24_indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ListInt myList = new ListInt(4);

            myList[0] = 50;
            myList[1] = 5;
            myList[2] = 5;
            myList[3] = 44;
            myList[4] = 6;
            myList[5] = 39;

            myList.Add(34);

            myList.Add(5, 6, 7);

            Console.WriteLine(myList[4]);

            Console.WriteLine(myList.Pop());
            Console.WriteLine(myList.Sum());
            Console.WriteLine(IndexOf(5));
            Console.WriteLine(myList.IndexOf(20));
            Console.WriteLine(myList.LastIndexOf(5));
            //Console.WriteLine(myList.Insert(9,5));
            var index = myList.IndexOf(9);
            Console.WriteLine(index);

        }
    }
}
