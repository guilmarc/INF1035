using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Core.Model
{
    /// <summary>
    /// Design pattern Factory : Création des monstres
    /// </summary>
    public static class MonsterFactory
	{
        /// <summary>
        /// Conteur d'instance servant à donner un numéro unique aux monstres
        /// </summary>
	    private static int _counter = 0;

        /// <summary>
        /// Génération d'un monstre imaginaire
        /// </summary>
        /// <returns></returns>
	    public static List<Monster> GenerateDummyMonsters()
	    {
	        return new List<Monster> {GenerateRandomMonster(1, Universe.Difficulties[0])};
	    }

        /// <summary>
        /// Génération d'un monstre aléatoire selon un niveau d'expérience et une difficuté
        /// </summary>
        /// <param name="experienceLevel"></param>
        /// <param name="difficulty"></param>
        /// <returns></returns>
        public static Monster GenerateRandomMonster(int experienceLevel, Difficulty difficulty)
	    {
	        return new Monster( ++_counter, PickRandomMonsterTemplateForLevel(experienceLevel), difficulty.CaracteristicFactor );
	    }

        /// <summary>
        /// Génération d'une liste de monstre aléatoire selon la force globale de l'enemie et le niveau de difficulté
        /// </summary>
        /// <param name="trainer"></param>
        /// <param name="difficulty"></param>
        /// <returns></returns>
	    public static List<Monster> GenerateRandomMonsters(Trainer trainer, Difficulty difficulty)
	    {
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
                initMonsters.Add(new Monster(++_counter, template));
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
