using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Utilities.Messages;
using System;

namespace CounterStrike.Models.Players
{
    public class Player : IPlayer
    {
        private string username;
        private int health;
        private int armor;
        private IGun gun;

        public Player(string username, int health, int armor, IGun gun)
        {
            this.Username = username;
            this.Health = health;
            this.Armor = armor;
            this.Gun = gun;
        }

        public string Username
        {
            get => this.username;

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerName);
                }

                this.username = value;
            }
        }

        public int Health
        {
            get => this.health;

            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerHealth);
                }

                this.health = value;
            }
        }

        public int Armor
        {
            get => this.armor;

            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerArmor);
                }

                this.armor = value;
            }
        }

        //Exception mess
        public IGun Gun
        {
            get => this.gun;

            private set
            {
                if(value == null)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGun);
                }

                this.gun = value;
            }
        }

        public bool IsAlive
        {
            get
            {
                if(this.Health > 0)
                {
                    return true;
                }

                return false;
            }
        }

        public void TakeDamage(int points)
        {
            if(this.Armor - points > 0)
            {
                this.Armor -= points;
            }
            else if(this.Armor - points == 0)
            {
                this.Armor -= points;
            }
            else
            {
                int temp = points - this.Armor;

                this.Armor = 0;

                if (this.Health <= temp)
                {
                    this.Health = 0;
                }
                else
                {
                    this.Health -= temp;
                }
            }
        }
    }
}
