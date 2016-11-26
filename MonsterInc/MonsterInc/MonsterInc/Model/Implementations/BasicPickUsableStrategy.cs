using System;

namespace Core.Model
{
    public class BasicPickUsableStrategy : IPickUsableStrategy
    {
        public Usable PickUsable(Player player, Player opponent)
        {
            switch (Utils.Random(1))
            {
                //Le hasard a choisi d'utiliser un item d'inventaire
                case 0: return player.ActiveTrainer.ActiveInventory.Random();
                //Le hasard a choisi d'utiliser une habilité
                default: return player.ActiveTrainer.ActiveMonster.ActiveSkills.Random();
            }
        }
    }
}