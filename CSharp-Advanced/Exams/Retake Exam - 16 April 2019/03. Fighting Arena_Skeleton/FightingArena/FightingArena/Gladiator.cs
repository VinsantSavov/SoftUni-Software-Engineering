using System.Text;

namespace FightingArena
{
    public class Gladiator
    {
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }

        public string Name { get; set; }
        public Stat Stat { get; set; }
        public Weapon Weapon { get; set; }

        public int GetTotalPower()
        {
            int sum = 0;
            sum += Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Skills + Stat.Strength + Weapon.Sharpness
                + Weapon.Size + Weapon.Solidity;

            return sum;

        }

        public int GetWeaponPower()
        {
            int sum = 0;

            sum += Weapon.Sharpness + Weapon.Size + Weapon.Solidity;
            return sum;
        }

        public int GetStatPower()
        {
            int sum = 0;
            sum += Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Skills + Stat.Strength;

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Name} - {this.GetTotalPower()}");
            sb.AppendLine($" Weapon Power: {this.GetWeaponPower()}");
            sb.AppendLine($" Stat Power: {this.GetStatPower()}");

            return sb.ToString().TrimEnd();
        }
    }
}
