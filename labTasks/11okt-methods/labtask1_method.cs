namespace labtask1_method
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = { 3, 6, 35,7, 33, 76, 4 };
            int number = 6;
            Console.WriteLine(indexOf(arr, number));
        }
        static int  indexOf(int[] arr, int number)
        {
            int result = -1;
            for (int i = 0; i < arr.Length; i++) {
                if (number == arr[i])
                {
                    return i;
                }
            }
            return result;


        }
    }
}
