using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Utilities.Messages;
using System.Collections.Generic;
using System.Linq;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        private List<IPlayer> terrorists;
        private List<IPlayer> counters;

        public Map()
        {
            this.terrorists = new List<IPlayer>();
            this.counters = new List<IPlayer>();
        }

        public string Start(ICollection<IPlayer> players)
        {
            CreatingTeams(players);

            while (this.terrorists.Count > 0 && this.counters.Count > 0)
            {
                //this.terrorists = this.terrorists.Where(t => t.IsAlive).ToList();

                if(!this.terrorists.Any(t => t.IsAlive))
                {
                    break;
                }

                foreach (var terrorist in this.terrorists)
                {
                    foreach (var counter in this.counters)
                    {
                        int bullets = terrorist.Gun.Fire();
                        counter.TakeDamage(bullets);
                    }
                }

                if (!this.counters.Any(c => c.IsAlive))
                {
                    break;
                }
                //this.counters = this.counters.Where(c => c.IsAlive).ToList();

                foreach (var counter in this.counters)
                {
                    foreach (var terrorist in this.terrorists)
                    {
                        int bullets = counter.Gun.Fire();
                        terrorist.TakeDamage(bullets);
                    }
                }
            }

            if (this.terrorists.Count > 0)
            {
                return "Terrorist wins!";
            }
            else
            {
                return "Counter Terrorist wins!";
            }
        }

        private void CreatingTeams(ICollection<IPlayer> players)
        {
            foreach (var player in players)
            {
                if (player.GetType().Name == "Terrorist")
                {
                    this.terrorists.Add(player);
                }
                else
                {
                    this.counters.Add(player);
                }
            }
        }
    }
}
