namespace Exc06.FoodShortage.Modules
{
    public class Robot : IDable
    {
        public string Model { get; }

        public string Id { get; }

        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }
    }
}

