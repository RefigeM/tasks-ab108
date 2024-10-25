namespace wehicle_task_class
{
     class Car:Wehicle
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int FuelCapcity { get; set; }
        public int FuelForOneKm { get; set; }
        public int CurrentFuel { get; set; }
        public Car(string model, string brand, int fuelForOneKm,int currentFuel,int currentCapacity, int year):base(year)
        {
            Model = model;
            Brand = brand;
            FuelCapcity = currentFuel;
            CurrentFuel=currentFuel;
            FuelForOneKm= fuelForOneKm;
        }
        public void ShowInfo() 
        {
            Console.WriteLine($"model:{Model}, brand:{Brand}, color:{Color}, year: {Year}, capacity:{FuelCapcity}, fuel for 1 km: {FuelForOneKm}, current fuel: {CurrentFuel}");
        }
        public void Drive(int distance)
        {
            if (CurrentFuel > distance * FuelForOneKm) Console.WriteLine($"car bu mesafeni gede bilecek, {CurrentFuel- distance * FuelForOneKm} litr benzin qalacaq.");
            
            else  Console.WriteLine($"benzin catmayacaq {distance * FuelForOneKm - CurrentFuel} litr benzin lazim olacaq.");
            
        }

    }
}
