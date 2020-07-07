using MortalEngines.Entities.Contracts;
using System.Text;

namespace MortalEngines.Entities
{
    public class Tank : BaseMachine, ITank
    {
        private const double INITIAL_HEALTH_POINTS = 100;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints - 40, defensePoints + 30, INITIAL_HEALTH_POINTS)
        {
            this.DefenseMode = true;
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if(this.DefenseMode == true)
            {
                this.DefenseMode = false;
                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
            else
            {
                this.DefenseMode = true;
                this.AttackPoints -= 40;
                this.DefensePoints += 30;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            string mode = this.DefenseMode == true ?"ON" : "OFF";

            sb.AppendLine(base.ToString());
            sb.AppendLine($" *Defense: {mode}");

            return sb.ToString().TrimEnd();
        }
    }
}
