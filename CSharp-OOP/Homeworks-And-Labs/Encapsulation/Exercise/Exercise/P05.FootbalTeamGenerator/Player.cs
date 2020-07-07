using System;

namespace P05.FootbalTeamGenerator
{
    public class Player
    {
        private string name;

        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.Stats = stats;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (Validator.ValidateName(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("A name should not be empty.");
                }
            }
        }
        public Stats Stats { get; }


        //public double OverAll()
        //{
        //    double overall = (this.Stats.Dribble + this.Stats.Endurance + this.Stats.Passing
        //        + this.Stats.Shooting + this.Stats.Sprint) / 5.0;

        //    return overall;
        //}
    }
}
