namespace P03.Raiding.Models
{
    public class Druid : BaseHero
    {
        private const int DEF_POWER = 80;
        public Druid(string name)
            : base(name, DEF_POWER)
        {
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
