class Soda : Drink
{
    bool diet;

    public Soda(string name, int calories, bool diet) : base(name, 40.0, true, calories)
    {
        this.diet = diet;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine(this.diet);
        Console.WriteLine("===============================");
    }
}