using System.Collections.Generic;
using System.Linq;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Models.Neghbourhoods
{
    public class GangNeighbourhood : INeighbourhood
    {
        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {
            while (mainPlayer.GunRepository.Models.Count > 0 && civilPlayers.Count > 0)
            {
                IGun mainPlayerGun = mainPlayer.GunRepository.Models.ToList()[0];

                while (mainPlayerGun.CanFire && civilPlayers.Count > 0)
                {
                    IPlayer player = civilPlayers.ToList()[0];

                    int bullets = mainPlayerGun.Fire();
                    player.TakeLifePoints(bullets);

                    if (!player.IsAlive)
                    {
                        civilPlayers.Remove(player);
                    }
                }

                mainPlayer.GunRepository.Remove(mainPlayerGun);
            }

            List<IPlayer> players = new List<IPlayer>();
            players = civilPlayers.ToList();

            while(mainPlayer.IsAlive && players.Count > 0)
            {
                IPlayer player = players.ToList()[0];

                if(player.GunRepository.Models.Count > 0)
                {
                    IGun playerGun = player.GunRepository.Models.ToList()[0];

                    while (playerGun.CanFire && mainPlayer.IsAlive)
                    {
                        int bullets = playerGun.Fire();
                        mainPlayer.TakeLifePoints(bullets);
                    }

                    player.GunRepository.Remove(playerGun);

                    if (player.GunRepository.Models.Count == 0)
                    {
                        players.Remove(player);
                    }
                }
                else
                {
                    players.Remove(player);
                }
            }
        }
    }
}
