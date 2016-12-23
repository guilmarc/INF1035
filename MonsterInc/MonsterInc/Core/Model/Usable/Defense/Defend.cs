using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    [Serializable]
    class Defend : Usable
    {
        public override void Consume(Player player, Player opponent)
        {
            player.ActiveTrainer.ActiveMonster.Caracteristics[0].Actual += 3;
            player.ActiveTrainer.ActiveMonster.Caracteristics[1].Actual += 3;
            player.ActiveTrainer.ActiveMonster.Caracteristics[5].Actual *= 2;

        }
    }
}
