namespace SpaceStation.Models.Astronauts
{
    public class Biologist : Astronaut
    {
        private const double INITIAL_OXYGEN = 70;

        public Biologist(string name)
            : base(name, INITIAL_OXYGEN)
        {
        }

        public override bool CanBreath
        {
            get
            {
                if(this.Oxygen >= 5)
                {
                    return true;
                }

                return false;
            }
        }

        public override void Breath()
        {
            this.Oxygen -= 5;
        }
    }
}
