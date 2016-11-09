using System;
using System.Collections.Generic;

namespace MonsterInc
{

	//public enum Element
	//{

	//}
	public enum MonsterCategory
	{
		Ball = 0,
		Titan,
		GiantTitan
	}

	public class MonsterTemplate
	{

		public string Name { get; set; }

		public MonsterCategory Category { get; set; }

		public int BaseLevel { get; set; }

		public int Scarcity { get; set; }

		public Element Element { get; set; }

		public List<MonsterTemplateCaracteristic> Caracteristics = new List<MonsterTemplateCaracteristic>();

	    public override string ToString()
	    {
	        return "Template Monster :: " + Name ;
	    }
	}
}
