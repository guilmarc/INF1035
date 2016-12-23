﻿using System;
namespace Core.Model
{
    [Serializable]
	public class MonsterCaracteristic
	{
		//readonly MonsterTemplateCaracteristic _monsterTemplateCaracteristic;

		//public MonsterTemplateCaracteristicType Type { get { return _monsterTemplateCaracteristic.Type; } }

	    public MonsterTemplateCaracteristicType Type { get; set; }

        public int Total { get; set; }

        int _actual;
        public int Actual
        {
            get
            {
                return this._actual;
            }
            set
            {
                this._actual = value > this.Total ? this.Total : value;
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
        public MonsterCaracteristic(MonsterTemplateCaracteristic monsterTemplateCaracteristic, int experienceLevel, double factor)
		{
			//Copie des caractéristiques 
            this.Type = monsterTemplateCaracteristic.Type;
            this.Base = HumanizeValue((int)(monsterTemplateCaracteristic.Base * factor));
		    this.Progression = HumanizeValue((int)(monsterTemplateCaracteristic.Progression));
            this.InitWithLevel(experienceLevel);
		}

	    public int HumanizeValue(int value)
	    {
	        return value; //TODO: Retourer une valeur aléaloire += THRESHOLD 
	    }

		public void InitWithLevel(int experienceLevel)
		{
            //Ici on fait -1 car on je veux pas débuter avec un ExperienceLevel = 0 mais 1
		    this.Total = this.Base + ((experienceLevel - 1) * this.Progression);
		    this.Actual = this.Total;
		}
	}
}