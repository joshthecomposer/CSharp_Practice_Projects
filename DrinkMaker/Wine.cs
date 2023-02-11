class Wine : Drink
{
    string region;
    int year;

    public Wine(string name, int calories, string region, int year) : base(name, 40.0, false, calories)
    {
        this.region = region;
        this.year = year;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine(this.region);
        Console.WriteLine(this.year);

        Console.WriteLine("==================");
    }
}