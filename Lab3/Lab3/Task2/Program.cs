using Task2.Services;

Console.WriteLine("Type x:");
double x;
while (!double.TryParse(Console.ReadLine(), out x))
{
    Console.WriteLine("Incorrect value! Try again");
}

Console.WriteLine("Type a:");
double a;
while (!double.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Incorrect value! Try again");
}

Console.WriteLine("Type b:");
double b;
while (!double.TryParse(Console.ReadLine(), out b))
{
    Console.WriteLine("Incorrect value! Try again");
}

if (x - a * b != 0) Console.WriteLine(Solving.GetResult(x, a, b));
else Console.WriteLine("unexpected value! Restart and try again!");
