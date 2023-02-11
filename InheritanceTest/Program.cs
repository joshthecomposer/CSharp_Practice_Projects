Cat cat = new Cat("House cat", "Tabby");

Console.WriteLine(cat.Species);
Console.WriteLine(cat.IsMammal);

Dog dog = new Dog("Wolf", "Lorge");

Console.WriteLine(dog.Species);
Console.WriteLine(dog.IsMammal);
Console.WriteLine(dog.Size);

Bird bird = new Bird("Chicken", false);

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