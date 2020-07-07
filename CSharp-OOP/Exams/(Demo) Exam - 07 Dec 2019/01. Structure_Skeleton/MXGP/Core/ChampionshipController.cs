using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using MXGP.Models.Races;
using MXGP.Repositories;
using MXGP.Models.Riders;
using MXGP.Core.Contracts;
using MXGP.Models.Motorcycles;
using MXGP.Utilities.Messages;
using MXGP.Repositories.Contracts;
using MXGP.Models.Races.Contracts;
using MXGP.Models.Riders.Contracts;
using MXGP.Models.Motorcycles.Contracts;

namespace MXGP.Core
{
    public class ChampionshipController : IChampionshipController
    {
        private IRepository<IMotorcycle> motorcycleRepository;
        private IRepository<IRace> raceRepository;
        private IRepository<IRider> riderRepository;

        public ChampionshipController()
        {
            this.motorcycleRepository = new MotorcycleRepository();
            this.raceRepository = new RaceRepository();
            this.riderRepository = new RiderRepository();
        }

        public string AddMotorcycleToRider(string riderName, string motorcycleModel)
        {
            IRider rider = this.riderRepository.GetByName(riderName);
            IMotorcycle motorcycle = this.motorcycleRepository.GetByName(motorcycleModel);

            if(rider == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RiderNotFound, riderName));
            }

            if(motorcycle == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.MotorcycleNotFound, motorcycleModel));
            }

            rider.AddMotorcycle(motorcycle);

            return string.Format(OutputMessages.MotorcycleAdded, riderName, motorcycleModel);
        }

        public string AddRiderToRace(string raceName, string riderName)
        {
            IRider rider = this.riderRepository.GetByName(riderName);
            IRace race = this.raceRepository.GetByName(raceName);

            if(rider == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RiderNotFound, riderName));
            }

            if(race == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }

            race.AddRider(rider);

            return string.Format(OutputMessages.RiderAdded, riderName, raceName);
        }

        public string CreateMotorcycle(string type, string model, int horsePower)
        {
            IMotorcycle motorcycle;

            if(type == "Speed")
            {
                motorcycle = new SpeedMotorcycle(model, horsePower);
            }
            else
            {
                motorcycle = new PowerMotorcycle(model, horsePower);
            }

            if (this.motorcycleRepository.GetAll().Any(m => m.Model == model))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.MotorcycleExists, model));
            }

            this.motorcycleRepository.Add(motorcycle);

            return string.Format(OutputMessages.MotorcycleCreated, type + "Motorcycle", model);
        }

        public string CreateRace(string name, int laps)
        {
            IRace race = new Race(name, laps);

            if (this.raceRepository.GetAll().Any(r => r.Name == name))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceExists, name));
            }

            this.raceRepository.Add(race);

            return string.Format(OutputMessages.RaceCreated, name);
        }

        public string CreateRider(string riderName)
        {
            IRider rider = new Rider(riderName);

            if (this.riderRepository.GetAll().Any(r => r.Name == riderName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.RiderExists, riderName));
            }

            this.riderRepository.Add(rider);

            return string.Format(OutputMessages.RiderCreated, riderName);
        }

        public string StartRace(string raceName)
        {
            StringBuilder sb = new StringBuilder();
            IRace race = this.raceRepository.GetByName(raceName);
            this.raceRepository.Remove(race);

            if (race == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }

            if(race.Riders.Count < 3)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceInvalid, raceName, 3));
            }

            List<IRider> topThreeRiders = race.Riders.OrderByDescending(r => r.Motorcycle.CalculateRacePoints(race.Laps))
                .ToList();

            sb.AppendLine(string.Format(OutputMessages.RiderFirstPosition, topThreeRiders[0].Name, raceName));
            sb.AppendLine(string.Format(OutputMessages.RiderSecondPosition, topThreeRiders[1].Name, raceName));
            sb.AppendLine(string.Format(OutputMessages.RiderThirdPosition, topThreeRiders[2].Name, raceName));
            topThreeRiders[0].WinRace();

            return sb.ToString().TrimEnd();
        }
    }
}
