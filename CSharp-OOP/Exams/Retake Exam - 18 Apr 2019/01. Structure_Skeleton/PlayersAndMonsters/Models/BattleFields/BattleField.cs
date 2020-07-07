using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Cards.Contracts;
using PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Linq;

namespace PlayersAndMonsters.Models.BattleFields
{
    public class BattleField : IBattleField
    {
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if(attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            if(attackPlayer.GetType().Name == "Beginner")
            {
                attackPlayer.Health += 40;

                foreach (var card in attackPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
            }

            if (enemyPlayer.GetType().Name == "Beginner")
            {
                enemyPlayer.Health += 40;

                foreach (var card in enemyPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
            }

            attackPlayer.Health += attackPlayer.CardRepository.Cards.Sum(c => c.HealthPoints);
            enemyPlayer.Health += enemyPlayer.CardRepository.Cards.Sum(c => c.HealthPoints);

            while(!attackPlayer.IsDead && !enemyPlayer.IsDead)
            {
                /* if(this.attackcounter == attackPlayer.CardRepository.Cards.Count)
                 {
                     this.attackcounter = 0;
                 }

                 ICard card = attackPlayer.CardRepository.Cards.ToList()[this.attackcounter];

                 enemyPlayer.TakeDamage(card.DamagePoints);
                 this.attackcounter++;

                 if (!enemyPlayer.IsDead)
                 {
                     if(this.enemycounter == enemyPlayer.CardRepository.Cards.Count)
                     {
                         this.enemycounter = 0;
                     }

                     ICard enemyCard = enemyPlayer.CardRepository.Cards.ToList()[this.enemycounter];

                     attackPlayer.TakeDamage(enemyCard.DamagePoints);
                     this.enemycounter++;
                 }*/
                enemyPlayer.TakeDamage(attackPlayer.CardRepository.Cards.Sum(c => c.DamagePoints));

                if (enemyPlayer.IsDead)
                {
                    break;
                }

                attackPlayer.TakeDamage(enemyPlayer.CardRepository.Cards.Sum(c => c.DamagePoints));
            }
        }
    }
}
