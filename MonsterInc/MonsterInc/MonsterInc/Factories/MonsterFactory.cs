using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Core.Model
{
	public static class MonsterFactory
	{

	    private static int counter = 0;

	    public static List<Monster> GenerateDummyMonsters()
	    {
	        return new List<Monster> {GenerateRandomMonster(1, Universe.Difficulties[0])};
	    }

        public static Monster GenerateRandomMonster(int experienceLevel, Difficulty difficulty)
	    {
	        return new Monster( ++counter, PickRandomMonsterTemplateForLevel(experienceLevel), difficulty.CaracteristicFactor );
	    }

	    public static List<Monster> GenerateRandomMonsters(Trainer trainer, Difficulty difficulty)
	    {
            //Pour l'instant on ne génère que le même nombre de monstre que le Trainer.
            //Il serait possible de générer des monstre aléatoirement selon le niveau d'énergie total par exemple.
	        var count = trainer.Monsters.Count();
	        var result = new List<Monster>();
	        var averageLevel = (int)trainer.Monsters.Average(x => x.ExperienceLevel);

	        for (var i = 0; i < count; i++)
	        {
	            result.Add( GenerateRandomMonster(averageLevel, difficulty) );
	        }

	        return result;
	    }

        /// <summary>
        /// Génération des Monstres initiaux (BaseLevel = 1)
        /// </summary>
        /// <returns></returns>
	    public static List<Monster> GenerateInitMonsters()
	    {
	        var initMonsters = new List<Monster>();
            var initMonsterTemplates = Universe.MonsterTemplates.Where(t => t.BaseLevel == 1).ToList();

            foreach (var template in initMonsterTemplates)
            {
                initMonsters.Add(new Monster(++counter, template));
            }

            return initMonsters;
        }

        /// <summary>
        /// Retourne un MonsterTemplate au hasard en se basant sur le niveau de rareté et le niveau d'expérience actuel.
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
	    public static MonsterTemplate PickRandomMonsterTemplateForLevel(int level)
	    {
	        const int LEVEL_THRESHOLD = 15;
	        var availableMonsters = Universe.MonsterTemplates.Where(t => t.BaseLevel >= (level - LEVEL_THRESHOLD) && t.BaseLevel <= (level + LEVEL_THRESHOLD)).ToList();
            var totalRarity = availableMonsters.Sum(x => x.Rarity);

            var rnd = Utils.Random(1, totalRarity);
            
            foreach(var template in availableMonsters)
            {
                rnd -= template.Rarity;
                if (rnd < 0)
                {
                    return template;              
                }
            }

	        return null;
      
	    }
	}
}
