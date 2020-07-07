using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Instruments.Contracts;
using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Models.Workshops.Contracts;
using System.Linq;

namespace SantaWorkshop.Models.Workshops
{
    public class Workshop : IWorkshop
    {
        public void Craft(IPresent present, IDwarf dwarf)
        {
            var instruments = dwarf.Instruments.ToList();

            while (true)
            {
                if(dwarf.Energy <= 0 || present.IsDone())
                {
                    break;
                }

                if (instruments[0].IsBroken())
                {
                    dwarf.Instruments.Remove(instruments[0]);
                    instruments.RemoveAt(0);

                    if (instruments.Count > 0)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                instruments[0].Use();
                dwarf.Work();
                present.GetCrafted();
            }
        }
    }
}
