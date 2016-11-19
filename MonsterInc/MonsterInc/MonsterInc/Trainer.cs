using System;
using System.Collections.Generic;

namespace MonsterInc
{
	/// <summary>
	/// Un entraîneur possède une liste de monstres
	/// </summary>
	public class Trainer
	{
	    private const int INIT_GOLD_VALUE = 1000;

		public string Name { get; set; }

	    public int Gold { get; set; } = INIT_GOLD_VALUE;

		public List<Item> Inventory { get; set; }

		public List<Monster> Monsters { get; set; } //Limité à 250

		public List<Item> ActiveInventory { get; set; }
		public List<Monster> ActiveMonsters { get; set; }

		public Element Affinity { get; set; }

		public void BuyItem(Item item)
		{
			if (item.Cost <= this.Gold)
			{
				
			}
		}
	}
}
