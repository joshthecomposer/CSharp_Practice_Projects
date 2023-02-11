class Dog : Animal
{
    string size;

    public string Size
    {
        get { return this.size; }
        set { this.size = value; }
    }

    public Dog(string species, string size, string noise) : base(species, "Omnivore", true, noise)
    {
        this.species = species;
        this.size = size;
    }
    public override void MakeNoise()
    {
        Console.WriteLine($"{size}{species} noise: {noise}!");
    }
}