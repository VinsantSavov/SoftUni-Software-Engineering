using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Planets;
using System.Collections.Generic;
using System.Linq;

namespace SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            foreach (var astronaut in astronauts)
            {
                while (astronaut.CanBreath && planet.Items.Count > 0)
                {
                    string item = planet.Items.ToList()[0];
                    astronaut.Bag.Items.Add(item);
                    planet.Items.Remove(item);
                    astronaut.Breath();
                }

                if(planet.Items.Count == 0)
                {
                    break;
                }
            }
        }
    }
}
