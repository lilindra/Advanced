using _01.SingleInheritance;

namespace Farm
{
    public class StartUp
    {
        static void Main()
        {
            Puppy puppy = new Puppy();

            puppy.Eat();

            puppy.Bark();

            puppy.Weep();
        }
    }
}