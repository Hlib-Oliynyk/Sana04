using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana04.Classes
{
    public class Product
    {
        protected string Name;
        protected double Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected double Weight;

        public Product()
        {
            Name = "Назва товару";
            Price = 0.0;
            Cost = new Currency("UAH", 1.0);
            Quantity = 0;
            Producer = "Назва компанії-виробника";
            Weight = 0.0;
        }

        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            SetName(name);
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(Product other)
        {
            Name = other.Name;
            Price = other.Price;
            Cost = new Currency(other.Cost.GetName(), other.Cost.GetExRate());
            Quantity = other.Quantity;
            Producer = other.Producer;
            Weight = other.Weight;
        }

        public void SetName(string name)
        {
            if (name == null || name.Length == 0)
            {
                throw new Exception("Name is empty!");
            }
            else
            {
                Name = name;
            }
        }

        public string GetName()
        {
            return Name;
        }

        public double GetPriceInUAH()
        {
            return Price * Cost.GetExRate();
        }

        public double GetTotalPriceInUAH()
        {
            return GetPriceInUAH() * Quantity;
        }

        public double GetTotalWeight()
        {
            return Weight * Quantity;
        }
    }
}