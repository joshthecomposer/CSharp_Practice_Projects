class Horse : Vehicle, INeedFuel
{
    public string FuelType {get; set;}
    public int FuelTotal {get; set;}
    public int BaseFuel {get; set;}

    public Horse(string name, string color) : base(name, 1, color, false)
    {
        FuelType = "Hay";
        FuelTotal = 10;
        BaseFuel = FuelTotal;
    }

    public void GiveFuel(int n)
    {
        FuelTotal += n;
        Console.WriteLine($"Adding {n} to fuel!");
    }
}