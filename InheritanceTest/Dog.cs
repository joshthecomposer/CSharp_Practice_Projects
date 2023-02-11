class Dog : Animal
{
    public string Size;

    public Dog(string size, string species) : base(species, "Omnivore", true)
    {
        Species = species;
        Size = size;
    }
}