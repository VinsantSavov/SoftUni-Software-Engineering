using System;

namespace P05.FootbalTeamGenerator
{
    public class Stats
    {
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Endurance
        {
            get
            {
                return this.endurance;
            }
            private set
            {
                if (Validator.ValidateStats(value))
                {
                    this.endurance = value;
                }
                else
                {
                    throw new ArgumentException("Endurance should be between 0 and 100.");
                }
            }
        }
        public int Sprint
        {
            get
            {
                return this.sprint;
            }
            private set
            {
                if (Validator.ValidateStats(value))
                {
                    this.sprint = value;
                }
                else
                {
                    throw new ArgumentException("Sprint should be between 0 and 100.");
                }
            }
        }
        public int Dribble
        {
            get
            {
                return this.dribble;
            }
            private set
            {
                if (Validator.ValidateStats(value))
                {
                    this.dribble = value;
                }
                else
                {
                    throw new ArgumentException("Dribble should be between 0 and 100.");
                }
            }
        }
        public int Passing
        {
            get
            {
                return this.passing;
            }
            private set
            {
                if (Validator.ValidateStats(value))
                {
                    this.passing = value;
                }
                else
                {
                    throw new ArgumentException("Passing should be between 0 and 100.");
                }
            }
        }
        public int Shooting
        {
            get
            {
                return this.shooting;
            }
            private set
            {
                if (Validator.ValidateStats(value))
                {
                    this.shooting = value;
                }
                else
                {
                    throw new ArgumentException("Shooting should be between 0 and 100.");
                }
            }
        }
    }
}
