
namespace P08.CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int? displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }
        public Engine(string model,int power, int? displacement, string efficiency)
            :this(model,power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
        public Engine(string model, int power, int? displacement)
            :this(model, power)
        {
            this.Displacement = displacement;
        }
        public Engine(string model, int power, string efficiency)
            : this(model, power)
        {
            this.Efficiency = efficiency;
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

        public int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
            }
        }

        public int? Displacement
        {
            get
            {
                return this.displacement;
            }
            set
            {
                this.displacement = value;
            }
        }

        public string Efficiency
        {
            get
            {
                return this.efficiency;
            }
            set
            {
                this.efficiency = value;
            }
        }

        public override string ToString()
        {
            string returned = string.Empty;

            if (displacement != null && efficiency != null)
            {
                returned = $" {Model}:\n    Power: {Power}\n    Displacement: {displacement}\n    Efficiency: {efficiency}";
            }
            else if(displacement != null)
            {
                returned = $" {Model}:\n    Power: {Power}\n    Displacement: {displacement}\n    Efficiency: n/a";
            }
            else if(efficiency != null)
            {
                returned = $" {Model}:\n    Power: {Power}\n    Displacement: n/a\n    Efficiency: {efficiency}";
            }
            else
            {
                returned = $" {Model}:\n    Power: {Power}\n    Displacement: n/a\n    Efficiency: n/a";
            }
            return returned;
        }
    }
}
