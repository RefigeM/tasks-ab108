
using _22okt_classTask_extensions.Extentions;

namespace _22okt_classTask_extensions
{
    public class Program
    {
        static string text = "123Refiqe";
        static int number = 6;
        static void Main(string[] args)
        {
            //Console.WriteLine(Extensions.IsOdd(6));
            Console.WriteLine(number.IsOdd());

            //Console.WriteLine(Extensions.IsEven(5));
            Console.WriteLine(5.IsEven());

            //Console.WriteLine(Extensions.HasDigit);
            Console.WriteLine(text.HasDigit());
            Console.WriteLine(text.HasDigit2());

            Console.WriteLine(text.CheckPassword());
            Console.WriteLine("sAlaMm".Capitalize());

        }
    }
}
