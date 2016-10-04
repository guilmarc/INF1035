using System;
using System.Collections.Generic;

namespace MonsterInc
{
	public class Player
	{
		public string Name { get; set; }
		public double Money { get; set; }

		public List<Tool> Inventory { get; set; }

		public List<Monster> Monsters { get; set; } //Limité à 250

		public Player()
		{
		}
	}
}
