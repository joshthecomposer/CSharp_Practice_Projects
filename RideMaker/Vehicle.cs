abstract class Vehicle
{
    public string Name { get; set; }
    int NumPassengers;
    string Color;
    bool HasEngine;
    int Mileage = 0;

    public Vehicle(string name, int numPassengers,string color,bool hasEngine)
    {
        this.Name = name;
        this.NumPassengers = numPassengers;
        this.Color = color;
        this.HasEngine = hasEngine;
    }

    public Vehicle(string name, string color)
    {
        this.Name = name;
        this.Color = color;
    }

    public void ShowInfo()
    {
        Console.WriteLine("======================");
        Console.WriteLine(this.Name + " Info:");
        Console.WriteLine("Passengers : " + this.NumPassengers);
        Console.WriteLine("Color : " + this.Color);
        Console.WriteLine("Engine??? : " + this.HasEngine);
        Console.WriteLine("Mileage : " + this.Mileage);
    }

    public void Travel(int miles)
    {
        this.Mileage += miles;
        Console.WriteLine("======================");
        Console.WriteLine(this.Name+" traveled "+this.Mileage+" miles.");
    }

}