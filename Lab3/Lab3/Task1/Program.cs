using Task1;

Console.WriteLine("Type a three-digit number:");
int num;

while (!int.TryParse(Console.ReadLine(), out num))
{
    Console.WriteLine("Incorrect value! Try again");
}

if (Math.Abs(num) >= 100 && Math.Abs(num) <= 999)
{
    Console.WriteLine("The result of inversing is : " + ThreeDigitNumber.ChangeDigits(num));
}
else
{
    Console.WriteLine("This is not a three-digit number!");
}



