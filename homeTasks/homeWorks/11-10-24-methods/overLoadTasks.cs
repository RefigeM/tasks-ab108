namespace overloadTasks
{
    internal class Program
    {
        static void Main()
        {
            area(5);
            area(2,9);
            area(5.5f,2f, 4.2f);
            area(2.2f, 2f,1f, 3.3f);
        }
        static void area(float r,float p=3) 
        {
            Console.WriteLine($"Cevrenin sahesi: {r * r * p}");
        }
        static void area(int a,float b)
        {
            Console.WriteLine($"Duzbucaqlinin sahesi: {a*b}");
        }
        static void area(float a, float b,float c)
        {
            Console.WriteLine($"Düzbucaqlı paralelpipedin sahesi: {2*(a*b+a*c+b*c)}");
        }
        static void area(float a, float b, float c, float r) {
            Console.WriteLine($"Ucbucaqlinin daxiline cekilmis cevrenin radiusu:{(a+b+c)/2*r}");
        }
        
    }
}
