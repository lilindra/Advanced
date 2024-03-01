/*
Peter 22 9010101122
MK-13 558833251
MK-12 33283122
End
122
 */
namespace Exc04.Border_Control
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> ids = new List<string>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] data = command.Split();

                if (data[0].Any(char.IsDigit) && data.Length == 2)
                {
                    string model = data[0];
                    string id = data[1];

                    ids.Add(id);
                }
                else
                {
                    string name = data[0];

                    if (data[1].Length > 3)
                    {
                        string id = data[1];
                        ids.Add(id);
                    }
                    else
                    {
                        int age = int.Parse(data[1]);
                        string id = data[2];
                        ids.Add(id);
                    }
                }

                command = Console.ReadLine();
            }

            int endNums = int.Parse(Console.ReadLine());

            foreach (var id in ids)
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