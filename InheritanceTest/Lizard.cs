class Lizard : Animal, I_LayEggs
{
    public int EggsPerBatch{get; set;}
    public Lizard(string species, string diet, int epb, string noise) : base(species, diet, false, noise)
    {
        this.EggsPerBatch = epb;
    }

    public void LayEggs()
    {
        Console.WriteLine($"{species} laid {EggsPerBatch}");
    }

    public override void MakeNoise()
    {
        Console.WriteLine($"{species} noise: {noise}");
    }

}