using Task3;

Console.WriteLine("Type the date you want to get the day of week (dd.MM.yyyy)");
string date = Console.ReadLine();

Console.WriteLine("The day of week is " + DateService.GetDayOfWeek(date));

Console.WriteLine("Type the day of date");
int day;
while(!int.TryParse(Console.ReadLine(), out day))
{
    Console.WriteLine("Incorrect value! Try again");
}

Console.WriteLine("Type the month of date");
int month;
while (!int.TryParse(Console.ReadLine(), out month))
{
    Console.WriteLine("Incorrect value! Try again");
}


Console.WriteLine("Type the day of date");
int year;
while (!int.TryParse(Console.ReadLine(), out year))
{
    Console.WriteLine("Incorrect value! Try again");
}


Console.WriteLine("The days span is " + DateService.GetDaysSpan(day, month, year) + " (day/s)");