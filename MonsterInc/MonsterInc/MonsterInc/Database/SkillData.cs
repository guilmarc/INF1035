using System.Collections.Generic;

namespace MonsterInc
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
                        Name = "",
                        EnergyPointCost = 10,
                        MinimumExperienceLevel = 1,
                        Scopes = new List<Scope>
                        {
                            new DamageScope { }
                        }
                    }
                };
            }
        }
    }
}