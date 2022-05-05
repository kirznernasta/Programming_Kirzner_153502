using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{

    public interface IPrice
    {
        public double GetPrice();
    }

    public class AbsDiscount : IPrice
    {
        private double price;
        private double discount;

        public AbsDiscount(double _price, double _discount)
        {
            price = _price;
            discount = _discount;
        }

        public double GetPrice()
        {
            return price * (1 - discount / 100);
        }
    }

    public class NoDiscount : IPrice
    {
        private double price;

        public NoDiscount(double _price)
        {
            price = _price;
        }

        public double GetPrice()
        {
            return price;
        }
    }
    public class Product
    {
        private IPrice ip;
        public string Name { get; set; }

        public Product(string _name, double _price)
        {
            Name = _name;
            ip = new NoDiscount(_price);
        }

        public Product(string _name, double _price, double _discount)
        {
            Name = _name;
            ip = new AbsDiscount(_price, _discount);
        }

        public double GetPrice()
        {
            return ip.GetPrice();
        }

        public override string ToString()
        {
            return Name + " " + GetPrice();
        }
    }
    public class Store
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(string _name, double _price, double _discount = 0) 
        {
            if (_discount == 0) products.Add(new Product(_name, _price));
            else products.Add(new Product(_name, _price, _discount));
        }

        public Product FindMinimal()
        {
            Product productMinimal = products[0];
            foreach (Product product in products)
            {
                if (productMinimal.GetPrice() > product.GetPrice()) productMinimal = product;
            }
            return productMinimal;
        }
    }

    

}
