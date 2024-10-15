using classTask_1;

namespace class_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product cay = new Product("Berqa", "Earl tea", 9.3d);
            Product sud = new Product("Azer sud", "Tetra Pak", 1.89d);
            Product salfet = new Product("Sun Salfet", "Maxi", 0.95d);
            Product yogurt = new Product("Milla yogurt", "Milla", 0.45d);
            Product makoron = new Product("Ankara makoron", "YUksuk", 3.6d);

            Product[] allProducts = { cay, sud, salfet, yogurt, makoron };

            productFilter(allProducts, 1.5, 3.6);
        }
        static void productFilter(Product[] products, double minPrice, double maxPrice)
        {
            foreach (Product product in products)
            {
                if (product.Price <= maxPrice && product.Price >= minPrice)
                {
                    Console.WriteLine($"{product.Name}");
                }
            }
        }
    }
}