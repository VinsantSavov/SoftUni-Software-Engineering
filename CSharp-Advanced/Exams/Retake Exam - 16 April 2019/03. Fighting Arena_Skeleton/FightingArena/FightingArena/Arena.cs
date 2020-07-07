using System.Linq;
using System.Collections.Generic;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;

        public Arena(string name)
        {
            this.Name = name;
            gladiators = new List<Gladiator>();
        }

        public string Name { get; set; }

        public int Count
        {
            get
            {
                return gladiators.Count;
            }
        }

        public void Add(Gladiator gladiator)
        {
           this.gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            Gladiator gladiatorToRemove = null;

            gladiatorToRemove = this.gladiators.FirstOrDefault(g => g.Name == name);

            if(gladiatorToRemove != null)
            {
                gladiators.Remove(gladiatorToRemove);
            }
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            int max = 0;
            Gladiator gladiatorMaxStat = null;

            foreach (var gladiator in gladiators)
            {
                if(gladiator.GetStatPower() > max)
                {
                    max = gladiator.GetStatPower();
                    gladiatorMaxStat = gladiator;
                }
            }

            return gladiatorMaxStat;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            int max = 0;
            Gladiator gladiatorMaxWeapon = null;

            foreach (var gladiator in gladiators)
            {
                if (gladiator.GetWeaponPower() > max)
                {
                    max = gladiator.GetWeaponPower();
                    gladiatorMaxWeapon = gladiator;
                }
            }

            return gladiatorMaxWeapon;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            int max = 0;
            Gladiator gladiatorMaxPower = null;

            foreach (var gladiator in gladiators)
            {
                if (gladiator.GetTotalPower() > max)
                {
                    max = gladiator.GetTotalPower();
                    gladiatorMaxPower = gladiator;
                }
            }

            return gladiatorMaxPower;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Count} gladiators are participating.";
        }
    }
}
