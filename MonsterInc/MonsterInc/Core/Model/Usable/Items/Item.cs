using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Xml.Serialization;

namespace Core.Model
{
    [XmlInclude(typeof(Antidote))]
    [XmlInclude(typeof(CaptureBall))]
    [XmlInclude(typeof(EnergyPotion))]
    [XmlInclude(typeof(LifePotion))]
    [XmlInclude(typeof(Revival))]
    [Serializable]
    public abstract class Item : Usable
    {
        /// <summary>
        /// Rareté de l'item. 100 = commun, 1=rare
        /// </summary>
        public int Rarity { get; set; }


        /// <summary>
        /// Coût de l'item en écu d'or
        /// </summary>
        public int Gold { get; set; }

        protected void InventoryDeduction(Player player)
        {
            player.Trainer.ActiveInventory.Remove(this);
            player.Trainer.Inventory.Remove(this);

        }


    }
}
