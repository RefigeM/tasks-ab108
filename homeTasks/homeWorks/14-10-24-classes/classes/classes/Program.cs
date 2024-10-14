namespace classes_tasks
{
    internal class Program
    {
        static void Main()
        {
            int minPrice = 2;
            int maxPrice = 6;


            product cay = new product("Berqa", "Earl tea", 9.3d);
            product sud = new product("Azer sud", "Tetra Pak", 1.89d);
            product salfet = new product("Sun Salfet", "Maxi", 0.95d);
            product yogurt = new product("Milla yogurt", "Milla", 0.45d);
            product makoron = new product("Ankara makoron", "YUksuk", 3.6d);
            product[] products = [cay, sud, salfet, yogurt, makoron];

            static void productFilter(product[] products, int minPrice, int maxPrice)
            {
                foreach (var product in products)
                {
                    if (product.Price > minPrice && product.Price < maxPrice)
                    {
                        Console.WriteLine(product.Name);
                    }

                }

                {

                }

            }



        }


    }
}
