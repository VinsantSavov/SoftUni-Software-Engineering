using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private readonly List<Rabbit> data;

        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Rabbit>();
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



        public void Add(Rabbit rabbit)
        {
            if(this.data.Count+1 <= this.Capacity) //&& !rabbits.Exists(r => r.Name == rabbit.Name)
            {
                this.data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            //Rabbit rabbitToRemove = null;

            //foreach (var rabbit in data)
            //{
            //    if(rabbit.Name == name)
            //    {
            //        rabbitToRemove = rabbit;
            //        break;
            //    }
            //}

            //if(rabbitToRemove != null)
            //{
            //    data.Remove(rabbitToRemove);
            //    return true;
            //}

            //return false;

            Rabbit rabbit = this.data.FirstOrDefault(r => r.Name == name);

            if(rabbit != null)
            {
                this.data.Remove(rabbit);
                return true;
            }

            return false;
        }

        public void RemoveSpecies(string species)
        {
            // this.data = data.Where(r => r.Species != species).ToList();
            this.data.RemoveAll(r => r.Species == species);
        }

        public Rabbit SellRabbit(string name)
        {
            //Rabbit rabbitToSell = null;

            //foreach (var rabbit in data)
            //{
            //    if(rabbit.Name == name)
            //    {
            //        rabbitToSell = rabbit;
            //        break;
            //    }
            //}

            //if(rabbitToSell != null)
            //{
            //    rabbitToSell.Available = false;
            //}
            //return rabbitToSell;

            Rabbit rabbit = null;

            rabbit = this.data.FirstOrDefault(r => r.Name == name);

            if(rabbit != null)
            {
                rabbit.Available = false;
            }

            return rabbit;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            Rabbit[] rabbitsToSell = data.Where(r => r.Species == species).ToArray();


            foreach (var rabbit in rabbitsToSell)
            {
                rabbit.Available = false;
            }

            return rabbitsToSell;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {this.Name}:");

            foreach (var rabbit in data.Where(r => r.Available == true)) // Where(r=>r.Available == true)
            {
                sb.AppendLine(rabbit.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
