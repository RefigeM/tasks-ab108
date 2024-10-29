namespace _29_10_24_generic;
     class Wolf :Animal
    {
    public bool IsPrideLeader { get; set; }
    public int AttackDamage { get; set; }
   
    public Wolf(int attackDamage,int hp):base(hp)
    {
        AttackDamage=attackDamage;        
    }
    

    public void Hunt<T>(T animal) where T : Animal
    {
        if (animal.HP <= 0 || animal.HP<AttackDamage) return;
        Console.WriteLine(animal.HP - AttackDamage);
        



    }
}

