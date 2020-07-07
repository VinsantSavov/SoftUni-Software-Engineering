using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AquariumAdventure
{
    public class Aquarium
    {
        private List<Fish> fishInPool;

        public Aquarium(string name, int capacity, int size)
        {
            this.fishInPool = new List<Fish>();
            this.Name = name;
            this.Capacity = capacity;
            this.Size = size;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Size { get; set; }


        public void Add(Fish fish)
        {
            bool unique = this.fishInPool.Any(f => f.Name == fish.Name);

            if(this.fishInPool.Count < this.Capacity && unique == false)
            {
                this.fishInPool.Add(fish);
            }
        }

        public bool Remove(string name)
        {
            Fish fishToRemove = null;

            fishToRemove = this.fishInPool.FirstOrDefault(f => f.Name == name);

            if(fishToRemove != null)
            {
                this.fishInPool.Remove(fishToRemove);
                return true;
            }

            return false;
        }

        public Fish FindFish(string name)
        {
            Fish fish = null;

            fish = this.fishInPool.FirstOrDefault(f => f.Name == name);

            return fish;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Aquarium: {this.Name} ^ Size: {this.Size}");

            foreach (var fish in this.fishInPool)
            {
                sb.AppendLine(fish.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
