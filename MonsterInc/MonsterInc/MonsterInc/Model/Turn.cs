using System;
using System.Collections.Generic;

namespace Core.Model
{
	public class Turn
	{
		public int Position { get; set; }

		public Monster OpponentMonster { get; set; }
		public Monster PlayerMonster { get; set; }

		public List<Action> Actions { get; set; }
	}
}
