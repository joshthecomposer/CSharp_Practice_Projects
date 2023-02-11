Horse horse = new Horse("Prancer", "Brown");

Car car = new Car("Geo Prism", "Gray and Blue", "Gas");

Bicycle bike = new Bicycle("Schwinn", "Blue");

List<Vehicle> vehicles = new List<Vehicle>{
    horse, car, bike
};

vehicles.ForEach(vehicle => Console.WriteLine(vehicle.Name));

List<INeedFuel> f = new List<INeedFuel>();

vehicles.ForEach(vehicle => {
    if (vehicle is INeedFuel)
    {
        f.Add((INeedFuel)vehicle);
    }
});

f.ForEach(vehicle => {
    Console.WriteLine(vehicle.FuelType);
    vehicle.GiveFuel(10);
});