using Lab8;

Store riga = new Store();
riga.AddProduct(" bread", 3200, 25);
riga.AddProduct("milk", 1200);
Console.WriteLine(riga.FindMinimal());