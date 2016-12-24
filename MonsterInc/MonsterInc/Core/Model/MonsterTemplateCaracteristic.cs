using System;
namespace Core.Model
{
    /// <summary>
    /// Liste des caractéristique d'un template de monstres
    /// </summary>
	public enum MonsterTemplateCaracteristicType
	{
		LifePoints,
		EnergyPoints,
		RegenerationPoints,
		AttackPoints,
		DefensePoints
	}

    /// <summary>
    /// Classe servant à sauvegarder des métriques de caractéristiques
    /// </summary>
    [Serializable]
    public class MonsterTemplateCaracteristic
	{
		/// <summary>
        /// Type de la caractéristique (typage)
        /// </summary>
		public MonsterTemplateCaracteristicType Type { get; set; }

        /// <summary>
        /// Valeur de base (initiale) de cette caractéristique
        /// </summary>
		public int Base { get; set; }					

        /// <summary>
        /// Niveau de progression de la caractérique modulée par le niveau d'Expérience
        /// </summary>
		public int Progression { get; set; }            
	}
}
