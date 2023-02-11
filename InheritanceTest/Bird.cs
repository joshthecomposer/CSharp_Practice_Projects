class Bird : Animal
{
    bool canFly;

    public bool CanFly
    {
        get { return this.canFly;}
        set { this.canFly = value; }
    }

    public Bird(string species, bool canFly) : base(species, "Omnivorous", canFly)
    {
        this.species = species;
        this.canFly = canFly;
    }

}