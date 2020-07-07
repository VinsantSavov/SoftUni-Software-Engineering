using P07.MilitaryElite.Contracts;
using P07.MilitaryElite.Enumerations;
using P07.MilitaryElite.Exceptions;

namespace P07.MilitaryElite.Models
{
    public class Mission : IMission
    {
        private MissionState state;

        public Mission(string codeName, MissionState state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; private set; }

        public MissionState State
        {
            get
            {
                return this.state;
            }
            private set
            {
                if((int)value == 1 || (int)value == 2)
                {
                    this.state = value;
                }
                else
                {
                    throw new InvalidMissionException();
                }
            }
        }

        public void CompleteMission()
        {
            this.state = MissionState.Finished;
        }

        public override string ToString()
        {
            return $"  Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
