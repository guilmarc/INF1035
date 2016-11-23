using System.Collections.Generic;
using Core.Model;

namespace Core.Data
{
    public static class ItemData
    {
        public static List<Item> Items
        {
            get
            {
                return new List<Item>
                {
					new CaptureBall
                    {
                        Name = "CBall (low grade)",
                        Description = "Low grade capture ball",
                        Rarity = 90,
                        Gold = 20,
                        Scopes = new List<Scope>
						{
							 new EffectScope() { Target = Scope.ScopeTarget.Opponent, Duration = 1, Magnitude = 0.2 } //TODO: Ajouter Effet ??
						}
                    },

                    new CaptureBall
                    {
                        Name = "CBall (medium grade)",
                        Description = "Medium grade capture ball",
                        Rarity = 75,
                        Gold = 100,
                        Scopes = new List<Scope>
                        {
                             new EffectScope() { Target = Scope.ScopeTarget.Opponent, Duration = 1, Magnitude = 0.4 } 
						}
                    },

                    new CaptureBall
                    {
                        Name = "CBall (high grade)",
                        Description = "High grade capture ball",
                        Rarity = 50,
                        Gold = 500,
                        Scopes = new List<Scope>
                        {
                             new EffectScope() { Target = Scope.ScopeTarget.Opponent, Duration = 1, Magnitude = 0.6 } 
						}
                    },

                    new CaptureBall
                    {
                        Name = "CBall (perfect grade)",
                        Description = "Perfect capture ball",
                        Rarity = 20,
                        Gold = 2000,
                        Scopes = new List<Scope>
                        {
                             new EffectScope() { Target = Scope.ScopeTarget.Opponent, Duration = 1, Magnitude = 0.8 } 
						}
                    },

                    new Revival
                    {
                        Name = "Revival Syringe (5 mL)",
                        Description = "Revival Syringe",
                        Rarity = 70,
                        Gold = 400,
                        Scopes = new List<Scope>
                        {
                             new EffectScope() { Target = Scope.ScopeTarget.Self, Duration = 1, Magnitude = 0.5 }
                        }
                    },

                    new Revival
                    {
                        Name = "Revival Syringe (10 mL)",
                        Description = "Large Revival Syringe",
                        Rarity = 30,
                        Gold = 1500,
                        Scopes = new List<Scope>
                        {
                             new EffectScope() { Target = Scope.ScopeTarget.Self, Duration = 1, Magnitude = 0.8 }
                        }
                    },

                    new LifePotion
                    {
                        Name = "Small Life Potion",
                        Description = "Small Life Potion",
                        Rarity = 95,
                        Gold = 5,
                        Scopes = new List<Scope>
                        {
                             new EffectScope() { Target = Scope.ScopeTarget.Self, Duration = 1, Magnitude = 0.015 }
                        }
                    },

                    new LifePotion
                    {
                        Name = "Medium Life Potion",
                        Description = "Medium Life Potion",
                        Rarity = 80,
                        Gold = 50,
                        Scopes = new List<Scope>
                        {
                             new EffectScope() { Target = Scope.ScopeTarget.Self, Duration = 1, Magnitude = 0.05 }
                        }
                    },

                    new LifePotion
                    {
                        Name = "Large Life Potion",
                        Description = "Large Life Potion",
                        Rarity = 60,
                        Gold = 200,
                        Scopes = new List<Scope>
                        {
                             new EffectScope() { Target = Scope.ScopeTarget.Self, Duration = 1, Magnitude = 0.15 }
                        }
                    },

                    new EnergyPotion
                    {
                        Name = "Small Energy Potion",
                        Description = "Small Energy Potion",
                        Rarity = 95,
                        Gold = 5,
                        Scopes = new List<Scope>
                        {
                             new EffectScope() { Target = Scope.ScopeTarget.Self, Duration = 1, Magnitude = 0.015 }
                        }
                    },

                    new EnergyPotion
                    {
                        Name = "Medium Energy Potion",
                        Description = "Medium Energy Potion",
                        Rarity = 80,
                        Gold = 50,
                        Scopes = new List<Scope>
                        {
                             new EffectScope() { Target = Scope.ScopeTarget.Self, Duration = 1, Magnitude = 0.05 }
                        }
                    },

                    new EnergyPotion
                    {
                        Name = "Large Energy Potion",
                        Description = "Large Energy Potion",
                        Rarity = 60,
                        Gold = 200,
                        Scopes = new List<Scope>
                        {
                             new EffectScope() { Target = Scope.ScopeTarget.Self, Duration = 1, Magnitude = 0.15 }
                        }
                    },

                    new Antidote
                    {
                        Name = "Low quality Antidote",
                        Description = "40% chance to remove negative effect",
                        Rarity = 95,
                        Gold = 5,
                        Scopes = new List<Scope>
                        {
                             new EffectScope() { Target = Scope.ScopeTarget.Self, Duration = 1, Magnitude = 0.4 }
                        }
                    },

                    new Antidote
                    {
                        Name = "Medium quality Antidote",
                        Description = "65% chance to remove negative effect",
                        Rarity = 80,
                        Gold = 50,
                        Scopes = new List<Scope>
                        {
                             new EffectScope() { Target = Scope.ScopeTarget.Self, Duration = 1, Magnitude = 0.65 }
                        }
                    },

                    new Antidote
                    {
                        Name = "Good quality Antidote",
                        Description = "90% chance to remove negative effect",
                        Rarity = 40,
                        Gold = 200,
                        Scopes = new List<Scope>
                        {
                             new EffectScope() { Target = Scope.ScopeTarget.Self, Duration = 1, Magnitude = 0.9 }
                        }
                    },

                };
            }
        }
    }
}