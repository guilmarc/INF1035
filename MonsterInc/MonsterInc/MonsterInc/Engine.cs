using System;
using System.Collections.Generic;
using Core.Model;
using Core.Data;
using System.Linq;

namespace Core
{
    /// <summary>
    /// Classe représentant l'IA de l'application
    /// </summary>
    public static class Engine
    {
        private const int INIT_GOLD = 1000;

        public static Player Player { get; set; }

        public static Player Opponent { get; set; }

        public static void Run()
        {

        }

        private static List<Monster> initMonsters;
        public  static List<Monster> InitMonsters
        {
            get
            {
                if (initMonsters == null)
                {
                    initMonsters = new List<Monster>();

                    var initMonsterTemplates = MonsterTemplates.Where(t => t.BaseLevel == 1).ToList();

                    foreach (var template in initMonsterTemplates)
                    {
                        initMonsters.Add(new Monster(template));
                    }
                }

                return initMonsters;
            }
        }



        /// <summary>
        /// Méthode responsable de la générations d'un entraîneur selon un niveau de difficulté
        /// </summary>
        /// <returns></returns>
        public static Trainer GenerateTrainer()
        {
            throw new NotImplementedException();     
        }



        /// <summary>
        /// Génération d'un groupe de monstres (ou les monstres disponibles selon un niveau d'ex.)
        /// </summary>
        public static List<Monster> GenerateOpponents()
        {
           return  MonsterFactory.GenerateMonsters(Player.Trainer);
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

        //TODO: Lire les Items du fichier XML
        private static List<Item> _items { get; set; }
        public static List<Item> Items
        {
            get { 
            //Si _items est vide, lire les items à partir du fichier XML et les enregistrer dans _items
            if (_items  == null)
            {
                _items = ItemData.Items;
            }
        //Retourner _items
        return _items;
}

}
        //TODO: Lire les MonsterTemplates du fichier XML
	    private static List<MonsterTemplate> _monsterTemplates;
	    public static List<MonsterTemplate> MonsterTemplates
	    {
	        get
	        {
                if(_monsterTemplates == null)
                {
                    _monsterTemplates = MonsterTemplateData.MonsterTemplates;
                }

                return _monsterTemplates;
	        }
	    }
	}
}
