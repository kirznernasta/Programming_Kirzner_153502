using Lab7;

Triangle tr = new Triangle();
tr.A = 3;
tr.B = 4;   
tr.C = 5;

Console.WriteLine(tr);
Console.WriteLine(tr.GetSquare());
Console.WriteLine(tr.GetPerimetr());

tr++;
Console.WriteLine(tr);
Console.WriteLine(tr.GetSquare());
Console.WriteLine(tr.GetPerimetr());

tr *= 3;
Console.WriteLine(tr);
Console.WriteLine(tr.GetSquare());
Console.WriteLine(tr.GetPerimetr());

tr -= 5;
Console.WriteLine(tr);
Console.WriteLine(tr.GetSquare());
Console.WriteLine(tr.GetPerimetr());

Triangle tr2 = new Triangle(3, 3, 3);
Console.WriteLine(tr2);

if (tr2) 
    Console.WriteLine("true");
else
    Console.WriteLine("false");

tr2 /= 2;
Console.WriteLine(tr2);
Console.WriteLine(tr2.GetSquare());
Console.WriteLine(tr2.GetPerimetr());

Console.WriteLine(tr2 < tr);
