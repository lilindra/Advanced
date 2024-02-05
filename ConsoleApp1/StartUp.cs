/*
2
V8-101 220 50
V4-33 140 28 B
3
FordFocus V4-33 1300 Silver
FordMustang V8-101
VolkswagenGolf V4-33 Orange
 */
using DefiningClasses;
using System.Drawing;
using System.Dynamic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] enginees = Console.ReadLine().Split().ToArray();

                string model = enginees[0];
                int power = int.Parse(enginees[1]);

                int displacement = 0;
                string efficiency = "";
                Engine engine = new Engine(model, power, displacement, efficiency);

                if (enginees.Length > 2)
                {
                    if (int.TryParse(enginees[2], out int displacementValue))
                    {
                        displacement = displacementValue;
                    }
                    else
                    {
                        efficiency = enginees[2];
                    }
                }

                if (enginees.Length > 3)
                {
                    efficiency = enginees[3];
                }

                engines.Add(new Engine(model, power, displacement, efficiency));
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0;i < m;i++)
            {
                string[] carInfo = Console.ReadLine().Split().ToArray();

                string model = carInfo[0];
                string engine = carInfo[1];

                int weight = 0;
                string color = "";
                Engine carEngine = engines.Find(e => e.Model == engine);
                Car car = new Car(model, carEngine, weight, color);

                if (carInfo.Length > 2)
                {
                    if (int.TryParse(carInfo[2], out int weightValue))
                    {
                        weight = weightValue;
                    }
                    else
                    {
                        color = carInfo[2];
                    }
                }

                if (carInfo.Length > 3)
                {
                    color = carInfo[3];
                }

                cars.Add(new Car(model, carEngine, weight, color));
            }

            // to fix here
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement > 0)
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                else
                {
                    Console.WriteLine($"    Displacement: n/a");
                }

                if (car.Engine.Efficiency != "")
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                }
                else
                {
                    Console.WriteLine($"    Efficiency: n/a");
                }

                if (car.Weight > 0)
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                else
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                if(car.Color != "")
                {
                    Console.WriteLine($"  Color: {car.Color}");
                }
                else
                {
                    Console.WriteLine($"  Color: n/a");
                }

            }
        }
    }
}