using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CounterStrike.Repositories
{
    public class PlayerRepository : IRepository<IPlayer>
    {
        private ICollection<IPlayer> players;

        public PlayerRepository()
        {
            this.players = new List<IPlayer>();
        }

        public IReadOnlyCollection<IPlayer> Models => (IReadOnlyCollection<IPlayer>)this.players;

        public void Add(IPlayer model)
        {
            if(model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerRepository);
            }

            this.players.Add(model);
        }

        public IPlayer FindByName(string name)
        {
            IPlayer player = this.players.FirstOrDefault(p => p.Username == name);

            return player;
        }

        public bool Remove(IPlayer model)
        {
            bool result = this.players.Remove(model);

            return result;
        }
    }
}
