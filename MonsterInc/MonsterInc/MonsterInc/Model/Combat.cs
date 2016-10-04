using System;
namespace MonsterInc
{
	public class Combat
	{
		Game game;

		public Player Opponent { get; set; }

		public Combat(Game game)
		{
			this.game = game;

		}

	} 
}
