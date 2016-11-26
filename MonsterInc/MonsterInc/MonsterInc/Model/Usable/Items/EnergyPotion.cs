using System;
using System.Linq;

namespace Core.Model
{
    /// <summary>
    /// Remonte les points d'énergie du monstre
    /// </summary>
    public class EnergyPotion : Item
    {
          public override void Consume(Player player, Player opponent)
        {
            var carac = player.ActiveTrainer.ActiveMonster.Caracteristics.First(x => x.Type == MonsterTemplateCaracteristicType.EnergyPoints);
            var scope =  (EffectScope)this.Scopes.First();
            double  energyAdded = carac.Total * scope.Magnitude ;
            int roundedEnergyAdded = (int)energyAdded;
            carac.Actual = carac.Actual +  int.Parse(roundedEnergyAdded.ToString());

            this.InventoryDeduction(player);
        }
    }
}