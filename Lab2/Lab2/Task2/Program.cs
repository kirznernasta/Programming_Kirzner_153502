//Task1
//Variant 16 (17 picture)

Console.WriteLine("Type the cord of x:");
double x = Double.Parse(Console.ReadLine());
Console.WriteLine("Type the cord of y:");
double y = Double.Parse(Console.ReadLine());


Calculate.Result(x, y);


public class Calculate
{
    public static int Result(double x, double y)
    {
        if (x <= 0 && x >= -23 && (y == -x || y == 23) || x == 0 && y <= 23 && y >= 0)
        {
            Console.WriteLine("On the border!");
            return 0;
        }
        else if (y > 0 && y < 23 && x < 0 && x > -23)
        {
            Console.WriteLine("Yes!");
            return 1;
        }
        else
        {
            Console.WriteLine("No!");
            return -1;
        }
        
    }
}