﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Reflection;
using Core.Model;

namespace Core.Data
{
    /// <summary>
    /// Classe responsable de générer les fichiers XML à partir des données dans les classes xxxxData.cs situés dans le même répertoire
    /// </summary>
    public static class XmlGenerator
    {
        public static void GenerateAllXml()
        {
            GenerateXml<Difficulty>();
            GenerateXml<Item>();
            GenerateXml<MonsterTemplate>();
            GenerateXml<Player>();
            GenerateXml<Skill>();
            GenerateXml<Trainer>();
        }

        //TODO: Changer les méthodes statiques par un Generic
        //https://dzone.com/articles/c-%E2%80%93-generic-serialization

        private static void GenerateXml<T>()
        {
            var filePath = Constants.UniverseDataPath + typeof(T).Name + Constants.SavedGameFileExtension;
            using (var stream = new System.IO.StreamWriter(filePath))
            {
                var serializer = new XmlSerializer(typeof(List<T>));
                serializer.Serialize(stream, new HardCodedDataAdaptor<T>().GetObjects());
            }
        }
    }
}