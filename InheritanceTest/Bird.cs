class Bird : Animal, I_LayEggs
{
    bool canFly;
    public int EggsPerBatch {get; set;}
    public bool CanFly
    {
        get { return this.canFly;}
        set { this.canFly = value; }
    }

    public Bird(string species, bool canFly, int epb, string noise) : base(species, "Omnivorous", canFly, noise)
    {
        this.species = species;
        this.canFly = canFly;
        EggsPerBatch = epb;
    }

    public void LayEggs()
    {
        Console.WriteLine($"{species} laid {EggsPerBatch} eggs!");
    }

    public override void MakeNoise()
    {
        Console.WriteLine($"{species} coos!");
    }
}