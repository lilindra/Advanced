using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StartUp
{
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemon;

        public Trainer(string name, List<Pokemon> pokemon)
        {
            this.name = name;
            this.pokemon = pokemon;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Badges
        {
            get { return badges; }
            set { badges = value; }
        }
        public List<Pokemon> Pokemons
        {
            get { return pokemon; }
            set { pokemon = value; }
        }
    }
}
