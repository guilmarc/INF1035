using System;
namespace MonsterInc
{
	//Un impact c'est un quadruplet Target, Effet, Magnitude et Durée
	public abstract class Scope
	{
		public enum ScopeTarget
		{
			Self = 0,
			Opponent
		}

		public ScopeTarget Target { get; set; } = ScopeTarget.Opponent;
		//public Effect Effect { get; set; }

		public virtual double Magnitude { get; set; }

		public int Duration { get; set; } = 1;
	}
}
