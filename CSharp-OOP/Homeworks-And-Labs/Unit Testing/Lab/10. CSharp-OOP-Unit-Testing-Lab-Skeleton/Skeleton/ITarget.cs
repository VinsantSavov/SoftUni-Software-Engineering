﻿namespace Skeleton
{
    public interface ITarget
    {
        void TakeAttack(int attackPoints);
        int GiveExperience();
        bool IsDead();
    }
}
