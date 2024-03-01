namespace Exc06.FoodShortage.Modules
{
    public class Citizen : IDable, IBirthable, IBuyer
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

        public int Food { get; set; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
