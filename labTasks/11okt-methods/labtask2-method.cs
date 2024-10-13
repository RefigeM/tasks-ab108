namespace labtask22222_method
{
    internal class Program
    {
        static void Main() {
            Console.WriteLine("Evvelki formasi:SaLaM NecESeN RefIQE");
           string mainStr= toLowerCase("SaLaM NecESeN RefIQE");
            Console.WriteLine(mainStr);
        }
        static string toLowerCase(string str)
        {
            string mainStr = " ";

            for (int i = 0; i < str.Length; i++) {
                if (str[i] >= 65 && str[i] <= 90)
                {
                    //Console.Write((char)(str[i] + 32));
                    mainStr += (char)(str[i] + 32);
                }
                else {
                    mainStr += str[i];
                    //Console.Write(str[i]);
                }
               
            }
            return mainStr;

        }
    }
}
