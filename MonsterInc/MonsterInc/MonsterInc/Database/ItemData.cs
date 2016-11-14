using System.Collections.Generic;

namespace MonsterInc
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
                        Cost = 20,
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
                        Cost = 100,
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
                        Cost = 500,
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
                        Cost = 2000,
                        Scopes = new List<Scope>
                        {
                             new EffectScope() { Target = Scope.ScopeTarget.Opponent, Duration = 1, Magnitude = 0.8 } 
						}
                    },

                    new Revival
                    {
                        Name = "Revival Syringe (5 mL) ",
                        Description = "Revival Syringe",
                        Rarity = 70,
                        Cost = 400,
                        Scopes = new List<Scope>
                        {
                             new EffectScope() { Target = Scope.ScopeTarget.Self, Duration = 1, Magnitude = 0.5 }
                        }
                    },

                    new Revival
                    {
                        Name = "Revival Syringe (10 mL) ",
                        Description = "Large Revival Syringe",
                        Rarity = 30,
                        Cost = 1500,
                        Scopes = new List<Scope>
                        {
                             new EffectScope() { Target = Scope.ScopeTarget.Self, Duration = 1, Magnitude = 0.8 }
                        }
                    },



                };
            }
        }
    }
}