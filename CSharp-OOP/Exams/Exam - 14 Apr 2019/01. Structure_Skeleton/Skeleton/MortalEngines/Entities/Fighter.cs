using MortalEngines.Entities.Contracts;
using System.Text;

namespace MortalEngines.Entities
{
    public class Fighter : BaseMachine, IFighter
    {
        private const double INITIAL_HEALTH_POINTS = 200;

        public Fighter(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints + 50, defensePoints - 25, INITIAL_HEALTH_POINTS)
        {
            this.AggressiveMode = true;
        }

        public bool AggressiveMode { get; private set; }

        public void ToggleAggressiveMode()
        {
            if(this.AggressiveMode == true)
            {
                this.AggressiveMode = false;
                this.AttackPoints -= 50;
                this.DefensePoints += 25;
            }
            else
            {
                this.AggressiveMode = true;
                this.AttackPoints += 50;
                this.DefensePoints -= 25;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string agressive = this.AggressiveMode == true ? "ON" : "OFF";

            sb.AppendLine(base.ToString());
            sb.AppendLine($" *Aggressive: {agressive}");

            return sb.ToString().TrimEnd();
        }
    }
}
