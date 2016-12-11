using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Core.Model
{
    //[Serializable]
	public class Skill : Usable
	{
		public int EnergyPointCost { get; set; }

		public int MinimumExperienceLevel { get; set; }

	    public Element Element { get; set; }

        public List<Element> ElementRequirement { get; set; } = new List<Element>(); // OK si un des éléments est dans la liste, et OK si liste vide

        public override void Consume(Player player, Player opponent)
        {
            //throw new NotImplementedException();
            opponent.ActiveTrainer.ActiveMonster.GetCaracteristic(MonsterTemplateCaracteristicType.LifePoints).Actual--;
        }
	}
}
