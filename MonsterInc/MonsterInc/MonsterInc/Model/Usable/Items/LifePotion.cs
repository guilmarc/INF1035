using System;
using System.Linq;

namespace Core.Model
{

    /// <summary>
    /// Item qui ajoute des points de vie
    /// </summary>
    [Serializable]
    public class LifePotion : Item
	{
        public override void Consume(Player player, Player opponent)
        {

            var carac = player.ActiveTrainer.ActiveMonster.Caracteristics.Where(c => c.Type == MonsterTemplateCaracteristicType.LifePoints).Single();

            if (carac.Actual > 0)
            {
                EffectScope scope = this.Scopes.OfType<EffectScope>().First();

                //monstre a 100 de vie et une potion qui heal de 15% (0.15) = + 15pv
                double lifeAdded = carac.Total * scope.Magnitude;
                int roundedLifeAdded = (int)lifeAdded;


                carac.Actual = carac.Actual + roundedLifeAdded;

                this.InventoryDeduction(player);
            }


        }
    }

}