using System.Collections.Generic;
using Core.Model;

namespace Core.Data
{
    public static class SkillData
    {
        public static List<Skill> Skills
        {
            get
            {
                return new List<Skill>
                {
                    new Skill {
                        Name = "Roll",
                        EnergyPointCost = 5,
                        MinimumExperienceLevel = 1,

                        Scopes = new List<Scope>
                        {
                            new DamageScope {Target = Scope.ScopeTarget.Opponent, Duration = 1, Magnitude = 10}
                        }
                        
                    },

                    new Skill {
                        Name = "Tornado",
                        EnergyPointCost = 20,
                        MinimumExperienceLevel = 10,
                        Element = Element.Air,
                        ElementRequirement = new List<Element>
                        {
                            Element.Air, Element.Grass
                        },
                        Scopes = new List<Scope>
                        {
                            new DamageScope {Target = Scope.ScopeTarget.Opponent, Duration = 1, Magnitude = 30}
                        }
                        //Effect = Effect.Confuse
                    },

                    new Skill {
                        Name = "FireBolt",
                        EnergyPointCost = 7,
                        MinimumExperienceLevel = 1,
                        Element = Element.Fire,
                        ElementRequirement = new List<Element>
                        {
                            Element.Fire, Element.Lava
                        },
                        Scopes = new List<Scope>
                        {
                            new DamageScope {Target = Scope.ScopeTarget.Opponent, Duration = 1, Magnitude = 15}
                        }
                    },

                    new Skill {
                        Name = "IceArrow",
                        EnergyPointCost = 10,
                        MinimumExperienceLevel = 5,
                        Element = Element.Ice,
                        ElementRequirement = new List<Element>
                        {
                            Element.Ice
                        },
                        Scopes = new List<Scope>
                        {
                            new DamageScope {Target = Scope.ScopeTarget.Opponent, Duration = 1, Magnitude = 25}
                        }
                    },

                    new Skill {
                        Name = "Kick",
                        EnergyPointCost = 4,
                        MinimumExperienceLevel = 20,
                        Scopes = new List<Scope>
                        {
                            new DamageScope {Target = Scope.ScopeTarget.Opponent, Duration = 1, Magnitude = 12}
                        }
                    },

                    new Skill {
                        Name = "PowerHit",
                        EnergyPointCost = 3,
                        MinimumExperienceLevel = 1,
                        //Element = type de l'élément du monstre se servant de l'attaque,
                        Scopes = new List<Scope>
                        {
                            new DamageScope {Target = Scope.ScopeTarget.Opponent, Duration = 1, Magnitude = 8}
                        }
                    },

                   


                };
            }
        }
    }
}