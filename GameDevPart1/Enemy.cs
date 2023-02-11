class Enemy
{
    string name;
    int health = 100;
    List<Attack> attacks = new List<Attack>();

    public Enemy(string name)
    {
        this.name = name;
    }

    public void RandomAttack()
    {
        Random r = new Random();
        Console.WriteLine(
            this.name + " did "+ 
            this.attacks[r.Next(0, attacks.Count)].Name
            );
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
}