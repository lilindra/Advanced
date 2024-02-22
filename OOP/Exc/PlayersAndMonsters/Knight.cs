using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class Knight : Hero
    {
        public string Username { get; set; }

        public int Level { get; set; }
        public Knight(string Username, int Level) : base(Username, Level)
        {

        }

    }
}
