//Method yaradirsiz 2 eded ve 1 operator('+','-','*','/') qebul edir. Qebul etdiyi operatora uygun a v' b ədədləri üzərində hesablama aparib alinan deyeri qaytarır.
namespace task_a
{
    internal class Program
    {
        static void Main() {
            int calculate = calculation(40, 4, '/');
            Console.WriteLine(calculate);
        }
        static int calculation(int a,int b,char c)
        {
            if (c == '+') {
                return a + b;
            }
            else if (c == '-')
            {
                return a - b;
            }
           else if (c == '*')
            {
                return a * b;
            }
             else if (c == '/')
            {
                return a / b;
            }
            
            return 0;
        }

    }
}
