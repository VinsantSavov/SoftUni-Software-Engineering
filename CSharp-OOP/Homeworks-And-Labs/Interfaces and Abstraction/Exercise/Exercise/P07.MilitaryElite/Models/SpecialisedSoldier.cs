using P07.MilitaryElite.Contracts;
using P07.MilitaryElite.Enumerations;
using P07.MilitaryElite.Exceptions;

namespace P07.MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private Corps corps;

        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public Corps Corps 
        {
            get
            {
                return this.corps;
            }
            private set
            {
                if((int)value == 1 || (int)value == 2)
                {
                    this.corps = value;
                }
                else
                {
                    throw new InvalidCorpsException();
                }
            }
        }
    }
}
