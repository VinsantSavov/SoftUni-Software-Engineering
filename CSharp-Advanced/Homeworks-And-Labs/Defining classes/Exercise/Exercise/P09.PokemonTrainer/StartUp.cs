using System;
using System.Collections.Generic;
using System.Linq;

namespace P09.PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<Trainer> trainers = new HashSet<Trainer>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Tournament")
                {
                    break;
                }

                string[] inputInfo = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string trainerName = inputInfo[0];
                string pokemonName = inputInfo[1];
                string pokemonElement = inputInfo[2];
                int pokemonHealth = int.Parse(inputInfo[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if(!trainers.Any(n=>n.Name == trainerName))
                {
                    Trainer trainer = new Trainer(trainerName, 0, new List<Pokemon>());
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
                else
                {
                    foreach (var trainer in trainers)
                    {
                        if(trainer.Name == trainerName)
                        {
                            trainer.Pokemons.Add(pokemon);
                        }
                    }
                }
                
            }

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "End")
                {
                    break;
                }
                if(command == "Fire" || command == "Water" || command == "Electricity")
                {
                    TrainerAndPokemon(trainers, command);
                }
            }

            trainers = trainers.OrderByDescending(n => n.NumberOfBadges).ToHashSet();

            foreach (var trainer in trainers)
            {
                Console.WriteLine(trainer);
            }
        }

        private static void TrainerAndPokemon(HashSet<Trainer> trainers, string command)
        {
            foreach (var trainer in trainers)
            {
                if(trainer.Pokemons.Any(n=>n.Element == command))
                {
                    trainer.NumberOfBadges++;
                }
                else
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        pokemon.Health -= 10;
                    }

                    if (trainer.Pokemons.Exists(p => p.Health < 0))
                    {
                        List<Pokemon> pokemonsWithNoHealth = trainer.Pokemons.FindAll(p => p.Health < 0);

                        foreach (var pokemon in pokemonsWithNoHealth)
                        {
                            trainer.Pokemons.Remove(pokemon);
                        }
                    }
                }
            }
        }
    }
}
