namespace Skeleton.Tests.Fakes
{
    public class FakeTarget : ITarget
    {
        public int GiveExperience()
        {
            return 20;
        }

        public bool IsDead()
        {
            return true;
        }

        public void TakeAttack(int attackPoints)
        {
            throw new System.NotImplementedException();
        }
    }
}
