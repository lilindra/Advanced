using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class MuseElf : Elf
    {
        public string Username { get; set; }

        public int Level { get; set; }
        public MuseElf(string Username, int Level) : base(Username, Level)
        {

        }

    }
}
