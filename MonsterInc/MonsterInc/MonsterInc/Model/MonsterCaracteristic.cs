using System;
namespace Core.Model
{
	public class MonsterCaracteristic
	{
		//readonly MonsterTemplateCaracteristic _monsterTemplateCaracteristic;

		//public MonsterTemplateCaracteristicType Type { get { return _monsterTemplateCaracteristic.Type; } }

	    public MonsterTemplateCaracteristicType Type { get; set; }

        public int Total { get; set; }

        public int Actual { get; set; }

        public int Base { get; set; }                   //Valeur de base de cette caractérsitique

        public int Progression { get; set; }

        public MonsterCaracteristic(MonsterTemplateCaracteristic monsterTemplateCaracteristic, int experienceLevel)
		{
			//Copie des caractéristiques 
            this.Type = monsterTemplateCaracteristic.Type;
            this.Base = HumanizeValue(monsterTemplateCaracteristic.Base);
		    this.Progression = HumanizeValue(monsterTemplateCaracteristic.Progression);
            this.InitWithLevel(experienceLevel);
		}

	    public int HumanizeValue(int value)
	    {
	        return value; //TODO: Retourer une valeur aléaloire += THRESHOLD 
	    }

		public void InitWithLevel(int experienceLevel)
		{
		    this.Total = this.Base + (experienceLevel * this.Progression);
		    this.Actual = this.Total;
		}
	}
}
