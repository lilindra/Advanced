using Exc05.BirthdayCelebrations.Modules;

namespace Exc04.Border_Control.Modules
{
    public class Citizen : IDable, IBirthable
    {
        public Citizen(string name, int age, string id, string birth)
        {
            Name = name;
            Age = age;
            Id = id;
            Birth = birth;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; set; }

        public string Birth { get; set; }
    }
}
