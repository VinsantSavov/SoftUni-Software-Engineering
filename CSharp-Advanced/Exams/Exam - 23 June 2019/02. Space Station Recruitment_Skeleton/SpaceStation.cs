using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private readonly List<Astronaut> data;

        private SpaceStation()
        {
            this.data = new List<Astronaut>();
        }

        public SpaceStation(string name, int capacity)
            :this()
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(Astronaut astronaut)
        {
            if(this.data.Count < this.Capacity)
            {
                this.data.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            Astronaut astronautToRemove = this.data.FirstOrDefault(a => a.Name == name);

            if(astronautToRemove != null)
            {
                this.data.Remove(astronautToRemove);
                return true;
            }

            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            Astronaut oldestAstronaut = null;
            int age = 0;

            foreach (var astr in this.data)
            {
                if(astr.Age > age)
                {
                    oldestAstronaut = astr;
                    age = astr.Age;
                }
            }

            return oldestAstronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut astronaut = this.data.FirstOrDefault(a => a.Name == name);

            return astronaut;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Astronauts working at Space Station {this.Name}:");

            foreach (var astr in this.data)
            {
                sb.AppendLine(astr.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
