using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Csharp_DZ_NEW_1_Dedok
{
    public class Money
    {
        private int dollars; 
        private int cents;   
        public Money(int dollars, int cents)
        {
            if (cents < 0 || cents >= 100)
            {
                throw new ArgumentException("Cents should be between 0 and 99.");
            }

            this.dollars = dollars;
            this.cents = cents;
        }
        public int Dollars
        {
            get { return dollars; }
            set { dollars = value; }
        }
        public int Cents
        {
            get { return cents; }
            set
            {
                if (value < 0 || value >= 100)
                {
                    throw new ArgumentException("Cents should be between 0 and 99.");
                }
                cents = value;
            }
        }
        public override string ToString()
        {
            return $"{dollars}.{cents:D2}"; 
        }
        public override bool Equals(object obj)
        {
            if (obj is Money other)
            {
                return dollars == other.dollars && cents == other.cents;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return dollars.GetHashCode() ^ cents.GetHashCode();
        }
    }
    public class Product
    {
        private string name;  
        private Money price;  
        public Product(string name, Money price)
        {
            this.name = name;
            this.price = price;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Money Price
        {
            get { return price; }
            set { price = value; }
        }
        public void DecreasePrice(Money amount)
        {
            int totalCents = price.Dollars * 100 + price.Cents;
            int amountCents = amount.Dollars * 100 + amount.Cents;

            int newTotalCents = totalCents - amountCents;

            if (newTotalCents < 0)
            {
                throw new ArgumentException("New price cannot be negative.");
            }

            price.Dollars = newTotalCents / 100;
            price.Cents = newTotalCents % 100;
        }
        public override string ToString()
        {
            return $"{name}, Price: {price.ToString()}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Product other)
            {
                return name == other.name && price.Equals(other.price);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode() ^ price.GetHashCode();
        }
    }
}
