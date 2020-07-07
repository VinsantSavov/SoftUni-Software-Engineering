using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using AquaShop.Models.Fish;
using AquaShop.Repositories;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Decorations;
using AquaShop.Utilities.Messages;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;

namespace AquaShop.Core.Contracts
{
    public class Controller : IController
    {
        private DecorationRepository decorationRepository;
        private readonly List<IAquarium> aquariums;

        public Controller()
        {
            this.decorationRepository = new DecorationRepository();
            this.aquariums = new List<IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium aquarium;

            if (aquariumType == "FreshwaterAquarium")
            {
                aquarium = new FreshwaterAquarium(aquariumName);
            }
            else if(aquariumType == "SaltwaterAquarium")
            {
                aquarium = new SaltwaterAquarium(aquariumName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }

            this.aquariums.Add(aquarium);

            return String.Format(OutputMessages.SuccessfullyAdded, aquariumType);
        }

        public string AddDecoration(string decorationType)
        {
            IDecoration decoration;

            if(decorationType == "Ornament")
            {
                decoration = new Ornament();
            }
            else if (decorationType == "Plant")
            {
                decoration = new Plant();
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }

            this.decorationRepository.Add(decoration);

            return String.Format(OutputMessages.SuccessfullyAdded, decorationType);
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            IAquarium aquarium = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);
            IFish fish;

            if(fishType == "FreshwaterFish")
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price);
            }
            else if(fishType == "SaltwaterFish")
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }

            if(aquarium.GetType().Name == "FreshwaterAquarium" && fishType == "FreshwaterFish" 
                || aquarium.GetType().Name == "SaltwaterAquarium" && fishType == "SaltwaterFish")
            {
                aquarium.AddFish(fish);
                return String.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName);
            }
            else
            {
                return OutputMessages.UnsuitableWater;
            }
        }

        public string CalculateValue(string aquariumName)
        {
            decimal value = 0;
            IAquarium aquarium = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);

            value += aquarium.Decorations.Sum(d => d.Price);
            value += aquarium.Fish.Sum(f => f.Price);

            return String.Format(OutputMessages.AquariumValue, aquariumName, value);
        }

        public string FeedFish(string aquariumName)
        {
            IAquarium aquarium = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);

            aquarium.Feed();

            return String.Format(OutputMessages.FishFed, aquarium.Fish.Count);
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            IAquarium aquarium = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);
            IDecoration decoration = this.decorationRepository.FindByType(decorationType);

            if (decoration == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.InexistentDecoration, decorationType));
            }

            aquarium.AddDecoration(decoration);
            this.decorationRepository.Remove(decoration);

            return String.Format(OutputMessages.EntityAddedToAquarium, decorationType, aquariumName);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var aquarium in this.aquariums)
            {
                sb.AppendLine(aquarium.GetInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
