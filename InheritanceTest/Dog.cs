class Dog : Animal
{
    string size;

    public string Size
    {
        get { return this.size; }
        set { this.size = value; }
    }

    public Dog(string species, string size) : base(species, "Omnivore", true)
    {
        this.species = species;
        this.size = size;
    }
}