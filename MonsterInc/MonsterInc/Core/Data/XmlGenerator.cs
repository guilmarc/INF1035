using System;
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
        /// <summary>
        /// Méthode principale de génération des fichiers Xml
        /// </summary>
        public static void GenerateAllXml()
        {
            GenerateXml<Difficulty>();
            GenerateXml<Item>();
            GenerateXml<MonsterTemplate>();
            GenerateXml<Player>();
            GenerateXml<Skill>();
            GenerateXml<Trainer>();
        }

        /// <summary>
        /// Génération d'un fichier Xml contenant les object de type en paramètre
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private static void GenerateXml<T>()
        {
            var filePath = Constants.UniverseDataPath + typeof(T).Name + ".xml";
            using (var stream = new System.IO.StreamWriter(filePath))
            {
                var serializer = new XmlSerializer(typeof(List<T>));
                serializer.Serialize(stream, new StaticDataAdaptor<T>().GetObjects());
            }
        }
    }
}
