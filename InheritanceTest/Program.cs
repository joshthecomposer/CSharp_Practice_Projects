Cat cat = new Cat("House cat", "Tabby", "Meow!");

Console.WriteLine(cat.Species);
Console.WriteLine(cat.IsMammal);

Dog dog = new Dog("Wolf", "Lorge", "Bark!");

Console.WriteLine(dog.Species);
Console.WriteLine(dog.IsMammal);
Console.WriteLine(dog.Size);

Lizard lizard = new Lizard("Gecko", "Carnivore", 10, "TONGUE SLITHER" );

Bird bird = new Bird("Chicken", false, 5, "Tweet");

Console.WriteLine(bird.CanFly);

List <Animal> animals = new List<Animal>{cat, dog, bird};

foreach(Animal a in animals)
{
    if (a is Cat)
    {
        Console.WriteLine("I'm alergic! I sneeze!");
    }
    if (a is Bird)
    {
        Console.WriteLine("That's a dang ol " + a.Species);
    }
    if (a is Dog)
    {
        Dog d = (Dog)a;
        Console.WriteLine("That's a cute " + d.Size + " dog!");
    }
}

lizard.MakeNoise();
cat.MakeNoise();