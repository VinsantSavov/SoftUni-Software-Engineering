using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using SantaWorkshop.Repositories;
using SantaWorkshop.Models.Dwarfs;
using SantaWorkshop.Core.Contracts;
using SantaWorkshop.Models.Presents;
using SantaWorkshop.Models.Workshops;
using SantaWorkshop.Utilities.Messages;
using SantaWorkshop.Models.Instruments;
using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Models.Workshops.Contracts;
using SantaWorkshop.Models.Instruments.Contracts;

namespace SantaWorkshop.Core
{
    public class Controller : IController
    {
        private DwarfRepository dwarfs;
        private PresentRepository presents;

        public Controller()
        {
            this.dwarfs = new DwarfRepository();
            this.presents = new PresentRepository();
        }
        public string AddDwarf(string dwarfType, string dwarfName)
        {
            IDwarf dwarf = null;
            if(dwarfType == "HappyDwarf")
            {
                dwarf = new HappyDwarf(dwarfName);
            }
            else if(dwarfType == "SleepyDwarf")
            {
                dwarf = new SleepyDwarf(dwarfName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDwarfType);
            }

            this.dwarfs.Add(dwarf);
            return $"Successfully added {dwarfType} named {dwarfName}.";
        }

        public string AddInstrumentToDwarf(string dwarfName, int power)
        {
            IInstrument instrument = new Instrument(power);

            IDwarf dwarf = this.dwarfs.FindByName(dwarfName);

            if(dwarf == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InexistentDwarf);
            }

            dwarf.AddInstrument(instrument);
            return $"Successfully added instrument with power {power} to dwarf {dwarfName}!";
        }

        public string AddPresent(string presentName, int energyRequired)
        {
            IPresent present = new Present(presentName, energyRequired);

            this.presents.Add(present);
            return $"Successfully added Present: {presentName}!";
        }

        public string CraftPresent(string presentName)
        {
            IWorkshop workshop = new Workshop();
            IPresent present = this.presents.FindByName(presentName);
            var readyDwarfs = this.dwarfs.Models.Where(d => d.Energy >= 50).OrderByDescending(a => a.Energy).ToList();

            if(readyDwarfs.Count > 0)
            {
                for (int i = 0; i < readyDwarfs.Count;)
                {
                    workshop.Craft(present, readyDwarfs[i]);

                    if (readyDwarfs[i].Energy == 0)
                    {
                        this.dwarfs.Remove(readyDwarfs[i]);
                        i++;
                    }
                    if (present.IsDone())
                    {
                        break;
                    }
                    if(!present.IsDone() || readyDwarfs[i].Instruments.Count == 0)
                    {
                        i++;
                    }
                }
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.DwarfsNotReady);
            }

            if (present.IsDone())
            {
                return $"Present {presentName} is done.";
            }
            else
            {
                return $"Present {presentName} is not done.";
            }
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            int createdPresentsCount = this.presents.Models.Count(p => p.IsDone());

            sb.AppendLine($"{createdPresentsCount} presents are done!");
            sb.AppendLine("Dwarfs info:");

            foreach (var dwarf in this.dwarfs.Models)
            {
                int instNotBroken = dwarf.Instruments.Count(i => !i.IsBroken());
                
                sb
                    .AppendLine($"Name: {dwarf.Name}")
                    .AppendLine($"Energy: {dwarf.Energy}")
                    .AppendLine($"Instruments: {instNotBroken} not broken left");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
