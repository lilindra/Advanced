using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Shopping_Spree
{
    public class Person
    {
        private string name;
        private int money;
        private List<Product> bag;

        public Person(string name, int money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }

        public string Name { get => name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public int Money { get => money; 
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public List<Product> Bag
        {
            get { return bag; }
        }

        public void BuyProduct(Product product)
        {
            if (Money >= product.Cost)
            {
                Money -= product.Cost;
                bag.Add(product);
                Console.WriteLine($"{Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
        }
    }
}
