class RangedFighter : Enemy
{
    int distance;

    public int Distance 
    {
        get { return distance; }
        set { distance = value; }
    }

    public RangedFighter(string name) : base(name, 100)
    {
        this.distance = 5;
        this.Attacks = new List<Attack>
        {
            new Attack("Shoot an arrow", 20),
            new Attack("Throw a knift", 15)
        };
    }

    public override void PerformAttack(Enemy target, Attack attack)
    {
        if (this.distance > 10)
        {
            base.PerformAttack(target, attack);
        }
        else
        {
            Console.WriteLine($"{this.Name} is too close to {target.Name} to attack!");
        }

    }
    public void Dash()
    {
        Console.WriteLine($"{this.Name} dashes away to gain some distance!");
        this.distance = 20;
    }
}