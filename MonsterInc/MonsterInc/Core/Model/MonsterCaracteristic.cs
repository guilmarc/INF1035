using System;
namespace Core.Model
{
    [Serializable]
	public class MonsterCaracteristic
	{
        /// <summary>
        /// Type de la caractéristique
        /// </summary>
	    public MonsterTemplateCaracteristicType Type { get; set; }

        /// <summary>
        /// Valeur total de cette caractéristique (valeur de réinitialisation)
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Valeur actuelle de cette caractéristique
        /// </summary>
        private int _actual;
        public int Actual
        {
            get
            {
                return this._actual;
            }
            set
            {
                this._actual = Math.Max(Math.Min(value, Total), 0);
            }
        }

        /// <summary>
        /// Valeur de base de cette caractéristique
        /// </summary>
        public int Base { get; set; }

        /// <summary>
        /// Valeur de progression de cette caractéristique modulée par le niveau d'expérience
        /// </summary>
        public int Progression { get; set; }

        /// <summary>
        /// Constructeur par défaut nécessaire à la sérialisation
        /// </summary>
        public MonsterCaracteristic(){}

        /// <summary>
        /// Constructeur obligatoire pour cette caractéristique
        /// </summary>
        /// <param name="monsterTemplateCaracteristic"></param>
        /// <param name="experienceLevel"></param>
        /// <param name="difficultyFactor"></param>
        public MonsterCaracteristic(MonsterTemplateCaracteristic monsterTemplateCaracteristic, int experienceLevel, double difficultyFactor)
		{
			//Copie des caractéristiques 
            this.Type = monsterTemplateCaracteristic.Type;
            this.Base = (int)(monsterTemplateCaracteristic.Base * difficultyFactor * Utils.HumanizeRatio());
		    this.Progression = (int)(monsterTemplateCaracteristic.Progression * Utils.HumanizeRatio());
            this.InitWithLevel(experienceLevel);
		}

        /// <summary>
        /// Réinitialisation des valeurs total et actuel de la caractéristique selon le niveau d'expérience
        /// </summary>
        /// <param name="experienceLevel"></param>
		public void InitWithLevel(int experienceLevel)
		{
            //Ici on fait -1 car on veux pas débuter avec un ExperienceLevel = 0 mais 1
		    this.Total = this.Base + ((experienceLevel - 1) * this.Progression);
		    this.Actual = this.Total;
		}
	}
}
