using MXGP.Models.Riders.Contracts;
using System.Linq;

namespace MXGP.Repositories
{
    public class RiderRepository : Repository<IRider>
    {
        public override IRider GetByName(string name)
        {
            IRider rider = this.GetAll().FirstOrDefault(r => r.Name == name);

            return rider;
        }
    }
}
