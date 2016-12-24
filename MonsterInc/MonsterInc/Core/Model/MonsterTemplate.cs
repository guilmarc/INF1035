using System;
using System.Collections.Generic;

namespace Core.Model
{
    /// <summary>
    /// Liste des catégories de montres
    /// </summary>
	public enum MonsterCategory
	{
		Ball = 0,
		Titan,
		GiantTitan,
        Dragon
	}

    [Serializable]
    public class MonsterTemplate
	{
        /// <summary>
        /// Nom du template de monstre
        /// </summary>
		public string Name { get; set; }

        /// <summary>
        /// Description du template de montre
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Catégorie du template de monstre
        /// </summary>
        public MonsterCategory Category { get; set; }

        /// <summary>
        /// Niveau d'expérience minimal du template de monstre
        /// </summary>
		public int BaseLevel { get; set; }

        /// <summary>
        /// Rareté de ce monstre
        /// </summary>
		public int Rarity { get; set; } //100 = common, 1 = rare

        /// <summary>
        /// Élement associé à ce template de monstre
        /// </summary>
		public Element Element { get; set; }

        /// <summary>
        /// Liste des caractéristiques du template de monstre
        /// </summary>
		public List<MonsterTemplateCaracteristic> Caracteristics = new List<MonsterTemplateCaracteristic>();

        /// <summary>
        /// Aggichage à l'écran
        /// </summary>
        /// <returns></returns>
	    public override string ToString()
	    {
	        return "Template Monster :: " + Name ;
	    }
	}
}
