/*
30,25,40,35
15,20,10,30
 */


using Microsoft.VisualBasic;

namespace _01._Monster_Extermination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] monsterArmour = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            Queue<int> monsterArmourQ = new Queue<int>(monsterArmour);

            int[] soldierImpact = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            Stack<int> soldierImpactS = new Stack<int>(soldierImpact);

            int killedMonsters = 0;

            while (monsterArmourQ.Count > 0 && soldierImpactS.Count > 0)
            {
                int armour = monsterArmourQ.Peek();
                int strike = soldierImpactS.Peek();

                if (strike >= armour)
                {
                    killedMonsters++;
                    strike -= armour;
                    soldierImpactS.Pop();
                    monsterArmourQ.Dequeue();

                    if (strike > 0 && soldierImpactS.Count == 0)
                    {
                        soldierImpactS.Push(strike);
                    }
                    else if (strike > 0)
                    {
                        int tempStrike = strike;
                        soldierImpactS.Push(soldierImpactS.Pop() + tempStrike);
                    }
                }
                else
                {
                    armour -= strike;
                    soldierImpactS.Pop();
                    monsterArmourQ.Dequeue();
                    monsterArmourQ.Enqueue(armour);
                }
            }

            if (monsterArmourQ.Count == 0)
            {
                Console.WriteLine("All monsters have been killed!");
            }
            else if (soldierImpactS.Count == 0)
            {
                Console.WriteLine("The soldier has been defeated.");
            }

            Console.WriteLine($"Total monsters killed: {killedMonsters}");
        }
    }
}
