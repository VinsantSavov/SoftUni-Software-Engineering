using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Models.Guns;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Core.Contracts
{
    public class Controller : IController
    {
        private IPlayer mainPlayer;
        private List<IPlayer> players;
        private IRepository<IGun> guns;

        public Controller()
        {
            this.mainPlayer = new MainPlayer();
            this.players = new List<IPlayer>();
            this.guns = new GunRepository();
        }

        public string AddGun(string type, string name)
        {
            IGun gun;

            if(type == "Pistol")
            {
                gun = new Pistol(name);
            }
            else if(type == "Rifle")
            {
                gun = new Rifle(name);
            }
            else
            {
                return "Invalid gun type!";
            }

            this.guns.Add(gun);

            return $"Successfully added {name} of type: {type}";
        }

        public string AddGunToPlayer(string name)
        {
            IPlayer player = this.players.FirstOrDefault(p => p.Name == name);

            if(this.guns.Models.Count == 0)
            {
                return "There are no guns in the queue!";
            }

            IGun gun = this.guns.Models.ToList()[0];

            if (name == "Vercetti")
            {
                this.mainPlayer.GunRepository.Add(gun);
                this.guns.Remove(gun);

                return $"Successfully added {gun.Name} to the Main Player: Tommy Vercetti";
            }
            else if (player == null)
            {
                return "Civil player with that name doesn't exists!";
            }
            else
            {
                player.GunRepository.Add(gun);
                this.guns.Remove(gun);

                return $"Successfully added {gun.Name} to the Civil Player: {name}";
            }
            
        }

        public string AddPlayer(string name)
        {
            IPlayer player = new CivilPlayer(name);

            this.players.Add(player);

            return $"Successfully added civil player: {name}!";
        }

        public string Fight()
        {
            StringBuilder sb = new StringBuilder();

            INeighbourhood neighbourhood = new GangNeighbourhood();
            int playersCountBeforeTheFight = this.players.Count;
            int playersHealthBefore = this.players.Sum(p => p.LifePoints);

            neighbourhood.Action(this.mainPlayer, this.players);

            int playersHealthAfter = this.players.Sum(p => p.LifePoints);

            if(this.mainPlayer.LifePoints == 100 && this.players.Count == playersCountBeforeTheFight 
                && playersHealthBefore == playersHealthAfter)
            {
                return "Everything is okay!";
            }

            sb.AppendLine("A fight happened:");
            sb.AppendLine($"Tommy live points: {this.mainPlayer.LifePoints}!");
            sb.AppendLine($"Tommy has killed: {playersCountBeforeTheFight - this.players.Count} players!");
            sb.AppendLine($"Left Civil Players: {this.players.Count}!");

            return sb.ToString().TrimEnd();
        }
    }
}
