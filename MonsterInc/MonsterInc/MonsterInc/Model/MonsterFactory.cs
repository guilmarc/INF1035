using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Model
{
	public static class MonsterFactory
	{
    
        private static Random random = new Random();

	    public static Monster GenerateMonster(int experienceLevel)
	    {
	        return new Monster( PickRandomMonsterTemplateForLevel(experienceLevel) );
	    }

	    public static List<Monster> GenerateMonsters(Trainer trainer)
	    {
            //Pour l'instant on ne génère que le même nombre de monstre que le Trainer.
            //Il serait possible de générer des monstre aléatoirement selon le niveau d'énergie total par exemple.
	        var count = trainer.Monsters.Count();
	        var result = new List<Monster>();
	        var averageLevel = (int)trainer.Monsters.Average(x => x.ExperienceLevel);

	        for (var i = 0; i < count; i++)
	        {
	            result.Add( GenerateMonster(averageLevel) );
	        }

	        return result;
	    }


        /// <summary>
        /// Retourne un MonsterTemplate au hasard en se basant sur le niveau de rareté et le niveau d'expérience actuel.
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
	    public static MonsterTemplate PickRandomMonsterTemplateForLevel(int level)
	    {
	        const int LEVEL_THRESHOLD = 15;
	        var availableMonsters = Engine.MonsterTemplates.Where(t => t.BaseLevel >= (level - LEVEL_THRESHOLD) && t.BaseLevel <= (level + LEVEL_THRESHOLD)).ToList();
            var totalRarity = availableMonsters.Sum(x => x.Rarity);

            var rnd = random.Next(1, totalRarity);
            
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
