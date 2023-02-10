Random rd = new Random();

static void d() {
    Console.WriteLine("===============================");
}

for (int i = 1; i < 256; i++)
{
    Console.WriteLine(i);
}

d();

for (int i = 0; i < 5; i++)
{
    int n = rd.Next(10, 21);
    Console.WriteLine(n);
}

d();

int sum = 0;
for (int i = 0; i < 5; i++)
{
    sum += rd.Next(10,21);
}

Console.WriteLine(sum);

d();

void fizzBuzz() {
    for (int i = 1; i < 101; i++)
    {
        if (i % 3 == 0 && i % 5 == 0) {
            Console.WriteLine("FizzBuzz");
        } 
        else if (i % 3 == 0) 
        {
            Console.WriteLine("Fizz");
        } 
        else if (i % 5 == 0) 
        {
            Console.WriteLine("Buzz");
        }
        else 
        {
            Console.WriteLine(i);
        }
    }
}

fizzBuzz();
d();