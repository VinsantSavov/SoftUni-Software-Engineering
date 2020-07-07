using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    public class Bag
    {
        private HashSet<Present> presents;

        public Bag(string color, int capacity)
        {
            this.presents = new HashSet<Present>();
            this.Color = color;
            this.Capacity = capacity;

        }

        public string Color { get; set; }
        public int Capacity { get; set; }

        public int Count 
        {
            get
            {
                return presents.Count;
            }
        }


        public void Add(Present present)
        {

            if (presents.Count < this.Capacity)
            {
                this.presents.Add(present);
            }
        }

        public bool Remove(string name)
        {
            Present presentToRemove = null;

            presentToRemove = presents.FirstOrDefault(p => p.Name == name);
            
            if (presentToRemove != null)
            {
                presents.Remove(presentToRemove);
                return true;
            }

            return false;
        }

        public Present GetHeaviestPresent()
        {
            List<Present> temp = presents.OrderByDescending(n => n.Weight).ToList();
            Present heaviestPresent = temp.First();

            return heaviestPresent;
        }

        public Present GetPresent(string name)
        {
            Present wantedPresent = null;

            wantedPresent = presents.FirstOrDefault(p => p.Name == name);

            return wantedPresent;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} bag contains:");

            foreach (var item in presents)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
