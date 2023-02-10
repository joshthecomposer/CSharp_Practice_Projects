Random rd = new Random();

for (int i = 0; i < 11; i++) 
{
    int n = rd.Next(1, 101);
    Console.WriteLine(n);
}

for (int i = 0; i < 11; i++)
{
    double d = rd.NextDouble();
    Console.WriteLine(d);
}