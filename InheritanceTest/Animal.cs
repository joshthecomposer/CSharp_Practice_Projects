abstract class Animal 
{
    protected string species;
    protected string diet;
    protected bool isMammal;
    protected string noise;

    public string Species 
    {
        get { return species; }
        set { species = value; }
    }
    public string Diet 
    {
        get { return diet; }
        set { diet = value; }
    }
    public bool IsMammal 
    {
        get { return isMammal; }
        set { isMammal = value; }
    }

    public Animal(string species, string diet, bool isMammal, string noise)
    {
        this.species = species;
        this.diet = diet;
        this.isMammal = isMammal;
        this.noise = noise;
    }

    public abstract void MakeNoise();
}