using System;
using System.Collections.Generic;

namespace Core.Model
{
	public class Skill : IActionable
	{

		public string Name { get; set; }

		public Element Element { get; set; }

		public int EnergyPointCost { get; set; }

		public int MinimumExperienceLevel { get; set; }

        public int Cooldown { get; set; }

        public Element ElementDamage { get; set; }

        public List<MonsterCategory> MonsterCategory { get; set; } // OK si un des éléments est dans la liste, et OK si liste vide

        public List<Element> ElementRequirement { get; set; } // OK si un des éléments est dans la liste, et OK si liste vide

        public List<Scope> Scopes { get; set; }

        //public Effect Effet { get; set; }  a faire si on a le temps car ca va être compliqué de changer la cible, etc
	}
}
