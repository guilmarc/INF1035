using System;
using System.Collections.Generic;

namespace MonsterInc
{
	public class Skill
	{

		public string Name { get; set; }
		public Element Element { get; set; }

		public int EnergyPointCost { get; set; }

		public int MinimumExperienceLevel { get; set; }

		public List<Scope> Scopes { get; set; } 
	}

	//Un impact c'est un triplet Effet, Magnitude et Durée
	public class Scope
	{
		public Effect Effect { get; set; }
		public double Magnitude { get; set; } = 1.0;
		public int Duration { get; set; } = 1;
	}

	public class Effect
	{
		public string Name { get; set; }

		//TODO: Trouver comment associer une strategie d'effet ici.
	}
}
