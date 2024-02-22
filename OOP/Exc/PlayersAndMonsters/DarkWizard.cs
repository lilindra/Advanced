using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class DarkWizard : Wizard
    {
        public string Username { get; set; }

        public int Level { get; set; }
        public DarkWizard(string Username, int Level) : base(Username, Level)
        {

        }
    }
}
