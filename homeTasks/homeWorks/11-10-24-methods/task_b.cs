//Method yaradırsız əgər methoda bir eded gonderilirse hemin ededin kvadratını, iki eded gonderilirse 1ci ədədi ikinci ədəd qədər qüvvətinə yüksəldirsiz.(Misal: MyMethod(2, 3)-- > 8)
namespace Task_B
{
    internal class Program
    {
        static void Main() 
        {
            int mainResult = powerOfNumber(2,6);
            //int mainResult = powerOfNumber(2);

            Console.WriteLine(mainResult);
        }
        static int powerOfNumber(int a,int b=2)
        {
            int result = 1;
            for (int i = 1; i <= b; i++) {
                result *= a;
            }
            return result;
        }
    }
}
