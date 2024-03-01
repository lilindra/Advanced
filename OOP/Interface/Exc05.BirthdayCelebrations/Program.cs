/*
2
Peter 25 8904041303 04/04/1989
Stan 27 WildMonkeys
Peter
George
Peter
End
 */
namespace Exc04.Border_Control
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> birthdates = new List<string>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] data = command.Split();

                if (data[0] == "Citizen")
                {
                    string name = data[1];
                    string age = data[2];
                    string id = data[3];
                    string birth = data[4];

                    birthdates.Add(birth);
                }
                else if (data[0] == "Pet")
                {
                    string name = data[1];
                    string birth = data[2];

                    birthdates.Add(birth);
                }
                else
                {
                    string model = data[1];
                    string id = data[2];
                }

                command = Console.ReadLine();
            }

            int endNums = int.Parse(Console.ReadLine());

            foreach (var id in birthdates)
            {
                string mainNumberString = id.ToString();
                string subNumberString = endNums.ToString();

                if (mainNumberString.EndsWith(subNumberString))
                {
                    Console.WriteLine(id);
                }
            }

        }
    }
}