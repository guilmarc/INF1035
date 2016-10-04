using System;
namespace MonsterInc
{
	public class MonsterFactory
	{
		public MonsterFactory()
		{
		}
	}

	public static class MonsterRepository
	{
		public static void getMonsters()
		{

			var newMonster = new Monster()
			{
				Name = "FireBall",
				NickName = "FireBall",
				ID = 1,
				Element = new Element() { Name = "Fire" }

			};

			newMonster.LifePoints = new MonsterCaracteristic(newMonster) { Base=10, Progression=2 };
			newMonster.EnergyPoints = new MonsterCaracteristic(newMonster) { Base = 10, Progression = 2 };
			newMonster.RegenerationPoints = new MonsterCaracteristic(newMonster) { Base = 10, Progression = 2 };
			newMonster.Attack = new MonsterCaracteristic(newMonster) { Base = 10, Progression = 2 };
			newMonster.Defense = new MonsterCaracteristic(newMonster) { Base = 10, Progression = 2 };




		}
	}
}
