namespace wehicle_task_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("bmw","bmw m5",2,40,48,2001);
            car.ShowInfo();
            car.Drive(30);
        }
    }
}
