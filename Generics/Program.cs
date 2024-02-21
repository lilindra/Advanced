/*
9 5 8 13
13 8 5 6
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] worms = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> wormsStack = new Stack<int>(worms);

            int[] holes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> holesQueue = new Queue<int>(holes);

            int matches = 0;

            while (wormsStack.Count > 0 && holesQueue.Count > 0)
            {
                int currentWorm = wormsStack.Peek();
                int currentHole = holesQueue.Peek();

                if (currentWorm == currentHole)
                {
                    matches++;
                    wormsStack.Pop();
                    holesQueue.Dequeue();
                }
                else
                {
                    holesQueue.Dequeue();
                    currentWorm -= 3;
                    wormsStack.Pop();
                    wormsStack.Push(currentWorm);

                    if (currentWorm <= 0)
                    {
                        // Only pop if the worm is greater than 0
                        wormsStack.Pop();
                    }
                }
            }

            // Print matches count
            if (matches > 0)
            {
                Console.WriteLine($"Matches: {matches}");
            }
            else
            {
                Console.WriteLine("There are no matches.");
            }

            // Print remaining worms
            if (wormsStack.Count == 0 && holesQueue.Count == 0)
            {
                Console.WriteLine("Every worm found a suitable hole!");
            }
            else if (wormsStack.Count == 0 && holesQueue.Count > 0)
            {
                Console.WriteLine("Worms left: none");
            }
            else
            {
                Console.WriteLine("Worms left: " + string.Join(", ", wormsStack));
            }

            // Print remaining holes
            if (holesQueue.Count == 0)
            {
                Console.WriteLine("Holes left: none");
            }
            else
            {
                Console.WriteLine("Holes left: " + string.Join(", ", holesQueue));
            }
        }
    }
}
