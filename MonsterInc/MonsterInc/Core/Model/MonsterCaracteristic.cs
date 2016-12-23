using System;
namespace Core.Model
{
    [Serializable]
	public class MonsterCaracteristic
	{

	    public MonsterTemplateCaracteristicType Type { get; set; }

        public int Total { get; set; }

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

        public int Base { get; set; }                   //Valeur de base de cette caractérsitique

        public int Progression { get; set; }

        /// <summary>
        /// Default constructor for serialisation
        /// </summary>
        public MonsterCaracteristic()
        {

        }
        public MonsterCaracteristic(MonsterTemplateCaracteristic monsterTemplateCaracteristic, int experienceLevel, double difficultyFactor)
		{
			//Copie des caractéristiques 
            this.Type = monsterTemplateCaracteristic.Type;
            this.Base = (int)(monsterTemplateCaracteristic.Base * difficultyFactor * Utils.HumanizeRatio());
		    this.Progression = (int)(monsterTemplateCaracteristic.Progression * Utils.HumanizeRatio());
            this.InitWithLevel(experienceLevel);
		}

		public void InitWithLevel(int experienceLevel)
		{
            //Ici on fait -1 car on veux pas débuter avec un ExperienceLevel = 0 mais 1
		    this.Total = this.Base + ((experienceLevel - 1) * this.Progression);
		    this.Actual = this.Total;
		}
	}
}
