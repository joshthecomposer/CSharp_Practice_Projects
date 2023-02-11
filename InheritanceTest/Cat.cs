class Cat : Animal
{
    string breed;

    public Cat(string species, string breed, string noise) : base(species, "Omnivore",  true, noise){
        this.species = species;
        this.breed = breed;
    }

    public override void MakeNoise()
    {
        Console.WriteLine($"{species} meows!!");
    }
}