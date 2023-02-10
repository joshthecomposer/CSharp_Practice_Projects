// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int number = 32;
bool success = true;
double height = 1.2;

Console.WriteLine($"The number is {number} and the height is {height} and the bool is {success}");

Console.WriteLine("The number is " + number + " and the height is " + height + " and the bool is " + success);

Console.WriteLine("{0} {1} {2}", number, height, success);

for(int i = 0; i < number; i++){
    Console.WriteLine(i);
}

