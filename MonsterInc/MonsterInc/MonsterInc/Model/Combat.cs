using System;
using System.Collections.Generic;

namespace MonsterInc
{

	/// <summary>
	/// 
	/// </summary>
	public class Combat
	{
		//Game game;
		public Reward Reward { get; set; }


		public Player Opponent { get; set; }
		public Player Player { get; set; }

		public List<Turn> Turns { get; set; }

		//public Combat(Game game)
		//{
		//	this.game = game;
		//}
	} 
}
