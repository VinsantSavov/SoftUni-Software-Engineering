
namespace P07.RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType,
            double tire1pressure, int tire1Age, double tire2pressure, int tire2Age, double tire3pressure, int tire3Age,
            double tire4pressure, int tire4Age)
        {
            this.Model = model;
            this.engine = new Engine(engineSpeed, enginePower);
            this.cargo = new Cargo(cargoWeight, cargoType);
            this.tires = new Tire[4]
            {
                new Tire(tire1pressure, tire1Age),
                new Tire(tire2pressure, tire2Age),
                new Tire(tire3pressure, tire3Age),
                new Tire(tire4pressure, tire4Age)
            };
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

        public Cargo Cargo
        {
            get
            {
                return this.cargo;
            }
            set
            {
                this.cargo = value;
            }
        }

        public Tire[] Tires
        {
            get
            {
                return this.tires;
            }
            set
            {
                this.tires = value;
            }
        }

        public override string ToString()
        {
            return model;
        }

    }
}
