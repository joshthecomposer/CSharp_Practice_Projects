class Dog : Animal
{
    string size;

    public string Size
    {
        get { return this.size; }
        set { this.size = value; }
    }

    public Dog(string size, string species) : base(species, "Omnivore", true)
    {
        Species = species;
        this.size = size;
    }
}