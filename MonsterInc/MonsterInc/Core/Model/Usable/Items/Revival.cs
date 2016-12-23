using System;
using System.Linq;

namespace Core.Model
{
    /// <summary>
    /// Seringue qui redonne la vie à un monstre mort
    /// </summary>
    [Serializable]
    public class Revival : LifePotion
    {

        public override void Consume(Player player, Player opponent)
        {
            
            var carac  = player.ActiveTrainer.ActiveMonster.Caracteristics.First(x => x.Type == MonsterTemplateCaracteristicType.LifePoints);
            carac.Actual = 1;
            base.Consume(player, opponent);


        }
    }
}