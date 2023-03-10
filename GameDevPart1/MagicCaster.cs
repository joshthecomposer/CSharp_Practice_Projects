class MagicCaster : Actor
{
    public MagicCaster(string name) : base(name, 80)
    {
        this.Attacks = new List<Attack>{
            new Attack("Fireball", 25),
            new Attack("Lightning bolt", 20),
            new Attack("Staff strike", 10)
        };
    }

    public void Heal(Actor target)
    {
        if (target.Health + 40 >= target.BaseHealth)
        {
            Console.WriteLine($"{this.Name} heals {target.Name} for {target.BaseHealth - target.Health}");
            target.Health = target.BaseHealth;
        }
        else
        {
            target.Health += 40;
            Console.WriteLine($"{this.Name} heals {target.Name} for 40");
        }
    }
}