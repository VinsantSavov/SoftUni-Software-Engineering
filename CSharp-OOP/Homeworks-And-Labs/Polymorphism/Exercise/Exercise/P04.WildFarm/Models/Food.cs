using P04.WildFarm.Models.Contracts;

namespace P04.WildFarm.Models
{
    public abstract class Food : IFood
    {
        public Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; private set; }
    }
}
