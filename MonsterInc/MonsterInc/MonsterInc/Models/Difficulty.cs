using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterInc.Models
{
    class Difficulty
    {
        public int DifficultyNumber { get; set; }
        public string Name { get; set; }

        public double BonusItemRarity { get; set; } //multiplicateur de rareté
        public int ItemRarityApplicable { get; set; } //rareté sur laquelle le bonus est appliqué ex : 40 pour rareté 1 à 40 (Item.Rarity)
        public double BonusMonsterRarity { get; set; } //multiplicateur de rareté
        public int MonsterLevelRarityApplicable { get; set; } //rareté sur laquelle le bonus est appliqué (ex : 20 pour monstres dispo a partir de lvl 20 (MonsterTemplate.BaseLevel)
        public double BonusOpponentDamage { get; set; } //multiplicateur du dommage

    }
}
