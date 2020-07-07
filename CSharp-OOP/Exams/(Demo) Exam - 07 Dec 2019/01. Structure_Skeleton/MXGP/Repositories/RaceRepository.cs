using MXGP.Models.Races.Contracts;
using System.Linq;

namespace MXGP.Repositories
{
    public class RaceRepository : Repository<IRace>
    {
        public override IRace GetByName(string name)
        {
            IRace race = this.GetAll().FirstOrDefault(r => r.Name == name);

            return race;
        }
    }
}
