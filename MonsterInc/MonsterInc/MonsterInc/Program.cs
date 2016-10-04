using System;

namespace MonsterInc
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			var monster = new Monster { ID = 1, Name = "Roger" };

			monster.ExperienceLevelChanged += (object sender, ExperienceLevelChangedEventArgs e) =>
			{
				Console.WriteLine("New Level :: " + e.NewExperienceLevel);
			};

			monster.IncrementExperiencePointBy(25);
			monster.IncrementExperiencePointBy(5);
			monster.IncrementExperiencePointBy(50);
		}
	}
}
