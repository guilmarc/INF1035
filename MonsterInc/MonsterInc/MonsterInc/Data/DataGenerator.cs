using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Reflection;

namespace MonsterInc
{
	/// <summary>
	/// Classe responsable de générer les fichiers XML à partir des données dans les classes xxxxData.cs situés dans le même répertoire
	/// </summary>
	public static class DataGenerator
	{
		public static void GenerateAllXML()
		{
			GenerateItemXML();
			GenerateMonsterXML();
			GenerateSkillXML();
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

		private static void GenerateItemXML()
		{
			XmlSerializer serialiser = new XmlSerializer(typeof(List<Item>));
			TextWriter Filestream = new StreamWriter(@"Items.xml");
			serialiser.Serialize(Filestream, ItemData.Items);
			Filestream.Close();
		}

		private static void GenerateMonsterXML()
		{
			XmlSerializer serialiser = new XmlSerializer(typeof(List<MonsterTemplate>));
			TextWriter Filestream = new StreamWriter(@"MonsterTemplates.xml");
			serialiser.Serialize(Filestream, MonsterTemplateData.MonsterTemplates);
			Filestream.Close();
		}

		private static void GenerateSkillXML()
		{
			XmlSerializer serialiser = new XmlSerializer(typeof(List<Skill>));
			TextWriter Filestream = new StreamWriter(@"Skills.xml");
			serialiser.Serialize(Filestream, SkillData.Skills);
			Filestream.Close();
		}





	}



	//XmlSerializer serialiser = new XmlSerializer(typeof(List<MonsterTemplate>));
	//TextWriter Filestream = new StreamWriter(@"MonsterTemplates.xml");
	//serialiser.Serialize(Filestream, MonsterTemplates);
 //   Filestream.Close();
}
