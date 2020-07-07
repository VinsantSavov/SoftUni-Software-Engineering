namespace ViceCity.Models.Players
{
    public class MainPlayer : Player
    {
        private const int INITIAL_LIFEPOINTS = 100;
        private const string NAME = "Tommy Vercetti";

        public MainPlayer()
            : base(NAME, INITIAL_LIFEPOINTS)
        {
        }
    }
}
