/*
Peter Charizard Fire 100
George Squirtle Water 38
Peter Pikachu Electricity 10
Tournament
Fire
Electricity
End
*/

namespace StartUp
{
    public class StartUp
    {
        static void Main()
        {

            string command = Console.ReadLine();
            List<Trainer> trainers = new List<Trainer>();
            //List<Pokemon> pokemons = new List<Pokemon>();


            while (command != "Tournament")
            {
                string[] info = command.Split();

                string name = info[0];
                string pokemonName = info[1];
                string element = info[2];
                int health = int.Parse(info[3]);

                int badges = 0;

                Pokemon pokemon = new Pokemon(pokemonName, element,health);
                //pokemons.Add(pokemon);
                Trainer trainer = trainers.FirstOrDefault(t => t.Name == name);

                if (trainer != null)
                {
                    trainer.Pokemons.Add(pokemon);
                }
                else
                {
                    trainers.Add(new Trainer(name, new List<Pokemon> { pokemon }));
                }

                command = Console.ReadLine();
            }

            string command2 = Console.ReadLine();

            while (command2 != "End")
            {
                if (command2 == "Fire")
                {
                    foreach (Trainer trainer in trainers)
                    {
                        if (trainer.Pokemons.Any(p => p.Element == command2))
                        {
                            trainer.Badges++;
                        }
                        else
                        {
                            foreach (Pokemon pokemon in trainer.Pokemons)
                            {
                                pokemon.Health -= 10;
                            }

                            // Remove fainted Pokémon
                            trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                        }
                    }

                }
                else if (command2 == "Water")
                {
                    foreach (Trainer trainer in trainers)
                    {
                        if (trainer.Pokemons.Any(p => p.Element == command2))
                        {
                            trainer.Badges++;
                        }
                        else
                        {
                            foreach (Pokemon pokemon in trainer.Pokemons)
                            {
                                pokemon.Health -= 10;
                            }

                            // Remove fainted Pokémon
                            trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                        }
                    }
                }
                else if ( command2 == "Electricity")
                {
                    foreach (Trainer trainer in trainers)
                    {
                        if (trainer.Pokemons.Any(p => p.Element == command2))
                        {
                            trainer.Badges++;
                        }
                        else
                        {
                            foreach (Pokemon pokemon in trainer.Pokemons)
                            {
                                pokemon.Health -= 10;
                            }

                            // Remove fainted Pokémon
                            trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                        }
                    }
                }

                command2 = Console.ReadLine();
            }

            foreach (Trainer trainer in trainers.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}