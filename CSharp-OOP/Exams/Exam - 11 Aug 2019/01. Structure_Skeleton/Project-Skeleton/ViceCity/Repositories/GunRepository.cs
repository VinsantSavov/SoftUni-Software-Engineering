using System.Collections.Generic;
using System.Linq;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        private List<IGun> guns;

        public GunRepository()
        {
            this.guns = new List<IGun>();
        }

        public IReadOnlyCollection<IGun> Models => this.guns;

        public void Add(IGun model)
        {
            if (!this.guns.Contains(model))
            {
                this.guns.Add(model);
            }
        }

        public IGun Find(string name)
        {
            IGun gun = this.guns.First(g => g.Name == name);

            return gun;
        }

        public bool Remove(IGun model)
        {
            return this.guns.Remove(model);
        }
    }
}
