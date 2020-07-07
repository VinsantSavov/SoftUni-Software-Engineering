using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;

namespace PlayersAndMonsters.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string username;
        private int health;

        public Player(ICardRepository cardRepo, string username, int health)
        {
            this.CardRepository = cardRepo;
            this.Username = username;
            this.Health = health;
        }

        public ICardRepository CardRepository { get; }

        public string Username
        {
            get => this.username;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Player's username cannot be null or an empty string.");
                }

                this.username = value;
            }
        }

        public int Health
        {
            get => this.health;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Player's health bonus cannot be less than zero.");
                }

                this.health = value;
            }
        }

        public bool IsDead 
        {
            get
            {
                if(this.health > 0)
                {
                    return false;
                }

                return true;
            }
        }

        public void TakeDamage(int damagePoints)
        {
            if(damagePoints < 0)
            {
                throw new ArgumentException("Damage points cannot be less than zero.");
            }

            if(this.health - damagePoints < 0)
            {
                this.health = 0;
            }
            else
            {
                this.health -= damagePoints;
            }
        }
    }
}
