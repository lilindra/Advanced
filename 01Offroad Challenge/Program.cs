/*
200 90 40 100
20 40 30 50
50 60 80 90
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Offroad_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialFuel = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> fuelStack = new Stack<int>(initialFuel);

            int[] consumptionIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> consumptionQueue = new Queue<int>(consumptionIndexes);

            int[] fuelNeeded = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> fuelNeededQueue = new Queue<int>(fuelNeeded);

            int altitude = 0;
            List<int> reachedAlt = new List<int>();

            while (consumptionQueue.Count > 0 && fuelStack.Count > 0)
            {
                int currentFuel = fuelStack.Pop();
                int currentConsumption = consumptionQueue.Dequeue();
                int currentFuelNeeded = fuelNeededQueue.Dequeue();

                if (currentFuel - currentConsumption >= currentFuelNeeded)
                {
                    altitude++;
                    reachedAlt.Add(altitude);
                    Console.WriteLine($"John has reached: Altitude {altitude}");
                }
                else
                {
                    Console.WriteLine($"John did not reach: Altitude {altitude + 1}");

                    if (altitude > 0)
                    {
                        Console.WriteLine($"John failed to reach the top.");

                        string result = $"Reached altitudes: {string.Join(", ", reachedAlt.Select(a => $"Altitude {a}"))}";

                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine($"John failed to reach the top.");
                        Console.WriteLine("John didn't reach any altitude.");
                    }

                    return;
                }
            }

            Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
        }
    }
}