namespace labtask3_method
{
    internal class Program
    {
        static void Main() {

            string resultString= toUpperCase("saLaM NecESEn");
            Console.WriteLine(resultString);
        }
        static string toUpperCase(string str)
        {
            string strMain = " ";
            
            for (int i = 0; i < str.Length; i++) {
                if (str[i] >= 97 && str[i] <= 122)
                {
                      strMain += (char)(str[i] - 32);
                }
                else {
                    strMain += str[i];

                }


            }
            return strMain;



        }
    }
}
