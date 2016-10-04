using System;
using System.Collections.Generic;
using System.Linq;

namespace MonsterInc
{
	public interface IExperienceLevelStrategy
	{
		int EvaluateExperienceLevel(int NewExperiencePoint);
	}

	public class BaseExperienceLevelStrategy : IExperienceLevelStrategy
	{
		public int EvaluateExperienceLevel(int NewExperiencePoint)
		{

			if (NewExperiencePoint < 25) return 1;
			if (NewExperiencePoint < 50) return 2;
			if (NewExperiencePoint < 75) return 3;
			if (NewExperiencePoint < 100) return 4;
			if (NewExperiencePoint < 150) return 5;
			if (NewExperiencePoint < 200) return 6;
			if (NewExperiencePoint < 250) return 7;
			if (NewExperiencePoint < 300) return 8;
			if (NewExperiencePoint < 350) return 9;
			if (NewExperiencePoint < 400) return 10;
			if (NewExperiencePoint < 450) return 11;
			if (NewExperiencePoint < 500) return 12;
			if (NewExperiencePoint < 600) return 13;
			if (NewExperiencePoint < 700) return 14;
			if (NewExperiencePoint < 800) return 15;
			if (NewExperiencePoint < 900) return 16;
			if (NewExperiencePoint < 1000) return 17;
			if (NewExperiencePoint < 1250) return 18;
			if (NewExperiencePoint < 1500) return 19;
			else return 20;
		}
	}
	//public delegate void ExperienceLevelChangedHandler(Monster m, EventArgs e);

	public class Monster
	{
		public static int MAX_EXP_LEVEL = 20; 

		//Nom de l'événement qui sera accessible de l'extérieur
		public event EventHandler<ExperienceLevelChangedEventArgs> ExperienceLevelChanged;

		public int ID { get; set; }

		public string Name { get; set; }

		//Devra être refactorisé dans une sous-classe CapturedMonster ???
		public string NickName { get; set; }

		public int Scarcity { get; set; }

		public Element Element { get; set; }

		//Initialemet à 1 jusqu'à 50
		public int ExperienceLevel { get; private set; } = 1;

		static int test = 3;
		//TODO : //Dans le set de cette variable, utiliser une strategy d'événement qui met à jour automatiquement le ExperienceLevel.
		//TODO : Exposer un evenement publique qui se déclanchera quand un niveau d'expérience est atteint.
		public int ExperiencePoint { get; private set; }

		public MonsterCaracteristic LifePoints = new MonsterCaracteristic(this);
		public MonsterCaracteristic EnergyPoints = new MonsterCaracteristic();
		public MonsterCaracteristic RegenerationPoints = new MonsterCaracteristic();
		public MonsterCaracteristic Attack = new MonsterCaracteristic();
		public MonsterCaracteristic Defense = new MonsterCaracteristic();


		public void IncrementExperiencePointBy(int points)
		{
			//On incrémente les points d'expérience selon le nombre de points demandés		                             
			this.ExperiencePoint += points;

			//Launch Strategy Here
			int newExperienceLevel = new BaseExperienceLevelStrategy().EvaluateExperienceLevel(this.ExperiencePoint);

			if (newExperienceLevel != this.ExperienceLevel)
			{
				this.ExperienceLevel = newExperienceLevel;
				OnExperienceLevelChanged(this.ExperienceLevel);
					
			}
		}


		public Monster()
		{
			
		}

		protected virtual void OnExperienceLevelChanged(int newExperienceLevel)
		{
			//TODO: Looper toutes les caractéristiques et 


			if (ExperienceLevelChanged != null)
				ExperienceLevelChanged(this, new ExperienceLevelChangedEventArgs() { NewExperienceLevel = newExperienceLevel });
		}
	}
}
