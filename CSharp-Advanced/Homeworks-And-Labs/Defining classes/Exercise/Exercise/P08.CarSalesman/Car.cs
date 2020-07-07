
namespace P08.CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int? weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }
        public Car(string model, Engine engine, int? weight, string color)
            :this(model, engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }
        public Car(string model, Engine engine, int? weight)
            :this(model,engine)
        {
            this.Weight = weight;
        }
        public Car(string model, Engine engine, string color)
            :this(model, engine)
        {
            this.Color = color;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public Engine Engine
        {
            get
            {
                return this.engine;
            }
            set
            {
                this.engine = value;
            }
        }

        public int? Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public override string ToString()
        {
            string returned = string.Empty;

            if(weight != null && color != null)
            {
                returned = $"{Model}:\n {engine}\n  Weight: {Weight}\n  Color: {Color}";
            }
            else if(weight != null)
            {
                returned = $"{Model}:\n {engine}\n  Weight: {Weight}\n  Color: n/a";
            }
            else if(color != null)
            {
                returned = $"{Model}:\n {engine}\n  Weight: n/a\n  Color: {Color}";
            }
            else
            {
                returned = $"{Model}:\n {engine}\n  Weight: n/a\n  Color: n/a";
            }

            return returned;
        }
    }
}
