using MXGP.Models.Motorcycles.Contracts;
using MXGP.Models.Riders.Contracts;
using MXGP.Utilities.Messages;
using System;

namespace MXGP.Models.Riders
{
    public class Rider : IRider
    {
        private string name;
        private bool canParticipate;

        public Rider(string name)
        {
            this.Name = name;

            this.canParticipate = false;
        }

        public string Name 
        {
            get => this.name;

            private set
            {
                if(string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName, value, 5));
                }

                this.name = value;
            }
        }

        public IMotorcycle Motorcycle { get; private set; }

        public int NumberOfWins { get; private set; }

        public bool CanParticipate => this.canParticipate;

        public void AddMotorcycle(IMotorcycle motorcycle)
        {
            if (motorcycle == null)
            {
                throw new ArgumentNullException(ExceptionMessages.MotorcycleInvalid);
            }

            this.Motorcycle = motorcycle;
            this.canParticipate = true;
        }

        public void WinRace()
        {
            this.NumberOfWins++;
        }
    }
}
