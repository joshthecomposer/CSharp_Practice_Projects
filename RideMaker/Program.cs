Vehicle geoPrism = new Vehicle("Geo Prism", 3, "Gray", true);
Vehicle jeepWrangler = new Vehicle("Jeep Wrangler", "Black");
Vehicle toyotaCamry = new Vehicle("Toyota Camry", "Blue");
Vehicle nissanUltima = new Vehicle("Nissan Ultima", "Red");

List<Vehicle> vehicles = new List<Vehicle>{geoPrism, jeepWrangler, toyotaCamry, nissanUltima};

foreach (Vehicle vehicle in vehicles)
{
    vehicle.ShowInfo();
}

toyotaCamry.Travel(100);
toyotaCamry.ShowInfo();//This is essentially a big ol' getter method
