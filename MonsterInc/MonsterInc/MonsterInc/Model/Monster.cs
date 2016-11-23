using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Core.Model
{
	public interface IExperienceLevelStrategy
	{
		int EvaluateExperienceLevel(int NewExperiencePoint);
	}

	public class BaseExperienceLevelStrategy : IExperienceLevelStrategy
	{

	

        public int EvaluateExperienceLevel(int NewExperiencePoint)
		{
            if (NewExperiencePoint < 250) return ((NewExperiencePoint / 25)+1); //1 à 10
            if (NewExperiencePoint < 1000) return ((NewExperiencePoint / 50) + 6); //11 à 25
            if (NewExperiencePoint < 5000) return ((NewExperiencePoint / 200) + 21); //26 à 45 
            if (NewExperiencePoint < 20000) return ((NewExperiencePoint / 400) + 34); // 46 à 83
            if (NewExperiencePoint < 32800) return ((NewExperiencePoint / 800) + 59); // 84 à 99
            return 100;
		}
	}
	//public delegate void ExperienceLevelChangedHandler(Monster m, EventArgs e);
    [Serializable]
	public class Monster
	{
        public Monster()
        {

        }
		public static int MAX_EXP_LEVEL = 20;

        [XmlIgnore]
        public MonsterTemplate Template { get; set; }

		//Nom de l'événement qui sera accessible de l'extérieur
		public event EventHandler<ExperienceLevelChangedEventArgs> ExperienceLevelChanged;

		public int ID { get; set; }

		public string NickName { get; set; }

		public int ExperienceLevel { get; set; }

		public int ExperiencePoint { get; set; }

		public List<MonsterCaracteristic> Caracteristics = new List<MonsterCaracteristic>();

		public void ConsumeItem(Item item)
		{
             //item.Consume(this);
        }



		public Monster(MonsterTemplate monsterTemplate, double CaracteristicFactor = 1.0)
		{
			this.Template = monsterTemplate;

			this.ExperienceLevel = monsterTemplate.BaseLevel;

			//Selon la demande de Adam, on relie les caractéristique avec le template
			foreach (var monsterTemplateCaracteristic in monsterTemplate.Caracteristics)
			{
				this.Caracteristics.Add( new MonsterCaracteristic(monsterTemplateCaracteristic, this.ExperienceLevel, CaracteristicFactor) );
			}
		}

	    public void ResetCaracterictics()
	    {
	        foreach (var caracterictic in this.Caracteristics)
	        {
	            caracterictic.InitWithLevel(this.ExperienceLevel);
	        }
	    }

		/// <summary>
		/// Méthode retournant la caractéristique de monstre tel que demandée  
		/// </summary>
		/// <returns>The caracteristic.</returns>
		/// <param name="type">Type.</param>
		public MonsterCaracteristic GetCaracteristic(MonsterTemplateCaracteristicType type)
		{
			return Caracteristics.FirstOrDefault(c => c.Type == type);
		}


		public void IncrementExperiencePointBy(int points)
		{
			//On incrémente les points d'expérience selon le nombre de points demandés		                             
			this.ExperiencePoint += points;

			//Launch Strategy Here
			int newExperienceLevel = new BaseExperienceLevelStrategy().EvaluateExperienceLevel(this.ExperiencePoint);

			if (newExperienceLevel != this.ExperienceLevel)
			{
				this.ExperienceLevel = newExperienceLevel;
				//OnExperienceLevelChanged(this.ExperienceLevel);
					
			}
		}



		//protected void OnExperienceLevelChanged(int newExperienceLevel)
		//{
		//	//TODO: Looper toutes les caractéristiques et mettre à jour le total
		//	foreach (MonsterCaracteristic caracteristic in this.Caracteristics)
		//	{
		//		caracteristic.UpdateWithLevel(newExperienceLevel);
		//	}

		//	if (ExperienceLevelChanged != null)
		//		ExperienceLevelChanged(this, new ExperienceLevelChangedEventArgs() { NewExperienceLevel = newExperienceLevel });
		//}
    }
}
