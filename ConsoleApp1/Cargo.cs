using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Cargo
    {
        private string type;
        private int weight;

        public Cargo(string type, int weight)
        {
            this.type = type;
            this.weight = weight;
        }

        public Cargo(int weight, string type)
        {
            this.weight = weight;
            this.type = type;
        }

        public string Type 
        {
            get { return type; }
            set { type = value; }
        }

        public int Weight 
        {
            get { return weight; }
            set { weight = value; }
        }

    }
}
