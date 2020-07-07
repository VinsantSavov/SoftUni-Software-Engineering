using PlayersAndMonsters.Repositories.Contracts;

namespace PlayersAndMonsters.Models.Players
{
    public class Beginner : Player
    {
        private const int INITIAL_HEALTH = 50;

        public Beginner(ICardRepository cardRepo, string username)
            : base(cardRepo, username, INITIAL_HEALTH)
        {
        }
    }
}
