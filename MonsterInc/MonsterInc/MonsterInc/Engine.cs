using System;
using System.Collections.Generic;

namespace MonsterInc
{

	/// <summary>
	/// Classe représentant l'IA de l'application
	/// </summary>
	public static class GameEngine
	{
	    private const int INIT_GOLD = 1000;

	    public static Player Player { get; set; }

        public static Player Opponent { get; set; }

        public static void Run()
		{
            
		}


        /// <summary>
        /// Genère les Monstres initiaux (sélectionnnés par le joueur)
        /// </summary>
	    public static List<Monster> GenerateInitMonsters()
	    {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Génération d'un groupe de monstres (ou les monstres disponibles selon un niveau d'ex.)
        /// </summary>
	    public static List<Monster> GenerateOpponents()
	    {
	        throw new NotImplementedException();
	    }


        /// <summary>
        /// Génération d'un Monster en fonction de sa rareté et du niveau d'expérience
        /// </summary>
        /// <param name="trainer"></param>
        /// <returns></returns>
	    public static Monster GenerateMonster(Trainer trainer)
	    {
            //Choisir un MonsterTemplate selon une rarete

            //Choisir un Monstre selon le niveau d'expérience
            throw new NotImplementedException();
        }

        //TODO: Trouver quel doit être le réel retour de cette méthode car nous devrons savoir si l'utilisation a fonctionné
        /// <summary>
        /// Méthode servant à consommer un item
        /// </summary>
        /// <param name="monster"></param>
        /// <param name="opponent"></param>
        /// <param name="item"></param>
	    public static void ConsumeItem(Monster monster, Monster opponent, Item item)
	    {
	        
	    }


        //TODO: Trouver quel doit être le réel retour de cette méthode car nous devrons savoir si l'habitlité a fonctionné
        /// <summary>
        /// Utilisation d'une habilité particulière 
        /// </summary>
        /// <param name="monster"></param>
        /// <param name="opponent"></param>
        /// <param name="skill"></param>
	    public static void UseSkill(Monster monster, Monster opponent, Skill skill)
	    {
	        
	    }


	    private static List<Item> _items { get; set; }

	    public static List<Item> GetAvailableItems()
	    {
            //Si _items est vide, lire les items à partir du fichier XML et les enregistrer dans _items

            //Retourner _items

            throw new NotImplementedException();
        }


	}
}
