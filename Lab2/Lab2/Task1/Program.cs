//Task1
//Variant 12
while (true)
{
    Console.WriteLine("Type the three-digit number:");
    int number = Int16.Parse(Console.ReadLine());
    number = Math.Abs(number);
    if (number >= 100 && number <= 999)
    {
        Calc.getResult(number);
    }
    else
    {
        Console.WriteLine("This is not a three-digit number!");
    }
    Console.WriteLine("\n***********\nChoose the option (another number will be percieved as exit):\n1. Continue\n2. Exit the program");
    int menu = Int16.Parse(Console.ReadLine());
    switch (menu)
    {
        case 1:
            break;
        case 2:
            Console.WriteLine("Bye-bye!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Bye-bye!");
            Environment.Exit(0);
            break;
    }
}

public class Calc
{
    public static int getResult(int number)
    {
        if (number / 100 > number % 10)
        {
            Console.WriteLine("The first digit in this number is bigger than the last one");
            return 1;
        }
        else if (number / 100 < number % 10)
        {
            Console.WriteLine("The last digit in this number is bigger than the first one");
            return -1;
        }
        else
        {
            Console.WriteLine("The last and first digits are equal");
            return 0;
        }
      
    }
}