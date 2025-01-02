using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sana04.Classes
{
    public class Currency
    {
        protected string Name;
        protected double ExRate;

        public Currency()
        {
            Name = "UAH";
            ExRate = 1.0;
        }

        public Currency(string name, double exRate)
        {
            SetName(name);
            SetExRate(exRate);
        }

        public Currency(Currency other)
        {
            Name = other.Name;
            ExRate = other.ExRate;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Currency name is empty!");
            Name = name;
        }

        public void SetExRate(double exRate)
        {
            if (exRate <= 0)
                throw new Exception("Exchange rate must be positive!");
            ExRate = exRate;
        }

        public string GetName() { return Name; }
        public double GetExRate() { return ExRate; }
    }
}

