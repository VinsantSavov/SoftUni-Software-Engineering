using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.FootbalTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (Validator.ValidateName(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("A name should not be empty.");
                }
            }
        }

        public int NumberOfPlayers
        {
            get
            {
                return this.players.Count;
            }
        }

        public int TeamRating
        {
            get
            {
                return this.Rating();
            }
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string name)
        {
            Player player = null;

            player = this.players.FirstOrDefault(n => n.Name == name);

            if(player != null)
            {
                this.players.Remove(player);
            }
            else
            {
                throw new ArgumentException($"Player {name} is not in {this.Name} team.");
            }
        }

        public int Rating()
        {
            double rating = 0;

            if (this.players.Count > 0)
            {
                foreach (var player in this.players)
                {
                    rating += (player.Stats.Dribble + player.Stats.Endurance + player.Stats.Passing
                + player.Stats.Shooting + player.Stats.Sprint) / 5.0;
                }

                return (int)Math.Round((rating / this.players.Count));
            }

            return 0;
        }
    }
}
