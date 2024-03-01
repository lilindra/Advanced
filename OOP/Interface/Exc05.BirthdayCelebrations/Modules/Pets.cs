namespace Exc05.BirthdayCelebrations.Modules
{
    public class Pets
    {
        public Pets(string name, string birth)
        {
            Name = name;
            Birth = birth;
        }

        public string Name { get; set; }

        public string Birth { get; set; }
    }
}
