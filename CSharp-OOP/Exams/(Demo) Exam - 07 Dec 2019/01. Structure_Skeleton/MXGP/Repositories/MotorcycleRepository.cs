using System.Linq;
using System.Collections.Generic;
using MXGP.Repositories.Contracts;
using MXGP.Models.Motorcycles.Contracts;

namespace MXGP.Repositories
{
    public class MotorcycleRepository : Repository<IMotorcycle>
    {
        public MotorcycleRepository()
        {
        }

        public override IMotorcycle GetByName(string name)
        {
            List<IMotorcycle> motorcycles = this.GetAll().ToList();

            IMotorcycle motorcycle = motorcycles.FirstOrDefault(m => m.Model == name);

            return motorcycle;
        }
    }
}
