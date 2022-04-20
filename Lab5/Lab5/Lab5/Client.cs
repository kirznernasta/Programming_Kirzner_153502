using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public enum PaymentType { Cash, Cashless }
    public class Product
    {
        public string Title { get; set; }

        public double Price { get; set; }

        public Product(string t, double p)
        {
            Title = t;
            Price = p;
        }


    }
    public class Client
    {
       public string Surname { get; set; }

        public List<Product> Products = new List<Product>();

        public PaymentType PaymentType { get; set; }

        public Client (string Sname)
        {
            Surname = Sname;
        }

        public void AddProd(Product Prod)
        {
            Products.Add(Prod);
        }

    }
    

    public class Store
    {
        private string Name;
        private bool is_start = false;
        private bool is_end = false;

        private List<Product> AllProducts = new List<Product>();

        private Client CurrentCustomer { get; set; }

        private List<Client> Clients = new List<Client>();

        public Store(string Name)
        {
            Name = Name;
        }

        public void AddProduct(string Name, double Cost)
        {
            Product Prod = new Product(Name, Cost);
            AllProducts.Add(Prod);
        }

        public void StartCall(string Cust, PaymentType type)
        {
            CurrentCustomer = new Client(Cust);
            CurrentCustomer.PaymentType = type;
            is_start = true;
            is_end = false;
        }

        public void EndCall()
        {
            Clients.Add(CurrentCustomer);
            CurrentCustomer = null;
            is_end = true;
            is_start = false;
        }

        public void MakeOrder(string Prod)
        {
            if (is_start)
            {
                bool is_there = false;
                for (int i = 0; i < AllProducts.Count; i++)
                {
                    if (AllProducts[i].Title == Prod)
                    {
                        CurrentCustomer.AddProd(AllProducts[i]);
                        is_there = true;
                    }
                }

                if (!is_there) Console.WriteLine("There is no sush product in the store!");
            }
            else
            {
                Console.WriteLine("Error! Start a call first!");
            }
            
        }


        public double GetTotalPrice(string Surname)
        {
            double total = 0;
            if (is_end)
            {
                bool is_there = false;

                for (int i = 0; i < Clients.Count; i++)
                {
                    if (Clients[i].Surname == Surname)
                    {
                        is_there = true;
                        for (int j = 0; j < Clients[i].Products.Count; j++)
                        {
                            total += Clients[i].Products[j].Price;

                        }

                    }
                }

                if (!is_there) Console.WriteLine("There is no sush client!");

            }
            else
            {
                Console.WriteLine("Error! End the call first!");
            }

            return total;
        }


        public string GetAllProducts(string Surname)
        {
            string result = "";

            if (is_end)
            {
                bool is_there = false;

                for (int i = 0; i < Clients.Count; i++)
                {
                    if (Clients[i].Surname == Surname)
                    {
                        is_there = true;
                        result += "Customer: " + Surname + "\n";
                        for (int j = 0; j < Clients[i].Products.Count; j++)
                        {
                            result += Clients[i].Products[j].Title + "\n";

                        }

                        result += "The type of payment: ";
                        if (Clients[i].PaymentType == PaymentType.Cash)
                        {
                            result += "cash\n";
                        }
                        else
                        {
                            result += "cashless payment\n";
                        }
                    }
                }

                if (!is_there) Console.WriteLine("There is no sush client!");
            }
            else
            {
                Console.WriteLine("Error! End the call first!");
            }

            return result;
        }
    }
}
