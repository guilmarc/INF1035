using System;
using System.Collections.Generic;

namespace MonsterInc
{
	public class Skill : IActionable
	{

		public string Name { get; set; }

		public Element Element { get; set; }

		public int EnergyPointCost { get; set; }

		public int MinimumExperienceLevel { get; set; }

		public List<Scope> Scopes { get; set; }

		public void Do(Context context, Monster destination)
		{
			
		}
	}
}
