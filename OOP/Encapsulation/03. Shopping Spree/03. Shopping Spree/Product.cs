﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Shopping_Spree
{
    public class Product
    {
        private string name;

        private int cost;

        public Product(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { 
            get => name; 
        
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public int Cost { get => cost; 
        
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                cost = value;
            }
        }
    }
}
