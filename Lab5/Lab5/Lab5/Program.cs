using Lab5;

Store Riga = new Store("Riga");

Riga.AddProduct("milk", 2.56);
Riga.AddProduct("bread", 1.2);
Riga.AddProduct("cucumber", 0.3);
Riga.AddProduct("potato", 0.4);
Riga.AddProduct("sousege", 0.7);
Riga.AddProduct("coca-cola", 2.69);

Riga.StartCall("Vlad", PaymentType.Cashless);

Riga.MakeOrder("coca-cola");
Riga.MakeOrder("coca-cola");
Riga.MakeOrder("cucumber");
Riga.MakeOrder("tomato");

Riga.EndCall();

Riga.StartCall("Nastya", PaymentType.Cash);

Riga.MakeOrder("potato");
Riga.MakeOrder("potato");
Riga.MakeOrder("potato");
Riga.MakeOrder("potato");
Riga.MakeOrder("potato");
Riga.MakeOrder("potato");
Riga.MakeOrder("potato");
Riga.MakeOrder("coca-cola");
Riga.MakeOrder("coca-cola");
Riga.MakeOrder("coca-cola");
Riga.MakeOrder("sousege");
Riga.MakeOrder("sousege");
Riga.MakeOrder("sousege");
Riga.MakeOrder("sousege");

Riga.EndCall();

Console.WriteLine(Riga.GetTotalPrice("Nastya"));
Console.WriteLine(Riga.GetAllProducts("Vlad"));