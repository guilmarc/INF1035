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

			Console.WriteLine(monster.LifePoints.Total);

			monster.IncrementExperiencePointBy(5);
			Console.WriteLine(monster.LifePoints.Total);

			monster.IncrementExperiencePointBy(50);

			Console.WriteLine(monster.LifePoints.Total);
		}
	}
}
