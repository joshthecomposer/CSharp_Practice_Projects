class Car : Vehicle, INeedFuel
{
    public string FuelType {get; set; }
    public int FuelTotal {get; set; }
    public int BaseFuel {get; set;}

    public Car(string name, string color, string fuelType) : base(name, 4, color, true)
    {
        FuelTotal = 10;
        FuelType = fuelType;
        BaseFuel = FuelTotal;
    }

    public void GiveFuel(int n)
    {
        FuelTotal += n;
        Console.WriteLine($"Adding {n} to fuel!");
    }
}