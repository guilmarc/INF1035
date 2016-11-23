
﻿using System.Collections.Generic;
using System.Linq;
using Core.Model;

namespace Core
{
    public static class InventoryFactory
    {

        public static void GenerateInventoryForTrainer(Trainer trainer)
        {
            Item item;
            do
            {
                item = PickRandomItemWithGold(trainer.Gold);
            } while ( item != null );

        }

        private static Item PickRandomItemWithGold(int Gold)
        {
            var availableItems = Universe.Items.Where(t => t.Gold <= Gold).ToList();
            if (availableItems.Count != 0)
            {
                var totalRarity = availableItems.Sum(x => x.Rarity);
                var rnd = Utils.Random(1, totalRarity);

                foreach (var item in availableItems)
                {
                    rnd -= item.Rarity;
                    if (rnd < 0)
                    {
                        return item;
                    }
                }
            }

            return null;
        }
    }
}