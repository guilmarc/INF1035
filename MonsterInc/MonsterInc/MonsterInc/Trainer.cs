using System;
using System.Collections.Generic;

namespace MonsterInc
{
	/// <summary>
	/// Un entraîneur possède une liste de monstres
	/// </summary>
	public class Trainer
	{
		public string Name { get; set; }
		public int Money { get; set; }

		public List<Item> Inventory { get; set; }

		public List<Monster> Monsters { get; set; } //Limité à 250

		public List<Item> ActiveInventory { get; set; }
		public List<Monster> ActiveMonsters { get; set; }

		public Element Affinity { get; set; }
	}
}
