class Cat : Animal
{
    string breed;

    public Cat(string species, string breed) : base(species, "Omnivore",  true){
        this.species = species;
        this.breed = breed;
    }

}