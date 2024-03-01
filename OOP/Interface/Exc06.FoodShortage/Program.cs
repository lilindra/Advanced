/*
2
Peter 25 8904041303 04/04/1989
Stan 27 WildMonkeys
Peter
George
Peter
End
 */
namespace Exc06.FoodShortage.Modules
{
    public class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<Rebel> rebels = new List<Rebel>();
            List<Citizen> people = new List<Citizen>();

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];

                    Rebel person = new Rebel(name, age, group);

                    rebels.Add(person);
                }
                else if (input.Length == 4)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    string birth = input[3];

                    Citizen person = new Citizen(name, age, id, birth);
                    people.Add(person);
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string name = command;

                if (rebels.Any(x => x.Name == name))
                {
                    rebels.First(x => x.Name == name).BuyFood();
                }
                else if (people.Any(x => x.Name == name))
                {
                    people.First(x => x.Name == name).BuyFood();
                }


                command = Console.ReadLine();
            }

            Console.WriteLine(rebels.Sum(x => x.Food) + people.Sum(x => x.Food));
        }
    }
}