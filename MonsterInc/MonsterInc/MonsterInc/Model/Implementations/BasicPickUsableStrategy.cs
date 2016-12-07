using System;

namespace Core.Model
{
    public class BasicPickUsableStrategy : IPickUsableStrategy
    {
        public Usable PickUsable(Player player, Player opponent)
        {
            //S'il n'existe plus d'item en inventaire, on modifie l'interval de random
            int interval = player.ActiveTrainer.ActiveInventory.Count == 0 ? 1 : 2;

            switch (Utils.Random(interval))
            {
                //Le hasard a choisi d'utiliser un item d'inventaire
                case 0: return player.ActiveTrainer.ActiveMonster.ActiveSkills.Random(); 
                //Le hasard a choisi d'utiliser une habilité
                case 1: return player.ActiveTrainer.ActiveInventory.Random();
                default: throw new InvalidOperationException("");
            }
        }
    }
}