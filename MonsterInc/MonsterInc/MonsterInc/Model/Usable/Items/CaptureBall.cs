using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    /// <summary>
    /// Permet de capturer un monstre
    /// </summary>
    [Serializable]
    public class CaptureBall : Item
    {
        public override void Consume(Player player, Player opponent)
        {
            //var monsterPlayerEnergy = player.ActiveTrainer.ActiveMonster.Caracteristics.First(x => x.Type == MonsterTemplateCaracteristicType.EnergyPoints);
            var monsterOpponentEnergy = opponent.ActiveTrainer.ActiveMonster.Caracteristics.First(x => x.Type == MonsterTemplateCaracteristicType.EnergyPoints);

            var scope = (EffectScope)this.Scopes.First();

            //   67%                                                ( 600     /    900  ) *100
            int energyPercent = Convert.ToInt16((monsterOpponentEnergy.Actual / monsterOpponentEnergy.Total)*100);//
            double captureBallPercent = scope.Magnitude;// metton 50%; (0.5)
            //33% de poid
            var inverseEnergyPercent = 100 - energyPercent;

            //16.5 =33 / 0.5
            var chance = inverseEnergyPercent / captureBallPercent;

            Random rnd = new Random();
            int random = rnd.Next(1, 100); // creates a number between 1 and 99
            if (random <= chance)
            {
                player.ActiveTrainer.Monsters.Add(opponent.ActiveTrainer.ActiveMonster);
            }

        }
    }
}
