using P07.MilitaryElite.Contracts;
using P07.MilitaryElite.Enumerations;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private readonly List<IMission> missions;

        public Commando(int id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.missions = new List<IMission>();
        }

        public IReadOnlyCollection<IMission> Missions 
        {
            get
            {
                return this.missions;
            }
        }

        public void AddMission(IMission mission)
        {
            this.missions.Add(mission);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {this.Corps}");
            sb.AppendLine("Missions:");

            foreach (var mission in this.missions)
            {
                sb.AppendLine(mission.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
