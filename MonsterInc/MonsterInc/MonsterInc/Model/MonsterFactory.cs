using System;
namespace Core.Model
{
	public static class MonsterFactory
	{
		public static Monster CreateMonsterFromTemplate(MonsterTemplate monsterTemplate)
		{
			var newMonster = new Monster(monsterTemplate);

			//TODO: Faire varier les élement variable du monstre nouvellement créé

			return newMonster;
		}
	}
}
