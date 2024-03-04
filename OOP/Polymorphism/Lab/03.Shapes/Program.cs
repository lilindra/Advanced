namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);

            Console.WriteLine(circle.Draw());

            Console.WriteLine(circle.CalculateArea());

            Console.WriteLine(circle.CalculatePerimeter());

            Rectangle rectangle = new Rectangle(5, 10);

            Console.WriteLine(rectangle.Draw());

            Console.WriteLine(rectangle.CalculateArea());

            Console.WriteLine(rectangle.CalculatePerimeter());
        }
    }
}