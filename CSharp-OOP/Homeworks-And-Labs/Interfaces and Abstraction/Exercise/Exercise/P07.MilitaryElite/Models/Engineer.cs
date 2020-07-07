using P07.MilitaryElite.Contracts;
using P07.MilitaryElite.Enumerations;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private readonly List<IRepair> repairs;

        public Engineer(int id, string firstName, string lastName, decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = new List<IRepair>();
        }

        public IReadOnlyCollection<IRepair> Repairs
        {
            get
            {
                return this.repairs;
            }
        }

        public void AddRepair(IRepair repair)
        {
            this.repairs.Add(repair);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {this.Corps}");
            sb.AppendLine("Repairs:");

            foreach (var repair in this.repairs)
            {
                sb.AppendLine(repair.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
