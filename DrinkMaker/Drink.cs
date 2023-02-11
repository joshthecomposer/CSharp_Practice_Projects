class Drink 
{
    protected string name;
    protected double temperature;
    protected bool isCarbonated;
    protected int calories;

    public Drink(string name, double temperature, bool isCarbonated, int calories)
    {
        this.name = name;
        this.temperature = temperature;
        this.isCarbonated = isCarbonated;
        this.calories = calories;
    }

    public virtual void ShowDrink()
    {
        Console.WriteLine(this.name);
        Console.WriteLine(this.temperature);
        Console.WriteLine(this.isCarbonated);
        Console.WriteLine(this.calories);
    }
}