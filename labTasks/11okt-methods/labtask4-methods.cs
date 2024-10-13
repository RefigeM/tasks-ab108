namespace labtask4_method
{
    internal class Program
    {
        static void Main()
        {
            string strSentence = "SAlam5 necec&en Refi8q9e?";
            CleanStr(strSentence);
        }
        static void CleanStr(string strSentence)
        {
            string resultStr = " ";
            for (int i = 0; i < strSentence.Length; i++) {
                if (strSentence[i]! >= 65 && strSentence[i]! <= 122 || strSentence[i] == 32)
                {
                    resultStr += strSentence[i];
                }
                

            }
            Console.WriteLine(resultStr);

        }
       
    }
}
