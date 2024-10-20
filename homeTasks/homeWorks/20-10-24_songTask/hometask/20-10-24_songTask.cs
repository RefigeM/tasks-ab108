using System;

namespace hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song("I Look to You", "pop");

            Console.WriteLine($"song. Songname:{Song.SongName},song genre: {Song.Genre}");
            Singer singer = new Singer("whitney", "Houston", 48);
            Console.WriteLine($"singer name:{Singer.SingerName},singer surname: {Singer.SingerSurname}, singer age: {Singer.Age}");
           




            int[] rates = { 1, 2, 3, 4 };

            int[] newRates = AddRating(rates);

            Console.WriteLine("show rates:");
            foreach (int rate in newRates)
            {
                Console.WriteLine(rate);
            }

            float averageRate = GetAverageRating(newRates);
            Console.WriteLine($"Avarage rate: {averageRate}");
            Console.WriteLine(Console.ReadLine()); // konsol penceresi derhal baglanmasin deye yazmisam.
        }

        static int[] AddRating(int[] rates)
        {
            Console.WriteLine("Add new rate;");
            int newRate = Convert.ToInt32(Console.ReadLine());

            int[] newRates = new int[rates.Length + 1];
            for (int i = 0; i < rates.Length; i++)
            {
                newRates[i] = rates[i];
            }

            newRates[newRates.Length - 1] = newRate;

            return newRates; 
        }

        static float GetAverageRating(int[] newRates)
        {
            int sumRate = 0;
            for (int i = 0; i < newRates.Length; i++)
            {
                sumRate += newRates[i];
            }

            return (float)sumRate / newRates.Length;
        }
    }
}
