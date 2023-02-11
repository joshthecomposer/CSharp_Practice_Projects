class Cat : Animal
{
    public string Breed;

    public Cat(string breed, string species) : base(species, "Omnivore",  true){
        Species = species;
        Breed = breed;
    }

}