using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission;
using SpaceStation.Models.Planets;
using SpaceStation.Repositories;
using SpaceStation.Repositories.Contracts;
using SpaceStation.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        private IRepository<IAstronaut> astronautRepository;
        private IRepository<IPlanet> planetRepository;
        private int exploredPlanets = 0;

        public Controller()
        {
            this.astronautRepository = new AstronautRepository();
            this.planetRepository = new PlanetRepository();
        }

        public string AddAstronaut(string type, string astronautName)
        {
            IAstronaut astronaut;

            if(type == "Biologist")
            {
                astronaut = new Biologist(astronautName);
            }
            else if(type == "Geodesist")
            {
                astronaut = new Geodesist(astronautName);
            }
            else if(type == "Meteorologist")
            {
                astronaut = new Meteorologist(astronautName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautType);
            }

            this.astronautRepository.Add(astronaut);

            return string.Format(OutputMessages.AstronautAdded, type, astronautName);
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            IPlanet planet = new Planet(planetName);

            foreach (var item in items)
            {
                planet.Items.Add(item);
            }

            this.planetRepository.Add(planet);

            return string.Format(OutputMessages.PlanetAdded, planetName);
        }

        public string ExplorePlanet(string planetName)
        {
            List<IAstronaut> astronauts = this.astronautRepository.Models
                .Where(a => a.Oxygen >= 60)
                .ToList();

            IPlanet planet = this.planetRepository.FindByName(planetName);
            IMission mission = new Mission();

            if(planetName == "Jupiter")
            {
                ;
            } 

            if(astronauts.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautCount);
            }

            mission.Explore(planet, astronauts);

            this.exploredPlanets++;

            return string.Format(OutputMessages.PlanetExplored, planetName, astronauts.Count(a => !a.CanBreath));
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.exploredPlanets} planets were explored!");
            sb.AppendLine("Astronauts info:");

            foreach (var astronaut in this.astronautRepository.Models)
            {
                sb.AppendLine($"Name: {astronaut.Name}");
                sb.AppendLine($"Oxygen: {astronaut.Oxygen}");

                if (astronaut.Bag.Items.Count == 0)
                {
                    sb.AppendLine($"Bag items: none");
                }
                else
                {
                    sb.Append($"Bag items: ");

                    sb.AppendLine(string.Join(", ", astronaut.Bag.Items));
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string RetireAstronaut(string astronautName)
        {
            IAstronaut astronautToRetire = this.astronautRepository.FindByName(astronautName);

            if(astronautToRetire == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidRetiredAstronaut, astronautName));
            }

            this.astronautRepository.Remove(astronautToRetire);

            return string.Format(OutputMessages.AstronautRetired, astronautName);
        }
    }
}
