

namespace classes_tasks
{
    class product
    {
        public string Name;
        public string BrandName;
        public double Price;

        public product(string name, string brandName, double price)
        {
            Name = name;
            BrandName = brandName;
            Price = price;
            Console.WriteLine($"{name} {brandName} {price}");

        }
        static void productFilter()
        {

        }

    }

}

