namespace ViceCity.Models.Guns
{
    public class Rifle : Gun
    {
        private const int BULLETS_PER_BARREL = 50;
        private const int TOTAL_BULLETS = 500;

        public Rifle(string name)
            : base(name, BULLETS_PER_BARREL, TOTAL_BULLETS)
        {
        }

        public override int Fire()
        {
            if (this.BulletsPerBarrel >= 5)
            {
                this.BulletsPerBarrel -= 5;
            }
            else
            {
                if (this.TotalBullets > 5 && this.TotalBullets >= 50)
                {
                    this.TotalBullets -= 50;
                    this.BulletsPerBarrel += 50;
                }
                else if (this.TotalBullets >= 5)
                {
                    this.BulletsPerBarrel += this.TotalBullets;
                    this.TotalBullets = 0;
                }

                this.BulletsPerBarrel -= 5;
            }

            return 5;
        }
    }
}
