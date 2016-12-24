using Core.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Core
{
    /// <summary>
    /// Classe d'utilitaires réutilisables d'un projet à l'autre
    /// </summary>
    public static class Utils
    {
        private static readonly Random _random = new Random();

        /// <summary>
        /// Retourne un nombre aléaloire entre 0 et max
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int Random(int max)
        {
            return _random.Next(max);
        }

        /// <summary>
        /// Retourne un nombre aléaloire entre min et max
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int Random(int min, int max)
        {
            return _random.Next(min, max);
        }

        /// <summary>
        /// Méthode d'humanisation des valeurs selon un facteur constant
        /// </summary>
        /// <returns></returns>
        public static float HumanizeRatio()
        {
            var humanizeValue = (int) (Constants.HumanizeFactor*100);
            var result = ((float)Random(humanizeValue + 1) - (humanizeValue/2f)) / 100f;
            return result + 1;
        }

        /// <summary>
        /// Retourne un Element au hasard
        /// </summary>
        /// <returns></returns>
        public static Element GetRandomElement()
        {
            var values = Enum.GetValues(typeof(Element));
            return (Element) values.GetValue(Random(values.Length - 1));
        }

        /// <summary>
        /// Sous classe servant à la sérialisation 
        /// </summary>
        public static class Serializer
        {
            /// <summary>
            /// Sérialisation en binaire
            /// </summary>
            public static class Binary
            {
                /// <summary>
                /// Écriture d'un objet dans un fichier binaire
                /// </summary>
                /// <typeparam name="T"></typeparam>
                /// <param name="filePath"></param>
                /// <param name="objectToWrite"></param>
                /// <param name="append"></param>
                public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
                {
                    using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
                    {
                        var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        binaryFormatter.Serialize(stream, objectToWrite);
                    }
                }

               /// <summary>
               /// Instanciation d'un objet à partir d'un fichier binaire
               /// </summary>
               /// <typeparam name="T"></typeparam>
               /// <param name="filePath"></param>
               /// <returns></returns>
                public static T ReadFromBinaryFile<T>(string filePath)
                {
                    using (Stream stream = File.Open(filePath, FileMode.Open))
                    {
                        var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        return (T)binaryFormatter.Deserialize(stream);
                    }
                }
            }

            public class Xml
            {
               /// <summary>
               /// Écriture d'un objet dans un fichier Xml
               /// </summary>
               /// <typeparam name="T"></typeparam>
               /// <param name="filePath"></param>
               /// <param name="objectToWrite"></param>
               /// <param name="append"></param>
                public static void WriteToXmlFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
                {
                    TextWriter writer = null;
                    try
                    {
                        var serializer = new XmlSerializer(typeof(T));
                        writer = new StreamWriter(filePath, append);
                        serializer.Serialize(writer, objectToWrite);
                    }
                    finally
                    {
                        if (writer != null)
                            writer.Close();
                    }
                }

                /// <summary>
                /// Instanciation d'un objet à partir d'un fichier Xml
                /// </summary>
                /// <typeparam name="T"></typeparam>
                /// <param name="filePath"></param>
                /// <returns></returns>
                public static T ReadFromXmlFile<T>(string filePath) where T : new()
                {
                    using (Stream stream = new FileStream(filePath, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        return (T)serializer.Deserialize(stream);

                    }
                }
            }
        }
    }
}