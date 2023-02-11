class Enemy
{
    string name;
    int health;
    int baseHealth;
    List<Attack> attacks = new List<Attack>();

    public int Health
    {
        get 
        { return health; }
        set 
        { 
            if (value > baseHealth)
            {
                health = baseHealth;
            } else
            {
                health = value;
            }
        }
    }
    public int BaseHealth
    {
        get {return baseHealth; }
    }

    public string Name {
        get { return name; }
    }

    public Enemy(string name, int health)
    {
        this.name = name;
        this.health = health;
        this.baseHealth = health;
    }

    public Attack RandomAttack()
    {
        Random r = new Random();
        return this.attacks[r.Next(0, attacks.Count)];
    }

    public List<Attack> Attacks
    {
        get { return attacks; }
        set { attacks = value; }
    }

    public void AddAttack(Attack attack)
    {
        this.attacks.Add(attack);
    }

    public virtual void PerformAttack(Enemy target, Attack attack)
    {
        target.Health -= attack.Damage;

        Console.WriteLine($"{this.name} attacks {target.Name} with {attack.Name} dealing {attack.Damage} damage.");
        Console.WriteLine($"{target.Name}'s health is {target.Health}.");
    }
}