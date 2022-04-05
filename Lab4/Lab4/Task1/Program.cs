TV tv = new TV();

Console.WriteLine("Type the name of an internet shop: ");
string name = Console.ReadLine();

tv.internetShop(name);

Console.WriteLine("Type the cost of a TV: ");
double cost = Double.Parse(Console.ReadLine());
tv.Cost = cost;

Console.WriteLine("Type the amount of purchases of TVs: ");
int purch = int.Parse(Console.ReadLine());
tv.InternetShop.Purchases = purch;

double earnings = tv.InternetShop.GetEarnings();

Console.WriteLine("Shop name: " + tv.InternetShop.Name);
Console.WriteLine("Cost of a TV: " + tv.Cost);
Console.WriteLine("Purchases of TVs: " + tv.InternetShop.Purchases);
Console.WriteLine("Earnings: " + earnings.ToString());



public class InternetShop 
{
    private static InternetShop instance;

    private InternetShop() {}

    public TV Product { get; set; }

    public string Name { get; private set; }

    public int Purchases { get; set; }

    protected InternetShop(string name, TV tv)
    {
        this.Name = name;
        Product = tv;
    }

    public static InternetShop getInstance(string name, TV tv)
    {
        if (instance == null)
        {
            instance = new InternetShop(name, tv);
        }
        return instance;
    }

    public double GetEarnings()
    {
        return Product.Cost * Purchases;
    }
}

public class TV
{
    public InternetShop InternetShop { get; set; }

    public void internetShop(string name)
    {
        InternetShop = InternetShop.getInstance(name, this);
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

}