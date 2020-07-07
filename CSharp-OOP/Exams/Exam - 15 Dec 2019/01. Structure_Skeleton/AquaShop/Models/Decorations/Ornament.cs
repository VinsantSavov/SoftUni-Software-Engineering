namespace AquaShop.Models.Decorations
{
    public class Ornament : Decoration
    {
        public const int COMFORT = 1;
        public const decimal PRICE = 5;

        public Ornament()
            : base(COMFORT, PRICE)
        {
        }
    }
}
