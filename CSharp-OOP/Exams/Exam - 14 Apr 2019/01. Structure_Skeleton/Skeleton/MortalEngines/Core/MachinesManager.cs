namespace MortalEngines.Core
{
    using Contracts;
    using MortalEngines.Common;
    using MortalEngines.Entities;
    using MortalEngines.Entities.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class MachinesManager : IMachinesManager
    {
        private List<IPilot> pilots;
        private List<IMachine> machines;

        public MachinesManager()
        {
            this.pilots = new List<IPilot>();
            this.machines = new List<IMachine>();
        }

        public string HirePilot(string name)
        {
            if(this.pilots.Any(p => p.Name == name))
            {
                return string.Format(OutputMessages.PilotExists, name);
            }

            IPilot pilot = new Pilot(name);
            this.pilots.Add(pilot);

            return string.Format(OutputMessages.PilotHired, name);
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            //Type
            if(this.machines.Any(m => m.Name == name && m.GetType().Name == nameof(Tank)))
            {
                return string.Format(OutputMessages.MachineExists, name);
            }

            IMachine machine = new Tank(name, attackPoints, defensePoints);

            this.machines.Add(machine);
            return string.Format(OutputMessages.TankManufactured, name, machine.AttackPoints, machine.DefensePoints);
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            if(this.machines.Any(m => m.Name == name && m.GetType().Name == nameof(Fighter)))
            {
                return string.Format(OutputMessages.MachineExists, name);
            }

            IMachine fighter = new Fighter(name, attackPoints, defensePoints);

            this.machines.Add(fighter);

            return string.Format(OutputMessages.FighterManufactured, name, fighter.AttackPoints, fighter.DefensePoints, "ON");
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            IPilot pilot = this.pilots.FirstOrDefault(p => p.Name == selectedPilotName);
            IMachine machine = this.machines.FirstOrDefault(m => m.Name == selectedMachineName);

            if(pilot == null)
            {
                return string.Format(OutputMessages.PilotNotFound, selectedPilotName);
            }

            if(machine == null)
            {
                return string.Format(OutputMessages.MachineNotFound, selectedMachineName);
            }

            if(machine.Pilot != null)
            {
                return string.Format(OutputMessages.MachineHasPilotAlready, selectedMachineName);
            }

            pilot.AddMachine(machine);
            machine.Pilot = pilot;

            return string.Format(OutputMessages.MachineEngaged, selectedPilotName, selectedMachineName);
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            IMachine attacking = this.machines.FirstOrDefault(m => m.Name == attackingMachineName);
            IMachine defending = this.machines.FirstOrDefault(m => m.Name == defendingMachineName);

            if(attacking == null)
            {
                return string.Format(OutputMessages.MachineNotFound, attackingMachineName);
            }

            if(defending == null)
            {
                return string.Format(OutputMessages.MachineNotFound, defendingMachineName);
            }

            if(attacking.HealthPoints == 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, attackingMachineName);
            }

            if (defending.HealthPoints == 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, defendingMachineName);
            }

            attacking.Attack(defending);

            return string.Format(OutputMessages.AttackSuccessful, defendingMachineName, attackingMachineName,
                defending.HealthPoints);
        }

        public string PilotReport(string pilotReporting)
        {
            IPilot pilot = this.pilots.First(p => p.Name == pilotReporting);

            return pilot.Report();
        }

        public string MachineReport(string machineName)
        {
            IMachine machine = this.machines.First(m => m.Name == machineName);

            return machine.ToString();
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            IFighter fighter = (IFighter)this.machines.FirstOrDefault(m => m.Name == fighterName &&
                                                                          m.GetType().Name == nameof(Fighter));

            if(fighter == null)
            {
                return string.Format(OutputMessages.MachineNotFound, fighterName);
            }

            fighter.ToggleAggressiveMode();

            return string.Format(OutputMessages.FighterOperationSuccessful, fighterName);
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            ITank machine = (ITank)this.machines.FirstOrDefault(t => t.Name == tankName &&
                                                                  t.GetType().Name == nameof(Tank));

            if(machine == null)
            {
                return string.Format(OutputMessages.MachineNotFound, tankName);
            }

            machine.ToggleDefenseMode();

            return string.Format(OutputMessages.TankOperationSuccessful, tankName);
        }
    }
}