using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class Startup
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Trainer> trainers = new List<Trainer>();

            while (input != "Tournament")
            {
                string[] tokens = input.Split(' ');
                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string element = tokens[2];
                int health = int.Parse(tokens[3]);

                var trainer = trainers.FirstOrDefault(m => m.Name == trainerName);
                
                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                }

                var pokemon = new Pokemon(pokemonName, element, health);
                trainer.Pokemons.Add(pokemon);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                foreach (var trainer in trainers)
                {                    
                    if (trainer.Pokemons.Any(m=>m.Element == input))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(c => c.Health -= 10);
                        trainer.Pokemons.RemoveAll(m => m.Health <= 0);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(m=>m.Badges))
            {
                Console.WriteLine(trainer.ToString());
            }
        }
    }
}
