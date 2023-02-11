class Attack 
{
    string name;
    int damage;

    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }

    public Attack(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public string Name  // property
    {
        get { return this.name; }   // get method
        set { this.name = value; }  // can add if statements for setter checks
    }
}