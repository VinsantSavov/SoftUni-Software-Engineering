using System.Linq;
using System.Collections.Generic;
using SantaWorkshop.Repositories.Contracts;
using SantaWorkshop.Models.Dwarfs.Contracts;

namespace SantaWorkshop.Repositories
{
    public class DwarfRepository : IRepository<IDwarf>
    {
        private readonly List<IDwarf> dwarfs;

        public IReadOnlyCollection<IDwarf> Models => this.dwarfs;

        public DwarfRepository()
        {
            dwarfs = new List<IDwarf>();
        }

        public void Add(IDwarf dwarf)
        {
            this.dwarfs.Add(dwarf);
        }

        public bool Remove(IDwarf dwarf)
        {
            return this.dwarfs.Remove(dwarf);
        }

        public IDwarf FindByName(string name)
        {
            IDwarf dwarf = this.dwarfs.FirstOrDefault(d => d.Name == name);

            return dwarf;
        }
    }
}
