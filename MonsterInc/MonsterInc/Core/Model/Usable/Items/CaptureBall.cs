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
            ////var monsterPlayerEnergy = player.ActiveTrainer.ActiveMonster.Caracteristics.First(x => x.Type == MonsterTemplateCaracteristicType.EnergyPoints);
            var monsterOpponentEnergy = opponent.ActiveTrainer.ActiveMonster.Caracteristics.First(x => x.Type == MonsterTemplateCaracteristicType.EnergyPoints);
            bool success = false;
            var scope = (EffectScope)this.Scopes.First();

            ////   67%                                                ( 600     /    900  ) *100
            int energyPercent = Convert.ToInt16((monsterOpponentEnergy.Actual / monsterOpponentEnergy.Total) * 100);//
            double captureBallPercent = scope.Magnitude;// metton 50%; (0.5)
            ////33% de poid
            var inverseEnergyPercent = 100 - energyPercent;

            ////16.5 =33 / 0.5
            var chance = inverseEnergyPercent * captureBallPercent;

            Random rnd = new Random();
            int random = rnd.Next(1, 100); // creates a number between 1 and 99
            if (random <= chance) success = true;

            if (success && opponent.Type == PlayerType.Human && opponent.ActiveTrainer.ActiveMonsters.Count == 1)
                success = false;


            if (success)
            {
                Monster monster = opponent.ActiveTrainer.ActiveMonster;
                //monster.NickName = monster.Template.Name;
                player.ActiveTrainer.Monsters.Add(monster);
                if (opponent.ActiveTrainer.ActiveMonsters.Count == 1)
                {
                    opponent.ActiveTrainer.ActiveMonster.Caracteristics[0].Actual = 0;
                }
                else if (opponent.ActiveTrainer.ActiveMonsters.Count > 1)
                {
                    opponent.ActiveTrainer.ActiveMonsters.Remove(opponent.ActiveTrainer.ActiveMonster);
                    opponent.ActiveTrainer.ActiveMonster = opponent.ActiveTrainer.ActiveMonsters[0];
                }
            }
            this.InventoryDeduction(player);

        }
    }
}
