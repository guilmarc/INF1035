using System;
using System.Collections.Generic;

namespace MonsterInc
{
	//Simulation du fichier XML des MonsterTemplate
	public static class MonsterTemplateData
	{
		public static List<MonsterTemplate> MonsterTemplates
		{
			get
			{
				return new List<MonsterTemplate>
				{
					new MonsterTemplate {
						Name = "Fire Ball",
						Category = MonsterCategory.Ball,
						BaseLevel = 1,
						Scarcity = 100,
						Element = Element.Fire,
						Caracteristics = new List<MonsterTemplateCaracteristic> {
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 10, Progression = 2},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 10, Progression = 2},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 10, Progression = 2},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 10, Progression = 2},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 10, Progression = 2},
						}
					},

					new MonsterTemplate {
						Name = "Fire Titan",
						Category = MonsterCategory.Titan,
						BaseLevel = 20,
						Scarcity = 50,
						Element = Element.Fire,
						Caracteristics = new List<MonsterTemplateCaracteristic> {
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 20, Progression = 3},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 20, Progression = 3},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 20, Progression = 3},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 20, Progression = 3},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 30, Progression = 3},
						}
					},
				};
			}
		}
	}
}
