using System;
namespace MonsterInc
{
	public class MonsterCaracteristic
	{

		int experienceLevel;

		public int Base { get; set; }
		public int Progression { get; set; }

		public int Total
		{
			get
			{
				return this.Base + (this.Progression * experienceLevel);
			}
		}

		public int Actual { get; set; }

		//public void Initialize()
		//{
		//	this.Actual = this.Actual != 0 ? this.Total : 0;
		//}

		public MonsterCaracteristic(Monster monster)
		{
			monster.ExperienceLevelChanged += (object sender, ExperienceLevelChangedEventArgs e) =>
			{
				
			};
		}

		public void LinkExperienceLevel(ref int experienceLevel)
		{
			this.experienceLevel = experienceLevel;
		}


	}
}
