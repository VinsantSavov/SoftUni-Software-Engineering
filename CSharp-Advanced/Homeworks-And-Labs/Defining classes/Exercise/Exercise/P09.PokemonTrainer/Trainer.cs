
using System.Collections.Generic;

namespace P09.PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;

        public Trainer(string name, int num, List<Pokemon> pokemons)
        {
            this.Name = name;
            this.NumberOfBadges = num;
            this.Pokemons = pokemons;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int NumberOfBadges
        {
            get
            {
                return this.numberOfBadges;
            }
            set
            {
                this.numberOfBadges = value;
            }
        }

        public List<Pokemon> Pokemons
        {
            get
            {
                return this.pokemons;
            }
            set
            {
                this.pokemons = value;
            }
        }

        public override string ToString()
        {
            return $"{Name} {NumberOfBadges} {Pokemons.Count}";
        }
    }
}
