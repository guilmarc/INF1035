using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;

namespace Core.Database
{
    class DifficultyData
    {
        public static List<Difficulty> Difficulty
        {
            get
            {
                return new List<Difficulty>
                {
                    new Difficulty
                    {
                        DifficultyNumber = 1,
                        Name = "Newborn",
                        BonusItemRarity = 1,
                        BonusMonsterRarity = 1,
                        BonusOpponentDamage = -1.3,
                        CaracteristicFactor = 1.0
                    },

                    new Difficulty
                    {
                        DifficultyNumber = 2,
                        Name = "Casual",
                        BonusItemRarity = 1.25,
                        ItemRarityApplicable = 90,
                        BonusMonsterRarity = 2,
                        MonsterLevelRarityApplicable = 20,
                        BonusOpponentDamage = -1.15,
                        CaracteristicFactor = 1.1
                    },

                    new Difficulty
                    {
                        DifficultyNumber = 3,
                        Name = "Fair",
                        BonusItemRarity = 1.5,
                        ItemRarityApplicable = 90,
                        BonusMonsterRarity = 3,
                        MonsterLevelRarityApplicable = 20,
                        BonusOpponentDamage = 1,
                        CaracteristicFactor = 1.2
                    },

                    new Difficulty
                    {
                        DifficultyNumber = 4,
                        Name = "Serious",
                        BonusItemRarity = 1.5,
                        ItemRarityApplicable = 90,
                        BonusMonsterRarity = 2,
                        MonsterLevelRarityApplicable = 20,
                        BonusOpponentDamage = 1.05,
                        CaracteristicFactor = 1.3
                    },

                    new Difficulty
                    {
                        DifficultyNumber = 5,
                        Name = "Expert",
                        BonusItemRarity = 2,
                        ItemRarityApplicable = 80,
                        BonusMonsterRarity = 3,
                        MonsterLevelRarityApplicable = 40,
                        BonusOpponentDamage = 1.1,
                        CaracteristicFactor = 1.4
                    },

                    new Difficulty
                    {
                        DifficultyNumber = 6,
                        Name = "Master",
                        BonusItemRarity = 5,
                        ItemRarityApplicable = 80,
                        BonusMonsterRarity = 5,
                        MonsterLevelRarityApplicable = 40,
                        BonusOpponentDamage = 1.5
                    },

                    new Difficulty
                    {
                        DifficultyNumber = 7,
                        Name = "Legend",
                        BonusItemRarity = 2,
                        ItemRarityApplicable = 50,
                        BonusMonsterRarity = 7,
                        MonsterLevelRarityApplicable = 40,
                        BonusOpponentDamage = 1.6
                    },

                    new Difficulty
                    {
                        DifficultyNumber = 8,
                        Name = "Insane",
                        BonusItemRarity = 5,
                        ItemRarityApplicable = 50,
                        BonusMonsterRarity = 10,
                        MonsterLevelRarityApplicable = 40,
                        BonusOpponentDamage = 1.7
                    },
                };
            }
        }
    }
}
