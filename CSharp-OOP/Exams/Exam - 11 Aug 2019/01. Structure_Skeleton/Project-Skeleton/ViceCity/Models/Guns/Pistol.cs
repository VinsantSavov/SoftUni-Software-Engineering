namespace ViceCity.Models.Guns
{
    public class Pistol : Gun
    {
        private const int BULLETS_PER_BARREL = 10;
        private const int TOTAL_BULLETS = 100;

        public Pistol(string name)
            : base(name, BULLETS_PER_BARREL, TOTAL_BULLETS)
        {
        }

        public override int Fire()
        {
            if(this.BulletsPerBarrel > 0)
            {
                this.BulletsPerBarrel--;
            }
            else
            {
                if(this.TotalBullets > 0 && this.TotalBullets >= 10)
                {
                    this.TotalBullets -= 10;
                    this.BulletsPerBarrel += 10;
                }
                else if(this.TotalBullets > 0)
                {
                    this.BulletsPerBarrel += this.TotalBullets;
                    this.TotalBullets = 0;
                }

                this.BulletsPerBarrel--;
            }

            return 1;
        }
    }
}
