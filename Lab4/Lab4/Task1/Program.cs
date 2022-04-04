TV tv = new TV();

Console.WriteLine("Type the name of an internet shop: ");
string name = Console.ReadLine();

tv.internetShop(name);

Console.WriteLine("Type the cost of a TV: ");
double cost = Double.Parse(Console.ReadLine());
tv.Cost = cost;

Console.WriteLine("Type the amount of purchases of TVs: ");
int purch = int.Parse(Console.ReadLine());
tv.Purchases = purch;

double earnings = tv.GetEarnings();

Console.WriteLine("Shop name: " + tv.InternetShop.Name);
Console.WriteLine("Cost of a TV: " + tv.Cost);
Console.WriteLine("Purchases of TVs: " + tv.Purchases);
Console.WriteLine("Earnings: " + earnings.ToString());



public class InternetShop 
{
    private static InternetShop instance;

    private InternetShop() {}

    public string Name { get; private set; }

    protected InternetShop(string name)
    {
        this.Name = name;
    }

    public static InternetShop getInstance(string name)
    {
        if (instance == null)
        {
            instance = new InternetShop(name);
        }
        return instance;
    }
}

public class TV
{
    public InternetShop InternetShop { get; set; }

    public void internetShop(string name)
    {
        InternetShop = InternetShop.getInstance(name);
    }
    public int Purchases
    {
        get; set;
    }
    public double Cost
    {
        get; set;
    }

    public void ChangeCost(double dcost)
    {
        Cost += dcost;
        if (Cost < 0) Cost = 0;
    }
    public double GetEarnings()
    {
        return Cost * Purchases;
    }

}