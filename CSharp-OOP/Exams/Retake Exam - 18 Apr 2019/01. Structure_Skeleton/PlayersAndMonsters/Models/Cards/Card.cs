using PlayersAndMonsters.Models.Cards.Contracts;
using System;

namespace PlayersAndMonsters.Models.Cards
{
    public abstract class Card : ICard
    {
        private string name;
        private int damagePoints;
        private int healthPoints;

        public Card(string name, int damage, int health)
        {
            this.Name = name;
            this.DamagePoints = damage;
            this.HealthPoints = health;
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Card's name cannot be null or an empty string.");
                }

                this.name = value;
            }
        }

        public int DamagePoints
        {
            get => this.damagePoints;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Card's damage points cannot be less than zero.");
                }

                this.damagePoints = value;
            }
        }

        public int HealthPoints 
        {
            get => this.healthPoints;

            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Card's HP cannot be less than zero.");
                }

                this.healthPoints = value;
            }
        }
    }
}
