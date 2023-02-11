class Cat : Animal
{
    string Breed;

    public Cat(string breed, string species) : base(species, "Omnivore",  true){
        Species = species;
        Breed = breed;
    }

}