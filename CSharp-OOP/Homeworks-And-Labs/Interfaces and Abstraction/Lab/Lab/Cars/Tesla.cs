using System.Text;

namespace Cars
{
    public class Tesla : IElectricCar
    {
        public Tesla(int battery, string model, string color)
        {
            this.Battery = battery;
            this.Model = model;
            this.Color = color;
        }

        public int Battery { get; private set; }

        public string Model { get; private set; }

        public string Color { get; private set; }

        public string Start()
        {
            return "Engine start!";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} Tesla {this.Model} with {this.Battery} Batteries");
            sb.AppendLine(this.Start());
            sb.AppendLine(this.Stop());

            return sb.ToString().TrimEnd();
        }
    }
}
