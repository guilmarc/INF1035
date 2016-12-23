﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Core.Model;

namespace Core
{

    public static class Extensions
    {

        public static void OnPropertyCHange(this PropertyChangedEventHandler propertyChanged, object sender, string propertyName)
        {
            if (propertyChanged != null)
            {
                propertyChanged(sender, new PropertyChangedEventArgs(propertyName));
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objectToSerialize"></param>
        /// <param name="nameOfFile"></param>
        /// <param name="defaultPath">System.Reflection.Assembly.GetExecutingAssembly().Location</param>
        /// <returns></returns>
        public static void XmlSerialize<T>(this T objectToSerialize, string nameOfFile, bool defaultPath )
        {
            if (!nameOfFile.ToLower().Contains(".xml"))
            {
                nameOfFile = nameOfFile + ".xml";
            }
            string directory ="";
            if (defaultPath)
            {
                directory = System.AppDomain.CurrentDomain.BaseDirectory;
            }
            string fullPath = $@"{directory}\{nameOfFile}";
            ///forstring
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            //StringWriter stringWriter = new StringWriter();
            //XmlTextWriter xmlWriter = new XmlTextWriter(stringWriter);

            //xmlWriter.Formatting = Formatting.Indented;
            //xmlSerializer.Serialize(xmlWriter, objectToSerialize);

            //return stringWriter.ToString();



            //todocument
            XmlSerializer serialiser = new XmlSerializer(typeof(T));
            TextWriter Filestream = new StreamWriter(fullPath);
            serialiser.Serialize(Filestream, objectToSerialize);
            Filestream.Close();

        }

        public static T XmlToObject<T>(string nameOfFile, bool defaultPath)
        {
            if (!nameOfFile.ToLower().Contains(".xml"))
            {
                nameOfFile = nameOfFile + ".xml";
            }
            string directory = "";
            if (defaultPath)
            {
                directory = System.AppDomain.CurrentDomain.BaseDirectory; 
            }
            string fullPath = $@"{directory}\{nameOfFile}";

            T returnObject = default(T);
            StreamReader xmlStream = new StreamReader(fullPath);

            Type[] types = new Type[] { typeof(T), typeof(Core.Model.DamageScope) };
            XmlSerializer serializer = new XmlSerializer(typeof(T), types);
            returnObject = (T)serializer.Deserialize(xmlStream);
            xmlStream.Close();
            return returnObject;
        }

        public static T ToEnum<T>(this string value)
        {
            return (T) Enum.Parse(typeof(T), value, true);
        }
        

        private static readonly Random _random = new Random();
        public static T Random<T>(this List<T> objects)
        {
            return objects.Count == 0 ? default(T) : objects[_random.Next(objects.Count - 1)];
        }

        public static List<Monster> Alive(this List<Monster> list)
        {
            return list.Where(x => x.GetCaracteristic(MonsterTemplateCaracteristicType.LifePoints).Actual > 0).ToList();
        }

        public static int Reset(this List<Monster> list)
        {
            list.ForEach(x => x.ResetCaracterictics());
            return list.Count;
        }

        public static int Energize(this List<Monster> list)
        {
            list.ForEach(x => x.Energize());
            return list.Count;
        }
    }
}
