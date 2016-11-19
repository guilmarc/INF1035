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
                        Description = "",
                        Cost = 20,
                        Scopes = new List<Scope>
						{
							 new DamageScope() { Target = Scope.ScopeTarget.Opponent, Duration = 1, Magnitude = 1 } //TODO: Ajouter Effet
						}
                    }
                };
            }
        }
    }
}