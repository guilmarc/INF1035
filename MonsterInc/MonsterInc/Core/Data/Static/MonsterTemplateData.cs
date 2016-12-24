using System;
using System.Collections.Generic;
using Core.Model;

namespace Core.Data.Static
{
	/// <summary>
    /// Classe de données hardcodées temporaires (non utilisée en mode runtime)
    /// </summary>
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
						Rarity = 100,
						Element = Element.Fire,
                        Description = "Little cute fire monster",
						Caracteristics = new List<MonsterTemplateCaracteristic> {
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 10, Progression = 2},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 10, Progression = 2},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 2, Progression = 2},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 10, Progression = 2},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 10, Progression = 2},
						},

                        

					},

					new MonsterTemplate {
						Name = "Fire Titan",
						Category = MonsterCategory.Titan,
						BaseLevel = 20,
						Rarity = 80,
						Element = Element.Fire,
                        Description = "Normal fire monster",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 20, Progression = 3},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 20, Progression = 3},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 4, Progression = 3},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 20, Progression = 3},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 20, Progression = 3},
						}
					},

                    new MonsterTemplate {
                        Name = "Giant Fire Titan",
                        Category = MonsterCategory.GiantTitan,
                        BaseLevel = 40,
                        Rarity = 35,
                        Element = Element.Fire,
                        Description = "Huge fire monster",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 6, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 30, Progression = 4},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Earth Ball",
                        Category = MonsterCategory.Ball,
                        BaseLevel = 1,
                        Rarity = 100,
                        Element = Element.Earth,
                        Description = "Little cute ball monster",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 10, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 10, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 2, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 10, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 10, Progression = 2},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Earth Titan",
                        Category = MonsterCategory.Titan,
                        BaseLevel = 20,
                        Rarity = 80,
                        Element = Element.Earth,
                        Description = "Medium earth monster",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 20, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 20, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 4, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 20, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 20, Progression = 3},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Giant Earth Titan",
                        Category = MonsterCategory.GiantTitan,
                        BaseLevel = 40,
                        Rarity = 35,
                        Element = Element.Earth,
                        Description = "Don't thrust me, I'm mad !",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 6, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 30, Progression = 4},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Water Ball",
                        Category = MonsterCategory.Ball,
                        BaseLevel = 1,
                        Rarity = 100,
                        Element = Element.Water,
                        Description = "Water little monster",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 10, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 10, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 2, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 10, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 10, Progression = 2},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Water Titan",
                        Category = MonsterCategory.Titan,
                        BaseLevel = 20,
                        Rarity = 80,
                        Element = Element.Water,
                        Description = "I love water !",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 20, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 20, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 4, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 20, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 20, Progression = 3},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Giant Water Titan",
                        Category = MonsterCategory.GiantTitan,
                        BaseLevel = 40,
                        Rarity = 35,
                        Element = Element.Water,
                        Description = "Water Water Water Water",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 6, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 30, Progression = 4},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Air Ball",
                        Category = MonsterCategory.Ball,
                        BaseLevel = 1,
                        Rarity = 100,
                        Element = Element.Air,
                        Description = "Little air ball cute monster",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 10, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 10, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 2, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 10, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 10, Progression = 2},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Air Titan",
                        Category = MonsterCategory.Titan,
                        BaseLevel = 20,
                        Rarity = 80,
                        Element = Element.Air,
                        Description = "Medium air ball monster",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 20, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 20, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 4, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 20, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 20, Progression = 3},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Giant Air Titan",
                        Category = MonsterCategory.GiantTitan,
                        BaseLevel = 40,
                        Rarity = 35,
                        Element = Element.Air,
                        Description = "Huge air ball cute monster",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 6, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 30, Progression = 4},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Magma Titan",
                        Category = MonsterCategory.Titan,
                        BaseLevel = 30,
                        Rarity = 50,
                        Element = Element.Lava,
                        Description = "Who am I ?",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 5, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 25, Progression = 3},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Giant Magma Titan",
                        Category = MonsterCategory.GiantTitan,
                        BaseLevel = 60,
                        Rarity = 10,
                        Element = Element.Lava,
                        Description = "Feeling Hothothot",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 7, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 35, Progression = 4},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Grass Titan",
                        Category = MonsterCategory.Titan,
                        BaseLevel = 30,
                        Rarity = 50,
                        Element = Element.Grass,
                        Description = "Grasshopper",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 5, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 25, Progression = 3},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Giant Grass Titan",
                        Category = MonsterCategory.GiantTitan,
                        BaseLevel = 60,
                        Rarity = 10,
                        Element = Element.Grass,
                        Description = "That is personnal",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 7, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 35, Progression = 4},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Ice Titan",
                        Category = MonsterCategory.Titan,
                        BaseLevel = 30,
                        Rarity = 50,
                        Element = Element.Ice,
                        Description = "Cold as ice",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 5, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 25, Progression = 3},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Giant Ice Titan",
                        Category = MonsterCategory.GiantTitan,
                        BaseLevel = 60,
                        Rarity = 10,
                        Element = Element.Ice,
                        Description = "Super dupper mega monster",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 7, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 35, Progression = 4},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Lightning Titan",
                        Category = MonsterCategory.Titan,
                        BaseLevel = 30,
                        Rarity = 50,
                        Element = Element.Lightning,
                        Description = "Bright as light",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 5, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 25, Progression = 3},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Giant Lightning Titan",
                        Category = MonsterCategory.GiantTitan,
                        BaseLevel = 60,
                        Rarity = 10,
                        Element = Element.Lightning,
                        Description = "Buzz Lightning",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 7, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 35, Progression = 4},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Four Heads Dragon (Fire)",
                        Category = MonsterCategory.Dragon,
                        BaseLevel = 20,
                        Rarity = 50,
                        Element = Element.Fire,
                        Description = "Gonna kill ya",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 8, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 40, Progression = 5},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Four Heads Dragon (Water)",
                        Category = MonsterCategory.Dragon,
                        BaseLevel = 20,
                        Rarity = 50,
                        Element = Element.Water,
                        Description = "You will never see me",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 8, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 40, Progression = 5},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Four Heads Dragon (Earth)",
                        Category = MonsterCategory.Dragon,
                        BaseLevel = 20,
                        Rarity = 50,
                        Element = Element.Earth,
                        Description = "Big big big monster",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 8, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 40, Progression = 5},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Four Heads Dragon (Air)",
                        Category = MonsterCategory.Dragon,
                        BaseLevel = 20,
                        Rarity = 50,
                        Element = Element.Air,
                        Description = "I need potatoes",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 8, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 40, Progression = 5},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Ultimate Four Heads Dragon (Lava)",
                        Category = MonsterCategory.Dragon,
                        BaseLevel = 20,
                        Rarity = 50,
                        Element = Element.Lava,
                        Description = "I'm kadaboum",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 8, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 40, Progression = 5},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Ultimate Four Heads Dragon (Grass)",
                        Category = MonsterCategory.Dragon,
                        BaseLevel = 20,
                        Rarity = 50,
                        Element = Element.Grass,
                        Description = "Green Green Greeeeeeeeeeen",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 8, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 40, Progression = 5},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Ultimate Four Heads Dragon (Ice)",
                        Category = MonsterCategory.Dragon,
                        BaseLevel = 20,
                        Rarity = 50,
                        Element = Element.Ice,
                        Description = "Je déteste Caillou",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 8, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 40, Progression = 5},
                        }
                    },

                    new MonsterTemplate {
                        Name = "Ultimate Four Heads Dragon (Lightning)",
                        Category = MonsterCategory.Dragon,
                        BaseLevel = 20,
                        Rarity = 50,
                        Element = Element.Lightning,
                        Description = "Super killer !",
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 8, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 40, Progression = 5},
                        }
                    },
                };
			}
		}
	}
}
