List<string> bikes = new List<string>();

bikes.Add("Kawasaki");
bikes.Add("Triumph");
bikes.Add("BMW");
bikes.Add("Moto Guzzi");
bikes.Add("Harley Davidson");
bikes.Add("Suzuki");

// for (int idx = 0; idx < bikes.Count; idx++)
// {
//     Console.WriteLine("_" + bikes[idx]);
// }

bikes.Insert(2, "ASSSSS");

// for (int idx = 0; idx < bikes.Count; idx++)
// {
//     Console.WriteLine("_" + bikes[idx]);
// }

bool removed = bikes.Remove("BMW");

foreach(string m in bikes)
{
    Console.WriteLine("_" + m);
}

Console.WriteLine(removed);