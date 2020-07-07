namespace ViceCity.Models.Players
{
    public class CivilPlayer : Player
    {
        private const int INITIAL_LIFEPOINTS = 50;

        public CivilPlayer(string name)
            : base(name, INITIAL_LIFEPOINTS)
        {
        }
    }
}
