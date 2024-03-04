namespace Shapes
{
    public abstract class Shape
    {
        private string name;

        public string Name { get { return name; } private set { name = value; } }

        protected Shape(string name)
        {
            this.Name = name;
        }

        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public virtual string Draw()
        {
            return $"Drawing {Name}";
        }
    }
}
