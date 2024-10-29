namespace _29_10_24_generic
{
    abstract class Animal
    {
        public int AvgLifeTime { get; set; }
        public string Breed { get; set; }
        public int HP { get; set; }
        public Gender Gender  { get; set; }

        protected Animal(int hp)
        {
            HP = hp;    
        }
    }
}
