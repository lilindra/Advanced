namespace Exc04.Border_Control.Modules
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

