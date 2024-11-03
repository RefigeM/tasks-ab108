using _3_11_24_fileStream.Models;

namespace _3_11_24_fileStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            FileHelper names = new FileHelper(@"C:\Users\ACER\OneDrive\Masaüstü\3-11-24_fileStream\3-11-24_fileStream\Files\names.json");
            names.Add("refiqe");
            names.Add("ali");
            names.Update(1,"sevil");
            names.Add("gunay");
            names.Add("ferid");
            names.Delete(3);


        }
    }
}
