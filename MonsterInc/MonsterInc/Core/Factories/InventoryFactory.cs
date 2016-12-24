
﻿using System;
 using System.Collections.Generic;
using System.Linq;
using Core.Model;

namespace Core
{
    /// <summary>
    /// Design pattern Factory : Création des items
    /// </summary>
    public static class InventoryFactory
    {
        /// <summary>
        /// Génère un inventaire aléatoire pour un entraîneur selon l'or disponible
        /// </summary>
        /// <param name="trainer"></param>
        public static void GenerateRandomInventoryForTrainer(Trainer trainer)
        {
            Item item;
            do
            {
                item = PickRandomItemWithGold(trainer.Gold);
                if (item != null)
                {
                    trainer.BuyItem(item);
                }

            } while ( item != null );
        }

        /// <summary>
        /// Sélectionne un item en magasin selon l'or disponible et le niveau de rareté de l'item
        /// </summary>
        /// <param name="Gold"></param>
        /// <returns></returns>
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