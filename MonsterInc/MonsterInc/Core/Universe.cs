
 using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using System.Xml.Serialization;

using Core.Data;
using Core.Exceptions;
using Core.Model;
using Core.Factories;

namespace Core
{

    /// <summary>
    /// Classe représent l'univers du jeu (les éléments)
    /// </summary>
    public static class Universe
    {

        /// <summary>
        /// Variables de cache
        /// </summary>
        private static List<MonsterTemplate> _monsterTemplates;
        private static List<Item> _items;
        private static List<Monster> _initMonsters;
        private static List<Difficulty> _difficulties;
        private static Player _dummyPlayer;
        private static List<Skill> _skills;

        /// <summary>
        /// Matrice des forces d'attaque modulées par éléments
        /// </summary>
        public static readonly int[,] ElementMatrix =
        {
            {50, 100, 50, 180, 20, 140, 200, 180}, //Fire
            {120, 50, 100, 250, 100, 200, 80, 100}, //Lava
            {200, 170, 50, 50, 180, 80, 20, 150}, //Earth
            {30, 20, 250, 50, 150, 100, 170, 250}, //Grass
            {200, 180, 50, 100, 50, 150, 170, 20}, //Water
            {200, 150, 150, 150, 50, 50, 150, 100}, //Ice
            {50, 150, 200, 200, 50, 50, 50, 150}, //Air
            {100, 100, 20, 200, 250, 50, 250, 50} //Lightning
        };

        /// <summary>
        /// Liste des templates de monstres selon l'adapteur de donnée connecté
        /// </summary>
        public static List<MonsterTemplate> MonsterTemplates
        {
            get
            {
                return _monsterTemplates = _monsterTemplates ?? new DataAdaptor<MonsterTemplate>().GetObjects();
            }
        }

        /// <summary>
        /// Liste des items selon l'adapteur de donnée connecté
        /// </summary>
        public static List<Item> Items
        {
            get
            {
                return _items = _items ?? new DataAdaptor<Item>().GetObjects();
            }
        }

        /// <summary>
        /// Liste des difficultés selon l'adapteur de donnée connecté
        /// </summary>
        public static List<Difficulty> Difficulties
        {
            get { return _difficulties = _difficulties ?? new DataAdaptor<Difficulty>().GetObjects(); }
        }

        /// <summary>
        /// Liste des habiletés selon l'adapteur de donnée connecté
        /// </summary>
        public static List<Skill> Skills
        {
            get { return _skills = _skills ?? new DataAdaptor<Skill>().GetObjects(); }
        }
        
        /// <summary>
        /// Liste des monstres initiaux disponibles
        /// </summary>
        public static List<Monster> InitMonsters
        {
            get
            {
                return _initMonsters = _initMonsters ?? MonsterFactory.GenerateInitMonsters();
            }
        }

        /// <summary>
        /// Joueur simulé disponible en test ou lors d'une partie simulée
        /// </summary>
        public static Player DummyPlayer
        {
            get
            {
                return _dummyPlayer = _dummyPlayer ?? PlayerFactory.GenerateDummyPlayer();
            }
        }

        /// <summary>
        /// Liste des nom de parties sauvegardées disponibles
        /// </summary>
        public static List<String> SavedGameFiles
        {
            get
            {
                IEnumerable<String> array = null;

                    array = from fullFilename
                        in Directory.EnumerateFiles(Constants.SavedGamePath, "*" + Constants.SavedGameFileExtension)
                        select Path.GetFileNameWithoutExtension(String.Concat((object) fullFilename));

                return new List<string>(array);
            }
        }
    }
}

