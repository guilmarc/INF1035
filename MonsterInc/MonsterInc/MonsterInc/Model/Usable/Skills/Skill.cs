using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Core.Model
{
    [Serializable]
	public class Skill : Usable
	{
        public Element Element { get; set; }

		public int EnergyPointCost { get; set; }

		public int MinimumExperienceLevel { get; set; }

        public int Cooldown { get; set; }

        public Element ElementDamage { get; set; }

        public List<MonsterCategory> MonsterCategory { get; set; } // OK si un des éléments est dans la liste, et OK si liste vide

        public List<Element> ElementRequirement { get; set; } // OK si un des éléments est dans la liste, et OK si liste vide

        public override void Consume(Player player, Player opponent)
        {
            throw new NotImplementedException();
        }
    }
}
