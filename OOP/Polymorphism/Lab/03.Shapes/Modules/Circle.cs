namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public double Radius { get => radius; private set => radius = value; }

        public Circle(double radius) : base("Circle")
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override string Draw()
        {
            return base.Draw();
        }
    }
}
