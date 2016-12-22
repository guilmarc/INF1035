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

        //private static void GenerateXML<T>(T type, string XMLFileName)
        //{
        //	XmlSerializer serialiser = new XmlSerializer(type);
        //	TextWriter Filestream = new StreamWriter(XMLFileName);
        //	serialiser.Serialize(Filestream, MonsterTemplates);
        //	Filestream.Close();
        //}

        private static void GenerateXml<T>()
        {
            using (var stream = new System.IO.StreamWriter("C:/xml/" + typeof(T).Name + ".xml"))
            {
                var serializer = new XmlSerializer(typeof(List<T>));
                serializer.Serialize(stream, new HardCodedDataAdaptor<T>().GetObjects());
            }
        }
    }
}
