using System;
using System.Collections.Generic;

namespace Core.Model
{

	//public enum Element
	//{

	//}
	public enum MonsterCategory
	{
		Ball = 0,
		Titan,
		GiantTitan,
        Dragon
	}

	public class MonsterTemplate
	{

		public string Name { get; set; }

		public MonsterCategory Category { get; set; }

		public int BaseLevel { get; set; }

		public int Rarity { get; set; } //100 = common, 1 = rare

		public Element Element { get; set; }

		public List<MonsterTemplateCaracteristic> Caracteristics = new List<MonsterTemplateCaracteristic>();

	    public override string ToString()
	    {
	        return "Template Monster :: " + Name ;
	    }
	}
}
