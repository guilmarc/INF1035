using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Core.Model
{

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

		public List<MonsterCaracteristic> Caracteristics { get; set; } = new List<MonsterCaracteristic>();

        [XmlIgnore]
        public List<Skill> ActiveSkills
	    {
	        get
	        {
                //Console.WriteLine(this.Template.Element.ToString());
                return Universe.Skills.Where(x => this.ExperienceLevel >= x.MinimumExperienceLevel).Where(y => (y.ElementRequirement.Count == 0) || y.ElementRequirement.Contains(this.Template.Element)).ToList();
	        }
	    }

	    public bool isAlive
	    {
	        get { return this.GetCaracteristic(MonsterTemplateCaracteristicType.LifePoints).Actual > 0; }
	    }

	    public Monster(int id, MonsterTemplate monsterTemplate, double CaracteristicFactor = 1.0)
		{
			this.Template = monsterTemplate;

			this.ExperienceLevel = monsterTemplate.BaseLevel;

			//Selon la demande de Adam, on relie les caractéristique avec le template
			foreach (var monsterTemplateCaracteristic in monsterTemplate.Caracteristics)
			{
				this.Caracteristics.Add( new MonsterCaracteristic(monsterTemplateCaracteristic, this.ExperienceLevel, CaracteristicFactor) );
			}
		}

	    public void Energize()
        { 
	        this.GetCaracteristic(MonsterTemplateCaracteristicType.EnergyPoints).Actual += this.GetCaracteristic(MonsterTemplateCaracteristicType.RegenerationPoints).Actual;
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
