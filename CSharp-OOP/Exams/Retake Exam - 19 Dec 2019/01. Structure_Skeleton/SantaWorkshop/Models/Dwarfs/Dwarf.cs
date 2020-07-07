using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SantaWorkshop.Utilities.Messages;
using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Instruments.Contracts;

namespace SantaWorkshop.Models.Dwarfs
{
    public abstract class Dwarf : IDwarf
    {
        private string name;
        private int energy;
        private readonly ICollection<IInstrument> instruments;

        public Dwarf(string name, int energy)
        {
            this.Name = name;
            this.Energy = energy;
            this.instruments = new Collection<IInstrument>();
        }
        public string Name 
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidDwarfName);
                }

                this.name = value;
            }
        }

        public int Energy 
        {
            get => this.energy;
            protected set
            {
                if(value < 0)
                {
                    this.energy = 0;
                }
                else
                {
                    this.energy = value;
                }
            }
        }

        public ICollection<IInstrument> Instruments => this.instruments;

        public void AddInstrument(IInstrument instrument)
        {
            this.instruments.Add(instrument);
        }

        public virtual void Work()
        {
            this.Energy -= 10;
        }
    }
}
