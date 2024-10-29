namespace _29_10_24_generic;
class Elephant : Animal
{
    public double Weight { get; set; }
    public bool IsTrained { get; set; }
    public Elephant(double weight, bool istrained, int hp) : base(hp)
    {
        {
            Weight = weight;
            IsTrained = istrained;

        }
    }
}
    
