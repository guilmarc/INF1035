
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using System.Xml.Serialization;

using Core.Data;
using Core.Model;
using MonsterInc.Factories;

namespace Core
{

    public enum Element
    {
        Fire = 0,
        Lava,
        Earth,
        Grass,
        Water,
        Ice,
        Air,
        Lightning
    }

    public static class Universe
    {

        //Variable de cache de donnée
        private static List<MonsterTemplate> _monsterTemplates;
        private static List<Item> _items;
        private static List<Monster> _initMonsters;
        private static List<Difficulty> _difficulties;
        private static Player _dummyPlayer;


        public static readonly int[,] ElementMatrix =
        {
            {50, 100, 50, 180, 0, 140, 200, 180}, //Fire
            {120, 50, 100, 250, 100, 200, 80, 100}, //Lava
            {200, 170, 50, 50, 180, 80, 20, 150}, //Earth
            {30, 0, 250, 50, 150, 100, 170, 250}, //Grass
            {200, 180, 50, 100, 50, 150, 170, 0}, //Water
            {200, 150, 150, 150, 50, 50, 150, 100}, //Ice
            {50, 150, 200, 200, 50, 50, 50, 150}, //Air
            {100, 100, 0, 200, 250, 50, 250, 50} //Lightning
        };


/*
        public static void LoadMonsterTemplatesFromXML()
        {
            XmlSerializer serialiser = new XmlSerializer(typeof(List<MonsterTemplate>));
            TextReader Filestream = new StreamReader(@"MonsterTemplates.xml");
            MonsterTemplates = serialiser.Deserialize(Filestream) as List<MonsterTemplate>;
        }

        public static void SaveMonsterTemplatesToXML()
        {
            //var xml = new XElement("MonsterTemplates", MonsterTemplates.Select(t => new XElement("MonsterTemplate", t)));

            //Console.WriteLine(xml.ToString());

            XmlSerializer serialiser = new XmlSerializer(typeof(List<MonsterTemplate>));
            TextWriter Filestream = new StreamWriter(@"MonsterTemplates.xml");
            serialiser.Serialize(Filestream, MonsterTemplates);
            Filestream.Close();
        }
*/

        public static List<MonsterTemplate> MonsterTemplates
        {
            get
            {
                return _monsterTemplates = _monsterTemplates ?? new DataAdaptor<MonsterTemplate>().getObjects();
            }
        }

        public static List<Item> Items
        {
            get
            {
                return _items = _items ?? new DataAdaptor<Item>().getObjects();
            }
        }

        public static List<Difficulty> Difficulties
        {
            get
            {
                return _difficulties = _difficulties ?? new DataAdaptor<Difficulty>().getObjects();
            }
        }

        public static List<Monster> InitMonsters
        {
            get
            {
                if (_initMonsters == null)
                {
                    _initMonsters = new List<Monster>();

                    var initMonsterTemplates = MonsterTemplates.Where(t => t.BaseLevel == 1).ToList();

                    foreach (var template in initMonsterTemplates)
                    {
                        _initMonsters.Add(new Monster(template));
                    }
                }

                return _initMonsters;
            }
        }

        public static Player DummyPlayer
        {
            get
            {
                return _dummyPlayer = _dummyPlayer ?? PlayerFactory.GenerateDummyPlayer();
            }
        }

        public static Player GenerateOpponent(Player player, Difficulty difficulty)
        {
            return PlayerFactory.GenerateOpponent(player, difficulty);
        }
    }
}

