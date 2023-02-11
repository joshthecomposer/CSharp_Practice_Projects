class Bird : Animal
{
    public bool CanFly;

    public Bird(string species, bool canFly) : base(species, "Omnivorous", canFly)
    {
        Species = species;
        CanFly = canFly;
    }
}