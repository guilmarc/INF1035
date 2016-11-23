using System;
using System.Collections.Generic;
using Core.Model;

namespace Core.Data
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
						Rarity = 100,
						Element = Element.Fire,
						Caracteristics = new List<MonsterTemplateCaracteristic> {
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 10, Progression = 2},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 10, Progression = 2},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 10, Progression = 2},
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
						Caracteristics = new List<MonsterTemplateCaracteristic> {
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 20, Progression = 3},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 20, Progression = 3},
							new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 20, Progression = 3},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 30, Progression = 4},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 10, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 10, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 10, Progression = 2},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 20, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 20, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 20, Progression = 3},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 30, Progression = 4},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 10, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 10, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 10, Progression = 2},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 20, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 20, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 20, Progression = 3},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 30, Progression = 4},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 10, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 10, Progression = 2},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 10, Progression = 2},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 20, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 20, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 20, Progression = 3},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 30, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 30, Progression = 4},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 25, Progression = 3},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 35, Progression = 4},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 25, Progression = 3},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 35, Progression = 4},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 25, Progression = 3},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 35, Progression = 4},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 25, Progression = 3},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 25, Progression = 3},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 35, Progression = 4},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 35, Progression = 4},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 40, Progression = 5},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 40, Progression = 5},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 40, Progression = 5},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 40, Progression = 5},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 40, Progression = 5},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 40, Progression = 5},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 40, Progression = 5},
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
                        Caracteristics = new List<MonsterTemplateCaracteristic> {
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.LifePoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.EnergyPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.RegenerationPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.AttackPoints,  Base = 40, Progression = 5},
                            new MonsterTemplateCaracteristic { Type = MonsterTemplateCaracteristicType.DefensePoints,  Base = 40, Progression = 5},
                        }
                    },
                };
			}
		}
	}
}
