namespace P03.Raiding.Models
{
    public class Rogue : BaseHero
    {
        private const int DEF_POWER = 80;
        public Rogue(string name)
            : base(name, DEF_POWER)
        {
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
