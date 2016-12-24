using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    /// <summary>
    /// Classe des niveau de difficulté
    /// </summary>
    public class Difficulty
    {
        /// <summary>
        /// Numéro de la difficulté
        /// </summary>
        public int DifficultyNumber { get; set; }

        /// <summary>
        /// Nom du niveau de difficulté
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Multiplicateur de rareté
        /// </summary>
        public double BonusItemRarity { get; set; }

        /// <summary>
        /// Rareté sur laquelle le bonus est appliqué ex : 40 pour rareté 1 à 40 (Item.Rarity)
        /// </summary>
        public int ItemRarityApplicable { get; set; }

        /// <summary>
        /// Multiplicateur de rareté
        /// </summary>
        public double BonusMonsterRarity { get; set; } 
        
        /// <summary>
        /// Rareté sur laquelle le bonus est appliqué (ex : 20 pour monstres dispo a partir de lvl 20 (MonsterTemplate.BaseLevel)
        /// </summary>
        public int MonsterLevelRarityApplicable { get; set; } 
        
        /// <summary>
        ///  Multiplicateur du dommage
        /// </summary>
        public double BonusOpponentDamage { get; set; } 

        /// <summary>
        /// Multiplicateur de la propriété Base de chacunes des caractéristiques d'un Monstre
        /// </summary>
        public double CaracteristicFactor { get; set; }

        /// <summary>
        /// Affichage de l'objet
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return Name;
        }

    }
}