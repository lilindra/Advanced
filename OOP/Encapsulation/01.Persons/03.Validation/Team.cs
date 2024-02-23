using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public string Name { get { return name; } private set { name = value; } }
        public IReadOnlyCollection<Person> FirstTeam { get { return this.firstTeam.AsReadOnly(); } }

        public IReadOnlyCollection<Person> ReserveTeam { get { return this.reserveTeam.AsReadOnly(); } }

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player);
            }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"First team has {firstTeam.Count} players.");
            sb.AppendLine($"Reserve team has {reserveTeam.Count} players.");

            return sb.ToString().Trim();
        }
    }
}
