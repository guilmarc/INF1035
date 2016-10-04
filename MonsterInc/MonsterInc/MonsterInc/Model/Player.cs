using System;
using System.Collections.Generic;

namespace MonsterInc
{
	public class Player
	{
		public string Name { get; set; }
		public double Money { get; set; }

		public List<Item> Inventory { get; set; }

		public List<Monster> CapturedMonsters { get; set; }

		public Player()
		{
		}
	}
}
