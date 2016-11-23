using System;
using System.Collections.Generic;
using Core.Model;
using Core.Data;
using System.Linq;
using System.Runtime.CompilerServices;

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

        public static Difficulty Difficulty { get; set; }

        public static void Run()
        {
            Difficulty = Universe.Difficulties[0];       //Met la difficulté par défaut pour fin de test
        }


        /// <summary>
        /// Méthode responsable de la générations d'un entraîneur selon un niveau de difficulté
        /// </summary>
        /// <returns></returns>
        public static Trainer GenerateTrainer()
        {
            return TrainerFactory.GenerateTrainer(Player.Trainer, Difficulty);
        }

        /// <summary>
        /// Génération d'un groupe de monstres (ou les monstres disponibles selon un niveau d'ex.)
        /// </summary>
        public static List<Monster> GenerateOpponents()
        {
           return MonsterFactory.GenerateMonsters(Player.Trainer, Difficulty);
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
    }
       
}

