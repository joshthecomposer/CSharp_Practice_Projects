class Coffee : Drink
{
    string roast;

    public Coffee(string name, int calories,  string roast) : base(name, 125.0, false, calories )
    {
        this.roast = roast;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine(this.roast);
        Console.WriteLine("===============================");
    }
}